namespace Proiect
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.numeProiectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddListButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.baraUtilizatori1 = new Proiect.BaraUtilizatori();
            this.menuStrip1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeProiectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1311, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numeProiectToolStripMenuItem
            // 
            this.numeProiectToolStripMenuItem.Name = "numeProiectToolStripMenuItem";
            this.numeProiectToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.numeProiectToolStripMenuItem.Text = "Meniu";
            // 
            // AddListButton
            // 
            this.AddListButton.Location = new System.Drawing.Point(3, 3);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(75, 23);
            this.AddListButton.TabIndex = 10;
            this.AddListButton.Text = "Adauga lista";
            this.AddListButton.UseVisualStyleBackColor = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.AddListButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1311, 539);
            this.flowLayoutPanel1.TabIndex = 11;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // baraUtilizatori1
            // 
            this.baraUtilizatori1.Dock = System.Windows.Forms.DockStyle.Top;
            this.baraUtilizatori1.Location = new System.Drawing.Point(0, 24);
            this.baraUtilizatori1.Name = "baraUtilizatori1";
            this.baraUtilizatori1.Size = new System.Drawing.Size(1311, 40);
            this.baraUtilizatori1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 603);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.baraUtilizatori1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem numeProiectToolStripMenuItem;
        private BaraUtilizatori baraUtilizatori1;
        private System.Windows.Forms.Button AddListButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

