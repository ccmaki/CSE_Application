
namespace CSE_Application
{
    partial class Welcome_Page
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome_Page));
            panel1 = new Panel();
            panel2 = new Panel();
            Welcome_to = new Label();
            label4 = new Label();
            label1 = new Label();
            Login_Admin_Button = new Button();
            Register_Button = new Button();
            pictureBox1 = new PictureBox();
            button_existing = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(0, 56, 168);
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1654, 91);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(206, 17, 38);
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.Location = new Point(0, 91);
            panel2.Name = "panel2";
            panel2.Size = new Size(1654, 35);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // Welcome_to
            // 
            Welcome_to.BackColor = Color.Transparent;
            Welcome_to.Font = new Font("Nirmala UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Welcome_to.Location = new Point(118, 243);
            Welcome_to.Name = "Welcome_to";
            Welcome_to.Size = new Size(900, 37);
            Welcome_to.TabIndex = 2;
            Welcome_to.Text = "Welcome to \r\n";
            Welcome_to.Click += Welcome_to_Click;
            // 
            // label4
            // 
            label4.Font = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 473);
            label4.Name = "label4";
            label4.Size = new Size(737, 89);
            label4.TabIndex = 5;
            label4.Text = "The Civil Service Commission was conferred the status of a department by Republic Act No. 2260 as amended and elevated to a constitutional body \r\nby the 1973 Constitution.";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Nirmala UI", 36.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(112, 280);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(803, 204);
            label1.TabIndex = 6;
            label1.Text = "Civil Service Examination\r\n(PPT) Professional Level Application Portal";
            // 
            // Login_Admin_Button
            // 
            Login_Admin_Button.BackColor = Color.FromArgb(0, 38, 168);
            Login_Admin_Button.BackgroundImageLayout = ImageLayout.None;
            Login_Admin_Button.Cursor = Cursors.Hand;
            Login_Admin_Button.FlatStyle = FlatStyle.Flat;
            Login_Admin_Button.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Login_Admin_Button.ForeColor = SystemColors.Control;
            Login_Admin_Button.Location = new Point(116, 576);
            Login_Admin_Button.Margin = new Padding(0);
            Login_Admin_Button.Name = "Login_Admin_Button";
            Login_Admin_Button.Size = new Size(343, 64);
            Login_Admin_Button.TabIndex = 7;
            Login_Admin_Button.Text = "Log in as Admin";
            Login_Admin_Button.UseVisualStyleBackColor = false;
            Login_Admin_Button.Click += Login_Admin_Button_Click;
            // 
            // Register_Button
            // 
            Register_Button.BackColor = Color.FromArgb(114, 106, 101);
            Register_Button.BackgroundImageLayout = ImageLayout.None;
            Register_Button.Cursor = Cursors.Hand;
            Register_Button.FlatStyle = FlatStyle.Flat;
            Register_Button.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Register_Button.ForeColor = SystemColors.Control;
            Register_Button.Location = new Point(113, 692);
            Register_Button.Margin = new Padding(0);
            Register_Button.Name = "Register_Button";
            Register_Button.Size = new Size(343, 64);
            Register_Button.TabIndex = 8;
            Register_Button.Text = "Register as Applicant";
            Register_Button.UseVisualStyleBackColor = false;
            Register_Button.Click += Register_Button_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.InitialImage = null;
            pictureBox1.Location = new Point(963, 215);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(572, 542);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // button_existing
            // 
            button_existing.BackColor = Color.FromArgb(0, 38, 168);
            button_existing.BackgroundImageLayout = ImageLayout.None;
            button_existing.Cursor = Cursors.Hand;
            button_existing.FlatStyle = FlatStyle.Flat;
            button_existing.Font = new Font("Nirmala UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button_existing.ForeColor = SystemColors.Control;
            button_existing.Location = new Point(476, 576);
            button_existing.Margin = new Padding(0);
            button_existing.Name = "button_existing";
            button_existing.Size = new Size(343, 64);
            button_existing.TabIndex = 10;
            button_existing.Text = "Log in as Existing Applicant";
            button_existing.UseVisualStyleBackColor = false;
            button_existing.Click += button1_Click;
            // 
            // Welcome_Page
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1654, 878);
            Controls.Add(button_existing);
            Controls.Add(pictureBox1);
            Controls.Add(Register_Button);
            Controls.Add(Login_Admin_Button);
            Controls.Add(label4);
            Controls.Add(Welcome_to);
            Controls.Add(label1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome_Page";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Panel panel1;
        private Panel panel2;
        private Label Welcome_to;
        private Label label4;
        private Label label1;
        private Button Login_Admin_Button;
        private Button Register_Button;
        private PictureBox pictureBox1;
        private Button button_existing;
    }
}
