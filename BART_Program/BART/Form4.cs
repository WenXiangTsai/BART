using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BART
{
    public partial class Form4 : Form
    {
       public Form4()
        {
            InitializeComponent();
        }

       private void MaxLifeSetting_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Enabled = true;
        } 

       private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show()
            Close();
        }


    }
}
