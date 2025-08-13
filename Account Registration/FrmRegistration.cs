using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Account_Registration;


namespace Account_Registration
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
        }
        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            cbProgram.Items.Add("BSIT");
            cbProgram.Items.Add("BSCS");
            cbProgram.Items.Add("BIT");
            cbProgram.Items.Add("BSCpE");
            cbProgram.Items.Add("BSBA");
            cbProgram.Items.Add("BSP");
            cbProgram.Items.Add("BSN");
            cbProgram.Items.Add("BSP");
            cbProgram.Items.Add("BSEE");
        }

        private void nxtBtn_Click(object sender, EventArgs e)
        {
            StudentInfoClass.FirstName = txtFirstname.Text;
            StudentInfoClass.LastName = txtLastname.Text;
            StudentInfoClass.MiddleName = txtMiddlename.Text;
            StudentInfoClass.Address = txtAddress.Text;
            StudentInfoClass.Program = cbProgram.Text;
            StudentInfoClass.Age = long.Parse(txtAge.Text);
            StudentInfoClass.ContactNo = long.Parse(txtContactNO.Text);
            StudentInfoClass.StudentNo = long.Parse(txtStudentNo.Text);


            FrmConfirm confirm = new FrmConfirm();
            if (confirm.ShowDialog() == DialogResult.OK)
            {
                
                txtFirstname.Clear();
                txtLastname.Clear();
                txtMiddlename.Clear();
                txtAddress.Clear();
                cbProgram.SelectedIndex = -1;
                txtAge.Clear();
                txtContactNO.Clear();
                txtStudentNo.Clear();
            }

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
