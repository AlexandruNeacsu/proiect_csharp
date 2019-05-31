using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using Proiect.Controls.Cards;
using Proiect.Clase;
using System.IO;
using System.Xml;

namespace Proiect
{
    public partial class List : UserControl
    {
        Lista list;

        public List(Lista list)
        {
            this.list = list;

            InitializeComponent();

            this.Name = list.Id.ToString();
            this.titluLb.Text = list.Nume;

            this.LoadCards();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.list.Delete();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //inlocuieste butonul de adaugare cu un alt control
            this.containerPanel.Visible = false;

            AddCard addCard = new AddCard(this.containerPanel, this.list.Id);

            this.flowLayoutPanel1.Controls.Add(addCard);

        }

        public void LoadCards()
        {
            //opreste layout panel din a face calculele pentru a determina pozitia obiectului inserat
            //imbunatateste performanta
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.Controls.Clear();

            foreach (Card card in this.list.GetCards())
            {
                card.deleted += this.onCardDelete;

                CardPreview cardPreview = new CardPreview(card);

                this.flowLayoutPanel1.Controls.Add(cardPreview);
            }

            //adauga la sfarsit butonul de "adauga card"
            this.flowLayoutPanel1.Controls.Add(this.containerPanel);
            this.flowLayoutPanel1.ResumeLayout();
        }


        private void onCardDelete(Object sender, EventArgs args)
        {
            //gasete cardul ce a fost sters, si scoate din flowlayout pentru a sincroniza cu BD
            Card card = (Card)sender;

            CardPreview preview = (CardPreview) this.flowLayoutPanel1.Controls.Find(card.Id.ToString(), false)[0];

            this.flowLayoutPanel1.Controls.Remove(preview);

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            this.list.Delete();
        }

        private void exportaTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "Text files (*.txt) | *.txt";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                FileStream stream = new FileStream(dialog.FileName, FileMode.Create, FileAccess.Write);
                StreamWriter sw = new StreamWriter(stream);

                string line = $"{list.Id},{list.Nume},{list.IdAutor}";
                sw.WriteLine(line);

                foreach (Object obj in this.flowLayoutPanel1.Controls)
                {
                    try
                    {
                        CardPreview preview = (CardPreview)obj;

                        Card card = preview.card;

                        line = $"   Id:{card.Id}, Nume: {card.Nume}, Descriere: {card.Descriere}";
                        sw.WriteLine(line);
                    }
                    catch (Exception){}
                }

                sw.Close();
                stream.Close();
            }
        }

        private void List_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void List_DragDrop(object sender, DragEventArgs e)
        {
            Card card = (Card)e.Data.GetData(typeof(Card));

            card.IdLista = this.list.Id;

            Form1 parent = (Form1) this.FindForm();

            //reincarca toate listele, pentru a vizualiza corect modificarea
            parent.LoadLists();
        }

        private void exportaXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            dialog.Filter = "XML files (*.xml) | *.xml";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;

                XmlWriter writer = XmlWriter.Create(dialog.FileName, settings);

                writer.WriteStartDocument();
                writer.WriteStartElement("Lista");
                writer.WriteAttributeString("id", this.list.Id.ToString());
                writer.WriteAttributeString("nume", this.list.Nume);

                foreach (Card card in this.list.GetCards())
                {
                    writer.WriteStartElement("id");
                    writer.WriteValue(card.Id.ToString());
                    writer.WriteEndElement();

                    writer.WriteStartElement("nume");
                    writer.WriteValue(card.Nume);
                    writer.WriteEndElement();

                    writer.WriteStartElement("continut");
                    writer.WriteValue(card.Descriere);
                    writer.WriteEndElement();

                }

                writer.WriteEndElement();
                writer.WriteEndDocument();

                writer.Close();
            }
        }
    }
}
