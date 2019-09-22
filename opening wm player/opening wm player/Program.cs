using System;
using System.Diagnostics;

namespace opening_wm_player
{
    class Program
    {
        static void Main(string[] args)
        {
            Process myprocess = new Process();
            myprocess.StartInfo.FileName = "wmplayer.exe";
            myprocess.StartInfo.Arguments = "\"F:\\PROGRAMMING VIDEOS\\C# Videos\\C# Events and Delegates Made Simple _ Mosh.mp4\"";
            myprocess.Start();
        }
    }
}
