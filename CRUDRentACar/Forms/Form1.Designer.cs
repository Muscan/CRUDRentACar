
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
            this.btnSignOut = new System.Windows.Forms.Button();
            this.btnPrintAllUsers = new System.Windows.Forms.Button();
            this.lstUsers = new System.Windows.Forms.ListView();
            this.btnDeleteUser = new System.Windows.Forms.Button();
            this.txtBoxDeleteUser = new System.Windows.Forms.TextBox();
            this.btnAddUser = new System.Windows.Forms.Button();
            this.btnEditUser = new System.Windows.Forms.Button();
            this.txtBoxEditName = new System.Windows.Forms.TextBox();
            this.txtBoxEditPassword = new System.Windows.Forms.TextBox();
            this.checkBoxEditIsAdmin = new System.Windows.Forms.CheckBox();
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
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // operatiiToolStripMenuItem
            // 
            this.operatiiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusParcAutoToolStripMenuItem,
            this.inchiriereMasinaToolStripMenuItem,
            this.returnareMasinaToolStripMenuItem});
            this.operatiiToolStripMenuItem.Name = "operatiiToolStripMenuItem";
            this.operatiiToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.operatiiToolStripMenuItem.Text = "Operatii";
            // 
            // statusParcAutoToolStripMenuItem
            // 
            this.statusParcAutoToolStripMenuItem.Name = "statusParcAutoToolStripMenuItem";
            this.statusParcAutoToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.statusParcAutoToolStripMenuItem.Text = "Status Parc Auto";
            this.statusParcAutoToolStripMenuItem.Click += new System.EventHandler(this.statusParcAutoToolStripMenuItem_Click);
            // 
            // inchiriereMasinaToolStripMenuItem
            // 
            this.inchiriereMasinaToolStripMenuItem.Name = "inchiriereMasinaToolStripMenuItem";
            this.inchiriereMasinaToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.inchiriereMasinaToolStripMenuItem.Text = "Inchiriere Masina";
            this.inchiriereMasinaToolStripMenuItem.Click += new System.EventHandler(this.inchiriereMasinaToolStripMenuItem_Click);
            // 
            // returnareMasinaToolStripMenuItem
            // 
            this.returnareMasinaToolStripMenuItem.Name = "returnareMasinaToolStripMenuItem";
            this.returnareMasinaToolStripMenuItem.Size = new System.Drawing.Size(207, 26);
            this.returnareMasinaToolStripMenuItem.Text = "Returnare Masina";
            this.returnareMasinaToolStripMenuItem.Click += new System.EventHandler(this.returnareMasinaToolStripMenuItem_Click);
            // 
            // updateToolStripMenuItem
            // 
            this.updateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.adaugareToolStripMenuItem,
            this.eliminareToolStripMenuItem,
            this.editareToolStripMenuItem});
            this.updateToolStripMenuItem.Name = "updateToolStripMenuItem";
            this.updateToolStripMenuItem.Size = new System.Drawing.Size(146, 26);
            this.updateToolStripMenuItem.Text = "Update";
            // 
            // adaugareToolStripMenuItem
            // 
            this.adaugareToolStripMenuItem.Name = "adaugareToolStripMenuItem";
            this.adaugareToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.adaugareToolStripMenuItem.Text = "Adaugare";
            this.adaugareToolStripMenuItem.Click += new System.EventHandler(this.adaugareToolStripMenuItem_Click);
            // 
            // eliminareToolStripMenuItem
            // 
            this.eliminareToolStripMenuItem.Name = "eliminareToolStripMenuItem";
            this.eliminareToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.eliminareToolStripMenuItem.Text = "Eliminare";
            this.eliminareToolStripMenuItem.Click += new System.EventHandler(this.eliminareToolStripMenuItem_Click);
            // 
            // editareToolStripMenuItem
            // 
            this.editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            this.editareToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.editareToolStripMenuItem.Text = "Editare";
            this.editareToolStripMenuItem.Click += new System.EventHandler(this.editareToolStripMenuItem_Click);
            // 
            // toolStriplblOperatiuni
            // 
            this.toolStriplblOperatiuni.Name = "toolStriplblOperatiuni";
            this.toolStriplblOperatiuni.Size = new System.Drawing.Size(79, 24);
            this.toolStriplblOperatiuni.Text = "Operatiuni";
            // 
            // btnSignOut
            // 
            this.btnSignOut.BackColor = System.Drawing.Color.Red;
            this.btnSignOut.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSignOut.Location = new System.Drawing.Point(871, 652);
            this.btnSignOut.Name = "btnSignOut";
            this.btnSignOut.Size = new System.Drawing.Size(129, 53);
            this.btnSignOut.TabIndex = 1;
            this.btnSignOut.Text = "Sign out";
            this.btnSignOut.UseVisualStyleBackColor = false;
            this.btnSignOut.Click += new System.EventHandler(this.btnSignOut_Click);
            // 
            // btnPrintAllUsers
            // 
            this.btnPrintAllUsers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnPrintAllUsers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnPrintAllUsers.Location = new System.Drawing.Point(155, 42);
            this.btnPrintAllUsers.Name = "btnPrintAllUsers";
            this.btnPrintAllUsers.Size = new System.Drawing.Size(142, 53);
            this.btnPrintAllUsers.TabIndex = 2;
            this.btnPrintAllUsers.Text = "Print All Users";
            this.btnPrintAllUsers.UseVisualStyleBackColor = false;
            this.btnPrintAllUsers.Click += new System.EventHandler(this.btnPrintAllUsers_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.BackColor = System.Drawing.SystemColors.ControlDark;
            this.lstUsers.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.lstUsers.GridLines = true;
            this.lstUsers.HideSelection = false;
            this.lstUsers.Location = new System.Drawing.Point(155, 101);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(412, 267);
            this.lstUsers.TabIndex = 3;
            this.lstUsers.TileSize = new System.Drawing.Size(1, 1);
            this.lstUsers.UseCompatibleStateImageBehavior = false;
            this.lstUsers.View = System.Windows.Forms.View.Details;
            // 
            // btnDeleteUser
            // 
            this.btnDeleteUser.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDeleteUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnDeleteUser.Location = new System.Drawing.Point(587, 503);
            this.btnDeleteUser.Name = "btnDeleteUser";
            this.btnDeleteUser.Size = new System.Drawing.Size(129, 53);
            this.btnDeleteUser.TabIndex = 4;
            this.btnDeleteUser.Text = "Delete User";
            this.btnDeleteUser.UseVisualStyleBackColor = false;
            this.btnDeleteUser.Click += new System.EventHandler(this.btnDeleteUser_Click);
            // 
            // txtBoxDeleteUser
            // 
            this.txtBoxDeleteUser.Location = new System.Drawing.Point(587, 572);
            this.txtBoxDeleteUser.Name = "txtBoxDeleteUser";
            this.txtBoxDeleteUser.Size = new System.Drawing.Size(213, 27);
            this.txtBoxDeleteUser.TabIndex = 5;
            // 
            // btnAddUser
            // 
            this.btnAddUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAddUser.Location = new System.Drawing.Point(432, 42);
            this.btnAddUser.Name = "btnAddUser";
            this.btnAddUser.Size = new System.Drawing.Size(135, 55);
            this.btnAddUser.TabIndex = 6;
            this.btnAddUser.Text = "Add User";
            this.btnAddUser.UseVisualStyleBackColor = true;
            this.btnAddUser.Click += new System.EventHandler(this.btnAddUser_Click);
            // 
            // btnEditUser
            // 
            this.btnEditUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnEditUser.Location = new System.Drawing.Point(614, 42);
            this.btnEditUser.Name = "btnEditUser";
            this.btnEditUser.Size = new System.Drawing.Size(135, 55);
            this.btnEditUser.TabIndex = 7;
            this.btnEditUser.Text = "Edit User";
            this.btnEditUser.UseVisualStyleBackColor = true;
            this.btnEditUser.Click += new System.EventHandler(this.btnEditUser_Click);
            // 
            // txtBoxEditName
            // 
            this.txtBoxEditName.Location = new System.Drawing.Point(614, 153);
            this.txtBoxEditName.Name = "txtBoxEditName";
            this.txtBoxEditName.Size = new System.Drawing.Size(125, 27);
            this.txtBoxEditName.TabIndex = 8;
            // 
            // txtBoxEditPassword
            // 
            this.txtBoxEditPassword.Location = new System.Drawing.Point(765, 153);
            this.txtBoxEditPassword.Name = "txtBoxEditPassword";
            this.txtBoxEditPassword.Size = new System.Drawing.Size(125, 27);
            this.txtBoxEditPassword.TabIndex = 9;
            // 
            // checkBoxEditIsAdmin
            // 
            this.checkBoxEditIsAdmin.AutoSize = true;
            this.checkBoxEditIsAdmin.Location = new System.Drawing.Point(899, 153);
            this.checkBoxEditIsAdmin.Name = "checkBoxEditIsAdmin";
            this.checkBoxEditIsAdmin.Size = new System.Drawing.Size(75, 24);
            this.checkBoxEditIsAdmin.TabIndex = 10;
            this.checkBoxEditIsAdmin.Text = "Admin";
            this.checkBoxEditIsAdmin.UseVisualStyleBackColor = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 734);
            this.Controls.Add(this.checkBoxEditIsAdmin);
            this.Controls.Add(this.txtBoxEditPassword);
            this.Controls.Add(this.txtBoxEditName);
            this.Controls.Add(this.btnEditUser);
            this.Controls.Add(this.btnAddUser);
            this.Controls.Add(this.txtBoxDeleteUser);
            this.Controls.Add(this.btnDeleteUser);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.btnPrintAllUsers);
            this.Controls.Add(this.btnSignOut);
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
        private System.Windows.Forms.Button btnSignOut;
        private System.Windows.Forms.Button btnPrintAllUsers;
        private System.Windows.Forms.ListView lstUsers;
        private System.Windows.Forms.Button btnDeleteUser;
        private System.Windows.Forms.TextBox txtBoxDeleteUser;
        private System.Windows.Forms.Button btnAddUser;
        private System.Windows.Forms.Button btnEditUser;
        private System.Windows.Forms.TextBox txtBoxEditName;
        private System.Windows.Forms.TextBox txtBoxEditPassword;
        private System.Windows.Forms.CheckBox checkBoxEditIsAdmin;
    }
}

