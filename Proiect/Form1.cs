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
using System.Data.OleDb;

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
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "SELECT id,nume FROM Liste";

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

                    List list = new List(id, listName);

                    this.selectableFlowLayoutPanel1.Controls.Add(list);
                }


                reader.Close();

                this.selectableFlowLayoutPanel1.Controls.Add(this.AddListButton);
                this.selectableFlowLayoutPanel1.ResumeLayout();
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
}
