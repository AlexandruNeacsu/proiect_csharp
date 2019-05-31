using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    public class Lista : ObiectBD
    {
        private int id;
        private string nume;
        private int idAutor;

        public Lista(int id, string nume, int idAutor)
        {
            this.id = id;
            this.nume = nume;
            this.idAutor = idAutor;
        }

        public int IdAutor
        {
            get { return idAutor; }
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public override void Delete()
        {
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "DELETE FROM Liste WHERE id = " + this.id;

            OleDbCommand command = new OleDbCommand(cmdText, connection);

            try
            {
                connection.Open();
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                connection.Close();

                //apeleaza toti abonati;
                this.onDeleted(this, EventArgs.Empty);
            }
        }

        public List<Card> GetCards()
        {
            List<Card> lista = new List<Card>();

            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "SELECT * FROM Cards WHERE id_lista = " + this.Id;

            OleDbCommand command = new OleDbCommand(cmdText, connection);

            try
            {
                connection.Open();
                OleDbDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    string numeCard = reader["nume"].ToString();
                    string descriere = reader["descriere"].ToString();
                    bool completat = Convert.ToBoolean(reader["completat"].ToString());
                    int idLista = Convert.ToInt32(reader["id_lista"].ToString());

                    Card card = new Card(id, numeCard, descriere, completat, idLista);
                    lista.Add(card);
                }


                reader.Close();
                return lista;
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
    }
}
