using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace SnowDev_Laucnher
{
    public partial class SplashScreen : Form
    {
        Launcher launcher = new Launcher();

        public SplashScreen()
        {
            InitializeComponent();

            Shown += new EventHandler(Form1_Shown);

            this.TransparencyKey = (BackColor);
            this.ShowInTaskbar = false;
        }

        void Form1_Shown(Object sender, EventArgs e)
        {
            var requisicaoWeb = WebRequest.Create("http://jsonplaceholder.typicode.com/posts/1");
            requisicaoWeb.Method = "GET";
            requisicaoWeb.GetResponse();

            this.Visible = false;

            this.Hide();

            launcher.Closed += (s, args) => this.Close();
            launcher.Show();
        }
    }
}
