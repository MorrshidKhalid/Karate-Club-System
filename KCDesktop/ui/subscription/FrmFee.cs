using System;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.subscription
{
    public partial class FrmFee : Form
    {
        public FrmFee() => InitializeComponent();

        private bool CheckValidation() => !Validation.IsMaskedTextBoxEmpty(mTbFee, ErrorProvider);

        private void RefreshFee() => lbFee.Text = ClsFee.CurrentFee().ToString();

        private void FrmFee_Load(object sender, EventArgs e) => RefreshFee();

        private void Confirm()
        {
            DialogResult result =
                MessageBox.Show
                ("Are you sure you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
                if (ClsFee.Update(decimal.Parse(mTbFee.Text)))
                    RefreshFee();
        }

        private void BtnAdjust_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
            {
                MessageBox.Show("Fee must inclouded");
                return;
            }

            Confirm();
            Close();
        }
    }
}