
namespace CRUDRentACar.Forms
{
    partial class DataReturn
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
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblNumeReturn = new System.Windows.Forms.Label();
            this.lblMarcaReturnata = new System.Windows.Forms.Label();
            this.btnOKreturn = new System.Windows.Forms.Button();
            this.btnCancelReturn = new System.Windows.Forms.Button();
            this.txtBoxNumeReturn = new System.Windows.Forms.TextBox();
            this.txtBoxMarcaReturn = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblReturn.Location = new System.Drawing.Point(254, 40);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(213, 24);
            this.lblReturn.TabIndex = 0;
            this.lblReturn.Text = "Introduceti date return";
            this.lblReturn.Click += new System.EventHandler(this.lblReturn_Click);
            // 
            // lblNumeReturn
            // 
            this.lblNumeReturn.AutoSize = true;
            this.lblNumeReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNumeReturn.Location = new System.Drawing.Point(272, 123);
            this.lblNumeReturn.Name = "lblNumeReturn";
            this.lblNumeReturn.Size = new System.Drawing.Size(186, 24);
            this.lblNumeReturn.TabIndex = 1;
            this.lblNumeReturn.Text = "Introduceti numele:";
            // 
            // lblMarcaReturnata
            // 
            this.lblMarcaReturnata.AutoSize = true;
            this.lblMarcaReturnata.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarcaReturnata.Location = new System.Drawing.Point(281, 209);
            this.lblMarcaReturnata.Name = "lblMarcaReturnata";
            this.lblMarcaReturnata.Size = new System.Drawing.Size(157, 24);
            this.lblMarcaReturnata.TabIndex = 2;
            this.lblMarcaReturnata.Text = "Marca Returnata";
            // 
            // btnOKreturn
            // 
            this.btnOKreturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOKreturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOKreturn.Location = new System.Drawing.Point(136, 337);
            this.btnOKreturn.Name = "btnOKreturn";
            this.btnOKreturn.Size = new System.Drawing.Size(119, 38);
            this.btnOKreturn.TabIndex = 3;
            this.btnOKreturn.Text = "OK";
            this.btnOKreturn.UseVisualStyleBackColor = false;
            this.btnOKreturn.Click += new System.EventHandler(this.btnOKreturn_Click);
            // 
            // btnCancelReturn
            // 
            this.btnCancelReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancelReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelReturn.Location = new System.Drawing.Point(503, 337);
            this.btnCancelReturn.Name = "btnCancelReturn";
            this.btnCancelReturn.Size = new System.Drawing.Size(106, 38);
            this.btnCancelReturn.TabIndex = 4;
            this.btnCancelReturn.Text = "Cancel";
            this.btnCancelReturn.UseVisualStyleBackColor = false;
            this.btnCancelReturn.Click += new System.EventHandler(this.btnCancelReturn_Click);
            // 
            // txtBoxNumeReturn
            // 
            this.txtBoxNumeReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxNumeReturn.Location = new System.Drawing.Point(297, 162);
            this.txtBoxNumeReturn.Name = "txtBoxNumeReturn";
            this.txtBoxNumeReturn.Size = new System.Drawing.Size(125, 32);
            this.txtBoxNumeReturn.TabIndex = 5;
            // 
            // txtBoxMarcaReturn
            // 
            this.txtBoxMarcaReturn.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtBoxMarcaReturn.Location = new System.Drawing.Point(297, 254);
            this.txtBoxMarcaReturn.Name = "txtBoxMarcaReturn";
            this.txtBoxMarcaReturn.Size = new System.Drawing.Size(125, 32);
            this.txtBoxMarcaReturn.TabIndex = 6;
            // 
            // DataReturn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxMarcaReturn);
            this.Controls.Add(this.txtBoxNumeReturn);
            this.Controls.Add(this.btnCancelReturn);
            this.Controls.Add(this.btnOKreturn);
            this.Controls.Add(this.lblMarcaReturnata);
            this.Controls.Add(this.lblNumeReturn);
            this.Controls.Add(this.lblReturn);
            this.Name = "DataReturn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataReturn";
            this.Load += new System.EventHandler(this.DataReturn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblNumeReturn;
        private System.Windows.Forms.Label lblMarcaReturnata;
        private System.Windows.Forms.Button btnOKreturn;
        private System.Windows.Forms.Button btnCancelReturn;
        private System.Windows.Forms.TextBox txtBoxNumeReturn;
        private System.Windows.Forms.TextBox txtBoxMarcaReturn;
    }
}