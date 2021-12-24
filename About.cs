using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursovoi_proekt
{
    public partial class About : Form
    {
        private const string filepath = "index.html";
        public About()
        {
            InitializeComponent();
            string html = File.ReadAllText(filepath);
            webBrowser1.DocumentText = html;
        }
    }
}
