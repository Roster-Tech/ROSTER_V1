using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;
using System.Speech;
using System.Speech.Synthesis;

namespace RosterTech
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("winmm.dll", EntryPoint = "mciSendStringA", ExactSpelling = true, CharSet = CharSet.Ansi, SetLastError = true)]
        private static extern int record(string lpstrCommand, string lpstrReturnString, int uReturnLength, int hwndCallback);
        
        public MainWindow()
        {
            InitializeComponent();
        }


        private void recordStartbtn_click(System.Object sender, System.EventArgs e)
        {
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
        }

        //recordStopbtn_click
        private void recordStopbtn_click(System.Object sender, System.EventArgs e)
        {
            String path = "D:\\Roster\\Project\\Audio";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            record("save recsound D:\\Roster\\Project\\Audio\\mic.wav", "", 0, 0);
            record("close recsound", "", 0, 0);
        }
        
        public static int ExecuteCommand(string commnd, string working_dir)
        {
            var pp = new ProcessStartInfo("cmd.exe", "/C" + commnd)
            {
                CreateNoWindow = true,
                UseShellExecute = false,
                WorkingDirectory = working_dir,
            };
            var process = Process.Start(pp);
            process.WaitForExit();
            process.Close();
            return 0;
        }

        // =========================== Text To Speech ============================== //

        SpeechSynthesizer speechSynthesizerObj;
        private void MainWindow_Load(object sender, EventArgs e)
        {
            speechSynthesizerObj = new SpeechSynthesizer();
            System.Windows.Forms.MessageBox.Show("rohit chouhan");
        }

        private void text_to_speech(String text)
        {
            //String text = "Hello Rohit sir how are you. is there anything I can help you";
            //Disposes the SpeechSynthesizer object   
            speechSynthesizerObj = new SpeechSynthesizer();
            speechSynthesizerObj.Dispose();
            if (text != "")
            {
                speechSynthesizerObj = new SpeechSynthesizer();
                speechSynthesizerObj.SpeakAsync(text);
            }
        }


    }


}
