using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Controls.List;
using Proiect.Controls;

namespace Proiect
{
    public partial class Form1 : Form
    {
        static public string Provider = "Provider = Microsoft.ACE.OLEDB.16.0; Data Source = proiect_csharp.accdb";

        public string titlu = "Proiect C#";
        

        public Form1()
        {
            InitializeComponent();
            this.baraUtilizatori1.SetTitlu(titlu);
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            AddList addList = new AddList(AddListButton);
            this.selectableFlowLayoutPanel1.Controls.Add(addList);
            addList.Focus();   //focus mai intai pe control, si dupa Select pe textbox in constructor
        }
    }
}
