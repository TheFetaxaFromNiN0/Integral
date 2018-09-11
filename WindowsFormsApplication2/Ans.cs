using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Ans : Form
    {
        public Ans()
        {
            InitializeComponent();
            AnsBox.Text = "12";            
        }

        private void Ans_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AnsClose_Click(object sender, EventArgs e)
        {            
            this.Hide();            
        }

        public void AnsBox_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
