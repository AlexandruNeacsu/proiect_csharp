using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proiect.Clase;

namespace Proiect.Controls.Cards
{
    class CardPreview : Button
    {
        Card card;

        public CardPreview(Clase.Card c) : base()
        {
            this.card = c;

            this.Name = c.Id.ToString();
            this.Text = c.Nume;
            this.BackColor = System.Drawing.SystemColors.ControlLight;

            this.Click += this.ClickHandler;

        }

        private void ClickHandler(object sender, EventArgs e)
        {
            Form1 parent = (Form1) this.FindForm();

            CardForm card = new CardForm(this.card, parent);

            card.ShowDialog();
        }

    }
}
