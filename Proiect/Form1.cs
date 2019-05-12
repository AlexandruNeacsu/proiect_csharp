using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class Form1 : Form
    {
        public string titlu = "Proiect C#";
        public Form1()
        {
            InitializeComponent();
            this.baraUtilizatori1.SetTitlu(titlu);
        }


    }
}
