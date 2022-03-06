using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CMSWinFormsApp
{
    public partial class JobDetailsForm : Form
    {
        public JobDetailsForm()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtCarNo_Leave(object sender, EventArgs e)
        {
            if ((txtCarNo.Text == "") || (txtCarNo.Text == null))
            {
                MessageBox.Show("Please specify a Valid Car Number");
                txtCarNo.Focus();
            }
        }

        private void btnUpdate_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (txtCarNo.Text.Length < 6)
                {
                    MessageBox.Show("Please specify a Valid Car Number");
                    txtCarNo.Focus();
                    return;
                }
                if (Convert.ToInt32(txtWorkerId.Text) < 1)
                {
                    MessageBox.Show("Please specify a Valid Worker Id");
                    txtWorkerId.Focus();
                    return;
                }
                if (Convert.ToDateTime(dateTimePicker1.Value) > DateTime.Today)
                {
                    MessageBox.Show("Please specify a Valid Date");
                    dateTimePicker1.Focus();
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();//close
        }
    }
}
