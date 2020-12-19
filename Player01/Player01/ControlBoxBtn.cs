using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Player01
{
    class ControlBoxBtn
    {
        public void FullScreen(Form Form1)
        {
            Form1.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Form1.Left = Form1.Top = 0;
            Form1.Width = Screen.PrimaryScreen.WorkingArea.Width;
            Form1.Height = Screen.PrimaryScreen.WorkingArea.Height;
        }
        // создать функцию, которая вернет прежнее состоянии окна 
        public void CloseScreen(Form Form1)
        {
            Form1.Close();
        }
    }
}
