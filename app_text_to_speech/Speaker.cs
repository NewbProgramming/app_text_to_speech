using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Net;
using System.Speech.Synthesis;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Media;

namespace app_text_to_speech
{
    class Speaker
    {
        private static SpeechSynthesizer Synth = new SpeechSynthesizer();

        private static string TemporaryFile = 
            Directory.GetCurrentDirectory() + Path.DirectorySeparatorChar +
            "temp.mp3"
        ;

        public static bool UseGoogle = true;

        public static void Speak(VoiceGender gender, string message)
        {
            Synth.SelectVoiceByHints(gender);
            
            UseGoogle = false; // Google's Text-To-Speech API is unavailable.

            Thread t = new Thread(() => {
                if(UseGoogle == true)
                {
                    string uri = 
                        "http://translate.google.com/translate_tts?tl=en&ie=UTF-8&client=t&q=" + 
                        System
                            .Web
                            .HttpUtility
                            .UrlEncode(message)
                            .ToString()
                    ;
                    
                    WebClient client = new WebClient();
                    
                    // Send fake request headers for "authentication".
                    client.Headers["Referer"] = "http://translate.google.com/";
                    client.Headers["User-Agent"] = "stagefright/1.2 (Linux;Android 5.0)";
                    
                    try {
                        client.DownloadFile(uri, TemporaryFile);

                        SoundPlayer sound = new SoundPlayer(TemporaryFile);
                    
                        sound.Play();
                    
                        File.Delete(TemporaryFile);
                    }
                    catch(Exception ex)
                    {
                        UseGoogle = false;
                        
                        System.Windows.Forms.MessageBox.Show(
                            "Turned off Google Text-to-Speech:" + Environment.NewLine + 
                            Environment.NewLine + 
                            ex.Message + Environment.NewLine + 
                            Environment.NewLine + 
                            ex.StackTrace
                        );
                        
                        Synth.Speak(message);
                    }
                }
                else
                {
                    Synth.Speak(message);
                }
            });
            t.Start();
        }

        public static void Speak(VoiceGender gender, string format, params object[] argument_list)
        {
            Speak(gender, string.Format(format, argument_list));
        }
    }
}
