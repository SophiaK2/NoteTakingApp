using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string noteTitle = Title.Text;
            string noteContent = Content.Text;

            if (string.IsNullOrWhiteSpace(noteTitle))
            {
                MessageBox.Show("Please enter a title for the note.");
                return;
            }

            if (string.IsNullOrWhiteSpace(noteContent))
            {
                DialogResult result = MessageBox.Show("You are about to save a note without any content. Continue?", "Confirm Save", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    return;
                }
            }


            using (SqlConnection sqlCon = new SqlConnection(@"Data Source=SOPHIA; Initial Catalog=NoteDB; Integrated Security=True;"))
            {
                sqlCon.Open();
                string insertQuery = "INSERT INTO Notes (Title, Content) VALUES (@Title, @Content)";
                using (SqlCommand command = new SqlCommand(insertQuery, sqlCon))
                {
                    command.Parameters.AddWithValue("@Title", noteTitle);
                    command.Parameters.AddWithValue("@Content", noteContent);

                    try
                    {
                        command.ExecuteNonQuery();
                        MessageBox.Show("Note saved successfully!");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error saving note: " + ex.Message);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            ShowNotesForm();
        }
        private void ShowNotesForm()
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

    }
}
