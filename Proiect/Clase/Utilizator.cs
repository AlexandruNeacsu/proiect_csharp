using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    public class Utilizator : ObiectBD, ICloneable, IComparable<Utilizator>
    {
        public List<Utilizator> utilizatori = new List<Utilizator>();

        private int id;

        private string nume;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }



        public int Id { get => id; }

        public Utilizator(int id, string nume)
        {
            this.id = id;
            this.Nume = nume;
        }


        public object Clone()
        {
            return new Utilizator(this.id, this.Nume);
        }

        public int CompareTo(Utilizator other)
        {
            return this.id.CompareTo(other.id);
        }

        public override void Delete()
        {
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "DELETE FROM Utilizatori WHERE id = " + this.id;

            OleDbCommand command = new OleDbCommand(cmdText, connection);

            command.ExecuteNonQuery();

            try
            {
                connection.Open();

            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
                this.onDeleted(this, EventArgs.Empty);
            }
        }
    }
}
