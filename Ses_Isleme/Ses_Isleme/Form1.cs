using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Recognition;
using SpeechLib;

namespace Ses_Isleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SpVoice sp = new SpVoice();

        private void button1_Click(object sender, EventArgs e)
        {
            SpeechRecognitionEngine sr = new SpeechRecognitionEngine();
            Grammar g = new DictationGrammar();
            sr.LoadGrammar(g);

            try
            {
                button1.Text = "Konuşun";
                sr.SetInputToDefaultAudioDevice();
                RecognitionResult res = sr.Recognize();
                button1.Text = res.Text;
            }
            catch (Exception)
            {
                button1.Text = "Anlaşılamadı";
            }
        }

        private void button1_TextChanged(object sender, EventArgs e)
        {
            if (button1.Text == "Hello")
            {
                
                label1.Text = "Hello how can I help you?";
                sp.Speak("Hello how can I help you?");
            }

            if (button1.Text == "What is your name")
            {

                label1.Text = "My name is  Assistant";
                sp.Speak("My name is Busenin Assistant");
            }

            if (button1.Text == "How are you")
            {

                label1.Text = "I am fine thank you. How are you?";
                sp.Speak("I'm fine thank you. How are you?");
            }
            if (button1.Text == "Thank you")
            {

                label1.Text = "I thank you. It was nice to talk to you.";
                sp.Speak("I thank you. It was nice to talk to you.");
            }
           

            if (button1.Text == "Black")
            {

                label1.Text = "Black";
                sp.Speak("Here the black color is displayed");
                BackColor = Color.Black;
            }

            if (button1.Text == "Yellow")
            {

                label1.Text = "Yellow";
                sp.Speak("Here the yellow color is displayed");
                BackColor = Color.Yellow;
            }

            if (button1.Text == "Red")
            {

                label1.Text = "Red";
                sp.Speak("Here the red color is displayed");
                BackColor = Color.Red;
            }
            if (button1.Text == "Blue")
            {

                label1.Text = "Blue";
                sp.Speak("Here the blue color is displayed");
                BackColor = Color.Blue;
            }

       
            if (button1.Text == "Germany")
            {
                sp.Speak("You can view everything about Germany here");
                label1.Text = "You can view everything about Germany here";
                webBrowser1.Navigate("https://www.google.com/search?q=Germany&safe=strict&bih=657&biw=1366&hl=en&sxsrf=ALeKk03kPz1FyloOBT4-PCZDfqxjVr5Zpg%3A1618710503909&ei=5497YL_yNtW73AOYv6voAQ&oq=Germany&gs_lcp=Cgdnd3Mtd2l6EANQ5Y0LWKCWC2C2pQtoAHACeACAAf8liAH_JZIBAzktMZgBAKABAaoBB2d3cy13aXrAAQE&sclient=gws-wiz&ved=0ahUKEwj_gdHE1obwAhXVHXcKHZjfCh0Q4dUDCA4&uact=5");
                
            }

            if (button1.Text == "Turkey")
            {
                sp.Speak("You can view everything about Turkey here");
                label1.Text = "You can view everything about Turkey here";
                webBrowser1.Navigate("https://www.google.com/search?q=T%C3%BCrkiye&oq=T%C3%BCrkiye&aqs=chrome..69i57j0i271l3j69i60j69i61l2.3641j0j7&sourceid=chrome&ie=UTF-8");

            }
            if (button1.Text == "Tokyo")
            {
                sp.Speak("You can view everything about Tokyo here");
                label1.Text = "You can view everything about Tokyo here";
                webBrowser1.Navigate("https://www.google.com/search?q=Tokyo&safe=strict&bih=657&biw=1366&hl=en&sxsrf=ALeKk01f4brLiXe3XOOGj32d0qgq4bX7cg%3A1618698953850&ei=yWJ7YNajM9WHwPAPqoiC4AQ&oq=Tokyo&gs_lcp=Cgdnd3Mtd2l6EAMyBwgjELADECcyBwgjELADECcyBwgjELADECcyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsAMyBwgAEEcQsANQ3uO4BVjK-LgFYLj5uAVoAXACeACAAZMDiAGTA5IBAzQtMZgBAKABAaoBB2d3cy13aXrIAQrAAQE&sclient=gws-wiz&ved=0ahUKEwiWrJHBq4bwAhXVAxAIHSqEAEwQ4dUDCA4&uact=5");
                
            }
            if (button1.Text == "University")
            {
                webBrowser1.Navigate("https://www.google.com/search?q=aksaray+%C3%BCniversitesi&safe=strict&bih=657&biw=1366&hl=en&sxsrf=ALeKk01xsYCrwvIx_gqtfsoZHv9_Ov6dJQ%3A1618711925014&ei=dZV7YK4Wt-Dv9Q-7oLjYBA&gs_ssp=eJzj4tLP1TdIt6xKjzcwYPQSTcwuTixKrFQ4vCcvsyy1qDizJLU4EwDRfAzw&oq=Aksaray+&gs_lcp=Cgdnd3Mtd2l6EAEYBjIGCCMQJxATMgQIIxAnMgQIIxAnMgUIABDLATIFCC4QywEyBQguEMsBMgUILhDLATIFCAAQywEyBQgAEMsBMgUIABDLAToFCAAQkQI6CwguEMcBEKMCEJECOgIIADoICC4QxwEQowI6AgguOgcIABCHAhAUULKcZFiFp2Rg1sFkaABwAngAgAHvA4gBgBOSAQkwLjMuMy4yLjGYAQCgAQGqAQdnd3Mtd2l6wAEB&sclient=gws-wiz");
                sp.Speak("You can view everything about University Aksaray here");
            }

            if (button1.Text == "Software")
            {
                webBrowser1.Navigate(" https://www.google.com/search?q=Yaz%C4%B1l%C4%B1m+nedir&safe=strict&bih=657&biw=1366&hl=en&sxsrf=ALeKk03MFigUxRm8aMkNsDmqTOUNvBpkSw%3A1618711280900&ei=8JJ7YLihNuePrgSdlZ7ABQ&oq=Yaz%C4%B1l%C4%B1m+nedir&gs_lcp=Cgdnd3Mtd2l6EAMyCggAEMsBEEYQ-QEyBQgAEMsBMgUIABDLATIFCAAQywEyBQgAEMsBMgUIABDLATIFCAAQywEyBQgAEMsBMgUIABDLATIFCAAQywE6BwgAEEcQsANQvDZYxkNgqkRoAXACeACAAcwCiAHrCZIBBzAuNC4xLjGYAQCgAQGqAQdnd3Mtd2l6yAEIwAEB&sclient=gws-wiz&ved=0ahUKEwi42ZC32YbwAhXnh4sKHZ2KB1gQ4dUDCA4&uact=5");
                sp.Speak("You can view everything about Software here");
            }

            if (button1.Text == "Google")
            {   
                label1.Text = "Google opens";
                System.Diagnostics.Process.Start("chrome.exe");
            }

            if (button1.Text == "Capital")
            {
                label1.Text = "Turkey's capital, Ankara";
                linkLabel1.Text = "Ankara View";
            }

            if(button1.Text == "Paint")
            {
                System.Diagnostics.Process.Start("mspaint.exe");
            }
        }
       
        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
               if(richTextBox1.Text == "Google" || richTextBox1.Text == "google")
                {
                    sp.Speak("Opens Chrome");
                    System.Diagnostics.Process.Start("chrome.exe");
                }

                if (richTextBox1.Text == "Paint" || richTextBox1.Text == "paint")
                {
                    sp.Speak("Opens Paint");
                    System.Diagnostics.Process.Start("mspaint.exe");
                }
                if (richTextBox1.Text == "University" || richTextBox1.Text == "university")
                {
                    sp.Speak("You can view everything about University Aksaray here ");
                    webBrowser1.Navigate("https://www.google.com/search?q=aksaray+%C3%BCniversitesi&safe=strict&bih=657&biw=1366&hl=en&sxsrf=ALeKk01xsYCrwvIx_gqtfsoZHv9_Ov6dJQ%3A1618711925014&ei=dZV7YK4Wt-Dv9Q-7oLjYBA&gs_ssp=eJzj4tLP1TdIt6xKjzcwYPQSTcwuTixKrFQ4vCcvsyy1qDizJLU4EwDRfAzw&oq=Aksaray+&gs_lcp=Cgdnd3Mtd2l6EAEYBjIGCCMQJxATMgQIIxAnMgQIIxAnMgUIABDLATIFCC4QywEyBQguEMsBMgUILhDLATIFCAAQywEyBQgAEMsBMgUIABDLAToFCAAQkQI6CwguEMcBEKMCEJECOgIIADoICC4QxwEQowI6AgguOgcIABCHAhAUULKcZFiFp2Rg1sFkaABwAngAgAHvA4gBgBOSAQkwLjMuMy4yLjGYAQCgAQGqAQdnd3Mtd2l6wAEB&sclient=gws-wiz");
                }
                if (richTextBox1.Text == "Türkiye" || richTextBox1.Text == "türkiye" || richTextBox1.Text == "Turkey" || richTextBox1.Text == "turkey")
                {
                    sp.Speak("You can view everything about Turkey here");
                    label1.Text = "You can view everything about Turkey here";
                    webBrowser1.Navigate("https://www.google.com/search?q=T%C3%BCrkiye&oq=T%C3%BCrkiye&aqs=chrome..69i57j0i271l3j69i60j69i61l2.3641j0j7&sourceid=chrome&ie=UTF-8");
                    
                }
                if (richTextBox1.Text == "Software" || richTextBox1.Text == "Yazılım" || richTextBox1.Text == "software" || richTextBox1.Text == "yazılım")
                {
                    sp.Speak("You can view everything about Software here");
                    label1.Text = "You can view everything about Turkey here";
                    webBrowser1.Navigate(" https://www.google.com/search?q=Yaz%C4%B1l%C4%B1m+nedir&safe=strict&bih=657&biw=1366&hl=en&sxsrf=ALeKk03MFigUxRm8aMkNsDmqTOUNvBpkSw%3A1618711280900&ei=8JJ7YLihNuePrgSdlZ7ABQ&oq=Yaz%C4%B1l%C4%B1m+nedir&gs_lcp=Cgdnd3Mtd2l6EAMyCggAEMsBEEYQ-QEyBQgAEMsBMgUIABDLATIFCAAQywEyBQgAEMsBMgUIABDLATIFCAAQywEyBQgAEMsBMgUIABDLATIFCAAQywE6BwgAEEcQsANQvDZYxkNgqkRoAXACeACAAcwCiAHrCZIBBzAuNC4xLjGYAQCgAQGqAQdnd3Mtd2l6yAEIwAEB&sclient=gws-wiz&ved=0ahUKEwi42ZC32YbwAhXnh4sKHZ2KB1gQ4dUDCA4&uact=5");
                   
                }
            }
            catch (Exception)
            {

                throw;
            }
            sp.Speak(richTextBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

      
    }
}
