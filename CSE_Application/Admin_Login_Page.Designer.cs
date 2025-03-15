namespace CSE_Application
{
    partial class Admin_Login_Page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin_Login_Page));
            pictureBox1 = new PictureBox();
            return_Home_Button = new Button();
            Welcome_to = new Label();
            panel2 = new Panel();
            panel1 = new Panel();
            label1 = new Label();
            panel3 = new Panel();
            forgot_Pass = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            Password = new Label();
            textBox1 = new TextBox();
            username = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(331, 375);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(312, 296);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 24;
            pictureBox1.TabStop = false;
            // 
            // return_Home_Button
            // 
            return_Home_Button.BackColor = Color.FromArgb(0, 38, 168);
            return_Home_Button.BackgroundImageLayout = ImageLayout.None;
            return_Home_Button.Cursor = Cursors.Hand;
            return_Home_Button.FlatStyle = FlatStyle.Flat;
            return_Home_Button.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            return_Home_Button.ForeColor = SystemColors.Control;
            return_Home_Button.Location = new Point(376, 708);
            return_Home_Button.Margin = new Padding(0);
            return_Home_Button.Name = "return_Home_Button";
            return_Home_Button.Size = new Size(222, 55);
            return_Home_Button.TabIndex = 23;
            return_Home_Button.Text = "RETURN HOME";
            return_Home_Button.UseVisualStyleBackColor = false;
            return_Home_Button.Click += return_Home_Button_Click;
            // 
            // Welcome_to
            // 
            Welcome_to.BackColor = Color.Transparent;
            Welcome_to.Font = new Font("Nirmala UI", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcome_to.Location = new Point(215, 199);
            Welcome_to.Name = "Welcome_to";
            Welcome_to.Size = new Size(609, 120);
            Welcome_to.TabIndex = 22;
            Welcome_to.Text = "Welcome to CSE Professional Level System Administration";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(206, 17, 38);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1654, 35);
            panel2.TabIndex = 20;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 56, 168);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 91);
            panel1.TabIndex = 19;
            // 
            // label1
            // 
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 30F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(3, 124);
            label1.Name = "label1";
            label1.Size = new Size(673, 60);
            label1.TabIndex = 19;
            label1.Text = "Log into your account";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(217, 217, 217);
            panel3.BackgroundImageLayout = ImageLayout.None;
            panel3.Controls.Add(forgot_Pass);
            panel3.Controls.Add(button1);
            panel3.Controls.Add(textBox2);
            panel3.Controls.Add(Password);
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(username);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(960, 124);
            panel3.Name = "panel3";
            panel3.Size = new Size(694, 755);
            panel3.TabIndex = 21;
            // 
            // forgot_Pass
            // 
            forgot_Pass.AutoSize = true;
            forgot_Pass.Cursor = Cursors.Hand;
            forgot_Pass.Font = new Font("Microsoft YaHei", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            forgot_Pass.ForeColor = Color.FromArgb(250, 0, 0);
            forgot_Pass.Location = new Point(250, 472);
            forgot_Pass.Name = "forgot_Pass";
            forgot_Pass.Size = new Size(174, 25);
            forgot_Pass.TabIndex = 24;
            forgot_Pass.Text = "Forgot Password?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 38, 168);
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Nirmala UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = SystemColors.Control;
            button1.Location = new Point(236, 584);
            button1.Margin = new Padding(0);
            button1.Name = "button1";
            button1.Size = new Size(222, 55);
            button1.TabIndex = 19;
            button1.Text = "LOGIN";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Font = new Font("MS UI Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(97, 371);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(480, 45);
            textBox2.TabIndex = 23;
            // 
            // Password
            // 
            Password.BackColor = Color.Transparent;
            Password.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Password.ImageAlign = ContentAlignment.TopLeft;
            Password.Location = new Point(97, 344);
            Password.Name = "Password";
            Password.Size = new Size(89, 31);
            Password.TabIndex = 22;
            Password.Text = "Password";
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Font = new Font("MS UI Gothic", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(97, 260);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(480, 45);
            textBox1.TabIndex = 21;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // username
            // 
            username.BackColor = Color.Transparent;
            username.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            username.ImageAlign = ContentAlignment.TopLeft;
            username.Location = new Point(97, 233);
            username.Name = "username";
            username.Size = new Size(89, 31);
            username.TabIndex = 20;
            username.Text = "Username";
            // 
            // Admin_Login_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1654, 878);
            Controls.Add(pictureBox1);
            Controls.Add(return_Home_Button);
            Controls.Add(Welcome_to);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panel3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Admin_Login_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Admin_Login_Page";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Button return_Home_Button;
        private Label Welcome_to;
        private Panel panel2;
        private Panel panel1;
        private Label label1;
        private Panel panel3;
        private Label forgot_Pass;
        private Button button1;
        private TextBox textBox2;
        private Label Password;
        private TextBox textBox1;
        private Label username;
    }
}