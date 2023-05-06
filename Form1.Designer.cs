namespace ClientProgram
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
            btnConnect = new Button();
            btnViewRoomNum = new Button();
            label3 = new Label();
            tbRoomNum = new TextBox();
            btnChangeRoomNum = new Button();
            label4 = new Label();
            label5 = new Label();
            tbUsername = new TextBox();
            tbPassword = new TextBox();
            btnSignIn = new Button();
            btnSignUp = new Button();
            groupBox1 = new GroupBox();
            btnOutRoom = new Button();
            btnJoinRoom = new Button();
            tbRoomList = new TextBox();
            btnRoomCreate = new Button();
            tbRoomCount = new TextBox();
            label7 = new Label();
            tbRoomName = new TextBox();
            label6 = new Label();
            btnRefreshRoomList = new Button();
            groupBox2 = new GroupBox();
            btnSend = new Button();
            tbMessage = new TextBox();
            tbRoomChat = new TextBox();
            groupBox3 = new GroupBox();
            groupBox4 = new GroupBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // btnConnect
            // 
            btnConnect.Location = new Point(6, 41);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(75, 53);
            btnConnect.TabIndex = 5;
            btnConnect.Text = "서버 연결";
            btnConnect.UseVisualStyleBackColor = true;
            btnConnect.Click += btnConnect_Click;
            // 
            // btnViewRoomNum
            // 
            btnViewRoomNum.Location = new Point(127, 42);
            btnViewRoomNum.Name = "btnViewRoomNum";
            btnViewRoomNum.Size = new Size(90, 23);
            btnViewRoomNum.TabIndex = 6;
            btnViewRoomNum.Text = "방 번호 조회";
            btnViewRoomNum.UseVisualStyleBackColor = true;
            btnViewRoomNum.Click += btnViewRoomNum_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(484, 15);
            label3.Name = "label3";
            label3.Size = new Size(0, 15);
            label3.TabIndex = 7;
            // 
            // tbRoomNum
            // 
            tbRoomNum.Location = new Point(127, 13);
            tbRoomNum.Name = "tbRoomNum";
            tbRoomNum.Size = new Size(90, 23);
            tbRoomNum.TabIndex = 8;
            // 
            // btnChangeRoomNum
            // 
            btnChangeRoomNum.Location = new Point(127, 71);
            btnChangeRoomNum.Name = "btnChangeRoomNum";
            btnChangeRoomNum.Size = new Size(90, 23);
            btnChangeRoomNum.TabIndex = 9;
            btnChangeRoomNum.Text = "방 번호 변경";
            btnChangeRoomNum.UseVisualStyleBackColor = true;
            btnChangeRoomNum.Click += btnChangeRoomNum_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 25);
            label4.Name = "label4";
            label4.Size = new Size(70, 15);
            label4.TabIndex = 10;
            label4.Text = "username : ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(8, 61);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 11;
            label5.Text = "password : ";
            // 
            // tbUsername
            // 
            tbUsername.Location = new Point(69, 22);
            tbUsername.Name = "tbUsername";
            tbUsername.Size = new Size(146, 23);
            tbUsername.TabIndex = 12;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(69, 57);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(146, 23);
            tbPassword.TabIndex = 13;
            // 
            // btnSignIn
            // 
            btnSignIn.Location = new Point(233, 33);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(75, 23);
            btnSignIn.TabIndex = 14;
            btnSignIn.Text = "로그인";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(221, 57);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(75, 23);
            btnSignUp.TabIndex = 15;
            btnSignUp.Text = "회원가입";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnOutRoom);
            groupBox1.Controls.Add(btnJoinRoom);
            groupBox1.Controls.Add(tbRoomList);
            groupBox1.Controls.Add(btnRoomCreate);
            groupBox1.Controls.Add(tbRoomCount);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(tbRoomName);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(btnRefreshRoomList);
            groupBox1.Location = new Point(12, 138);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(240, 226);
            groupBox1.TabIndex = 16;
            groupBox1.TabStop = false;
            groupBox1.Text = "방 목록";
            // 
            // btnOutRoom
            // 
            btnOutRoom.Location = new Point(134, 197);
            btnOutRoom.Name = "btnOutRoom";
            btnOutRoom.Size = new Size(100, 23);
            btnOutRoom.TabIndex = 9;
            btnOutRoom.Text = "방 나가기";
            btnOutRoom.UseVisualStyleBackColor = true;
            btnOutRoom.Click += btnOutRoom_Click;
            // 
            // btnJoinRoom
            // 
            btnJoinRoom.Location = new Point(134, 168);
            btnJoinRoom.Name = "btnJoinRoom";
            btnJoinRoom.Size = new Size(100, 23);
            btnJoinRoom.TabIndex = 8;
            btnJoinRoom.Text = "방 참가";
            btnJoinRoom.UseVisualStyleBackColor = true;
            btnJoinRoom.Click += btnJoinRoom_Click;
            // 
            // tbRoomList
            // 
            tbRoomList.BackColor = SystemColors.HighlightText;
            tbRoomList.Location = new Point(3, 19);
            tbRoomList.Multiline = true;
            tbRoomList.Name = "tbRoomList";
            tbRoomList.ReadOnly = true;
            tbRoomList.Size = new Size(125, 201);
            tbRoomList.TabIndex = 7;
            // 
            // btnRoomCreate
            // 
            btnRoomCreate.Location = new Point(134, 139);
            btnRoomCreate.Name = "btnRoomCreate";
            btnRoomCreate.Size = new Size(100, 23);
            btnRoomCreate.TabIndex = 6;
            btnRoomCreate.Text = "방 생성";
            btnRoomCreate.UseVisualStyleBackColor = true;
            btnRoomCreate.Click += btnRoomCreate_Click;
            // 
            // tbRoomCount
            // 
            tbRoomCount.Location = new Point(134, 110);
            tbRoomCount.Name = "tbRoomCount";
            tbRoomCount.Size = new Size(100, 23);
            tbRoomCount.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(134, 92);
            label7.Name = "label7";
            label7.Size = new Size(47, 15);
            label7.TabIndex = 4;
            label7.Text = "방 정원";
            // 
            // tbRoomName
            // 
            tbRoomName.Location = new Point(134, 66);
            tbRoomName.Name = "tbRoomName";
            tbRoomName.Size = new Size(100, 23);
            tbRoomName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(136, 48);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 2;
            label6.Text = "방 이름";
            // 
            // btnRefreshRoomList
            // 
            btnRefreshRoomList.Location = new Point(136, 22);
            btnRefreshRoomList.Name = "btnRefreshRoomList";
            btnRefreshRoomList.Size = new Size(98, 23);
            btnRefreshRoomList.TabIndex = 1;
            btnRefreshRoomList.Text = "새로고침";
            btnRefreshRoomList.UseVisualStyleBackColor = true;
            btnRefreshRoomList.Click += btnRefreshRoomList_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnSend);
            groupBox2.Controls.Add(tbMessage);
            groupBox2.Controls.Add(tbRoomChat);
            groupBox2.Location = new Point(274, 138);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(287, 226);
            groupBox2.TabIndex = 17;
            groupBox2.TabStop = false;
            groupBox2.Text = "방 채팅";
            // 
            // btnSend
            // 
            btnSend.Location = new Point(206, 196);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(75, 23);
            btnSend.TabIndex = 2;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // tbMessage
            // 
            tbMessage.Location = new Point(6, 197);
            tbMessage.Name = "tbMessage";
            tbMessage.Size = new Size(194, 23);
            tbMessage.TabIndex = 1;
            // 
            // tbRoomChat
            // 
            tbRoomChat.BackColor = SystemColors.HighlightText;
            tbRoomChat.Location = new Point(6, 19);
            tbRoomChat.Multiline = true;
            tbRoomChat.Name = "tbRoomChat";
            tbRoomChat.ReadOnly = true;
            tbRoomChat.ScrollBars = ScrollBars.Vertical;
            tbRoomChat.Size = new Size(275, 172);
            tbRoomChat.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(tbUsername);
            groupBox3.Controls.Add(tbPassword);
            groupBox3.Controls.Add(btnSignUp);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(label5);
            groupBox3.Location = new Point(12, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(304, 100);
            groupBox3.TabIndex = 18;
            groupBox3.TabStop = false;
            groupBox3.Text = "로그인";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(btnConnect);
            groupBox4.Controls.Add(btnViewRoomNum);
            groupBox4.Controls.Add(btnChangeRoomNum);
            groupBox4.Controls.Add(tbRoomNum);
            groupBox4.Location = new Point(340, 12);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(223, 100);
            groupBox4.TabIndex = 19;
            groupBox4.TabStop = false;
            groupBox4.Text = "테스트";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(573, 569);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(btnSignIn);
            Controls.Add(label3);
            Controls.Add(groupBox3);
            Controls.Add(groupBox4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnConnect;
        private Button btnViewRoomNum;
        private Label label3;
        private TextBox tbRoomNum;
        private Button btnChangeRoomNum;
        private Label label4;
        private Label label5;
        private TextBox tbUsername;
        private TextBox tbPassword;
        private Button btnSignIn;
        private Button btnSignUp;
        private GroupBox groupBox1;
        private Button btnRoomCreate;
        private TextBox tbRoomCount;
        private Label label7;
        private TextBox tbRoomName;
        private Label label6;
        private Button btnRefreshRoomList;
        private TextBox tbRoomList;
        private Button btnOutRoom;
        private Button btnJoinRoom;
        private GroupBox groupBox2;
        private Button btnSend;
        private TextBox tbMessage;
        private TextBox tbRoomChat;
        private GroupBox groupBox3;
        private GroupBox groupBox4;
    }
}