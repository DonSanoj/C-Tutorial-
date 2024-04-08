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
    public partial class Form2 : Form
    {
        public Form2(string fName, string lName, string username, string email)
        {
            InitializeComponent();
            lblFName.Text = fName;
            lblSName.Text = lName;
            lblUsername.Text = username;
            lblEmail.Text = email;
        }
    }
}
