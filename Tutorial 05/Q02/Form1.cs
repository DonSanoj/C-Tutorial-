using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            txtFName.Text = "";
            txtLName.Text = "";
            txtEmail.Text = "";
            txtDOB.Text = "";
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtCPassword.Text = "";
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (
                txtFName.Text == "" || txtLName.Text == "" || txtEmail.Text == "" ||
                txtDOB.Text == "" || txtUsername.Text == "" || txtPassword.Text == "" ||
                txtCPassword.Text == "" )
            {
                MessageBox.Show("Please fill all the fields", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            if (txtPassword.Text != txtCPassword.Text)
            {
                MessageBox.Show("Password does not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (!AllFieldsString())
            {
                MessageBox.Show("Please fill all the fields with valid data", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!isValidEmail(txtEmail.Text))
            {
                MessageBox.Show("Invalid email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!isValidDOB(txtDOB.Text))
            {
                MessageBox.Show("Invalid date of birth", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string fName = txtFName.Text;
            string lName = txtLName.Text;
            string username = txtUsername.Text;
            string email = txtEmail.Text;

            Form2 form2 = new Form2(fName, lName, username, email);
            form2.Show();
            this.Hide();
        }

        private bool AllFieldsString()
        {
            foreach (Control control in Controls)
            {
                if (control is TextBox textBox && textBox.Text == "" && textBox.Name != "txtCPassword")
                {
                    return false;
                }
            }
            return true;
        }

        private bool isValidEmail(string email)
        {
            return email.Contains("@") && email.Contains(".");
        }

        private bool isValidDOB(string dob)
        {
            DateTime dateTime;
            bool isValidFormat = DateTime.TryParseExact(dob, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out dateTime);
            return isValidFormat;
        }
    }
}
