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
    public partial class Teachers : Form
    {
        public Teachers()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAddNewQuestion_Click(object sender, EventArgs e)
        {
            addNewQuestions1.Visible= true;
            addNewQuestions1.BringToFront();
        }

        private void Teachers_Load(object sender, EventArgs e)
        {
            addNewQuestions1.Visible= false;
            updateQuestion1.Visible= false;
            viewAndDeleteQuestion1.Visible= false;
        }

        private void btnUpdateQuestion_Click(object sender, EventArgs e)
        {
            updateQuestion1.Visible= true;
            updateQuestion1.BringToFront();
        }

        private void btnViewDeleteQuestion_Click(object sender, EventArgs e)
        {
            viewAndDeleteQuestion1.Visible= true;
            viewAndDeleteQuestion1.BringToFront();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Login login= new Login();
            login.Show();
            this.Hide();
        }
    }
}
