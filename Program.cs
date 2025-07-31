using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyWinFormsApp
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }

    public class MainForm : Form
    {
        public MainForm()
        {
            this.Text = "Hello World";
            this.Size = new Size(400, 300);
            this.StartPosition = FormStartPosition.CenterScreen;

            var label = new Label
            {
                Text = "Hello, Windows Forms!",
                AutoSize = true,
                Location = new Point(100, 100),
            };

            this.Controls.Add(label);
        }
    }
}