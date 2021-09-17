
namespace CRUDRentACar.Forms
{
    partial class frmStatus
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
            this.listMasini = new System.Windows.Forms.ListView();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listMasini
            // 
            this.listMasini.BackColor = System.Drawing.Color.DarkGray;
            this.listMasini.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listMasini.GridLines = true;
            this.listMasini.HideSelection = false;
            this.listMasini.Location = new System.Drawing.Point(-2, -1);
            this.listMasini.Name = "listMasini";
            this.listMasini.Scrollable = false;
            this.listMasini.Size = new System.Drawing.Size(811, 450);
            this.listMasini.TabIndex = 0;
            this.listMasini.TileSize = new System.Drawing.Size(1, 1);
            this.listMasini.UseCompatibleStateImageBehavior = false;
            this.listMasini.View = System.Windows.Forms.View.Details;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnExit.Location = new System.Drawing.Point(637, 378);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(141, 60);
            this.btnExit.TabIndex = 1;
            this.btnExit.Text = "EXIT";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.listMasini);
            this.Name = "frmStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Parc Auto";
            this.Load += new System.EventHandler(this.frmStatus_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listMasini;
        private System.Windows.Forms.Button btnExit;
    }
}