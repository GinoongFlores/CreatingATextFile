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
    public partial class FrmLab1 : Form
    {
        public FrmLab1()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

            /*  Uncomment for 1st laboratory    */

           /* FrmFileName frmFileName = new FrmFileName();
            frmFileName.ShowDialog(); */



            // Second Laboratory Exercise
            FrmRegistration frmRegistration = new FrmRegistration();
            frmRegistration.ShowDialog();

            string getInput = txtInput.Text.ToString();

            string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            using (StreamWriter outputFile = new StreamWriter(Path.Combine(docPath,
            FrmFileName.setFileName)))
            {
                outputFile.WriteLine(getInput);
                Console.WriteLine(getInput);
            }

        }

        private void FrmLab1_Load(object sender, EventArgs e)
        {

        }
    }
}
