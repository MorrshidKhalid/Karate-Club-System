using System;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.members
{
    public partial class FrmPaymentHIstory : Form
    {
        private ClsMember member;

        public FrmPaymentHIstory() => InitializeComponent();


        private bool CheckValidation() => Validation.IsTextBoxEmpty(tbMemberID, e: ErrorProvider);

        /******************** Refresh ********************/
        private void RefreshMemberComboBox() => Lib.LoadDataToComboBox(ClsMember.AllMembers(), ref CbMember, "Name");


        /******************** Load Data ********************/
        private void FrmPaymentHIstory_Load(object sender, EventArgs e) => RefreshMemberComboBox();

        private void LoadHistory() => dgvHistory.DataSource = ClsMember.GetHistory(int.Parse(tbMemberID.Text));


        /******************** Find Objects ********************/
        private void CbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            member = ClsMember.Find(Lib.SelectedItem(CbMember));
            dgvHistory.DataSource = ClsMember.GetHistory(member.MemberID);
        }
        


        /******************** Search ********************/
        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            LoadHistory();
        }
        
    }
}
