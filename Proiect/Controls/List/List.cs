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
using System.Drawing.Printing;

namespace Proiect
{
    public partial class List : UserControl
    {
        Lista list;

        private Font printFont;
        private PrintPreviewDialog printPreviewDialog = new PrintPreviewDialog();
        public PrintDocument pd;
        StreamReader streamToPrint = null;

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
                creareTextFile(dialog.FileName);
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

        private void printeazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                creareTextFile("temp\\print.txt");
                streamToPrint = new StreamReader("temp\\print.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            try
            {
                printFont = new Font("Arial", 12);
                pd = new PrintDocument();
                this.pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
                pd.Print();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            streamToPrint.Close();
        }

        private void previozonarePrintareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pd = new PrintDocument();
            printFont = new Font("Arial", 16);

            try
            {
                creareTextFile("temp\\print.txt");
                streamToPrint = new StreamReader("temp\\print.txt");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }

            this.pd.PrintPage += new PrintPageEventHandler(this.PrintPage);
            printPreviewDialog.Document = pd;

            printPreviewDialog.ShowDialog();
            streamToPrint.Close();
        }

        private void PrintPage(object sender, PrintPageEventArgs ev)
        {
            string linie_txt = "Text de scris in documnet";

            SolidBrush pns = new SolidBrush(Color.Red);

            ev.HasMorePages = true;     //daca true => apeleaza din nou PrintPage cand sunt pagini
            float linesPerPage = 0;
            float yPos = 0;
            int count = 10;

            float leftMargin = ev.MarginBounds.Left;
            float topMargin = ev.MarginBounds.Top;

            linie_txt = null;

            linesPerPage = ev.MarginBounds.Height / printFont.GetHeight(ev.Graphics);

            while (count < linesPerPage && (linie_txt = streamToPrint.ReadLine()) != null)
            {
                yPos = topMargin + (count * printFont.GetHeight(ev.Graphics));
                ev.Graphics.DrawString(linie_txt, printFont, Brushes.Black, leftMargin, yPos, new StringFormat());
                count++;
            }

            if (linie_txt != null)
            {
                ev.HasMorePages = true;
            }
            else
            {
                ev.HasMorePages = false;
            }
        }

        void creareTextFile(string path)
        {
            FileStream stream = new FileStream(path, FileMode.Create, FileAccess.Write);
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
                catch (Exception) { }
            }

            sw.Close();
            stream.Close();
        }
    }
}
