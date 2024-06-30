namespace KCDesktop.ui.members
{
    partial class FrmManegeMembers
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
            this.CntxDeletePhone = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvPhone = new System.Windows.Forms.DataGridView();
            this.CntxDelete = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CntxDeleteMember = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.CntxOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.BtnSave = new System.Windows.Forms.Button();
            this.BtnPhone = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbMidName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.lbTitle = new System.Windows.Forms.Label();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhone)).BeginInit();
            this.CntxDelete.SuspendLayout();
            this.CntxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CntxDeletePhone
            // 
            this.CntxDeletePhone.Name = "CntxDeletePhone";
            this.CntxDeletePhone.Size = new System.Drawing.Size(107, 22);
            this.CntxDeletePhone.Text = "Delete";
            this.CntxDeletePhone.Click += new System.EventHandler(this.CntxDeletePhone_Click);
            // 
            // dgvPhone
            // 
            this.dgvPhone.AllowUserToAddRows = false;
            this.dgvPhone.AllowUserToDeleteRows = false;
            this.dgvPhone.AllowUserToOrderColumns = true;
            this.dgvPhone.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPhone.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvPhone.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPhone.ContextMenuStrip = this.CntxDelete;
            this.dgvPhone.Location = new System.Drawing.Point(228, 82);
            this.dgvPhone.Name = "dgvPhone";
            this.dgvPhone.ReadOnly = true;
            this.dgvPhone.Size = new System.Drawing.Size(248, 209);
            this.dgvPhone.TabIndex = 83;
            // 
            // CntxDelete
            // 
            this.CntxDelete.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxDeletePhone});
            this.CntxDelete.Name = "CntxDelete";
            this.CntxDelete.Size = new System.Drawing.Size(108, 26);
            // 
            // CntxDeleteMember
            // 
            this.CntxDeleteMember.Name = "CntxDeleteMember";
            this.CntxDeleteMember.Size = new System.Drawing.Size(112, 22);
            this.CntxDeleteMember.Text = "Delete";
            this.CntxDeleteMember.Click += new System.EventHandler(this.CntxDeleteMember_Click);
            // 
            // CntxUpdate
            // 
            this.CntxUpdate.Name = "CntxUpdate";
            this.CntxUpdate.Size = new System.Drawing.Size(112, 22);
            this.CntxUpdate.Text = "Update";
            this.CntxUpdate.Click += new System.EventHandler(this.CntxUpdate_Click);
            // 
            // CntxOptions
            // 
            this.CntxOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CntxUpdate,
            this.CntxDeleteMember});
            this.CntxOptions.Name = "CntxOptions";
            this.CntxOptions.Size = new System.Drawing.Size(113, 48);
            // 
            // dgvMembers
            // 
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AllowUserToOrderColumns = true;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMembers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.ContextMenuStrip = this.CntxOptions;
            this.dgvMembers.Location = new System.Drawing.Point(482, 80);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.Size = new System.Drawing.Size(584, 363);
            this.dgvMembers.TabIndex = 82;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(940, 12);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 39);
            this.BtnSave.TabIndex = 81;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // BtnPhone
            // 
            this.BtnPhone.Location = new System.Drawing.Point(20, 197);
            this.BtnPhone.Name = "BtnPhone";
            this.BtnPhone.Size = new System.Drawing.Size(142, 25);
            this.BtnPhone.TabIndex = 80;
            this.BtnPhone.Text = "Add Contact Info";
            this.BtnPhone.UseVisualStyleBackColor = true;
            this.BtnPhone.Click += new System.EventHandler(this.BtnPhone_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(3, 57);
            this.label9.MinimumSize = new System.Drawing.Size(20, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(1077, 10);
            this.label9.TabIndex = 79;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(21, 160);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(58, 16);
            this.label11.TabIndex = 78;
            this.label11.Text = "Address";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(96, 160);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(126, 20);
            this.tbAddress.TabIndex = 77;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Last name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(96, 134);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(126, 20);
            this.tbLastName.TabIndex = 75;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Mid name";
            // 
            // tbMidName
            // 
            this.tbMidName.Location = new System.Drawing.Point(96, 108);
            this.tbMidName.Name = "tbMidName";
            this.tbMidName.Size = new System.Drawing.Size(126, 20);
            this.tbMidName.TabIndex = 73;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 16);
            this.label4.TabIndex = 72;
            this.label4.Text = "First name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(96, 82);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(126, 20);
            this.tbFirstName.TabIndex = 71;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(15, 19);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(165, 25);
            this.lbTitle.TabIndex = 70;
            this.lbTitle.Text = "ADD MEMBER";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmManegeMembers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 520);
            this.Controls.Add(this.dgvPhone);
            this.Controls.Add(this.dgvMembers);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.BtnPhone);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbMidName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.lbTitle);
            this.Name = "FrmManegeMembers";
            this.Text = "FrmManegeMembers";
            this.Load += new System.EventHandler(this.FrmManegeMembers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPhone)).EndInit();
            this.CntxDelete.ResumeLayout(false);
            this.CntxOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem CntxDeletePhone;
        private System.Windows.Forms.DataGridView dgvPhone;
        private System.Windows.Forms.ContextMenuStrip CntxDelete;
        private System.Windows.Forms.ToolStripMenuItem CntxDeleteMember;
        private System.Windows.Forms.ToolStripMenuItem CntxUpdate;
        private System.Windows.Forms.ContextMenuStrip CntxOptions;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.Button BtnPhone;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbMidName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}