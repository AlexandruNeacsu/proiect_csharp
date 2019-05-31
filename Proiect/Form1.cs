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
using Proiect.Controls.Auth;
using System.Data.OleDb;
using Proiect.Clase;

namespace Proiect
{
    public partial class Form1 : Form
    {
        //pentru a folosi in diversele apeluri la BD
        static public string Provider = "Provider = Microsoft.ACE.OLEDB.16.0; Data Source = proiect_csharp.accdb";

        public string titlu = "Proiect C#";
        public Utilizator utilizator;


        private void ShowLogin()
        {
            Login login = new Login(this);

            login.ShowDialog();

            if (login.DialogResult == DialogResult.Cancel)
            {
                //daca user alege cancel, inchide aplicatia
                Environment.Exit(-1);   //In constructor nu putem folosi Aplication.Exit
            }
        }

        public Form1()
        {
            ShowLogin();

            InitializeComponent();
            this.baraUtilizatori1.SetTitlu(titlu);
            this.LoadLists();
        }

        private void AddListButton_Click(object sender, EventArgs e)
        {
            AddList addList = new AddList(AddListButton);
            this.selectableFlowLayoutPanel1.Controls.Add(addList);
            addList.Focus();   //focus mai intai pe control, si dupa Select pe textbox in constructor
        }

        public void LoadLists()
        {
            //incarca toate listelele din BD in layout panel
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "SELECT * FROM Liste";

            OleDbCommand command = new OleDbCommand(cmdText, connection);
            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                this.selectableFlowLayoutPanel1.SuspendLayout();
                this.selectableFlowLayoutPanel1.Controls.Clear();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    string listName = reader["nume"].ToString();
                    int idAutor = Convert.ToInt32(reader["id_autor"].ToString());

                    Lista lista = new Lista(id, listName, idAutor);
                    lista.deleted += this.onListDelete;

                    List list = new List(lista);

                    this.selectableFlowLayoutPanel1.Controls.Add(list);
                }


                reader.Close();

                this.selectableFlowLayoutPanel1.Controls.Add(this.AddListButton);
                this.selectableFlowLayoutPanel1.ResumeLayout();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();
            }
        }

        private void onListDelete(Object sender, EventArgs args)
        {
            Lista lista = (Lista) sender;

            List list = (List)this.selectableFlowLayoutPanel1.Controls.Find(lista.Id.ToString(), false)[0];

            this.selectableFlowLayoutPanel1.Controls.Remove(list);

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //ascunde formularul cand user da logout
            this.Visible = false;
            ShowLogin();
            this.Visible = true;
        }
    }
}
