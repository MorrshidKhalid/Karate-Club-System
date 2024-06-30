using System;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.test
{
    public partial class FrmTestFee : Form
    {
        private ClsBeltRank beltRank;
        public FrmTestFee() => InitializeComponent();

        private bool CheckValidation() => Validation.HasNotSelected(CbBeltRank, e: ErrorProvider);

        /******************** Refresh ********************/
        private void RefreshBeltRankComboBox() => Lib.LoadDataToComboBox(ClsBeltRank.GetAllRanks(), ref CbBeltRank, "RankName");


        /******************** Load Date ********************/
        private void LoadBeltRankData()
        {
            beltRank = ClsBeltRank.Find(Lib.SelectedItem(CbBeltRank));

            if (beltRank.IsExists())
                lbFee.Text = beltRank.TestFee.ToString();
            else
                lbFee.Text = "???";
        }
        private void CbBeltRank_SelectedIndexChanged(object sender, EventArgs e) => LoadBeltRankData();
        private void FrmTestFee_Load(object sender, EventArgs e) => RefreshBeltRankComboBox();


        /******************** Save ********************/
        private void Confirm()
        {
            DialogResult result =
                MessageBox.Show
                ("Are you sure you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
                if (ClsBeltRank.UpdateFee(beltRank.RankID, decimal.Parse(mTbFee.Text)))
                    lbFee.Text = mTbFee.Text.ToString();
        }
        private void BtnAdjust_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            if (!mTbFee.MaskCompleted)
            {
                MessageBox.Show("Paid Must be inclouded and in the form of 000");
                return;
            }

            Confirm();
        }
            
             
    }
}
