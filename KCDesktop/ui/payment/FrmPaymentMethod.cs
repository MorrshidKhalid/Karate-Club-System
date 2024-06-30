using System;
using System.Windows.Forms;
using KCBusinessLayer;
using KCDesktop.helper_lib;

namespace KCDesktop.ui.payment
{
    public partial class FrmPaymentMethod : Form
    {
        private Mode mode;
        private ClsMethod method;


        public FrmPaymentMethod() => InitializeComponent();

        private bool CheckValidation() => Validation.IsTextBoxEmpty(tbMethodName, e: ErrorProvider);


        private void Clear()
        {
            lbTitle.Text = "ADD NEW METHOD";
            BtnSave.Text = "SAVE";
            tbMethodName.Clear();
        }

        private void RefreshMethodList() => dgvMethodList.DataSource = ClsMethod.AllMethods();

        private void FrmPaymentMethod_Load(object sender, EventArgs e) => RefreshMethodList();

        private void ContxUpdate_Click(object sender, EventArgs e)
        {
            method = ClsMethod.Find(Lib.CurrentRowID(dgvMethodList));

            if (method.IsExists())
            {
                lbTitle.Text = "UPDATE METHOD";
                BtnSave.Text = "UPDATE";
                tbMethodName.Text = method.MethodName;
                mode = Mode.Update;
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {

            if (CheckValidation())
                return;


            if (mode == Mode.Add)
                method = new ClsMethod();

            method.MethodName = tbMethodName.Text.ToString();
            if(method.Save())
            {
                MessageBox.Show("Successfully Done");
                Clear();
                RefreshMethodList();
                mode = Mode.Add;
            } else MessageBox.Show("Error");
        }

    }
}
