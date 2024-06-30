namespace KCDesktop.ui.subscription
{
    partial class FrmSubscriptionList
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
            this.dpStart = new System.Windows.Forms.DateTimePicker();
            this.dpEnd = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.BtnSearch = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbFind = new System.Windows.Forms.TextBox();
            this.BtnFind = new System.Windows.Forms.Button();
            this.CbMethod = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ChbAll = new System.Windows.Forms.CheckBox();
            this.dgvSubscriptionList = new System.Windows.Forms.DataGridView();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptionList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // dpStart
            // 
            this.dpStart.Location = new System.Drawing.Point(12, 77);
            this.dpStart.Name = "dpStart";
            this.dpStart.Size = new System.Drawing.Size(200, 20);
            this.dpStart.TabIndex = 0;
            // 
            // dpEnd
            // 
            this.dpEnd.Location = new System.Drawing.Point(12, 123);
            this.dpEnd.Name = "dpEnd";
            this.dpEnd.Size = new System.Drawing.Size(200, 20);
            this.dpEnd.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "End Date";
            // 
            // BtnSearch
            // 
            this.BtnSearch.Location = new System.Drawing.Point(245, 114);
            this.BtnSearch.Name = "BtnSearch";
            this.BtnSearch.Size = new System.Drawing.Size(166, 37);
            this.BtnSearch.TabIndex = 4;
            this.BtnSearch.Text = "Search";
            this.BtnSearch.UseVisualStyleBackColor = true;
            this.BtnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label9
            // 
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label9.Location = new System.Drawing.Point(0, 193);
            this.label9.MaximumSize = new System.Drawing.Size(1000, 2);
            this.label9.MinimumSize = new System.Drawing.Size(20, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(800, 2);
            this.label9.TabIndex = 52;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(451, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 18);
            this.label3.TabIndex = 53;
            this.label3.Text = "Find By ID";
            // 
            // tbFind
            // 
            this.tbFind.Location = new System.Drawing.Point(451, 131);
            this.tbFind.Name = "tbFind";
            this.tbFind.Size = new System.Drawing.Size(105, 20);
            this.tbFind.TabIndex = 54;
            // 
            // BtnFind
            // 
            this.BtnFind.Location = new System.Drawing.Point(572, 110);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.Size = new System.Drawing.Size(85, 41);
            this.BtnFind.TabIndex = 55;
            this.BtnFind.Text = "Find";
            this.BtnFind.UseVisualStyleBackColor = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // CbMethod
            // 
            this.CbMethod.FormattingEnabled = true;
            this.CbMethod.Location = new System.Drawing.Point(245, 77);
            this.CbMethod.Name = "CbMethod";
            this.CbMethod.Size = new System.Drawing.Size(166, 21);
            this.CbMethod.TabIndex = 57;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(242, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 18);
            this.label4.TabIndex = 58;
            this.label4.Text = "Payment Method";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(240, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(249, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "SUBSCRIPTIONS LIST";
            // 
            // ChbAll
            // 
            this.ChbAll.AutoSize = true;
            this.ChbAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChbAll.Location = new System.Drawing.Point(697, 12);
            this.ChbAll.Name = "ChbAll";
            this.ChbAll.Size = new System.Drawing.Size(91, 24);
            this.ChbAll.TabIndex = 62;
            this.ChbAll.Text = "All Times";
            this.ChbAll.UseVisualStyleBackColor = true;
            this.ChbAll.CheckedChanged += new System.EventHandler(this.ChbAll_CheckedChanged);
            // 
            // dgvSubscriptionList
            // 
            this.dgvSubscriptionList.AllowUserToAddRows = false;
            this.dgvSubscriptionList.AllowUserToDeleteRows = false;
            this.dgvSubscriptionList.AllowUserToOrderColumns = true;
            this.dgvSubscriptionList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubscriptionList.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvSubscriptionList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSubscriptionList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubscriptionList.Location = new System.Drawing.Point(12, 220);
            this.dgvSubscriptionList.Name = "dgvSubscriptionList";
            this.dgvSubscriptionList.ReadOnly = true;
            this.dgvSubscriptionList.Size = new System.Drawing.Size(776, 376);
            this.dgvSubscriptionList.TabIndex = 63;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // FrmSubscriptionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 608);
            this.Controls.Add(this.dgvSubscriptionList);
            this.Controls.Add(this.ChbAll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.CbMethod);
            this.Controls.Add(this.BtnFind);
            this.Controls.Add(this.tbFind);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.BtnSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dpEnd);
            this.Controls.Add(this.dpStart);
            this.Name = "FrmSubscriptionList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SUBSCRIPTIONS LIST";
            this.Load += new System.EventHandler(this.FrmSubscriptionList_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubscriptionList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dpStart;
        private System.Windows.Forms.DateTimePicker dpEnd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnSearch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbFind;
        private System.Windows.Forms.Button BtnFind;
        private System.Windows.Forms.ComboBox CbMethod;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox ChbAll;
        private System.Windows.Forms.DataGridView dgvSubscriptionList;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
    }
}