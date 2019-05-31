namespace Proiect
{
    partial class List
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
            this.button1 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.containerPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.titluLb = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaTextToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportaXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1.SuspendLayout();
            this.containerPanel.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(3, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(101, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Adauga card nou";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AllowDrop = true;
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.containerPanel);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 41);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(229, 63);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            this.flowLayoutPanel1.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.flowLayoutPanel1.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // containerPanel
            // 
            this.containerPanel.AllowDrop = true;
            this.containerPanel.Controls.Add(this.deleteButton);
            this.containerPanel.Controls.Add(this.button1);
            this.containerPanel.Location = new System.Drawing.Point(2, 2);
            this.containerPanel.Margin = new System.Windows.Forms.Padding(2);
            this.containerPanel.Name = "containerPanel";
            this.containerPanel.Size = new System.Drawing.Size(225, 59);
            this.containerPanel.TabIndex = 2;
            this.containerPanel.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.containerPanel.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(147, 33);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(75, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Sterge Lista";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // titluLb
            // 
            this.titluLb.AutoSize = true;
            this.titluLb.Location = new System.Drawing.Point(10, 9);
            this.titluLb.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titluLb.Name = "titluLb";
            this.titluLb.Size = new System.Drawing.Size(27, 13);
            this.titluLb.TabIndex = 3;
            this.titluLb.Text = "Titlu";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteToolStripMenuItem,
            this.exportaTextToolStripMenuItem,
            this.exportaXMLToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 92);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // exportaTextToolStripMenuItem
            // 
            this.exportaTextToolStripMenuItem.Name = "exportaTextToolStripMenuItem";
            this.exportaTextToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportaTextToolStripMenuItem.Text = "Exporta text";
            this.exportaTextToolStripMenuItem.Click += new System.EventHandler(this.exportaTextToolStripMenuItem_Click);
            // 
            // exportaXMLToolStripMenuItem
            // 
            this.exportaXMLToolStripMenuItem.Name = "exportaXMLToolStripMenuItem";
            this.exportaXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportaXMLToolStripMenuItem.Text = "Exporta XML";
            this.exportaXMLToolStripMenuItem.Click += new System.EventHandler(this.exportaXMLToolStripMenuItem_Click);
            // 
            // List
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.titluLb);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "List";
            this.Size = new System.Drawing.Size(243, 106);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.List_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.List_DragEnter);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.containerPanel.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label titluLb;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.Panel containerPanel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.ToolStripMenuItem exportaTextToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportaXMLToolStripMenuItem;
    }
}
