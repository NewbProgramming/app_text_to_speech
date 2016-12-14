using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_text_to_speech
{
    public partial class window_get_text : Form
    {
        public string speak = string.Empty;

        public window_get_text()
        {
            InitializeComponent();
        }

        private void window_get_text_Load(object sender, EventArgs e)
        {
            this.BringToFront();
            textbox.Focus();
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            this.speak = textbox.Text;
            this.Close();
        }
    }
}
