using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CampusDeneme._02
{
        public partial class Contact : Form
        {
            public Contact()
            {
                InitializeComponent();
            }

            private void btnMain_Click(object sender, EventArgs e)
            {
                MainPage mainPage = new MainPage();
                mainPage.Show();
                this.Hide();
            }

            private void pictureMap_Click(object sender, EventArgs e)
            {

            }

            private void button1_Click(object sender, EventArgs e)
            {
                string url = "http://webmail.ikc.edu.tr/";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }

            private void button2_Click(object sender, EventArgs e)
            {
                string url = "https://akillikart.ikc.edu.tr/Login";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }

            private void button3_Click(object sender, EventArgs e)
            {
                string url = "https://ubs.ikc.edu.tr/";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }

            private void button4_Click(object sender, EventArgs e)
            {
                string url = "https://ikcu.edu.tr/Duyuru/";
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }
}
