using System;
using System.Windows.Forms;
using test;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();

        // Splash aç
        using (SplashForm splash = new SplashForm())
        {
            splash.ShowDialog();
        }

        // Ardından ana formu aç
        Application.Run(new Form1());
    }
}
