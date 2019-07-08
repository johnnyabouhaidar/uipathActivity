using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dtepkr
{
    public static class newClass
    {
        public static string res;
        public static DialogResult runForm()
        {
            DialogResult dr = DialogResult.None;
            using (Form1 frm =new Form1())
            {
                dr = frm.ShowDialog();
            }
            return dr;
        }
    }
}
