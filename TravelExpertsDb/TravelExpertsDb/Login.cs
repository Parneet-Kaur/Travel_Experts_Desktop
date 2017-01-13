using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TravelExpertsDb
{
    public partial class Login : MaterialForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Validator v1 = new Validator();
            if (v1.isEmpty(txtUsername)) {
                lblErrorMessage.Text = "Username is required.";
                lblErrorMessage.Visible = true;
            }
            else if (v1.isEmpty(txtPassword)) {
                lblErrorMessage.Text = "Password is required.";
                lblErrorMessage.Visible = true;
            }
            else {
                if (v1.username(txtUsername) )
                {
                    //if  the data validates then compare against db
                    DataAccessLogin login = new DataAccessLogin();
                    if (login.validateCredentials(txtUsername.Text, txtPassword.Text))
                    {
                        //send to home page
                        lblErrorMessage.Text = "Welcome agent";
                        lblErrorMessage.Visible = true;
                    }
                    else {
                        lblErrorMessage.Text = "Invalid credentials";
                        lblErrorMessage.Visible = true;
                    }
                }
                else {
                    lblErrorMessage.Text = "Username or password is not correct.";
                    lblErrorMessage.Visible = true;
                }
                    

            }//end of exterior else
          

        }
    }
}
