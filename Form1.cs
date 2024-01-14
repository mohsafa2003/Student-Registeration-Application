using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApp
{
    public partial class Form1 : Form
    {
        int student_ID;
        string studentName;
        string studentGender;
        string phoneNo;
        string Residence;
        string Dob;
        string classCombo;
        string majorCombo;

    

        public Form1()
        {
            InitializeComponent();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            student_ID = 1;
            studentName = NameInput.Text;
            studentGender = GenderCombo.Text;
            phoneNo = phoneNumInput.Text;
            Residence = ResidenceInput.Text;
            Dob = DateOfBirthText.Text;
            classCombo = ClassCombo.Text;
            majorCombo = MajorCombo.Text;

           var studentTable = StudentTable;



        }



        private void NameText_Click(object sender, EventArgs e)
        {

        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            studentName = NameInput.Text;
            studentGender = GenderCombo.Text;
            phoneNo = phoneNumInput.Text;
            Residence = ResidenceInput.Text;
            Dob = DateOfBirthText.Text;
            classCombo = ClassCombo.Text;
            majorCombo = MajorCombo.Text;


            if (studentName != string.Empty)
            {
               
                try
                {
                    
                    StudentTable.Rows[student_ID++].Cells["StudentName"].Value = (studentName);
                    StudentTable.Rows[student_ID].Cells["Student_ID"].Value = (Convert.ToString(student_ID));
                    StudentTable.Rows.Add();
                }
                catch(Exception ex) 
                {
                    MessageBox.Show("Failure to do task!" , "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                
            }
        }





        
    }
}
