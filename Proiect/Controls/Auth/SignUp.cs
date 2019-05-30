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

namespace Proiect.Controls.Auth
{
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.usernameTb.Text;
            string parola = this.parolaTb.Text;

            errorProvider1.Clear();

            if (username == "")
            {
                this.errorProvider1.SetError(usernameTb, "Username nu trebuie sa fie gol!");
            }
            else if (parola == "")
            {
                this.errorProvider1.SetError(parolaTb, "Parola nu trebuie sa fie goala!");
            }
            else
            {
                OleDbConnection connection = new OleDbConnection(Form1.Provider);
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                try
                {
                    connection.Open();

                    command.Transaction = connection.BeginTransaction();    

                    command.CommandText = "SELECT * FROM Utilizatori WHERE nume = @nume";

                    command.Parameters.Add("nume", OleDbType.Char).Value = username;

                    OleDbDataReader reader = command.ExecuteReader();
                    bool hasRows = reader.HasRows;
                    reader.Close();

                    if (hasRows) 
                    {
                        DialogResult result = MessageBox.Show("Username deja folosit! Incearca alt username", "Ooops...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if (result == DialogResult.Cancel)
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        command.CommandText = "INSERT INTO Utilizatori (nume, parola) VALUES (@nume, @parola)";

                        command.Parameters.Add("nume", OleDbType.Char).Value = username;
                        command.Parameters.Add("parola", OleDbType.Char).Value = parola;

                        command.ExecuteNonQuery();

                        command.Transaction.Commit();

                        MessageBox.Show("Utilizator creat!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    command.Transaction.Rollback();
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}
