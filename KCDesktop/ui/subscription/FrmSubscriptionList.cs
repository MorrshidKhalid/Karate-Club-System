using System;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.subscription
{
    public partial class FrmSubscriptionList : Form
    {
        private enum EnValidation { Find, Info}
        public FrmSubscriptionList() => InitializeComponent();

        private bool CheckValidation(EnValidation v)
        {
            if (v == EnValidation.Find)
                return Validation.IsTextBoxEmpty(tbFind, e: ErrorProvider);
            else
                return Validation.HasNotSelected(CbMethod, ErrorProvider);
        }



        private string SelectedItem(ComboBox cb) => (string)cb.SelectedItem;
        private void EnabelControls(bool enable)
        {
            dpStart.Enabled = enable;
            dpEnd.Enabled = enable;
            BtnFind.Enabled = enable;
            tbFind.Enabled = enable;
            CbMethod.Enabled = enable;
            BtnSearch.Enabled = enable;
        }
        /******************** Refresh ********************/
        private void RefreshMethodComboBox() => Lib.LoadDataToComboBox(ClsMethod.AllMethods(), ref CbMethod, "MethodName");
        private void RefreshSubscription()
        {
            if (ChbAll.Checked)
            {
                dgvSubscriptionList.DataSource = ClsSubscription.GetSubscription();
                return;
            }
            else
                dgvSubscriptionList.DataSource = ClsSubscription.GetSubscription(dpStart.Value.Date, dpEnd.Value.Date, SelectedItem(CbMethod));
        }
        private void FindSubscription() => dgvSubscriptionList.DataSource = ClsSubscription.Find(int.Parse(tbFind.Text));


        private void FrmSubscriptionList_Load(object sender, EventArgs e) => RefreshMethodComboBox();

        
        /******************** Events ********************/
        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (CheckValidation(EnValidation.Info))
                return;


            RefreshSubscription();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (CheckValidation(EnValidation.Find))
                return;

            FindSubscription();
        }
            
            

        private void ChbAll_CheckedChanged(object sender, EventArgs e)
        {
            if (ChbAll.Checked)
            {
                EnabelControls(false);
                RefreshSubscription();
            }
            else
            {
                EnabelControls(true);
                RefreshSubscription();
            }
        }
    }
}
