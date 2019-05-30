namespace Proiect.Controls.Cards
{
    partial class AddCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.AddCardBt = new System.Windows.Forms.Button();
            this.anuleazabt = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(3, 3);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(223, 52);
            this.textBox1.TabIndex = 0;
            // 
            // AddCardBt
            // 
            this.AddCardBt.Location = new System.Drawing.Point(3, 61);
            this.AddCardBt.Name = "AddCardBt";
            this.AddCardBt.Size = new System.Drawing.Size(121, 23);
            this.AddCardBt.TabIndex = 1;
            this.AddCardBt.Text = "Adauga card";
            this.AddCardBt.UseVisualStyleBackColor = true;
            this.AddCardBt.Click += new System.EventHandler(this.AddCardBt_Click);
            // 
            // anuleazabt
            // 
            this.anuleazabt.Location = new System.Drawing.Point(130, 61);
            this.anuleazabt.Name = "anuleazabt";
            this.anuleazabt.Size = new System.Drawing.Size(75, 23);
            this.anuleazabt.TabIndex = 2;
            this.anuleazabt.Text = "Anuleaza";
            this.anuleazabt.UseVisualStyleBackColor = true;
            this.anuleazabt.Click += new System.EventHandler(this.anuleazabt_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // AddCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.anuleazabt);
            this.Controls.Add(this.AddCardBt);
            this.Controls.Add(this.textBox1);
            this.Name = "AddCard";
            this.Size = new System.Drawing.Size(229, 87);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button AddCardBt;
        private System.Windows.Forms.Button anuleazabt;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
