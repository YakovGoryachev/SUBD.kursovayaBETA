using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SUBD.kursovayaBETA
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public AutorizationForm AutForm;
        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void BackBut_Click(object sender, EventArgs e)
        {
            try
            {
                Close();
                AutForm.Show();
            }
            catch (Exception ex)
            {

            }
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
