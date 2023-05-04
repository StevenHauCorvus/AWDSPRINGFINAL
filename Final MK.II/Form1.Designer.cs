namespace Final_MK.II
{
    partial class Form1
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
            pictureBox1 = new PictureBox();
            loginScreen = new GroupBox();
            pictureBox2 = new PictureBox();
            btnLogin = new Button();
            lblErrorPass = new Label();
            lblErrorUser = new Label();
            label2 = new Label();
            label1 = new Label();
            txtPassword = new TextBox();
            txtUserName = new TextBox();
            topBar = new GroupBox();
            label8 = new Label();
            btnLogout = new Button();
            button2 = new Button();
            button1 = new Button();
            button3 = new Button();
            btnCreateTicket = new Button();
            gbStatus = new GroupBox();
            gbRemove = new GroupBox();
            label4 = new Label();
            btnGBRemove = new Button();
            cboRemoveID = new ComboBox();
            btnRemoveTicketID = new Button();
            rtbOutput = new RichTextBox();
            gbTicket = new GroupBox();
            btnPrintTicket = new Button();
            lblWelcome = new Label();
            txtEmail = new TextBox();
            cboCourse = new ComboBox();
            labelanother = new Label();
            txtLastName = new TextBox();
            label7 = new Label();
            txtFirstName = new TextBox();
            label6 = new Label();
            txtStudentID = new TextBox();
            label5 = new Label();
            gbAdminVerification = new GroupBox();
            lblAdminError = new Label();
            button5 = new Button();
            label9 = new Label();
            btnAdminSearch = new Button();
            txtAdministratorPassword = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            loginScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            topBar.SuspendLayout();
            gbStatus.SuspendLayout();
            gbRemove.SuspendLayout();
            gbTicket.SuspendLayout();
            gbAdminVerification.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Resize_typing;
            pictureBox1.Location = new Point(0, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 494);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // loginScreen
            // 
            loginScreen.BackColor = Color.White;
            loginScreen.Controls.Add(pictureBox2);
            loginScreen.Controls.Add(btnLogin);
            loginScreen.Controls.Add(lblErrorPass);
            loginScreen.Controls.Add(lblErrorUser);
            loginScreen.Controls.Add(label2);
            loginScreen.Controls.Add(label1);
            loginScreen.Controls.Add(txtPassword);
            loginScreen.Controls.Add(txtUserName);
            loginScreen.Controls.Add(pictureBox1);
            loginScreen.Location = new Point(-9, -9);
            loginScreen.Name = "loginScreen";
            loginScreen.Size = new Size(1076, 522);
            loginScreen.TabIndex = 1;
            loginScreen.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.blue_block;
            pictureBox2.Location = new Point(701, 120);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(92, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.LightSkyBlue;
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(637, 369);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(235, 40);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // lblErrorPass
            // 
            lblErrorPass.AutoSize = true;
            lblErrorPass.ForeColor = Color.Red;
            lblErrorPass.Location = new Point(718, 303);
            lblErrorPass.Name = "lblErrorPass";
            lblErrorPass.Size = new Size(0, 20);
            lblErrorPass.TabIndex = 6;
            // 
            // lblErrorUser
            // 
            lblErrorUser.AutoSize = true;
            lblErrorUser.ForeColor = Color.Red;
            lblErrorUser.Location = new Point(718, 219);
            lblErrorUser.Name = "lblErrorUser";
            lblErrorUser.Size = new Size(0, 20);
            lblErrorUser.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(637, 303);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Gray;
            label1.Location = new Point(637, 219);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 3;
            label1.Text = "Username";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.WhiteSmoke;
            txtPassword.Location = new Point(637, 326);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(235, 27);
            txtPassword.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.BackColor = Color.WhiteSmoke;
            txtUserName.Location = new Point(637, 242);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(235, 27);
            txtUserName.TabIndex = 1;
            // 
            // topBar
            // 
            topBar.BackColor = Color.Transparent;
            topBar.Controls.Add(label8);
            topBar.Controls.Add(btnLogout);
            topBar.Controls.Add(button2);
            topBar.Controls.Add(button1);
            topBar.Controls.Add(button3);
            topBar.Controls.Add(btnCreateTicket);
            topBar.Location = new Point(1, 44);
            topBar.Name = "topBar";
            topBar.Size = new Size(146, 222);
            topBar.TabIndex = 2;
            topBar.TabStop = false;
            topBar.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(101, 65);
            label8.Name = "label8";
            label8.Size = new Size(17, 20);
            label8.TabIndex = 5;
            label8.Text = "0";
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(255, 192, 192);
            btnLogout.BackgroundImageLayout = ImageLayout.None;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.Black;
            btnLogout.Location = new Point(0, 187);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(140, 29);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "LOGOUT";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.BackgroundImageLayout = ImageLayout.None;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(0, 131);
            button2.Name = "button2";
            button2.Size = new Size(140, 29);
            button2.TabIndex = 3;
            button2.Text = "Live Demo";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 96);
            button1.Name = "button1";
            button1.Size = new Size(140, 29);
            button1.TabIndex = 2;
            button1.Text = "Close Ticket";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.BackgroundImageLayout = ImageLayout.None;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.Black;
            button3.Location = new Point(0, 61);
            button3.Name = "button3";
            button3.Size = new Size(140, 29);
            button3.TabIndex = 1;
            button3.Text = "Check Status";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // btnCreateTicket
            // 
            btnCreateTicket.BackColor = Color.Transparent;
            btnCreateTicket.BackgroundImageLayout = ImageLayout.None;
            btnCreateTicket.FlatStyle = FlatStyle.Flat;
            btnCreateTicket.ForeColor = Color.Black;
            btnCreateTicket.Location = new Point(0, 26);
            btnCreateTicket.Name = "btnCreateTicket";
            btnCreateTicket.Size = new Size(140, 29);
            btnCreateTicket.TabIndex = 0;
            btnCreateTicket.Text = "Create Ticket";
            btnCreateTicket.TextAlign = ContentAlignment.MiddleLeft;
            btnCreateTicket.UseVisualStyleBackColor = false;
            btnCreateTicket.Click += btnCreateTicket_Click;
            // 
            // gbStatus
            // 
            gbStatus.BackColor = Color.Transparent;
            gbStatus.Controls.Add(gbRemove);
            gbStatus.Controls.Add(rtbOutput);
            gbStatus.Location = new Point(276, 70);
            gbStatus.Name = "gbStatus";
            gbStatus.Size = new Size(436, 321);
            gbStatus.TabIndex = 3;
            gbStatus.TabStop = false;
            gbStatus.Visible = false;
            // 
            // gbRemove
            // 
            gbRemove.Controls.Add(label4);
            gbRemove.Controls.Add(btnGBRemove);
            gbRemove.Controls.Add(cboRemoveID);
            gbRemove.Controls.Add(btnRemoveTicketID);
            gbRemove.Location = new Point(62, 42);
            gbRemove.Name = "gbRemove";
            gbRemove.Size = new Size(313, 101);
            gbRemove.TabIndex = 1;
            gbRemove.TabStop = false;
            gbRemove.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 36);
            label4.Name = "label4";
            label4.Size = new Size(117, 20);
            label4.TabIndex = 3;
            label4.Text = "Remove Case ID";
            // 
            // btnGBRemove
            // 
            btnGBRemove.BackColor = Color.Red;
            btnGBRemove.ForeColor = Color.White;
            btnGBRemove.Location = new Point(270, 14);
            btnGBRemove.Name = "btnGBRemove";
            btnGBRemove.Size = new Size(43, 29);
            btnGBRemove.TabIndex = 2;
            btnGBRemove.Text = "X";
            btnGBRemove.UseVisualStyleBackColor = false;
            btnGBRemove.Click += btnGBRemove_Click;
            // 
            // cboRemoveID
            // 
            cboRemoveID.FormattingEnabled = true;
            cboRemoveID.Location = new Point(94, 67);
            cboRemoveID.Name = "cboRemoveID";
            cboRemoveID.Size = new Size(151, 28);
            cboRemoveID.TabIndex = 1;
            // 
            // btnRemoveTicketID
            // 
            btnRemoveTicketID.Location = new Point(126, 32);
            btnRemoveTicketID.Name = "btnRemoveTicketID";
            btnRemoveTicketID.Size = new Size(94, 29);
            btnRemoveTicketID.TabIndex = 0;
            btnRemoveTicketID.Text = "button4";
            btnRemoveTicketID.UseVisualStyleBackColor = true;
            btnRemoveTicketID.Click += btnRemoveTicketID_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(3, 149);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(424, 166);
            rtbOutput.TabIndex = 0;
            rtbOutput.Text = "";
            // 
            // gbTicket
            // 
            gbTicket.BackColor = Color.Transparent;
            gbTicket.Controls.Add(btnPrintTicket);
            gbTicket.Controls.Add(lblWelcome);
            gbTicket.Controls.Add(txtEmail);
            gbTicket.Controls.Add(cboCourse);
            gbTicket.Controls.Add(labelanother);
            gbTicket.Controls.Add(txtLastName);
            gbTicket.Controls.Add(label7);
            gbTicket.Controls.Add(txtFirstName);
            gbTicket.Controls.Add(label6);
            gbTicket.Controls.Add(txtStudentID);
            gbTicket.Controls.Add(label5);
            gbTicket.Location = new Point(224, 54);
            gbTicket.Name = "gbTicket";
            gbTicket.Size = new Size(544, 403);
            gbTicket.TabIndex = 4;
            gbTicket.TabStop = false;
            gbTicket.Visible = false;
            // 
            // btnPrintTicket
            // 
            btnPrintTicket.BackColor = Color.FromArgb(255, 192, 192);
            btnPrintTicket.BackgroundImageLayout = ImageLayout.None;
            btnPrintTicket.FlatStyle = FlatStyle.Flat;
            btnPrintTicket.ForeColor = Color.Black;
            btnPrintTicket.Location = new Point(190, 364);
            btnPrintTicket.Name = "btnPrintTicket";
            btnPrintTicket.Size = new Size(140, 29);
            btnPrintTicket.TabIndex = 6;
            btnPrintTicket.Text = "Create Ticket";
            btnPrintTicket.UseVisualStyleBackColor = false;
            btnPrintTicket.Click += btnPrintTicket_Click;
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Location = new Point(22, 30);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(119, 20);
            lblWelcome.TabIndex = 9;
            lblWelcome.Text = "Welcome Steven";
            lblWelcome.Click += label9_Click;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.Location = new Point(38, 138);
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(473, 220);
            txtEmail.TabIndex = 8;
            // 
            // cboCourse
            // 
            cboCourse.FormattingEnabled = true;
            cboCourse.Location = new Point(355, 104);
            cboCourse.Name = "cboCourse";
            cboCourse.Size = new Size(156, 28);
            cboCourse.TabIndex = 7;
            cboCourse.SelectedIndexChanged += cboCourse_SelectedIndexChanged;
            // 
            // labelanother
            // 
            labelanother.AutoSize = true;
            labelanother.Location = new Point(260, 104);
            labelanother.Name = "labelanother";
            labelanother.Size = new Size(89, 20);
            labelanother.TabIndex = 6;
            labelanother.Text = "Department";
            // 
            // txtLastName
            // 
            txtLastName.BackColor = Color.Gainsboro;
            txtLastName.Location = new Point(102, 97);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(139, 27);
            txtLastName.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(38, 100);
            label7.Name = "label7";
            label7.Size = new Size(58, 20);
            label7.TabIndex = 4;
            label7.Text = "Subject";
            // 
            // txtFirstName
            // 
            txtFirstName.BackColor = Color.Gainsboro;
            txtFirstName.Location = new Point(336, 67);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(175, 27);
            txtFirstName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(281, 67);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 2;
            label6.Text = "Name";
            // 
            // txtStudentID
            // 
            txtStudentID.BackColor = Color.Gainsboro;
            txtStudentID.Location = new Point(122, 64);
            txtStudentID.Name = "txtStudentID";
            txtStudentID.Size = new Size(139, 27);
            txtStudentID.TabIndex = 1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 67);
            label5.Name = "label5";
            label5.Size = new Size(94, 20);
            label5.TabIndex = 0;
            label5.Text = "Employee ID";
            // 
            // gbAdminVerification
            // 
            gbAdminVerification.BackColor = Color.Transparent;
            gbAdminVerification.Controls.Add(lblAdminError);
            gbAdminVerification.Controls.Add(button5);
            gbAdminVerification.Controls.Add(label9);
            gbAdminVerification.Controls.Add(btnAdminSearch);
            gbAdminVerification.Controls.Add(txtAdministratorPassword);
            gbAdminVerification.Location = new Point(766, 4);
            gbAdminVerification.Name = "gbAdminVerification";
            gbAdminVerification.Size = new Size(293, 125);
            gbAdminVerification.TabIndex = 5;
            gbAdminVerification.TabStop = false;
            gbAdminVerification.Visible = false;
            // 
            // lblAdminError
            // 
            lblAdminError.AutoSize = true;
            lblAdminError.ForeColor = Color.Red;
            lblAdminError.Location = new Point(199, 50);
            lblAdminError.Name = "lblAdminError";
            lblAdminError.Size = new Size(41, 20);
            lblAdminError.TabIndex = 4;
            lblAdminError.Text = "Error";
            // 
            // button5
            // 
            button5.BackColor = Color.Red;
            button5.ForeColor = Color.White;
            button5.Location = new Point(244, 19);
            button5.Name = "button5";
            button5.Size = new Size(43, 29);
            button5.TabIndex = 3;
            button5.Text = "X";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(68, 23);
            label9.Name = "label9";
            label9.Size = new Size(134, 20);
            label9.TabIndex = 2;
            label9.Text = "Password Required";
            // 
            // btnAdminSearch
            // 
            btnAdminSearch.Location = new Point(84, 80);
            btnAdminSearch.Name = "btnAdminSearch";
            btnAdminSearch.Size = new Size(94, 29);
            btnAdminSearch.TabIndex = 1;
            btnAdminSearch.Text = "button4";
            btnAdminSearch.UseVisualStyleBackColor = true;
            btnAdminSearch.Click += btnAdminSearch_Click;
            // 
            // txtAdministratorPassword
            // 
            txtAdministratorPassword.Location = new Point(68, 47);
            txtAdministratorPassword.Name = "txtAdministratorPassword";
            txtAdministratorPassword.Size = new Size(125, 27);
            txtAdministratorPassword.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.baby_blue_back;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1058, 492);
            Controls.Add(loginScreen);
            Controls.Add(gbTicket);
            Controls.Add(gbAdminVerification);
            Controls.Add(topBar);
            Controls.Add(gbStatus);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            loginScreen.ResumeLayout(false);
            loginScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            topBar.ResumeLayout(false);
            topBar.PerformLayout();
            gbStatus.ResumeLayout(false);
            gbRemove.ResumeLayout(false);
            gbRemove.PerformLayout();
            gbTicket.ResumeLayout(false);
            gbTicket.PerformLayout();
            gbAdminVerification.ResumeLayout(false);
            gbAdminVerification.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private GroupBox loginScreen;
        private Label label1;
        private TextBox txtPassword;
        private TextBox txtUserName;
        private Label label2;
        private Label lblErrorUser;
        private Label lblErrorPass;
        private Button btnLogin;
        private PictureBox pictureBox2;
        private GroupBox topBar;
        private Button btnCreateTicket;
        private Button button3;
        private Button button1;
        private Button button2;
        private Button btnLogout;
        private GroupBox gbStatus;
        private RichTextBox rtbOutput;
        private Label label8;
        private GroupBox gbRemove;
        private Button btnRemoveTicketID;
        private ComboBox cboRemoveID;
        private Button btnGBRemove;
        private Label label4;
        private GroupBox gbTicket;
        private TextBox txtStudentID;
        private Label label5;
        private TextBox txtFirstName;
        private Label label6;
        private TextBox txtLastName;
        private Label label7;
        private ComboBox cboCourse;
        private Label labelanother;
        private TextBox txtEmail;
        private Label lblWelcome;
        private GroupBox gbAdminVerification;
        private Button btnAdminSearch;
        private TextBox txtAdministratorPassword;
        private Label label9;
        private Button button5;
        private Label lblAdminError;
        private Button btnPrintTicket;
    }
}