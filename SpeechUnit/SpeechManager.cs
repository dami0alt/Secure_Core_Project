using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;
using System.Speech.Synthesis;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;

namespace SpeechUnit
{
    public class SpeechManager
    {

        private  SpeechRecognitionEngine recognizer;
        private  Dictionary<string, Action> commands;
        private  Form parentForm;

        private string userName;
        private string userCategory;
        private int accessLevel;
        private Image userProfileImage;

        public SpeechManager(Form form, string username, string category, int level, Image profilePic)
        {
            parentForm = form;
            userName = username;
            userCategory = category;
            accessLevel = level;
            userProfileImage = profilePic;

            recognizer = new SpeechRecognitionEngine(new CultureInfo("en-US"));

            InitializeCommands();
            ConfigureRecognizer();
        }

        private void InitializeCommands()
        {
            commands = new Dictionary<string, Action>(StringComparer.OrdinalIgnoreCase)
            {
                { "close", CloseApp },
                { "time", ShowTime },
                /*{ "user info", ShowUserInfo }*/
            };
        }

        private void ConfigureRecognizer()
        {
            Choices words = new Choices(commands.Keys.ToArray());
            GrammarBuilder gb = new GrammarBuilder();
            gb.Culture = recognizer.RecognizerInfo.Culture;
            gb.Append(words);

            Grammar grammar = new Grammar(gb);
            grammar.Name = "SecureCoreVoiceCommands";
            recognizer.LoadGrammarAsync(grammar);

            recognizer.SetInputToDefaultAudioDevice();
            recognizer.SpeechRecognized += Recognizer_SpeechRecognized;

            recognizer.RecognizeAsync(RecognizeMode.Multiple);
        }

        private void Recognizer_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            string command = e.Result.Text.ToLower();

            if (commands.ContainsKey(command))
            {
                commands[command].Invoke();
            }
        }

        private void CloseApp()
        {
            parentForm.Invoke(new Action(() =>
            {
                parentForm.Close();
                Application.Exit();
            }));
        }

        private void ShowTime()
        {
            string hour = DateTime.Now.ToString("hh:mm tt");
            parentForm.Invoke(new Action(() =>
            {
                MessageBox.Show($"Current time: {hour}", "System Time",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }));
        }

        /*private void ShowUserInfo()
        {
            parentForm.Invoke(new Action(() =>
            {
                FrmUserInfo form = new FrmUserInfo(userName, userCategory, accessLevel.ToString(), userProfileImage);
                form.ShowDialog(parentForm);
            }));
        }
        */

        public void Stop()
        {
            recognizer.RecognizeAsyncStop();
            recognizer.Dispose();
        }
    }
}
