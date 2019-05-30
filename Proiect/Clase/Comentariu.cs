using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    public class Comentariu
    {
        private int id;
        private string continut;
        private int idCard;
        private int idUtilizator;

        public Comentariu(int id, string continut, int idCard, int idUtilizator)
        {
            this.id = id;
            this.continut = continut;
            this.idCard = idCard;
            this.idUtilizator = idUtilizator;
        }
    }
}
