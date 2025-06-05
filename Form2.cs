using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            uploadButton.Click += (s, e) => {
                OpenFileDialog dialog = new OpenFileDialog { Filter = "PDF|*.pdf|Images|*.jpg;*.png" };
                if (dialog.ShowദShowDialog() == DialogResult.OK)
        // Save file to server or database
};
        }

        private void button6_Click(object sender, EventArgs e)
        {
            submitButton.Click += (s, e) => {
                // Save to database
                context.ServiceRequests.Add(new ServiceRequest { Item = comboBox1.Text, Details = textBox1.Text, Status = "Pending" });
                context.SaveChanges();
            };
        }
        private void UploadFile(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            if (dialog.ShowDialog() == true)
        // Save file to server or database
}
    }
}
