namespace KCDesktop
{
    partial class FrmHome
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
            this.components = new System.ComponentModel.Container();
            this.HomeMenu = new System.Windows.Forms.MenuStrip();
            this.clubToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuInstractors = new System.Windows.Forms.ToolStripMenuItem();
            this.membersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuManageMembers = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTakeTest = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuPaymentHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.subscriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SubscriptionMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuFee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuTestFee = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMethod = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feedbackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contactDeveloperToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnSave = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tbAmountPaid = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMethod = new System.Windows.Forms.ComboBox();
            this.lbFee = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DpEnd = new System.Windows.Forms.DateTimePicker();
            this.DpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMidName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.CbMember = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.tbNote = new System.Windows.Forms.TextBox();
            this.RbNew = new System.Windows.Forms.RadioButton();
            this.RbExists = new System.Windows.Forms.RadioButton();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.HomeMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // HomeMenu
            // 
            this.HomeMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clubToolStripMenuItem,
            this.MenuSettings,
            this.reportsToolStripMenuItem});
            this.HomeMenu.Location = new System.Drawing.Point(0, 0);
            this.HomeMenu.Name = "HomeMenu";
            this.HomeMenu.Size = new System.Drawing.Size(800, 24);
            this.HomeMenu.TabIndex = 4;
            this.HomeMenu.Text = "menuStrip1";
            // 
            // clubToolStripMenuItem
            // 
            this.clubToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuInstractors,
            this.membersToolStripMenuItem});
            this.clubToolStripMenuItem.Name = "clubToolStripMenuItem";
            this.clubToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.clubToolStripMenuItem.Text = "Club";
            // 
            // MenuInstractors
            // 
            this.MenuInstractors.Name = "MenuInstractors";
            this.MenuInstractors.Size = new System.Drawing.Size(129, 22);
            this.MenuInstractors.Text = "Instractors";
            this.MenuInstractors.Click += new System.EventHandler(this.MenuInstractors_Click);
            // 
            // membersToolStripMenuItem
            // 
            this.membersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuManageMembers,
            this.MenuTakeTest,
            this.MenuPaymentHistory});
            this.membersToolStripMenuItem.Name = "membersToolStripMenuItem";
            this.membersToolStripMenuItem.Size = new System.Drawing.Size(129, 22);
            this.membersToolStripMenuItem.Text = "Members";
            // 
            // MenuManageMembers
            // 
            this.MenuManageMembers.Name = "MenuManageMembers";
            this.MenuManageMembers.Size = new System.Drawing.Size(231, 22);
            this.MenuManageMembers.Text = "Manage Members";
            this.MenuManageMembers.Click += new System.EventHandler(this.MenuManageMembers_Click);
            // 
            // MenuTakeTest
            // 
            this.MenuTakeTest.Name = "MenuTakeTest";
            this.MenuTakeTest.Size = new System.Drawing.Size(231, 22);
            this.MenuTakeTest.Text = "Take Test";
            this.MenuTakeTest.Click += new System.EventHandler(this.MenuTakeTest_Click);
            // 
            // MenuPaymentHistory
            // 
            this.MenuPaymentHistory.Name = "MenuPaymentHistory";
            this.MenuPaymentHistory.Size = new System.Drawing.Size(231, 22);
            this.MenuPaymentHistory.Text = "Subscription Payment History";
            this.MenuPaymentHistory.Click += new System.EventHandler(this.MenuPaymentHistory_Click);
            // 
            // MenuSettings
            // 
            this.MenuSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subscriptionToolStripMenuItem,
            this.MenuTestFee,
            this.MenuMethod,
            this.toolStripMenuItem1,
            this.aboutToolStripMenuItem});
            this.MenuSettings.Name = "MenuSettings";
            this.MenuSettings.Size = new System.Drawing.Size(61, 20);
            this.MenuSettings.Text = "Settings";
            // 
            // subscriptionToolStripMenuItem
            // 
            this.subscriptionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SubscriptionMenu,
            this.MenuFee});
            this.subscriptionToolStripMenuItem.Name = "subscriptionToolStripMenuItem";
            this.subscriptionToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.subscriptionToolStripMenuItem.Text = "Subscription";
            // 
            // SubscriptionMenu
            // 
            this.SubscriptionMenu.Name = "SubscriptionMenu";
            this.SubscriptionMenu.Size = new System.Drawing.Size(166, 22);
            this.SubscriptionMenu.Text = "Subscriptions List";
            this.SubscriptionMenu.Click += new System.EventHandler(this.SubscriptionMenu_Click);
            // 
            // MenuFee
            // 
            this.MenuFee.Name = "MenuFee";
            this.MenuFee.Size = new System.Drawing.Size(166, 22);
            this.MenuFee.Text = "Subscription Fee";
            this.MenuFee.Click += new System.EventHandler(this.MenuFee_Click);
            // 
            // MenuTestFee
            // 
            this.MenuTestFee.Name = "MenuTestFee";
            this.MenuTestFee.Size = new System.Drawing.Size(166, 22);
            this.MenuTestFee.Text = "Test Fee";
            this.MenuTestFee.Click += new System.EventHandler(this.MenuTestFee_Click);
            // 
            // MenuMethod
            // 
            this.MenuMethod.Name = "MenuMethod";
            this.MenuMethod.Size = new System.Drawing.Size(166, 22);
            this.MenuMethod.Text = "Payment Method";
            this.MenuMethod.Click += new System.EventHandler(this.MenuMethod_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(163, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feedbackToolStripMenuItem,
            this.contactDeveloperToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(166, 22);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // feedbackToolStripMenuItem
            // 
            this.feedbackToolStripMenuItem.Name = "feedbackToolStripMenuItem";
            this.feedbackToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.feedbackToolStripMenuItem.Text = "Feedback";
            // 
            // contactDeveloperToolStripMenuItem
            // 
            this.contactDeveloperToolStripMenuItem.Name = "contactDeveloperToolStripMenuItem";
            this.contactDeveloperToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.contactDeveloperToolStripMenuItem.Text = "Developer Contact ";
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // BtnSave
            // 
            this.BtnSave.Location = new System.Drawing.Point(671, 294);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(117, 35);
            this.BtnSave.TabIndex = 50;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(480, 190);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 49;
            this.label8.Text = "Amount*";
            // 
            // tbAmountPaid
            // 
            this.tbAmountPaid.Location = new System.Drawing.Point(481, 206);
            this.tbAmountPaid.Name = "tbAmountPaid";
            this.tbAmountPaid.Size = new System.Drawing.Size(97, 20);
            this.tbAmountPaid.TabIndex = 48;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(252, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 47;
            this.label7.Text = "Payment Method*";
            // 
            // cbMethod
            // 
            this.cbMethod.FormattingEnabled = true;
            this.cbMethod.Location = new System.Drawing.Point(251, 206);
            this.cbMethod.Name = "cbMethod";
            this.cbMethod.Size = new System.Drawing.Size(200, 21);
            this.cbMethod.TabIndex = 46;
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFee.Location = new System.Drawing.Point(661, 46);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(0, 21);
            this.lbFee.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(602, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 24);
            this.label6.TabIndex = 44;
            this.label6.Text = "Fee:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(479, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "End Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(248, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Start Date";
            // 
            // DpEnd
            // 
            this.DpEnd.Location = new System.Drawing.Point(481, 155);
            this.DpEnd.Name = "DpEnd";
            this.DpEnd.Size = new System.Drawing.Size(200, 20);
            this.DpEnd.TabIndex = 41;
            this.DpEnd.ValueChanged += new System.EventHandler(this.DpEnd_ValueChanged);
            // 
            // DpStart
            // 
            this.DpStart.Location = new System.Drawing.Point(251, 155);
            this.DpStart.Name = "DpStart";
            this.DpStart.Size = new System.Drawing.Size(200, 20);
            this.DpStart.TabIndex = 40;
            this.DpStart.ValueChanged += new System.EventHandler(this.DpStart_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 39;
            this.label3.Text = "Last name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(71, 188);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(126, 20);
            this.tbLastName.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Mid name";
            // 
            // tbMidName
            // 
            this.tbMidName.Location = new System.Drawing.Point(71, 162);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.Size = new System.Drawing.Size(126, 20);
            this.tbMidName.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 136);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 35;
            this.label1.Text = "First name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(71, 136);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(126, 20);
            this.tbFirstName.TabIndex = 34;
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(0, 71);
            this.label9.MaximumSize = new System.Drawing.Size(1000, 2);
            this.label9.MinimumSize = new System.Drawing.Size(20, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(800, 2);
            this.label9.TabIndex = 51;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(10, 214);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 13);
            this.label11.TabIndex = 54;
            this.label11.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(71, 214);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(126, 20);
            this.tbAddress.TabIndex = 53;
            // 
            // CbMember
            // 
            this.CbMember.FormattingEnabled = true;
            this.CbMember.Location = new System.Drawing.Point(96, 93);
            this.CbMember.Name = "CbMember";
            this.CbMember.Size = new System.Drawing.Size(200, 21);
            this.CbMember.TabIndex = 55;
            this.CbMember.SelectedIndexChanged += new System.EventHandler(this.CbMember_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(318, 97);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 13);
            this.label10.TabIndex = 57;
            this.label10.Text = "Find By ID";
            // 
            // tbMemberID
            // 
            this.tbMemberID.Location = new System.Drawing.Point(380, 93);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(97, 20);
            this.tbMemberID.TabIndex = 56;
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(483, 90);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(69, 27);
            this.BtnFind.TabIndex = 58;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(78, 13);
            this.label12.TabIndex = 59;
            this.label12.Text = "Select Member";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(10, 262);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 61;
            this.label13.Text = "Note";
            // 
            // tbNote
            // 
            this.tbNote.Location = new System.Drawing.Point(71, 262);
            this.tbNote.MaxLength = 200;
            this.tbNote.Multiline = true;
            this.tbNote.Name = "tbNote";
            this.tbNote.Size = new System.Drawing.Size(272, 67);
            this.tbNote.TabIndex = 60;
            // 
            // RbNew
            // 
            this.RbNew.AutoSize = true;
            this.RbNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbNew.Location = new System.Drawing.Point(15, 43);
            this.RbNew.Name = "RbNew";
            this.RbNew.Size = new System.Drawing.Size(120, 24);
            this.RbNew.TabIndex = 62;
            this.RbNew.TabStop = true;
            this.RbNew.Text = "New Member";
            this.RbNew.UseVisualStyleBackColor = true;
            this.RbNew.CheckedChanged += new System.EventHandler(this.RbNew_CheckedChanged);
            // 
            // RbExists
            // 
            this.RbExists.AutoSize = true;
            this.RbExists.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RbExists.Location = new System.Drawing.Point(165, 43);
            this.RbExists.Name = "RbExists";
            this.RbExists.Size = new System.Drawing.Size(131, 24);
            this.RbExists.TabIndex = 63;
            this.RbExists.TabStop = true;
            this.RbExists.Text = "Exists Member";
            this.RbExists.UseVisualStyleBackColor = true;
            this.RbExists.CheckedChanged += new System.EventHandler(this.RbExists_CheckedChanged);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 341);
            this.Controls.Add(this.RbExists);
            this.Controls.Add(this.RbNew);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.tbNote);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMemberID);
            this.Controls.Add(this.CbMember);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbAmountPaid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbMethod);
            this.Controls.Add(this.lbFee);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DpEnd);
            this.Controls.Add(this.DpStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMidName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.HomeMenu);
            this.MainMenuStrip = this.HomeMenu;
            this.MinimumSize = new System.Drawing.Size(816, 380);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            this.HomeMenu.ResumeLayout(false);
            this.HomeMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip HomeMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuSettings;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbAmountPaid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMethod;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker DpEnd;
        private System.Windows.Forms.DateTimePicker DpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMidName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.ComboBox CbMember;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox tbNote;
        private System.Windows.Forms.RadioButton RbNew;
        private System.Windows.Forms.RadioButton RbExists;
        private System.Windows.Forms.ToolStripMenuItem subscriptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SubscriptionMenu;
        private System.Windows.Forms.ToolStripMenuItem MenuFee;
        private System.Windows.Forms.ToolStripMenuItem MenuMethod;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feedbackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contactDeveloperToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clubToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuInstractors;
        private System.Windows.Forms.ToolStripMenuItem membersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuManageMembers;
        private System.Windows.Forms.ToolStripMenuItem MenuTakeTest;
        private System.Windows.Forms.ToolStripMenuItem MenuPaymentHistory;
        private System.Windows.Forms.ToolStripMenuItem MenuTestFee;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}

