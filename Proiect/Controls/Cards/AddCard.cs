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

namespace Proiect.Controls.Cards
{
    public partial class AddCard : UserControl
    {
        private Panel containerButon;
        private int idParinte;

        public AddCard(Panel panel, int id)
        {
            this.containerButon = panel;
            this.idParinte = id;

            InitializeComponent();
        }

        private void AddCardBt_Click(object sender, EventArgs e)
        {
            string nume = this.textBox1.Text;

            if (nume != "")
            {
                OleDbConnection connection = new OleDbConnection(Form1.Provider);
                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                try
                {
                    connection.Open();
                    command.Transaction = connection.BeginTransaction();

                    command.CommandText = "INSERT INTO Cards (nume, id_lista) VALUES (@nume, @idLista) ";

                    command.Parameters.Add("nume", OleDbType.Char).Value = nume;
                    command.Parameters.Add("nume", OleDbType.Integer).Value = this.idParinte;

                    command.ExecuteNonQuery();
                    command.Transaction.Commit();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    command.Transaction.Rollback();
                }
                finally
                {
                    connection.Close();

                    //refresh the layout panel
                    Form1 parent = (Form1)this.ParentForm;
                    parent.LoadLists();

                    this.containerButon.Visible = true;
                    this.Dispose();
                }

            }
            else
            {
                errorProvider1.SetError(textBox1, "Va rugam sa setati un nume!");
            }
        }

        private void anuleazabt_Click(object sender, EventArgs e)
        {
            this.containerButon.Visible = true;
            this.Dispose();
        }
    }
}
