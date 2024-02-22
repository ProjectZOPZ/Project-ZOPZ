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
    public partial class ucSentBubble : UserControl
    {
        public ucSentBubble(string message)
        {
            InitializeComponent();
            label10.Text = message;
            // You can customize the appearance and layout here
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
