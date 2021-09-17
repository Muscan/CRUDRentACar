
namespace CRUDRentACar.Forms
{
    partial class DataEntry
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.lblMarca = new System.Windows.Forms.Label();
            this.txtBoxNume = new System.Windows.Forms.TextBox();
            this.txtBoxMarca = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDate.Location = new System.Drawing.Point(112, 31);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(252, 24);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Introducere Date Inchiriere";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNume.Location = new System.Drawing.Point(131, 118);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(217, 23);
            this.lblNume.TabIndex = 1;
            this.lblNume.Text = "Introduceti numele dvs.:";
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMarca.Location = new System.Drawing.Point(112, 183);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(284, 23);
            this.lblMarca.TabIndex = 2;
            this.lblMarca.Text = "Introduceti marca masinii dorite:";
            // 
            // txtBoxNume
            // 
            this.txtBoxNume.Location = new System.Drawing.Point(184, 144);
            this.txtBoxNume.Name = "txtBoxNume";
            this.txtBoxNume.Size = new System.Drawing.Size(125, 27);
            this.txtBoxNume.TabIndex = 3;
            // 
            // txtBoxMarca
            // 
            this.txtBoxMarca.Location = new System.Drawing.Point(184, 209);
            this.txtBoxMarca.Name = "txtBoxMarca";
            this.txtBoxMarca.Size = new System.Drawing.Size(125, 27);
            this.txtBoxMarca.TabIndex = 4;
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnOK.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnOK.Location = new System.Drawing.Point(67, 290);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(94, 29);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnCancel.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancel.Location = new System.Drawing.Point(341, 290);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // DataEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(482, 353);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtBoxMarca);
            this.Controls.Add(this.txtBoxNume);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.lblNume);
            this.Controls.Add(this.lblDate);
            this.Name = "DataEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.TextBox txtBoxNume;
        private System.Windows.Forms.TextBox txtBoxMarca;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}