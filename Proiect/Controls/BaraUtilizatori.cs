using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect
{
    public partial class BaraUtilizatori : UserControl
    {
        public string titlu = "Proiect";

        public BaraUtilizatori()
        {
            InitializeComponent();
            //Form1 parinte = (Form1)this.ParentForm;
            //this.labelTitlu.Text = parinte.titlu;
        }

        public void SetTitlu(string titlu)
        {
            this.labelTitlu.Text = titlu;
        }
    }
}
