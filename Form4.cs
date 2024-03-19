using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
namespace Notes
{
    public partial class Form4 : Form
    {
        private NoteManager noteManager;

        public Form4()
        {
            InitializeComponent();
            noteManager = new NoteManager();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            List<Note> notes = noteManager.GetAllNotes();
            dataGridView1.DataSource = notes;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                noteManager.ImportNotesFromFile(filePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Get the selected note's details
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int noteID = Convert.ToInt32(selectedRow.Cells["NoteID"].Value);
                string title = textBoxTitle.Text;
                string content = textBoxContent.Text;

                // Create a Note object with the updated details
                Note updatedNote = new Note
                {
                    NoteID = noteID,
                    Title = title,
                    Content = content
                };

                // Call the UpdateNote method of the NoteManager
                noteManager.UpdateNote(updatedNote);

                // Optionally, refresh the DataGridView to reflect the updated note
                dataGridView1.DataSource = noteManager.GetAllNotes();
            }
            else
            {
                MessageBox.Show("Please select a note to update.");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
    public class Note
    {
        public int NoteID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class NoteManager
    {
        private string connectionString = @"Data Source=SOPHIA;Initial Catalog=NoteDB;Integrated Security=True";

        public List<Note> GetAllNotes()
        {
            List<Note> notes = new List<Note>();
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    string query = "SELECT NoteID, Title, Content FROM Notes";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        sqlCon.Open();
                        SqlDataReader reader = cmd.ExecuteReader();
                        while (reader.Read())
                        {
                            Note note = new Note
                            {
                                NoteID = Convert.ToInt32(reader["NoteID"]),
                                Title = reader["Title"].ToString(),
                                Content = reader["Content"].ToString()
                            };
                            notes.Add(note);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return notes;
        }

        public void UpdateNote(Note note)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    string query = "UPDATE Notes SET Title = @Title, Content = @Content WHERE NoteID = @NoteID";
                    using (SqlCommand cmd = new SqlCommand(query, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@Title", note.Title);
                        cmd.Parameters.AddWithValue("@Content", note.Content);
                        cmd.Parameters.AddWithValue("@NoteID", note.NoteID);
                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Note updated successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        public void ImportNotesFromFile(string filePath)
        {
            List<Note> notes = new List<Note>();

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        string[] parts = line.Split(',');
                        int noteId = int.Parse(parts[0]);
                        string title = parts[1];
                        string content = parts[2];

                        Note note = new Note { NoteID = noteId, Title = title, Content = content };
                        notes.Add(note);
                    }
                }

                foreach (var note in notes)
                {
                    InsertNoteIntoDatabase(note);
                }

                MessageBox.Show("Notes imported successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error importing notes: " + ex.Message);
            }

        }
        private void InsertNoteIntoDatabase(Note note)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(connectionString))
                {
                    string insertQuery = "INSERT INTO Notes (NoteID, Title, Content) VALUES (@NoteID, @Title, @Content)";
                    using (SqlCommand cmd = new SqlCommand(insertQuery, sqlCon))
                    {
                        cmd.Parameters.AddWithValue("@NoteID", note.NoteID);
                        cmd.Parameters.AddWithValue("@Title", note.Title);
                        cmd.Parameters.AddWithValue("@Content", note.Content);

                        sqlCon.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inserting note into database: " + ex.Message);
            }
        }


    }
}