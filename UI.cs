using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

class UI: Form {
    public UI() {
        Text = "UI Window";
        Size = new Size(100, 300);
        FormBorderStyle = FormBorderStyle.FixedToolWindow;
        
        int MaxColor = Color.White.ToArgb();
        
        for (var i = 0; i <= MaxColor; i++) {
            BackColor = Color.FromArgb(i);
            Thread.Sleep(1000);
        }
    }
}

class Program {
    [STAThread]
    static void Main() {
        Application.EnableVisualStyles();
        Application.Run(new UI());
    }
}
