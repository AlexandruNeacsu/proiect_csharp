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
        public Card card;

        public CardPreview(Clase.Card c) : base()
        {
            this.card = c;

            this.Name = c.Id.ToString();
            this.Text = c.Nume;

            if (card.Completat)
            {
                this.BackColor = System.Drawing.SystemColors.ControlDark;
            }
            else
            {
                this.BackColor = System.Drawing.SystemColors.ControlLight;
            }


            this.MouseDown += this.CardPreview_MouseDown;
            this.Click += this.ClickHandler;

        }

        private void ClickHandler(object sender, EventArgs e)
        {
            Form1 parent = (Form1) this.FindForm();

            CardForm card = new CardForm(this.card, parent);

            card.ShowDialog();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CardPreview
            // 
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CardPreview_MouseDown);
            this.ResumeLayout(false);

        }

        private void CardPreview_MouseDown(object sender, MouseEventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Control))
            {
                DoDragDrop(this.card, DragDropEffects.Move);
            }
        }
    }
}
