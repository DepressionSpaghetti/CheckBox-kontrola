using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CheckBox_Kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtBox.AppendText("Odabrali ste:" + Environment.NewLine);
        }


        private void chkDorucak_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void chkRucak_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void chkVecera_CheckedChanged(object sender, EventArgs e)
        {

        }
        
        private void chkHide_CheckedChanged(object sender, EventArgs e)
        {
            if (chkHide.Checked) txtBox.Hide();
                    else txtBox.Show();

        }
        
        private void btnPosalji_Click(object sender, EventArgs e)
        {
            txtBox.Clear();
            txtBox.AppendText("Odabrali ste:" + Environment.NewLine);
            if (chkDorucak.Checked) txtBox.AppendText(chkDorucak.Text + Environment.NewLine);
            if (chkRucak.Checked) txtBox.AppendText(chkRucak.Text + Environment.NewLine);
            if (chkVecera.Checked) txtBox.AppendText(chkVecera.Text + Environment.NewLine);


        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
