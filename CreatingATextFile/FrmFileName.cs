using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CreatingATextFile
{
    public partial class FrmFileName : Form
    {

        public static string setFileName;

        public FrmFileName()
        {
            InitializeComponent();
        }

        private void btnOkay_Click(object sender, EventArgs e)
        {
            setFileName = txtFileName.Text.ToString() + ".txt";
            Close(); 
        }
    }
}
