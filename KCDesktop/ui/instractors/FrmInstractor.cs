using System;
using System.Drawing;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.instractors
{
    public partial class FrmInstractor : Form
    {
        private Mode mode = Mode.Add;
        private ClsInstractor instractor;
        private ClsPhone phone;
        private int maskedTBCount = 0; // Keeps track of the number of textboxes.

        // Default Constractor.
        public FrmInstractor() => InitializeComponent();

        private void Clear()
        {
            lbTitle.Text = "ADD INSTRACTOR";
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

        private bool CheckValidation()
        {
            // TextBox Input Validation.
            bool isValid = Validation.IsTextBoxEmpty(tbFirstName, e: ErrorProvider) ||
                           Validation.IsTextBoxEmpty(tbLastName, e: ErrorProvider);

            return isValid;
        }

        /******************** Refresh ********************/
        private void RefreshInstractorList() => dgvInstractor.DataSource = ClsInstractor.AllInstractoras();
        private void RefreshPhoneList() => dgvPhone.DataSource = ClsPhone.GetPhones(instractor.PersonID);
      

        private void FrmInstractor_Load(object sender, EventArgs e) => RefreshInstractorList();


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
                PersonID = instractor.PersonID,
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
  
        private void CntxUpdate_Click(object sender, EventArgs e)
        {
            instractor = ClsInstractor.Find(Lib.CurrentRowID(dgvInstractor));

            if (instractor.IsExists())
            {
                lbTitle.Text = "UPDATE INSTRACTOR";
                BtnSave.Text = "UPDATE";
                RefreshPhoneList();
                mode = Mode.Update;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (CheckValidation())
                return;

            if (mode == Mode.Add)
                instractor = new ClsInstractor();

            // Get data from the user.
            instractor.FirstName = tbFirstName.Text.ToString();
            instractor.MidName = tbMidName.Text.ToString();
            instractor.LastName = tbLastName.Text.ToString();
            instractor.Address = tbAddress.Text.ToString();


            if (instractor.Save())
            {
                MessageBox.Show("Successfully Done");
                SaveNumbersToDB();
                Clear();
                RefreshInstractorList();
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

        private void CntxDeleteInstractor_Click(object sender, EventArgs e)
        {
            instractor = ClsInstractor.Find(Lib.CurrentRowID(dgvInstractor));

            if (instractor.IsExists())
            {
                DialogResult result =
                MessageBox.Show
                ("Are you sure you want to continue?",
                "Confirmation",
                MessageBoxButtons.YesNo);


                if (result == DialogResult.Yes)
                    if (instractor.Delete())
                    {
                        MessageBox.Show("Deleted Successfully");
                        RefreshInstractorList();
                        Clear();
                    }
                else MessageBox.Show("Can't Delete");
            }
        }
    }
}
