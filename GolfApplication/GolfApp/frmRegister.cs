using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GolfApp
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            //create new golfDB to connect to DB?
            GolfDB db = new GolfDB();

            //create user to be saved
            User user = new User();


            if (txtPassword.Text != txtPassConfirmation.Text)
            {
                txtPassNotMatched.Visible = true;
            }

            else if (txtPassword.Text == txtPassConfirmation.Text && txtPassword.Text.Length >= 6)
            {
                //check to see if user is already present by username
                User testUser = DBHelper.GetUserByUsername(txtUsername.Text);
                if (testUser == null)
                {
                    User saveUser = new User();
                    saveUser.Username = txtUsername.Text;
                    saveUser.Password = txtPassword.Text;

                    db.Users.Add(saveUser);
                    if (db.SaveChanges() == 1)
                    {
                        MessageBox.Show("User saved!");
                    }
                }
                else
                {
                    MessageBox.Show("User already exists!");
                }
            }
            else
            {
                lblPassCharacter.Visible = true;
            }
        }

        private void btnBackToLogin_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            lblPassCharacter.Visible = false;
            txtPassNotMatched.Visible = false;
        }

        private void txtPassConfirmation_TextChanged(object sender, EventArgs e)
        {
            txtPassNotMatched.Visible = false;
        }
    }
}
