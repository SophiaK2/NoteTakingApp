namespace Notes
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            textBoxTitle = new TextBox();
            textBoxContent = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Papyrus", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(142, 23);
            button1.Name = "button1";
            button1.Size = new Size(213, 47);
            button1.TabIndex = 0;
            button1.Text = "Import Note";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Papyrus", 14F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(12, 76);
            button2.Name = "button2";
            button2.Size = new Size(213, 47);
            button2.TabIndex = 1;
            button2.Text = "Update Note";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Papyrus", 9F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(3, 451);
            button3.Name = "button3";
            button3.Size = new Size(112, 34);
            button3.TabIndex = 2;
            button3.Text = "GO Back!";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 142);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(343, 129);
            dataGridView1.TabIndex = 3;
            // 
            // textBoxTitle
            // 
            textBoxTitle.Location = new Point(3, 297);
            textBoxTitle.Name = "textBoxTitle";
            textBoxTitle.Size = new Size(150, 31);
            textBoxTitle.TabIndex = 4;
            // 
            // textBoxContent
            // 
            textBoxContent.Location = new Point(3, 334);
            textBoxContent.Name = "textBoxContent";
            textBoxContent.Size = new Size(277, 58);
            textBoxContent.TabIndex = 5;
            textBoxContent.Text = "";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.f45a3f9121bb34086f81c0a93e4e8fb5;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(447, 580);
            Controls.Add(textBoxContent);
            Controls.Add(textBoxTitle);
            Controls.Add(dataGridView1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private DataGridView dataGridView1;
        private TextBox textBoxTitle;
        private RichTextBox textBoxContent;
    }
}