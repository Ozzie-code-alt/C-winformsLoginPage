using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace loginNet
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnCLosee_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtName_Click(object sender, EventArgs e) // on click changes highlight
        {
            txtName.BackColor = Color.White;
            panel7.BackColor = Color.LightSkyBlue;
            txtPass.BackColor = Color.White;
            panel6.BackColor = Color.CornflowerBlue;
        }

        private void txtPass_Click(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightSkyBlue;
            txtPass.BackColor = Color.White;
            txtName.BackColor= Color.White;
            panel7.BackColor= Color.CornflowerBlue;
        }

        private void panel7_MouseEnter(object sender, EventArgs e)
        {
            panel7.BackColor = Color.LightSkyBlue;
        }

    

        private void panel6_MouseEnter(object sender, EventArgs e)
        {
            panel6.BackColor = Color.LightSkyBlue;
        }

        private void pictureBox4_MouseDown(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar = false;
        }

        private void pictureBox4_MouseUp(object sender, MouseEventArgs e)
        {
            txtPass.UseSystemPasswordChar=true;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtName.Text == "UserName" && txtPass.Text == "Password")
            {
                MessageBox.Show("Opens another Form","SUCCESS!");
            }
            else
            {
                MessageBox.Show(" Wrong username and pass, Try again", " FAIL");
            }
        }
    }
}
