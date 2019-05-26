using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Proiect.Controls.Card;

namespace Proiect
{
    public partial class List : UserControl
    {
        private int id;
        private string nume;

        public List(int id, string nume)
        {
            this.id = id;
            this.nume = nume;

            InitializeComponent();

            this.titluLb.Text = nume;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string sql = "DELETE FROM Liste WHERE id = " + this.id;

            OleDbCommand command = new OleDbCommand(sql, connection);

            try
            {
                connection.Open();

                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                //reload the lists
                Form1 parent = (Form1) this.ParentForm;
                parent.LoadLists();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.containerButon.Visible = false;

            AddCard addCard = new AddCard(this.containerButon, this.id);

            this.flowLayoutPanel1.Controls.Add(addCard);

        }
    }
}
