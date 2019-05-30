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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = this.usernameTb.Text;
            string parola = this.parolaTb.Text;

            errorProvider1.Clear();

            if(username == "")
            {
                this.errorProvider1.SetError(usernameTb, "Username nu trebuie sa fie gol!");
            }else if (parola == "")
            {
                this.errorProvider1.SetError(parolaTb, "Parola nu trebuie sa fie goala!");
            }else
            {
                OleDbConnection connection = new OleDbConnection(Form1.Provider);
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;

                try
                {
                    connection.Open();

                    command.CommandText = "SELECT * FROM Utilizatori WHERE nume = @nume AND parola = @parola";

                    command.Parameters.Add("nume", OleDbType.Char).Value = username;
                    command.Parameters.Add("parola", OleDbType.Char).Value = parola;

                    OleDbDataReader reader = command.ExecuteReader();

                    if(!reader.HasRows)
                    {
                        DialogResult result = MessageBox.Show("Parola sau username incorect!", "Ooops...", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                        if(result == DialogResult.Cancel)
                        {
                            this.DialogResult = DialogResult.Cancel;
                        }
                    }
                    else
                    {
                        this.DialogResult = DialogResult.OK;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    connection.Close();
                }

            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUp signUp = new SignUp();

            this.Visible = false;

            signUp.ShowDialog();

            if(signUp.DialogResult == DialogResult.Cancel)
            {
                this.DialogResult = DialogResult.Cancel;
            }
            else
            {
            this.Visible = true;
            }
        }
    }
}
