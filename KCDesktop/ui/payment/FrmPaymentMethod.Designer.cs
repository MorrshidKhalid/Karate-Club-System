namespace KCDesktop.ui.payment
{
    partial class FrmPaymentMethod
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
            this.dgvMethodList = new System.Windows.Forms.DataGridView();
            this.contextOptions = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ContxUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.ContxDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.lbTitle = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbMethodName = new System.Windows.Forms.TextBox();
            this.BtnSave = new System.Windows.Forms.Button();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodList)).BeginInit();
            this.contextOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMethodList
            // 
            this.dgvMethodList.AllowUserToAddRows = false;
            this.dgvMethodList.AllowUserToDeleteRows = false;
            this.dgvMethodList.AllowUserToOrderColumns = true;
            this.dgvMethodList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMethodList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMethodList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMethodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMethodList.ContextMenuStrip = this.contextOptions;
            this.dgvMethodList.Location = new System.Drawing.Point(337, 55);
            this.dgvMethodList.Name = "dgvMethodList";
            this.dgvMethodList.ReadOnly = true;
            this.dgvMethodList.Size = new System.Drawing.Size(451, 383);
            this.dgvMethodList.TabIndex = 0;
            // 
            // contextOptions
            // 
            this.contextOptions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ContxUpdate,
            this.ContxDelete});
            this.contextOptions.Name = "contextOptions";
            this.contextOptions.Size = new System.Drawing.Size(113, 48);
            // 
            // ContxUpdate
            // 
            this.ContxUpdate.Name = "ContxUpdate";
            this.ContxUpdate.Size = new System.Drawing.Size(112, 22);
            this.ContxUpdate.Text = "Update";
            this.ContxUpdate.Click += new System.EventHandler(this.ContxUpdate_Click);
            // 
            // ContxDelete
            // 
            this.ContxDelete.Name = "ContxDelete";
            this.ContxDelete.Size = new System.Drawing.Size(112, 22);
            this.ContxDelete.Text = "Delete";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(12, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(163, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "ADD METHOD";
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(12, 50);
            this.label9.MaximumSize = new System.Drawing.Size(1000, 2);
            this.label9.MinimumSize = new System.Drawing.Size(20, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(776, 2);
            this.label9.TabIndex = 64;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 16);
            this.label4.TabIndex = 66;
            this.label4.Text = "Method Name";
            // 
            // tbMethodName
            // 
            this.tbMethodName.Location = new System.Drawing.Point(108, 67);
            this.tbMethodName.Name = "tbMethodName";
            this.tbMethodName.Size = new System.Drawing.Size(126, 20);
            this.tbMethodName.TabIndex = 65;
            // 
            // BtnSave
            // 
            this.BtnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSave.Location = new System.Drawing.Point(108, 106);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(126, 39);
            this.BtnSave.TabIndex = 67;
            this.BtnSave.Text = "Save";
            this.BtnSave.UseVisualStyleBackColor = true;
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmPaymentMethod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnSave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbMethodName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.dgvMethodList);
            this.Name = "FrmPaymentMethod";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPaymentMethod";
            this.Load += new System.EventHandler(this.FrmPaymentMethod_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMethodList)).EndInit();
            this.contextOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMethodList;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbMethodName;
        private System.Windows.Forms.Button BtnSave;
        private System.Windows.Forms.ContextMenuStrip contextOptions;
        private System.Windows.Forms.ToolStripMenuItem ContxUpdate;
        private System.Windows.Forms.ToolStripMenuItem ContxDelete;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}