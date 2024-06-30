namespace KCDesktop.ui.members
{
    partial class FrmPaymentHIstory
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
            this.CbMember = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnFind = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.tbMemberID = new System.Windows.Forms.TextBox();
            this.dgvHistory = new System.Windows.Forms.DataGridView();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // CbMember
            // 
            this.CbMember.FormattingEnabled = true;
            this.CbMember.Location = new System.Drawing.Point(16, 38);
            this.CbMember.Name = "CbMember";
            this.CbMember.Size = new System.Drawing.Size(175, 21);
            this.CbMember.TabIndex = 69;
            this.CbMember.SelectedIndexChanged += new System.EventHandler(this.CbMember_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 21);
            this.label2.TabIndex = 68;
            this.label2.Text = "Member";
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(511, 35);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(69, 27);
            this.BtnFind.TabIndex = 79;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(242, 38);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(145, 20);
            this.label10.TabIndex = 78;
            this.label10.Text = "Find Member By ID";
            // 
            // tbMemberID
            // 
            this.tbMemberID.Location = new System.Drawing.Point(393, 38);
            this.tbMemberID.Name = "tbMemberID";
            this.tbMemberID.Size = new System.Drawing.Size(97, 20);
            this.tbMemberID.TabIndex = 77;
            // 
            // dgvHistory
            // 
            this.dgvHistory.AllowUserToAddRows = false;
            this.dgvHistory.AllowUserToDeleteRows = false;
            this.dgvHistory.AllowUserToOrderColumns = true;
            this.dgvHistory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHistory.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvHistory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHistory.Location = new System.Drawing.Point(16, 67);
            this.dgvHistory.Name = "dgvHistory";
            this.dgvHistory.ReadOnly = true;
            this.dgvHistory.Size = new System.Drawing.Size(882, 493);
            this.dgvHistory.TabIndex = 80;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmPaymentHIstory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 572);
            this.Controls.Add(this.dgvHistory);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbMemberID);
            this.Controls.Add(this.CbMember);
            this.Controls.Add(this.label2);
            this.Name = "FrmPaymentHIstory";
            this.Text = "MEMBER PAYMENTS HISTORY";
            this.Load += new System.EventHandler(this.FrmPaymentHIstory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox CbMember;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbMemberID;
        private System.Windows.Forms.DataGridView dgvHistory;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}