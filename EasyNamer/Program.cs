using System;
using System.Windows.Forms;
using System.Collections.Generic;

namespace EasyNamer
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        static int clickCount = 0;
        static Timer timer = new Timer();
        static public List<string> Messages = new List<string>();

        static public void TripleClick(TextBox tb)
        {
            timer.Stop();
            clickCount++;
            if (clickCount == 3) {
                tb.SelectAll();
                clickCount = 0;
            } else if (clickCount < 3) {
                timer.Interval = 300;
                timer.Start();
                timer.Tick += (s, t) => {
                    timer.Stop();
                    clickCount = 0;
                };
            }
        }
    }
}
