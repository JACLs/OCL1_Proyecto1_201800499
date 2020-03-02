namespace OCL1_Proyecto1_201800499
{
    partial class VentanaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VentanaPrincipal));
            this.menuPrincipal = new System.Windows.Forms.MenuStrip();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newTabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tokensToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.errorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlTabs = new System.Windows.Forms.TabControl();
            this.rtbConsole = new System.Windows.Forms.RichTextBox();
            this.lblConsole = new System.Windows.Forms.Label();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.saveFile = new System.Windows.Forms.SaveFileDialog();
            this.menuPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPrincipal
            // 
            this.menuPrincipal.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarToolStripMenuItem});
            this.menuPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuPrincipal.Name = "menuPrincipal";
            this.menuPrincipal.Size = new System.Drawing.Size(1469, 28);
            this.menuPrincipal.TabIndex = 1;
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem,
            this.newTabToolStripMenuItem});
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(44, 24);
            this.abrirToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = global::OCL1_Proyecto1_201800499.Properties.Resources.Open_256;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Image = global::OCL1_Proyecto1_201800499.Properties.Resources.Save_256;
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // newTabToolStripMenuItem
            // 
            this.newTabToolStripMenuItem.Image = global::OCL1_Proyecto1_201800499.Properties.Resources.AddTab_256;
            this.newTabToolStripMenuItem.Name = "newTabToolStripMenuItem";
            this.newTabToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.newTabToolStripMenuItem.Text = "New Tab";
            this.newTabToolStripMenuItem.Click += new System.EventHandler(this.newTabToolStripMenuItem_Click);
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tokensToolStripMenuItem,
            this.errorsToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.guardarToolStripMenuItem.Text = "Compile";
            // 
            // tokensToolStripMenuItem
            // 
            this.tokensToolStripMenuItem.Image = global::OCL1_Proyecto1_201800499.Properties.Resources.Ticket_256;
            this.tokensToolStripMenuItem.Name = "tokensToolStripMenuItem";
            this.tokensToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.tokensToolStripMenuItem.Text = "Tokens";
            // 
            // errorsToolStripMenuItem
            // 
            this.errorsToolStripMenuItem.Image = global::OCL1_Proyecto1_201800499.Properties.Resources.Error_256;
            this.errorsToolStripMenuItem.Name = "errorsToolStripMenuItem";
            this.errorsToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.errorsToolStripMenuItem.Text = "Errors";
            // 
            // controlTabs
            // 
            this.controlTabs.Location = new System.Drawing.Point(12, 31);
            this.controlTabs.Name = "controlTabs";
            this.controlTabs.SelectedIndex = 0;
            this.controlTabs.Size = new System.Drawing.Size(469, 613);
            this.controlTabs.TabIndex = 0;
            // 
            // rtbConsole
            // 
            this.rtbConsole.BackColor = System.Drawing.Color.Gray;
            this.rtbConsole.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.rtbConsole.Location = new System.Drawing.Point(13, 704);
            this.rtbConsole.Name = "rtbConsole";
            this.rtbConsole.Size = new System.Drawing.Size(468, 163);
            this.rtbConsole.TabIndex = 2;
            this.rtbConsole.Text = "";
            // 
            // lblConsole
            // 
            this.lblConsole.AutoSize = true;
            this.lblConsole.Location = new System.Drawing.Point(13, 681);
            this.lblConsole.Name = "lblConsole";
            this.lblConsole.Size = new System.Drawing.Size(59, 17);
            this.lblConsole.TabIndex = 3;
            this.lblConsole.Text = "Console";
            // 
            // openFile
            // 
            this.openFile.DefaultExt = "er";
            this.openFile.Filter = "Files ER (*.er)|*.er";
            this.openFile.Title = "Save";
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.openFile_FileOk);
            // 
            // saveFile
            // 
            this.saveFile.DefaultExt = "er";
            this.saveFile.Filter = "Archivos ER (*.er)|*.er";
            this.saveFile.Title = "Save";
            this.saveFile.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFile_FileOk);
            // 
            // VentanaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1469, 879);
            this.Controls.Add(this.lblConsole);
            this.Controls.Add(this.rtbConsole);
            this.Controls.Add(this.controlTabs);
            this.Controls.Add(this.menuPrincipal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuPrincipal;
            this.Name = "VentanaPrincipal";
            this.Text = "Proyecto1_201800499";
            this.menuPrincipal.ResumeLayout(false);
            this.menuPrincipal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuPrincipal;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.TabControl controlTabs;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newTabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tokensToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem errorsToolStripMenuItem;
        private System.Windows.Forms.RichTextBox rtbConsole;
        private System.Windows.Forms.Label lblConsole;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.SaveFileDialog saveFile;
    }
}

