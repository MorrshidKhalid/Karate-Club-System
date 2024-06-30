using System;
using System.Drawing;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.members
{
    public partial class FrmManegeMembers : Form
    {
        private Mode mode = Mode.Add;
        private ClsMember member;
        private ClsPhone phone;
        private int maskedTBCount = 0; // Keeps track of the number of textboxes.


        // Default Constructor.
        public FrmManegeMembers() => InitializeComponent();

        private bool CheckValidation()
        {
            // TextBox Input Validation.
            bool isValid = Validation.IsTextBoxEmpty(tbFirstName, e: ErrorProvider) ||
                           Validation.IsTextBoxEmpty(tbLastName, e: ErrorProvider);

            return isValid;
        }
        private void Clear()
        {
            lbTitle.Text = "ADD MEMBER";
            tbFirstName.Clear();
            tbMidName.Clear();
            tbLastName.Clear();
            tbAddress.Clear();
            if (maskedTBCount > 0)
                for (int i = 0; i < maskedTBCount; i++)
                {
                    MaskedTextBox maskedTB = (MaskedTextBox)Controls.Find($"phone{i}", true)[0];
                    maskedTB.Parent?.Controls.Remove(maskedTB);
                    maskedTB.Dispose();
                }

            maskedTBCount = 0;
            dgvPhone.DataSource = null;
            BtnSave.Text = "Save";
            mode = Mode.Add;
        }



        /******************** Refresh ********************/
        private void RefreshMemberList() => dgvMembers.DataSource = ClsMember.AllMembers();
        private void RefreshPhoneList() => dgvPhone.DataSource = ClsPhone.GetPhones(member.PersonID);


        private void FrmManegeMembers_Load(object sender, EventArgs e) => RefreshMemberList();


        /******************** Deal With Phone ********************/
        private void GenerateDynamicTextBox()
        {
            MaskedTextBox maskedTextBox = new MaskedTextBox // Create a new MaskedTextBox control
            {
                Mask = "(999) 000-000",  // phone number mask.
                Location = new Point(17, 223 + (maskedTBCount * 25)), // Adjust position based on count
                Size = new Size(99, 25),
                Name = $"phone{maskedTBCount}" // Unique name for each MaskedTextBox.
            };

            Controls.Add(maskedTextBox); // Add the MaskedTextBox to the form's Controls collection.
            maskedTBCount++; // Increment counter.
        }
        private void SavePhone(string phoneNumber)
        {
            phone = new ClsPhone
            {
                PersonID = member.PersonID,
                PhoneNumber = phoneNumber
            };
            if (!phone.Save())
                MessageBox.Show("Error");
        }
        private void SaveNumbersToDB()
        {
            if (maskedTBCount > 0)
                for (int i = 0; i < maskedTBCount; i++)
                {
                    MaskedTextBox mTB = (MaskedTextBox)Controls.Find($"phone{i}", true)[0];
                    if (mTB.MaskCompleted) // Make sure us valid number
                        SavePhone(mTB.Text);
                }
        }

        private void BtnPhone_Click(object sender, EventArgs e)
        {
            if (maskedTBCount < 5)
                GenerateDynamicTextBox();
        }



        /******************** SAVE & UPDATE ********************/
        private void NewMember()
        {
            member = new ClsMember()
            {
                FirstName = tbFirstName.Text.ToString(),
                MidName = tbMidName.Text.ToString(),
                LastName = tbLastName.Text.ToString(),
                Address = tbAddress.Text.ToString(),
            };
        }

        private void CntxUpdate_Click(object sender, EventArgs e)
        {
            member = ClsMember.Find(Lib.CurrentRowID(dgvMembers));

            if (member.IsExists())
            {
                lbTitle.Text = "UPDATE MEMBER";
                lbTitle.Text = "UPDATE MEMBER";
                BtnSave.Text = "UPDATE";
                tbFirstName.Text = member.FirstName;
                tbMidName.Text = member.MidName;
                tbLastName.Text = member.LastName;
                tbAddress.Text = member.Address;
                RefreshPhoneList();
                mode = Mode.Update;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            if (mode == Mode.Add)
                NewMember();

            // Get data from the user.
            member.FirstName = tbFirstName.Text.ToString();
            member.MidName = tbMidName.Text.ToString();
            member.LastName = tbLastName.Text.ToString();
            member.Address = tbAddress.Text.ToString();
            member.IsActive = true;
            member.LastBeltRankID = 1; // White Belt By Default.


            if (member.Save())
            {
                MessageBox.Show("Successfully Done");
                SaveNumbersToDB();
                Clear();
                RefreshMemberList();
                mode = Mode.Add;
            }
            else MessageBox.Show("Error");
        }



        /******************** Delete ********************/
        private void CntxDeletePhone_Click(object sender, EventArgs e)
        {
            DialogResult result =
                MessageBox.Show
                ("Are you sure you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo);


            if (result == DialogResult.Yes)
                if (ClsPhone.Delete(Lib.CurrentRowID(dgvPhone)))
                {
                    MessageBox.Show("Deleted Successfully");
                    RefreshPhoneList();
                }
                else MessageBox.Show("Can't Delete");
        }

        private void CntxDeleteMember_Click(object sender, EventArgs e)
        {
            member = ClsMember.Find(Lib.CurrentRowID(dgvMembers));

            if (member.IsExists())
            {
                DialogResult result =
                MessageBox.Show
                ("Are you sure you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                    if (member.Delete())
                    {
                        MessageBox.Show("Deleted Successfully");
                        RefreshMemberList();
                        Clear();
                    }
                    else MessageBox.Show("Make sure there is no data relited to this member");
            }
        }
    }
}
