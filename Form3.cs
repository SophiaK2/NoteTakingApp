using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            DisplayNotes();

        }

        private void Form3_Load(object sender, EventArgs e)
        {
        }
        private void DisplayNotes()
        {
            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=SOPHIA; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string selectQuery = "SELECT NoteID, Timestampp, Title, Content FROM Notes";
                using (SqlCommand command = new SqlCommand(selectQuery, sqlCon))
                {
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    DataTable dataTable = new DataTable();
                    adapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int noteIdToDelete = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["NoteID"].Value);
                DeleteNote(noteIdToDelete);
            }
            else
            {
                MessageBox.Show("Please select a note to delete.");
            }
        }
        private void DeleteNote(int noteId)
        {
            try
            {
                using (SqlConnection sqlCon = new SqlConnection(@"Data Source=SOPHIA; Initial Catalog=NoteDB; Integrated Security=True;"))
                {
                    sqlCon.Open();
                    string deleteQuery = "DELETE FROM Notes WHERE NoteID = @NoteID";
                    using (SqlCommand command = new SqlCommand(deleteQuery, sqlCon))
                    {
                        command.Parameters.AddWithValue("@NoteID", noteId);
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Note deleted successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error deleting note: " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 form3 = new Form3();
            form3.ShowDialog();
        }
    }
}
