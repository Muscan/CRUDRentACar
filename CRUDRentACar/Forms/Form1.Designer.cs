
namespace CRUDRentACar
{
    partial class frmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.toolStripOperatiuni = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.operatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusParcAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchiriereMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnareMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adaugareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStriplblOperatiuni = new System.Windows.Forms.ToolStripLabel();
            this.toolStripOperatiuni.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripOperatiuni
            // 
            this.toolStripOperatiuni.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripOperatiuni.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStriplblOperatiuni});
            this.toolStripOperatiuni.Location = new System.Drawing.Point(0, 0);
            this.toolStripOperatiuni.Name = "toolStripOperatiuni";
            this.toolStripOperatiuni.Size = new System.Drawing.Size(1056, 27);
            this.toolStripOperatiuni.TabIndex = 0;
            this.toolStripOperatiuni.Text = "Operatiuni";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiiToolStripMenuItem,
            this.updateToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            // 
            // operatiiToolStripMenuItem
            // 
            this.operatiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusParcAutoToolStripMenuItem,
            this.inchiriereMasinaToolStripMenuItem,
            this.returnareMasinaToolStripMenuItem});
            this.operatiiToolStripMenuItem.Name = "operatiiToolStripMenuItem";
            this.operatiiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.operatiiToolStripMenuItem.Text = "Operatii";
            // 
            // statusParcAutoToolStripMenuItem
            // 
            this.statusParcAutoToolStripMenuItem.Name = "statusParcAutoToolStripMenuItem";
            this.statusParcAutoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.statusParcAutoToolStripMenuItem.Text = "Status Parc Auto";
            this.statusParcAutoToolStripMenuItem.Click += new System.EventHandler(this.statusParcAutoToolStripMenuItem_Click);
            // 
            // inchiriereMasinaToolStripMenuItem
            // 
            this.inchiriereMasinaToolStripMenuItem.Name = "inchiriereMasinaToolStripMenuItem";
            this.inchiriereMasinaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.inchiriereMasinaToolStripMenuItem.Text = "Inchiriere Masina";
            this.inchiriereMasinaToolStripMenuItem.Click += new System.EventHandler(this.inchiriereMasinaToolStripMenuItem_Click);
            // 
            // returnareMasinaToolStripMenuItem
            // 
            this.returnareMasinaToolStripMenuItem.Name = "returnareMasinaToolStripMenuItem";
            this.returnareMasinaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.returnareMasinaToolStripMenuItem.Text = "Returnare Masina";
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.eliminareToolStripMenuItem,
            this.editareToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            // 
            // eliminareToolStripMenuItem
            // 
            this.eliminareToolStripMenuItem.Name = "eliminareToolStripMenuItem";
            this.eliminareToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.eliminareToolStripMenuItem.Text = "Eliminare";
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.editareToolStripMenuItem.Text = "Editare";
            // 
            // toolStriplblOperatiuni
            // 
            this.toolStriplblOperatiuni.Name = "toolStriplblOperatiuni";
            this.toolStriplblOperatiuni.Size = new System.Drawing.Size(79, 24);
            this.toolStriplblOperatiuni.Text = "Operatiuni";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 734);
            this.Controls.Add(this.toolStripOperatiuni);
            this.Name = "frmMain";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStripOperatiuni.ResumeLayout(false);
            this.toolStripOperatiuni.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripOperatiuni;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem operatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusParcAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchiriereMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnareMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adaugareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminareToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editareToolStripMenuItem;
        private System.Windows.Forms.ToolStripLabel toolStriplblOperatiuni;
    }
}

