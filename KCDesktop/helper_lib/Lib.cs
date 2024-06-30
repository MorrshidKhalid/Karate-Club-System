using System.Data;
using System.Windows.Forms;

namespace KCDesktop.helper_lib
{
    public class Lib
    {
        public static void LoadDataToComboBox(DataTable dt, ref ComboBox cb, string clm)
        {
            cb.Items.Clear();
            foreach (DataRow row in dt.Rows)
                cb.Items.Add(row[clm]);
        }

        public static int CurrentRowID(DataGridView dgv) => (int)dgv.CurrentRow.Cells[0].Value;

        public static string SelectedItem(ComboBox cb) => (string)cb.SelectedItem;
    }
}
