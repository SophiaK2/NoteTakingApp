namespace Notes
{
    partial class Form2
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
            label1 = new Label();
            Content = new RichTextBox();
            Title = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.Location = new Point(191, 599);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 0;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Thistle;
            label1.Font = new Font("Ravie", 9F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(154, 9);
            label1.Name = "label1";
            label1.Size = new Size(265, 24);
            label1.TabIndex = 1;
            label1.Text = "Share Your Thoughts";
            // 
            // Content
            // 
            Content.BackColor = Color.BurlyWood;
            Content.Location = new Point(72, 123);
            Content.Name = "Content";
            Content.Size = new Size(374, 311);
            Content.TabIndex = 3;
            Content.Text = "";
            // 
            // Title
            // 
            Title.BackColor = Color.BurlyWood;
            Title.Location = new Point(180, 75);
            Title.Name = "Title";
            Title.PlaceholderText = "Add Title";
            Title.Size = new Size(150, 31);
            Title.TabIndex = 4;
            // 
            // button2
            // 
            button2.BackColor = Color.RosyBrown;
            button2.Location = new Point(191, 648);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 5;
            button2.Text = "See Notes";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.c21d57b492468481e2305b333c95b053;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(550, 694);
            Controls.Add(button2);
            Controls.Add(Title);
            Controls.Add(Content);
            Controls.Add(label1);
            Controls.Add(button1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private RichTextBox Content;
        private TextBox Title;
        private Button button2;
    }
}