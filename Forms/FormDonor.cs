using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBFinalBDS_Ver1.Forms
{
    public partial class FormDonor : Form
    {
        private Button currentButton;
        private Random random;
        private Form activeForm;
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = Color.Navy;
                    currentButton.ForeColor = Color.White;
                }
            }
        }
        private void DisableButton()
        {
            /*foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Beige;
                }
            }*/
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();

        }
        public FormDonor()
        {
            InitializeComponent();
        }

        private void personalInformationbtn_Click(object sender, EventArgs e)
        {
           
        }

        private void guardianInformationbtn_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormGuardianInfo(), sender);
        }

        private void personalInformationbtn_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPersonalInfo(), sender);
        }
    }
}
