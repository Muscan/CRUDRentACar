
namespace CRUDRentACar.Forms
{
    partial class LoginUserRole
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginUserRole));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.operatiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusParcAutoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inchiriereMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.returnareMasinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSignOut = new System.Windows.Forms.Button();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 27);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.operatiiToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(34, 24);
            this.toolStripDropDownButton1.Text = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
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
            this.operatiiToolStripMenuItem.Click += new System.EventHandler(this.operatiiToolStripMenuItem_Click);
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
            this.returnareMasinaToolStripMenuItem.Click += new System.EventHandler(this.returnareMasinaToolStripMenuItem_Click);
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.Location = new System.Drawing.Point(547, 324);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(141, 72);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign Out as User";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // LoginUserRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSignOut);
            this.Controls.Add(this.toolStrip1);
            this.Name = "LoginUserRole";
            this.Text = "LoginUserRole";
            this.Load += new System.EventHandler(this.LoginUserRole_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem operatiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusParcAutoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inchiriereMasinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem returnareMasinaToolStripMenuItem;
        private System.Windows.Forms.Button btnSignOut;
    }
}