using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Controls.List
{
    public partial class AddList : UserControl
    {
        Button addListButton;
        public AddList(Button button)
        {
            addListButton = button;
            InitializeComponent();

            this.ActiveControl = this.textBox1;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

        }

        private void AddList_Leave(object sender, EventArgs e)
        {
            this.addListButton.Visible = true;
            this.Dispose();
        }

        private void AddList_Paint(object sender, PaintEventArgs e)
        {
            this.textBox1.Select();
        }
    }
}
