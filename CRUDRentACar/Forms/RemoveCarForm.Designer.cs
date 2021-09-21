
namespace CRUDRentACar.Forms
{
    partial class RemoveCarForm
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
            this.lblEliminare = new System.Windows.Forms.Label();
            this.lblEliminareMarca = new System.Windows.Forms.Label();
            this.txtBoxEliminareMarca = new System.Windows.Forms.TextBox();
            this.Cancel = new System.Windows.Forms.Button();
            this.btnEliminareMasina = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblEliminare
            // 
            this.lblEliminare.AutoSize = true;
            this.lblEliminare.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEliminare.Location = new System.Drawing.Point(270, 28);
            this.lblEliminare.Name = "lblEliminare";
            this.lblEliminare.Size = new System.Drawing.Size(161, 24);
            this.lblEliminare.TabIndex = 0;
            this.lblEliminare.Text = "Eliminare Masina";
            this.lblEliminare.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblEliminareMarca
            // 
            this.lblEliminareMarca.AutoSize = true;
            this.lblEliminareMarca.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEliminareMarca.Location = new System.Drawing.Point(270, 132);
            this.lblEliminareMarca.Name = "lblEliminareMarca";
            this.lblEliminareMarca.Size = new System.Drawing.Size(173, 24);
            this.lblEliminareMarca.TabIndex = 1;
            this.lblEliminareMarca.Text = "Introduceti Marca:";
            this.lblEliminareMarca.Click += new System.EventHandler(this.lblEliminareMarca_Click);
            // 
            // txtBoxEliminareMarca
            // 
            this.txtBoxEliminareMarca.Location = new System.Drawing.Point(270, 170);
            this.txtBoxEliminareMarca.Name = "txtBoxEliminareMarca";
            this.txtBoxEliminareMarca.Size = new System.Drawing.Size(161, 27);
            this.txtBoxEliminareMarca.TabIndex = 2;
            // 
            // Cancel
            // 
            this.Cancel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Cancel.Location = new System.Drawing.Point(76, 368);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(94, 29);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // btnEliminareMasina
            // 
            this.btnEliminareMasina.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEliminareMasina.Location = new System.Drawing.Point(647, 368);
            this.btnEliminareMasina.Name = "btnEliminareMasina";
            this.btnEliminareMasina.Size = new System.Drawing.Size(112, 29);
            this.btnEliminareMasina.TabIndex = 4;
            this.btnEliminareMasina.Text = "Eliminare";
            this.btnEliminareMasina.UseVisualStyleBackColor = true;
            this.btnEliminareMasina.Click += new System.EventHandler(this.btnEliminareMasina_Click);
            // 
            // RemoveCarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminareMasina);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.txtBoxEliminareMarca);
            this.Controls.Add(this.lblEliminareMarca);
            this.Controls.Add(this.lblEliminare);
            this.Name = "RemoveCarForm";
            this.Text = "RemoveCarForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEliminare;
        private System.Windows.Forms.Label lblEliminareMarca;
        private System.Windows.Forms.TextBox txtBoxEliminareMarca;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button btnEliminareMasina;
    }
}