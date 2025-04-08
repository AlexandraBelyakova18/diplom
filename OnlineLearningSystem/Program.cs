using System;
using System.Windows.Forms;

namespace OnlineLearningSystem
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.MainMenuForm());
        }
    }
}
