using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Juan_Week07_Week08
{
    public partial class Signup : Form
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Users newUser = new Users();
            newUser.Fullname = tbRegFullname.Text;
            newUser.Email = tbRegEmail.Text;
            newUser.Username = tbRegUsername.Text;
            newUser.Password = tbRegPassword.Text;

            Users.UserList.Add(newUser);

            MessageBox.Show("Registration successful!");

            Login loginForm = new Login();
            loginForm.Show();
            this.Hide();
        }
    }
}
