using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Clase
{
    public class Card : ObiectBD, IDetalii, ICloneable, IComparable<Card>
    {
        private int id;
        private string nume;
        private string descriere;
        private bool completat;
        private int idLista;

        public int Id { get => id; }

        public int IdLista{ get => idLista; }

        public string Nume {
            get => nume;
            set => setStringField("Nume", value);
        }

        public string Descriere
        {
            get => descriere;
            set => setStringField("descriere", value);
        }

        public bool Completat
        {
            get => completat;
            set
            {
                OleDbConnection connection = new OleDbConnection(Form1.Provider);
                OleDbCommand command = new OleDbCommand();

                command.Connection = connection;

                try
                {
                    connection.Open();
                    command.Transaction = connection.BeginTransaction();

                    command.CommandText = "UPDATE Cards SET completat = @completat";

                    command.Parameters.Add("completat", OleDbType.Char).Value = value;

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
                }
            }
        }

        public Card(int id, string nume, string descriere, bool completat, int idLista)
        {
            this.id = id;
            this.nume = nume;
            this.descriere = descriere;
            this.completat = completat;
            this.idLista = idLista;
        }

        public static Card operator ++(Card c)
        {
            c.Completat = true;
            return c;
        }

        public static Card operator --(Card c)
        {
            c.Completat = false;
            return c;
        }

        public object Clone()
        {
            return new Card(this.id, this.nume, this.descriere, this.completat, this.IdLista);
        }

        public int CompareTo(Card c)
        {
            return this.id.CompareTo(c.id);

        }

        public DataSet GetComentarii()
        {

            OleDbConnection connection = new OleDbConnection(Form1.Provider);
            OleDbDataAdapter adapter = new OleDbDataAdapter("SELECT u.nume, c.continut FROM Comentarii c INNER JOIN Utilizatori u ON c.id_utilizator = u.id WHERE id_card = " + this.id, connection);

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet, "comentarii");

            connection.Close();

            return dataSet;
        }

        public List<Utilizator> GetAutori()
        {
            List<Utilizator> utilizatori = new List<Utilizator>();

            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "SELECT * FROM Utilizatori WHERE id_utilizator IN (SELECT id_utilizator FROM comentarii WHERE id_card = ?)";

            OleDbCommand command = new OleDbCommand(cmdText, connection);

            try
            {
                connection.Open();

                command.Parameters.Add("id_card", OleDbType.Integer).Value = this.id;

                OleDbDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    int id = Convert.ToInt32(reader["id"].ToString());
                    string nume = reader["nume"].ToString();


                    Utilizator utilizator = new Utilizator(id, nume);

                    utilizatori.Add(utilizator);

                }


                reader.Close();
                return utilizatori;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        void setStringField(string columnName, string valoare)
        {
            OleDbConnection connection = new OleDbConnection(Form1.Provider);
            OleDbCommand command = new OleDbCommand();

            command.Connection = connection;

            try
            {

                connection.Open();
                command.Transaction = connection.BeginTransaction();

                command.CommandText = "UPDATE Cards SET " + columnName + " = @parametru WHERE id = @idCard";

                command.Parameters.Add("parametru", OleDbType.Char).Value = valoare;
                command.Parameters.Add("idCard", OleDbType.Integer).Value = this.id;

                command.ExecuteNonQuery();
                command.Transaction.Commit();

                this.descriere = valoare;

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

        public Utilizator getAutor()
        {
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "SELECT * FROM Utilizatori WHERE id_utilizator = (SELECT id_utilizator FROM Liste WHERE id = @idLista)";

            OleDbCommand command = new OleDbCommand(cmdText, connection);

            try
            {
                connection.Open();

                command.Parameters.Add("idLista", OleDbType.Integer).Value = this.IdLista;

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                int id = Convert.ToInt32(reader["id"].ToString());
                string nume = reader["nume"].ToString();

                Utilizator utilizator = new Utilizator(id, nume);


                reader.Close();
                return utilizator;
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

        public Lista GetLista()
        {
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "SELECT * FROM Liste WHERE id = @idLista";

            OleDbCommand command = new OleDbCommand(cmdText, connection);

            try
            {
                connection.Open();

                command.Parameters.Add("idLista", OleDbType.Integer).Value = this.idLista;

                OleDbDataReader reader = command.ExecuteReader();
                reader.Read();

                int id = Convert.ToInt32(reader["id"].ToString());
                string nume = reader["nume"].ToString();
                int idAutor = Convert.ToInt32(reader["id_autor"].ToString());

                Lista lista = new Lista(id, nume, idAutor);

                reader.Close();
                return lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            finally
            {
                connection.Close();
            }
        }

        public override void Delete()
        {
            OleDbConnection connection = new OleDbConnection(Form1.Provider);

            string cmdText = "DELETE FROM Cards WHERE id = " + this.id;

            OleDbCommand command = new OleDbCommand(cmdText, connection);


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

                this.onDeleted(this, EventArgs.Empty);
            }
        }
    }
}
