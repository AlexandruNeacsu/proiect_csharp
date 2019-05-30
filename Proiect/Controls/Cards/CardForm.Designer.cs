namespace Proiect.Controls.Cards
{
    partial class CardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.addCommentBt = new System.Windows.Forms.Button();
            this.comentariuTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.descriereTb = new System.Windows.Forms.TextBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.listaLb = new System.Windows.Forms.Label();
            this.titluTb = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(496, 61);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteButton.TabIndex = 27;
            this.DeleteButton.Text = "Sterge Card";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // addCommentBt
            // 
            this.addCommentBt.Location = new System.Drawing.Point(63, 273);
            this.addCommentBt.Name = "addCommentBt";
            this.addCommentBt.Size = new System.Drawing.Size(75, 23);
            this.addCommentBt.TabIndex = 25;
            this.addCommentBt.Text = "Adauga";
            this.addCommentBt.UseVisualStyleBackColor = true;
            this.addCommentBt.Click += new System.EventHandler(this.addCommentBt_Click);
            // 
            // comentariuTb
            // 
            this.comentariuTb.Location = new System.Drawing.Point(63, 213);
            this.comentariuTb.Multiline = true;
            this.comentariuTb.Name = "comentariuTb";
            this.comentariuTb.Size = new System.Drawing.Size(363, 54);
            this.comentariuTb.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Adauga comentariu";
            // 
            // descriereTb
            // 
            this.descriereTb.Location = new System.Drawing.Point(63, 87);
            this.descriereTb.Multiline = true;
            this.descriereTb.Name = "descriereTb";
            this.descriereTb.Size = new System.Drawing.Size(363, 54);
            this.descriereTb.TabIndex = 18;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(63, 147);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 17;
            this.EditButton.Text = "Editeaza";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Descriere";
            // 
            // listaLb
            // 
            this.listaLb.AutoSize = true;
            this.listaLb.Location = new System.Drawing.Point(60, 42);
            this.listaLb.Name = "listaLb";
            this.listaLb.Size = new System.Drawing.Size(35, 13);
            this.listaLb.TabIndex = 15;
            this.listaLb.Text = "label1";
            // 
            // titluTb
            // 
            this.titluTb.BackColor = System.Drawing.SystemColors.Control;
            this.titluTb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.titluTb.Location = new System.Drawing.Point(63, 20);
            this.titluTb.Name = "titluTb";
            this.titluTb.Size = new System.Drawing.Size(99, 13);
            this.titluTb.TabIndex = 14;
            this.titluTb.Text = "Titlu";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 311);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(363, 150);
            this.dataGridView1.TabIndex = 29;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 473);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.addCommentBt);
            this.Controls.Add(this.comentariuTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.descriereTb);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listaLb);
            this.Controls.Add(this.titluTb);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "CardForm";
            this.Text = "Card";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button addCommentBt;
        private System.Windows.Forms.TextBox comentariuTb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox descriereTb;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label listaLb;
        private System.Windows.Forms.TextBox titluTb;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}