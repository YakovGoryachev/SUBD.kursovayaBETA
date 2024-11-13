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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }
        public RegistrationForm RegForm;

        private void AutorizationForm_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void EntryBut_Click(object sender, EventArgs e)
        {

        }

        private void RegistrationBut_Click(object sender, EventArgs e)
        {
            try
            {
                if (RegForm == null)
                {
                    RegForm = new RegistrationForm();
                    RegForm.AutForm = this;
                    RegForm.Show();
                    Hide();
                }
                else if (RegForm.IsDisposed)
                {
                    RegForm = new RegistrationForm();
                    RegForm.AutForm = this;
                    RegForm.Show();
                }
                RegForm.Activate();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExitBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
