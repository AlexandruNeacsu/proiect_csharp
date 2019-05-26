using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Controls.Card
{
    class CardPreview : Button
    {
        private int id;
        private string nume;
        private string descriere;
        
        public CardPreview(int id, string nume, string descriere) : base()
        {
            this.id = id;
            this.nume = nume;
            this.descriere = descriere;

            this.Name = "CardPreviewName:" + nume;
            this.Text = nume;
            this.BackColor = System.Drawing.SystemColors.ControlLight;

            this.Click += this.ClickHandler;

        }

        private void ClickHandler(object sender, EventArgs e)
        {
            Card card = new Card();

            card.ShowDialog();
        }
    }
}
