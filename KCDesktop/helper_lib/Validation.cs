using System;
using System.Windows.Forms;

namespace KCDesktop.helper_lib
{
    public static class Validation
    {
        private static void ErrorProvider(Control control, string msg, ErrorProvider errorProvider, bool dismiss = false)
        {
            if (dismiss)
            {
                errorProvider.SetError(control, string.Empty);
                return;
            }

            errorProvider.SetError(control, msg);
        }

        private static bool IsTextBoxEmpty(TextBox tb) => tb.Text.Trim() == "";

        private static bool HasNotSelected(ComboBox cb) => cb.SelectedIndex == -1;


        public static bool IsTextBoxEmpty(TextBox tb, ErrorProvider e, string msg = "Can't be Empty")
        {

            if (IsTextBoxEmpty(tb))
            {
                ErrorProvider(tb, msg, e);
                return true;
            }
            else
            {
                ErrorProvider(tb, msg, e, true);
                return false;
            }
        }

        public static bool IsMaskedTextBoxEmpty(MaskedTextBox mTB, ErrorProvider e, string msg = "Can't be Empty")
        {
            if (mTB.MaskCompleted)
            {
                ErrorProvider(mTB, msg, e);
                return true;
            }
            else
            {
                ErrorProvider(mTB, msg, e, true);
                return false;
            }
        }

        public static bool HasNotSelected(ComboBox cb, ErrorProvider e, string msg = "No Item Selected")
        {
            if (HasNotSelected(cb))
            {
                ErrorProvider(cb, msg, e);
                return true;
            }
            else 
            {
                ErrorProvider(cb, msg, e, true);
                return false;
            } 
        }

        public static bool IsDateSmaller(DateTimePicker dp, ErrorProvider e, string msg = "Date Must Be Now Or in The Futuer")
        {
            if (dp.Value.Date < DateTime.Now.Date)
            {
                ErrorProvider(dp, msg, e);
                return true;
            }
            else
            {
                ErrorProvider(dp, msg, e, true);
                return false;
            }
        }
        public static bool IsEqual(DateTimePicker dp, ErrorProvider e, string msg = "Date Must Be On The Futuer")
        {
            if (dp.Value.Date == DateTime.Now.Date)
            {
                ErrorProvider(dp, msg, e);
                return true;
            }
            else
            {
                ErrorProvider(dp, msg, e, true);
                return false;
            }
        }

    }
}