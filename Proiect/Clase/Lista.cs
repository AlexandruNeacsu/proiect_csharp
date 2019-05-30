using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    public class Lista
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

    }
}
