using Proiect.Clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect.Controls.Cards
{
    public partial class CardForm : Form
    {
        Card card;

        public CardForm(Card card)
        {
            this.card = card;

            InitializeComponent();

            this.titluTb.Text = card.Nume;
            this.listaLb.Text = $"In lista {card.GetLista().Nume}";

            this.descriereTb.Text = card.Descriere;
            this.
        }
    }
}
