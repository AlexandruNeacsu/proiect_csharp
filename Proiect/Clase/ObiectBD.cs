using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.Clase
{
    public abstract class ObiectBD
    {

        public delegate void DeleteEventHandler(Object sender, EventArgs args);
        public event DeleteEventHandler deleted;

        protected void onDeleted(Object source, EventArgs args)
        {
            if (this.deleted != null)
            {
                deleted(this, EventArgs.Empty);
            }
        }


        public abstract void Delete();



    }
}
