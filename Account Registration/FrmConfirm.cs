using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Account_Registration.StudentInfoClass;

namespace Account_Registration
{
    public partial class FrmConfirm : Form
    {
        private DelegateText DelProgram, DelLastName, DelFirstName, DelMiddleName, DelAddress;
        private DelegateNumber DelNumAge, DelNumContactNo, DelStudNo;

        

        public FrmConfirm()
        {
            InitializeComponent();
           
            DelProgram = new DelegateText(GetProgram);
            DelLastName = new DelegateText(GetLastName);
            DelFirstName = new DelegateText(GetFirstName);
            DelMiddleName = new DelegateText(GetMiddleName);
            DelAddress = new DelegateText(GetAddress);
            DelNumAge = new DelegateNumber(GetAge);
            DelNumContactNo = new DelegateNumber(GetContactNo);
            DelStudNo = new DelegateNumber(GetStudentNo);

        }

        private void FrmConfirm_Load(object sender, EventArgs e)
        {

            lblProgram.Text = DelProgram(StudentInfoClass.Program); 
            lblLastname.Text = DelLastName(LastName);
            lblFirstname.Text = DelFirstName(FirstName);
            lblMiddlename.Text = DelMiddleName(MiddleName);
            lblAddress.Text = DelAddress(Address);
            lblAge.Text = DelNumAge(Age).ToString();
            lblContactNo.Text = DelNumContactNo(ContactNo).ToString();
            lblStudentNo.Text = DelStudNo(StudentNo).ToString();

        }

        private void Submitbtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void FrmConfirm_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }
    }
}