using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_text_to_speech
{
    public partial class text_to_speech : Form
    {
        VoiceGender gender = VoiceGender.Neutral;

        public text_to_speech()
        {
            InitializeComponent();
        }

        private void text_to_speech_Load(object sender, EventArgs e)
        {
            this.Hide();
            
            if(this.gender == VoiceGender.Neutral || this.gender == VoiceGender.Female)
            {
                notify_menu_changeGender.Text = "Change to Male";
            }
            else
            {
                notify_menu_changeGender.Text = "Change to Female";
            }
            
            Speaker.Speak(VoiceGender.Female, "Text to Speech by Noob Programming has started");
        }

        private void notify_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            window_get_text window = new window_get_text();
            
            window.ShowDialog();

            Speaker.Speak(this.gender, window.speak);
        }

        private void notify_menu_DragDrop(object sender, DragEventArgs e)
        {
            MessageBox.Show(e.Data.ToString());
        }

        private void notify_menu_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void notify_menu_changeGender_Click(object sender, EventArgs e)
        {
            
            if(this.gender == VoiceGender.Neutral || this.gender == VoiceGender.Female)
            {
                this.gender = VoiceGender.Male;
                notify_menu_changeGender.Text = "Change to Female";
            }
            else
            {
                this.gender = VoiceGender.Female;
                notify_menu_changeGender.Text = "Change to Male";
            }
        }
    }
}
