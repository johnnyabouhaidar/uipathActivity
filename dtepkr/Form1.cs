using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dtepkr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void dmy_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd-MM-yyyy";
        }

        private void mdy_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "MM-dd-yyyy";
        }

        private void dmyslash_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "dd/MM/yyyy";
        }

        private void mdyslash_CheckedChanged(object sender, EventArgs e)
        {
            dateTimePicker1.CustomFormat = "MM/dd/yyyy";
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
        public String outputDate
        {
            get { return dateTimePicker1.Text; }
        }

        private void DoneBTN_Click(object sender, EventArgs e)
        {
            newClass.res = outputDate;
            this.Close();
        }
        
    }
}
