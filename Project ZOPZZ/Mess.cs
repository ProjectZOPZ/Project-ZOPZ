using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_ZOPZZ
{
    public partial class Mess : Form
    {
        public Mess(string title, string message)
        {
            InitializeComponent();
            this.title.Text = title;
            this.description.Text = message;
        }
        public static DialogResult Show(string title, string description)
        {
            return new Mess(title, description).ShowDialog();
        }
        private void description_Click(object sender, EventArgs e)
        {

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Mess_Load(object sender, EventArgs e)
        {

        }
    }
}
