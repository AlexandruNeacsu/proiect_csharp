using Proiect.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Controls.Cards
{
    public partial class CardForm : Form
    {
        Card card;
        Form1 parent;

        public CardForm(Card card, Form1 parent)
        {
            this.card = card;
            this.parent = parent;

            InitializeComponent();

            this.titluTb.Text = card.Nume;
            this.listaLb.Text = $"In lista {card.GetLista().Nume}";

            this.descriereTb.Text = card.Descriere;

            this.dataGridView1.AutoGenerateColumns = true;
            this.dataGridView1.DataSource = card.GetComentarii();
            this.dataGridView1.DataMember = "comentarii";
        }

        private void addCommentBt_Click(object sender, EventArgs e)
        {
            string comentariu = this.comentariuTb.Text;

            if (comentariu != "")
            {
                OleDbConnection connection = new OleDbConnection(Form1.Provider);
                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                try
                {
                    connection.Open();
                    command.Transaction = connection.BeginTransaction();

                    command.CommandText = "INSERT INTO Comentarii (continut, id_card, id_utilizator) VALUES (@comentariu, @idCard, @idUtilizator) ";

                    command.Parameters.Add("comentariu", OleDbType.Char).Value = comentariu;
                    command.Parameters.Add("idCard", OleDbType.Integer).Value = this.card.Id;
                    command.Parameters.Add("idUtilizator", OleDbType.Integer).Value = parent.utilizator.Id;


                    command.ExecuteNonQuery();
                    command.Transaction.Commit();

                    this.dataGridView1.DataSource = this.card.GetComentarii();

                }
                catch (Exception ex)
                {
                    command.Transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    connection.Close();
                }

            }
            else
            {
                errorProvider1.SetError(comentariuTb, "Comentariul nu poate fii gol!");
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            string descriere = this.descriereTb.Text;

            if (descriere != "")
            {

                this.card.Descriere = descriere;
                //this.dataGridView1.DataSource = this.card.GetComentarii();
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            this.card.Delete();
        }
    }
}
