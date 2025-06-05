using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ITP4915M
{
    public partial class LoginForm : Form
    {
        private Dictionary<string, string> userAccounts;

        public LoginForm()
        {
            InitializeComponent();
            userAccounts = new Dictionary<string, string>();
            SetupPlaceholderBehavior();
        }

        private void SetupPlaceholderBehavior()
        {
            textBox1.Enter += (sender, e) => { if (textBox1.Text == "") label4.Visible = false; };
            textBox1.Leave += (sender, e) => { if (textBox1.Text == "") label4.Visible = true; };
            textBox2.Enter += (sender, e) => { if (textBox2.Text == "") label5.Visible = false; };
            textBox2.Leave += (sender, e) => { if (textBox2.Text == "") label5.Visible = true; };

            textBox1.TextChanged += (sender, e) => { label4.Visible = textBox1.Text == ""; };
            textBox2.TextChanged += (sender, e) => { label5.Visible = textBox2.Text == ""; };
        }

        private void SignUp_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userAccounts.ContainsKey(username))
            {
                MessageBox.Show("Username already exists", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            userAccounts.Add(username, password);
            MessageBox.Show("Account created successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Please enter both username and password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!userAccounts.ContainsKey(username))
            {
                MessageBox.Show("Username not found", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (userAccounts[username] != password)
            {
                MessageBox.Show("Incorrect password", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Login successful!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
            ClearFields();
        }

        private void ClearFields()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label4.Visible = true;
            label5.Visible = true;
            textBox1.Focus();
        }
    }
}
