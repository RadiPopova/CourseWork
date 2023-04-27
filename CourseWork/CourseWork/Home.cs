using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CourseWork
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void addParKids_Click(object sender, EventArgs e)
        {
            form_Add_Parent add = new form_Add_Parent();
            add.MdiParent = this;
            add.Show();
     
        }

        private void payMember_Click(object sender, EventArgs e)
        {
            frmPayPeriod payPeriod= new frmPayPeriod();
            payPeriod.MdiParent = this;
            payPeriod.Show();
        }

        private void payFoodTrans_Click(object sender, EventArgs e)
        {
            frmPayFood payFood = new frmPayFood();
            payFood.MdiParent = this;
            payFood.Show();
        }

     
    }
}
