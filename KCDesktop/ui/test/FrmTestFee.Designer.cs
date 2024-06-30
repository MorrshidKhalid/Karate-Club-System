namespace KCDesktop.ui.test
{
    partial class FrmTestFee
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
            this.mTbFee = new System.Windows.Forms.MaskedTextBox();
            this.lbFee = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnAdjust = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.CbBeltRank = new System.Windows.Forms.ComboBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // mTbFee
            // 
            this.mTbFee.Location = new System.Drawing.Point(17, 94);
            this.mTbFee.Mask = "000";
            this.mTbFee.Name = "mTbFee";
            this.mTbFee.Size = new System.Drawing.Size(50, 20);
            this.mTbFee.TabIndex = 62;
            this.mTbFee.ValidatingType = typeof(int);
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFee.Location = new System.Drawing.Point(440, 18);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(36, 20);
            this.lbFee.TabIndex = 61;
            this.lbFee.Text = "???";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Current Test Fee:";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 45);
            this.label9.MaximumSize = new System.Drawing.Size(1000, 2);
            this.label9.MinimumSize = new System.Drawing.Size(20, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(497, 2);
            this.label9.TabIndex = 59;
            // 
            // BtnAdjust
            // 
            this.BtnAdjust.Location = new System.Drawing.Point(331, 77);
            this.BtnAdjust.Name = "BtnAdjust";
            this.BtnAdjust.Size = new System.Drawing.Size(145, 37);
            this.BtnAdjust.TabIndex = 58;
            this.BtnAdjust.Text = "ADJUST";
            this.BtnAdjust.UseVisualStyleBackColor = true;
            this.BtnAdjust.Click += new System.EventHandler(this.BtnAdjust_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Test Coust";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 56;
            this.label1.Text = "Adjust The Test Fee ";
            // 
            // CbBeltRank
            // 
            this.CbBeltRank.FormattingEnabled = true;
            this.CbBeltRank.Location = new System.Drawing.Point(118, 56);
            this.CbBeltRank.Name = "CbBeltRank";
            this.CbBeltRank.Size = new System.Drawing.Size(154, 21);
            this.CbBeltRank.TabIndex = 63;
            this.CbBeltRank.SelectedIndexChanged += new System.EventHandler(this.CbBeltRank_SelectedIndexChanged);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmTestFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 131);
            this.Controls.Add(this.CbBeltRank);
            this.Controls.Add(this.mTbFee);
            this.Controls.Add(this.lbFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnAdjust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmTestFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADJUST THE TEST FEE";
            this.Load += new System.EventHandler(this.FrmTestFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MaskedTextBox mTbFee;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnAdjust;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CbBeltRank;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}