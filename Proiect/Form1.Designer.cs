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
            this.selectableFlowLayoutPanel1 = new Proiect.Controls.SelectableFlowLayoutPanel();
            this.AddListButton = new System.Windows.Forms.Button();
            this.baraUtilizatori1 = new Proiect.BaraUtilizatori();
            this.menuStrip1.SuspendLayout();
            this.selectableFlowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numeProiectToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1748, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // numeProiectToolStripMenuItem
            // 
            this.numeProiectToolStripMenuItem.Name = "numeProiectToolStripMenuItem";
            this.numeProiectToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.numeProiectToolStripMenuItem.Text = "Meniu";
            // 
            // selectableFlowLayoutPanel1
            // 
            this.selectableFlowLayoutPanel1.AutoScroll = true;
            this.selectableFlowLayoutPanel1.Controls.Add(this.AddListButton);
            this.selectableFlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.selectableFlowLayoutPanel1.Location = new System.Drawing.Point(0, 77);
            this.selectableFlowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.selectableFlowLayoutPanel1.Name = "selectableFlowLayoutPanel1";
            this.selectableFlowLayoutPanel1.Size = new System.Drawing.Size(1748, 665);
            this.selectableFlowLayoutPanel1.TabIndex = 11;
            this.selectableFlowLayoutPanel1.WrapContents = false;
            // 
            // AddListButton
            // 
            this.AddListButton.Location = new System.Drawing.Point(4, 4);
            this.AddListButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddListButton.Name = "AddListButton";
            this.AddListButton.Size = new System.Drawing.Size(117, 28);
            this.AddListButton.TabIndex = 10;
            this.AddListButton.Text = "Adauga o lista";
            this.AddListButton.UseVisualStyleBackColor = true;
            this.AddListButton.Click += new System.EventHandler(this.AddListButton_Click);
            // 
            // baraUtilizatori1
            // 
            this.baraUtilizatori1.Dock = System.Windows.Forms.DockStyle.Top;
            this.baraUtilizatori1.Location = new System.Drawing.Point(0, 28);
            this.baraUtilizatori1.Margin = new System.Windows.Forms.Padding(5);
            this.baraUtilizatori1.Name = "baraUtilizatori1";
            this.baraUtilizatori1.Size = new System.Drawing.Size(1748, 49);
            this.baraUtilizatori1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1748, 742);
            this.Controls.Add(this.selectableFlowLayoutPanel1);
            this.Controls.Add(this.baraUtilizatori1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.selectableFlowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem numeProiectToolStripMenuItem;
        private BaraUtilizatori baraUtilizatori1;
        private System.Windows.Forms.Button AddListButton;
        private Controls.SelectableFlowLayoutPanel selectableFlowLayoutPanel1;
    }
}

