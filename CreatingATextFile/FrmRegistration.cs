using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingATextFile
{
    public partial class FrmRegistration : Form
    {
        public FrmRegistration()
        {
            InitializeComponent();
         
        }

        private void FrmRegistration_Load(object sender, EventArgs e)
        {
            string[] listOfPrograms = new string[]
        {
                "BS Information Technology",
                "BS Computer Science",
                "BS Information Systems",
                "BS in Accountancy",
                "BS in Hospitatality Management",
                "BS in Tourism Management"
        };

            for (int i = 0; i < 6; i++)
            {
                cbPrograms.Items.Add(listOfPrograms[i].ToString());
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string[] registration = {"Student No: " + lblStudentNo.Text, "Full Name: " + txtLastName.Text + ", " + txtFirstName.Text,
                                     "Program: " + cbPrograms.Text, "Gender: " + cbGender.Text, "Age: " + txtAge.Text, 
                                     "Birthday: " + datePickerBirthday.Text, "Contact No: " + txtContactNo.Text};

            // Show frmFileName class to create a file name
            FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.setFileName)))
            {
                foreach (string reg in registration)
                {
                    outputFile.WriteLine(reg);
                    Console.WriteLine(reg);
                }
              
            }
        }
    }
}
