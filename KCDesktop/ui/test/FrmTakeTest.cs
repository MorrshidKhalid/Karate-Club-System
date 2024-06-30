using System;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.test
{
    public partial class FrmTakeTest : Form
    {
        private ClsBeltRank beltRank;
        private ClsMember member;
        private ClsInstractor instractor;
        private ClsPayment payment;
        private bool BeltResult = false;


        // Default Constructor.
        public FrmTakeTest() => InitializeComponent();

        private bool CheckValidation()
        {
            bool isValid =
                Validation.HasNotSelected(CbInstractor, e: ErrorProvider) ||
                Validation.HasNotSelected(CbMember, e: ErrorProvider) ||
                Validation.HasNotSelected(CbBeltRank, e: ErrorProvider) ||
                Validation.HasNotSelected(CbMethod, e: ErrorProvider);
                
           

            return isValid;
        }

        private void Clear()
        {
            CbBeltRank.SelectedIndex = -1;
            CbMember.SelectedIndex = -1;
            CbInstractor.SelectedIndex = -1;
            CbMethod.SelectedIndex = -1;
            mTbAmount.Clear();
            tbNote.Clear();
            RbFaild.Checked = true;
            RbPassed.Checked = false;
        }


        /******************** Refresh ********************/
        private void RefreshInstractorComboBox() => Lib.LoadDataToComboBox(ClsInstractor.AllInstractoras(), ref CbInstractor, "Name");
        private void RefreshMemberComboBox() => Lib.LoadDataToComboBox(ClsMember.AllMembers(), ref CbMember, "Name");
        private void RefreshBeltRankComboBox() => Lib.LoadDataToComboBox(ClsBeltRank.GetAllRanks(), ref CbBeltRank, "RankName");
        private void RefreshMethodComboBox() => Lib.LoadDataToComboBox(ClsMethod.AllMethods(), ref CbMethod, "MethodName");


        private void FrmTakeTest_Load(object sender, EventArgs e)
        {
            
            lbDate.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");
            RefreshInstractorComboBox();
            RefreshMemberComboBox();
            RefreshBeltRankComboBox();
            RefreshMethodComboBox();
        }


        /******************** Load Date ********************/
        private void LoadBeltRankData()
        {
            beltRank = ClsBeltRank.Find(Lib.SelectedItem(CbBeltRank));

            if (beltRank.IsExists())
            {
                lbFee.Text = beltRank.TestFee.ToString();
                lbRankName.Text = beltRank.RankName.ToString();
            } 
            else
            {
                lbFee.Text = "???";
                lbRankName.Text = "?????";
            }
        }
        private void LoadMemberData()
        {
            member = ClsMember.Find(Lib.SelectedItem(CbMember));
            if (member.IsExists())
            {
                lbLastRank.Text = ClsBeltRank.Find(member.LastBeltRankID).RankName.ToString();
                lbMember.Text = member.FullName();
            }
            else
            {
                lbMember.Text = "?????";
                lbLastRank.Text = "?????";
            }
        }
        private void LoadInstractorData()
        {
            instractor = ClsInstractor.Find(Lib.SelectedItem(CbInstractor));
            if (instractor.IsExists())
                lbInstractor.Text = instractor.FullName();
            else lbInstractor.Text = "?????";
        }


        private void CbBeltRank_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadBeltRankData();
        }
        private void CbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMemberData();
        }
        private void CbInstractor_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInstractorData();
        }



        /******************** Payment ********************/
        private void PreparePayment()
        {
            payment = new ClsPayment()
            {
                MethodID = ClsMethod.GetMethodID(Lib.SelectedItem(CbMethod)),
                MemberID = member.MemberID,
                AmountPaid = decimal.Parse(mTbAmount.Text),
                Date = DateTime.Now.Date,
                Note = tbNote.Text.ToString()
            };

            if (!payment.Save())
                MessageBox.Show("Can't Save Payment");
        }


        /******************** Take Test ********************/

        private void RbPassed_CheckedChanged(object sender, EventArgs e) => BeltResult = true;
        private void RbFaild_CheckedChanged(object sender, EventArgs e) => BeltResult = false;
        private void Save()
        {
            PreparePayment();

            ClsTest test = new ClsTest
            {
                TestedByInstructorID = instractor.InstractorID,
                MemberID = member.MemberID,
                RankID = beltRank.RankID,
                Result = BeltResult,
                Date = DateTime.Now.Date,
                PaymentID = payment.insertedID
            };

            if (test.Save())
                MessageBox.Show("Test Saved Successfully");
            else MessageBox.Show("Error");
        }
        private void BtnSave_Click(object sender, EventArgs e) 
        {
            if (CheckValidation())
                return;

            if (!mTbAmount.MaskCompleted)
            {
                MessageBox.Show("Paid Must be inclouded");
                return;
            }

            Save();
            Clear();
        }
        
    }
}
