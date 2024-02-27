using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizManagement
{
    public partial class Login : Form
    {
        function fn = new function();
        String query;
        public Login()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
      
         wrongLabel.Visible= false;
         panel2.Visible= false;
        }


        private void checkBoxShowHide_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowHide.Checked == true)
            {
                txtPassword.PasswordChar = '\0';
                checkBoxShowHide.Text = "Hide Passowrd";
            }
            else
            {
                txtPassword.PasswordChar = '*';
                checkBoxShowHide.Text = "Show Passowrd";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String username, user_password;

            username = txtUserName.Text;
            user_password = txtPassword.Text;
            wrongLabel.Visible = false;
            try
            {
                query = "select * from AspNetUsers where UserName ='"+txtUserName.Text+ "' AND PasswordHash = '"+txtPassword.Text+"'";
               DataSet ds = fn.getData(query);
                if (ds.Tables[0].Rows.Count > 0)
                {
                    username = txtUserName.Text;
                    user_password = txtPassword.Text;
                        Teachers te = new Teachers();
                        te.Show();
                        this.Hide();
                }
                else
                {
                    wrongLabel.Visible = true;
                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();
                }
            }
            catch
            {
                MessageBox.Show("Error");

            }
            //if (txtUserName.Text == "btechdays" && txtPassword.Text == "btechdays")
            //{
            //    Teachers te = new Teachers();
            //    te.Show();
            //    this.Hide();
            //}
            //else
            //{
            //    wrongLabel.Visible = true;
            //}
        }
    }
}
