using System;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;
using KCDesktop.ui.instractors;
using KCDesktop.ui.subscription;
using KCDesktop.ui.members;
using KCDesktop.ui.test;
using KCDesktop.ui.payment;

namespace KCDesktop
{
    public partial class FrmHome : Form
    {
        private ClsMember member;
        private ClsPayment payment;
        private ClsSubscription subscription;
        private Mode mode;

        // Default Constructor.
        public FrmHome()
        {
            InitializeComponent();
            RbNew.Checked = true;
        }

        private bool CheckValidation()
        {
           

            if (RbExists.Checked)
            {
                return Validation.HasNotSelected(CbMember, e: ErrorProvider) ||
                       Validation.HasNotSelected(cbMethod, e: ErrorProvider) ||
                       Validation.IsTextBoxEmpty(tbAmountPaid, e: ErrorProvider);
            }

            else
            {
                return Validation.IsTextBoxEmpty(tbFirstName, e: ErrorProvider) ||
                       Validation.IsTextBoxEmpty(tbLastName, e: ErrorProvider) ||
                       Validation.HasNotSelected(cbMethod, e: ErrorProvider) ||
                       Validation.IsTextBoxEmpty(tbAmountPaid, e: ErrorProvider);
            }
        }

        private void EnableControls(bool enable, RadioButton rb)
        {
            if (rb == RbNew)
            {
                CbMember.Enabled = enable;
                tbMemberID.Enabled = enable;
                BtnFind.Enabled = enable;
            }
            else
            {
                tbFirstName.Enabled = enable;
                tbMidName.Enabled = enable;
                tbLastName.Enabled = enable;
                tbAddress.Enabled = enable;
            }
        }
        private void Clear()
        {
            tbFirstName.Clear();
            tbMidName.Clear();
            tbLastName.Clear();
            tbAddress.Clear();
            tbMemberID.Clear();
        }



        /******************** Refresh ********************/
        private void RefreshMethodComboBox() => Lib.LoadDataToComboBox(ClsMethod.AllMethods(), ref cbMethod, "MethodName");
        private void RefreshMemberComboBox() => Lib.LoadDataToComboBox(ClsMember.AllMembers(), ref CbMember, "Name");
        private void RefreshMemberData()
        {
            if (member.IsExists())
            {
                tbFirstName.Text = member.FirstName;
                tbMidName.Text = member.MidName;
                tbLastName.Text = member.LastName;
                tbAddress.Text = member.Address;
                tbMemberID.Text = member.MemberID.ToString();
            }
            else
            {
                MessageBox.Show("Member Not Found");
                Clear(); // Clear text on controls.
            }
        }
        private void RefreshFee() => lbFee.Text = (Date.DifferenceInDays(DpStart, DpEnd) * ClsFee.CurrentFee()).ToString();


        private void FrmHome_Load(object sender, EventArgs e)
        {
            RefreshMethodComboBox();
            RefreshMemberComboBox();
            RefreshFee();
        }


        /******************** Prepare Objects ********************/
        private void PrepareMember()
        {
            if (mode == Mode.Add)
            {
                member = new ClsMember
                {
                    FirstName = tbFirstName.Text.ToString(),
                    MidName = tbMidName.Text.ToString(),
                    LastName = tbLastName.Text.ToString(),
                    Address = tbAddress.Text.ToString(),
                    IsActive = true,
                    LastBeltRankID = 1 // White Belt By Default.
                };

                if (!member.Save())
                    MessageBox.Show("Can't Save Member");
            }
        }

        private void PreparePayment()
        {
            payment = new ClsPayment()
            {
                MethodID = ClsMethod.GetMethodID(Lib.SelectedItem(cbMethod)),
                AmountPaid = decimal.Parse(tbAmountPaid.Text),
                Date = DateTime.Now.Date,
                Note = tbNote.Text.ToString()
            };

            if (mode == Mode.Update)
                payment.MemberID = member.MemberID;
            else
                payment.MemberID = member.insertedID;

            

            if (!payment.Save())
                MessageBox.Show("Can't Save Payment");
        }

        private void PrepareSubscription()
        {
            subscription = new ClsSubscription()
            {
                PaymentID = payment.insertedID,
                Fee = decimal.Parse(lbFee.Text),
                StartDate = DpStart.Value.Date,
                EndtDate = DpEnd.Value.Date,
            };

            if (mode == Mode.Update)
                subscription.MemberID = member.MemberID;
            else
                subscription.MemberID = member.insertedID;

            if (!subscription.Save())
                MessageBox.Show("Can't Save subscription");
            else MessageBox.Show("Subscription Added Successfully :)");
        }


        /******************** Save ********************/

        private void Save()
        {
            PrepareMember();
            PreparePayment();
            PrepareSubscription();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            Save();
        }


        /******************** Events ********************/
        private void RbNew_CheckedChanged(object sender, EventArgs e)
        {
            Clear(); // Clear any Data on TextBoxes.

            if (RbNew.Checked)
            {
                EnableControls(false, RbNew);
                mode = Mode.Add;
            }
            else
            {
                EnableControls(true, RbNew);
                mode = Mode.Update;
            }
        }

        private void RbExists_CheckedChanged(object sender, EventArgs e)
        {
            Clear(); // Clear any Data on TextBoxes.

            if (RbExists.Checked)
            {
                EnableControls(false, RbExists);
                mode = Mode.Update;
            }
            else
            {
                EnableControls(true, RbExists);
                mode = Mode.Add;
            }
        }

        private void CbMember_SelectedIndexChanged(object sender, EventArgs e)
        {
            member = ClsMember.Find(Lib.SelectedItem(CbMember));
            RefreshMemberData();
        }

        private void BtnFind_Click(object sender, EventArgs e)
        {
            if (Validation.IsTextBoxEmpty(tbMemberID, e: ErrorProvider))
                return;

            CbMember.Text = string.Empty; // Clear ComboBox Text.
            int memberID = int.Parse(tbMemberID.Text.ToString());
            member = ClsMember.Find(memberID);
            RefreshMemberData();
        }

        private void DpEnd_ValueChanged(object sender, EventArgs e) => RefreshFee();

        private void DpStart_ValueChanged(object sender, EventArgs e) => RefreshFee();


        /******************** Open Forms ********************/
        private void MenuFee_Click(object sender, EventArgs e)
        {
            new FrmFee().ShowDialog();
            RefreshFee();
        }

        private void SubscriptionMenu_Click(object sender, EventArgs e) => new FrmSubscriptionList().Show();

        private void MenuInstractors_Click(object sender, EventArgs e) => new FrmInstractor().Show();

        private void MenuManageMembers_Click(object sender, EventArgs e) => new FrmManegeMembers().Show();

        private void MenuTakeTest_Click(object sender, EventArgs e) => new FrmTakeTest().Show();

        private void MenuTestFee_Click(object sender, EventArgs e) => new FrmTestFee().ShowDialog();

        private void MenuPaymentHistory_Click(object sender, EventArgs e) => new FrmPaymentHIstory().Show();

        private void MenuMethod_Click(object sender, EventArgs e)
        {
            new FrmPaymentMethod().ShowDialog();
            RefreshMethodComboBox();
        }
    }
}