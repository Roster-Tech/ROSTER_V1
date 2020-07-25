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


//using System.Runtime.InteropServices;
//using System.Windows.Forms;

using System.Diagnostics;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Runtime.InteropServices;
using System.IO;

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
            //timer1.Enabled = true;
            //timer1.Start();
            record("open new Type waveaudio Alias recsound", "", 0, 0);
            record("record recsound", "", 0, 0);
        }

        //recordStopbtn_click

        private void recordStopbtn_click(System.Object sender, System.EventArgs e)
        {
            //timer1.Stop();
            //timer1.Enabled = false;
            String path = "D:\\Roster\\Project\\Audio";
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            record("save recsound D:\\Roster\\Project\\Audio\\mic.wav", "", 0, 0);
            record("close recsound", "", 0, 0);
        }
    }

    

}
