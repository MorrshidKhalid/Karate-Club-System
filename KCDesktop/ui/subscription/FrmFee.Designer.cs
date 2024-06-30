namespace KCDesktop.ui.subscription
{
    partial class FrmFee
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnAdjust = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbFee = new System.Windows.Forms.Label();
            this.mTbFee = new System.Windows.Forms.MaskedTextBox();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(208, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Adjust The Fee Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Coust Per Day:";
            // 
            // BtnAdjust
            // 
            this.BtnAdjust.Location = new System.Drawing.Point(315, 74);
            this.BtnAdjust.Name = "BtnAdjust";
            this.BtnAdjust.Size = new System.Drawing.Size(145, 37);
            this.BtnAdjust.TabIndex = 3;
            this.BtnAdjust.Text = "ADJUST";
            this.BtnAdjust.UseVisualStyleBackColor = true;
            this.BtnAdjust.Click += new System.EventHandler(this.BtnAdjust_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 42);
            this.label9.MaximumSize = new System.Drawing.Size(1000, 2);
            this.label9.MinimumSize = new System.Drawing.Size(20, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(497, 2);
            this.label9.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(273, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(165, 20);
            this.label3.TabIndex = 53;
            this.label3.Text = "Current Price Per Day:";
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbFee.Location = new System.Drawing.Point(440, 15);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(36, 20);
            this.lbFee.TabIndex = 54;
            this.lbFee.Text = "???";
            // 
            // mTbFee
            // 
            this.mTbFee.Location = new System.Drawing.Point(133, 84);
            this.mTbFee.Mask = "0000.00";
            this.mTbFee.Name = "mTbFee";
            this.mTbFee.Size = new System.Drawing.Size(50, 20);
            this.mTbFee.TabIndex = 55;
            this.mTbFee.ValidatingType = typeof(int);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmFee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 131);
            this.Controls.Add(this.mTbFee);
            this.Controls.Add(this.lbFee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnAdjust);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(537, 170);
            this.MinimumSize = new System.Drawing.Size(537, 170);
            this.Name = "FrmFee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ADJUST THE PRICE";
            this.Load += new System.EventHandler(this.FrmFee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnAdjust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.MaskedTextBox mTbFee;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}