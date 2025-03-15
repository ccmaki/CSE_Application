namespace CSE_Application
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            lbl1 = new Label();
            label3 = new Label();
            label4 = new Label();
            Logout = new Button();
            label6 = new Label();
            ApplicantionForm_Button = new Button();
            ApplicationStatus_Button = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 56, 168);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 47);
            panel1.TabIndex = 20;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(41, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(164, 158);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 25;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lbl1
            // 
            lbl1.BackColor = Color.Transparent;
            lbl1.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl1.ForeColor = Color.FromArgb(32, 30, 80);
            lbl1.Location = new Point(211, 82);
            lbl1.Name = "lbl1";
            lbl1.Size = new Size(352, 41);
            lbl1.TabIndex = 26;
            lbl1.Text = "Republic of the Philippines";
            lbl1.Click += lbl1_Click;
            // 
            // label3
            // 
            label3.BackColor = Color.Transparent;
            label3.Cursor = Cursors.Hand;
            label3.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(1056, 120);
            label3.Name = "label3";
            label3.Size = new Size(83, 34);
            label3.TabIndex = 29;
            label3.Text = "Profile";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.BackColor = Color.Transparent;
            label4.Cursor = Cursors.Hand;
            label4.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(1175, 120);
            label4.Name = "label4";
            label4.Size = new Size(83, 34);
            label4.TabIndex = 30;
            label4.Text = "About";
            label4.Click += label4_Click;
            // 
            // Logout
            // 
            Logout.BackColor = Color.FromArgb(191, 43, 43);
            Logout.BackgroundImageLayout = ImageLayout.None;
            Logout.Cursor = Cursors.Hand;
            Logout.FlatStyle = FlatStyle.Flat;
            Logout.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Logout.ForeColor = SystemColors.Control;
            Logout.Location = new Point(1283, 108);
            Logout.Margin = new Padding(0);
            Logout.Name = "Logout";
            Logout.Size = new Size(120, 53);
            Logout.TabIndex = 31;
            Logout.Text = " Log Out";
            Logout.UseVisualStyleBackColor = false;
            Logout.Click += Logout_Click;
            // 
            // label6
            // 
            label6.BackColor = Color.Transparent;
            label6.Font = new Font("Nirmala UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(99, 288);
            label6.Name = "label6";
            label6.Size = new Size(1000, 41);
            label6.TabIndex = 33;
            label6.Text = "You are applying for the Civil Service Examination (Pen and Paper Test) Professional Level.";
            // 
            // ApplicantionForm_Button
            // 
            ApplicantionForm_Button.BackColor = Color.FromArgb(0, 56, 168);
            ApplicantionForm_Button.BackgroundImageLayout = ImageLayout.None;
            ApplicantionForm_Button.Cursor = Cursors.Hand;
            ApplicantionForm_Button.FlatStyle = FlatStyle.Flat;
            ApplicantionForm_Button.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplicantionForm_Button.ForeColor = SystemColors.Control;
            ApplicantionForm_Button.Location = new Point(466, 364);
            ApplicantionForm_Button.Margin = new Padding(0);
            ApplicantionForm_Button.Name = "ApplicantionForm_Button";
            ApplicantionForm_Button.Size = new Size(301, 152);
            ApplicantionForm_Button.TabIndex = 34;
            ApplicantionForm_Button.Text = "Application Form";
            ApplicantionForm_Button.UseVisualStyleBackColor = false;
            ApplicantionForm_Button.Click += ApplicantionForm_Button_Click;
            // 
            // ApplicationStatus_Button
            // 
            ApplicationStatus_Button.BackColor = Color.FromArgb(216, 216, 216);
            ApplicationStatus_Button.BackgroundImageLayout = ImageLayout.None;
            ApplicationStatus_Button.Cursor = Cursors.Hand;
            ApplicationStatus_Button.FlatStyle = FlatStyle.Flat;
            ApplicationStatus_Button.Font = new Font("Nirmala UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ApplicationStatus_Button.ForeColor = Color.Black;
            ApplicationStatus_Button.Location = new Point(817, 364);
            ApplicationStatus_Button.Margin = new Padding(0);
            ApplicationStatus_Button.Name = "ApplicationStatus_Button";
            ApplicationStatus_Button.Size = new Size(301, 152);
            ApplicationStatus_Button.TabIndex = 35;
            ApplicationStatus_Button.Text = "Application Status";
            ApplicationStatus_Button.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            label7.BackColor = Color.Transparent;
            label7.Font = new Font("Nirmala UI", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(99, 569);
            label7.Name = "label7";
            label7.Size = new Size(1000, 41);
            label7.TabIndex = 37;
            label7.Text = "Steps for applying:";
            // 
            // label8
            // 
            label8.BackColor = Color.Transparent;
            label8.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Black;
            label8.Location = new Point(118, 610);
            label8.Name = "label8";
            label8.Size = new Size(1000, 41);
            label8.TabIndex = 38;
            label8.Text = "1. Click the ‘Application Form’ tab to proceed with your application.\n";
            // 
            // label9
            // 
            label9.BackColor = Color.Transparent;
            label9.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Black;
            label9.Location = new Point(118, 651);
            label9.Name = "label9";
            label9.Size = new Size(1000, 41);
            label9.TabIndex = 39;
            label9.Text = "2. Click ‘Application Status’ to view the status of your application.";
            // 
            // label10
            // 
            label10.BackColor = Color.Transparent;
            label10.Font = new Font("Nirmala UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Black;
            label10.Location = new Point(118, 692);
            label10.Name = "label10";
            label10.Size = new Size(1000, 41);
            label10.TabIndex = 40;
            label10.Text = "3. Download the copy of your Application Receipt.";
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(211, 114);
            label1.Name = "label1";
            label1.Size = new Size(415, 41);
            label1.TabIndex = 41;
            label1.Text = "Civil Service Commission";
            // 
            // label2
            // 
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(191, 43, 43);
            label2.Location = new Point(277, 155);
            label2.Name = "label2";
            label2.Size = new Size(415, 41);
            label2.TabIndex = 42;
            label2.Text = "Gawing Lingkod Bayani ang Bawat Kawani";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1654, 878);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(ApplicationStatus_Button);
            Controls.Add(ApplicantionForm_Button);
            Controls.Add(label6);
            Controls.Add(Logout);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lbl1);
            Controls.Add(pictureBox1);
            Controls.Add(panel1);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Applicant_Dashboard";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label lbl1;
        private Label label3;
        private Label label4;
        private Button Logout;
        private Label label6;
        private Button ApplicantionForm_Button;
        private Button ApplicationStatus_Button;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label1;
        private Label label2;
    }
}