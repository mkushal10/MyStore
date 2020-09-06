namespace MyStore
{
    partial class FormUserDashboard
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
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblDevelopersName = new System.Windows.Forms.Label();
            this.menuStripTop = new System.Windows.Forms.MenuStrip();
            this.purchaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.lblAppName2 = new System.Windows.Forms.Label();
            this.lblAppName1 = new System.Windows.Forms.Label();
            this.lblLoggedUser = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlFooter.SuspendLayout();
            this.menuStripTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.DarkBlue;
            this.pnlFooter.Controls.Add(this.lblDevelopersName);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.pnlFooter.Location = new System.Drawing.Point(0, 378);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(800, 72);
            this.pnlFooter.TabIndex = 7;
            // 
            // lblDevelopersName
            // 
            this.lblDevelopersName.AutoSize = true;
            this.lblDevelopersName.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDevelopersName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblDevelopersName.Location = new System.Drawing.Point(594, 9);
            this.lblDevelopersName.Name = "lblDevelopersName";
            this.lblDevelopersName.Size = new System.Drawing.Size(222, 20);
            this.lblDevelopersName.TabIndex = 0;
            this.lblDevelopersName.Text = "Developed By: KUSHAL NEUPANE";
            // 
            // menuStripTop
            // 
            this.menuStripTop.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripTop.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.purchaseToolStripMenuItem,
            this.salesToolStripMenuItem,
            this.inventoryToolStripMenuItem});
            this.menuStripTop.Location = new System.Drawing.Point(0, 0);
            this.menuStripTop.Name = "menuStripTop";
            this.menuStripTop.Size = new System.Drawing.Size(800, 24);
            this.menuStripTop.TabIndex = 8;
            // 
            // purchaseToolStripMenuItem
            // 
            this.purchaseToolStripMenuItem.Name = "purchaseToolStripMenuItem";
            this.purchaseToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.purchaseToolStripMenuItem.Text = "Purchase";
            // 
            // salesToolStripMenuItem
            // 
            this.salesToolStripMenuItem.Name = "salesToolStripMenuItem";
            this.salesToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.salesToolStripMenuItem.Text = "Sales";
            // 
            // inventoryToolStripMenuItem
            // 
            this.inventoryToolStripMenuItem.Name = "inventoryToolStripMenuItem";
            this.inventoryToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.inventoryToolStripMenuItem.Text = "Inventory";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(475, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 25);
            this.label1.TabIndex = 13;
            this.label1.Text = "Billing and Inventory Management System";
            // 
            // lblAppName2
            // 
            this.lblAppName2.AutoSize = true;
            this.lblAppName2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName2.Location = new System.Drawing.Point(625, 252);
            this.lblAppName2.Name = "lblAppName2";
            this.lblAppName2.Size = new System.Drawing.Size(68, 23);
            this.lblAppName2.TabIndex = 12;
            this.lblAppName2.Text = "Store";
            // 
            // lblAppName1
            // 
            this.lblAppName1.AutoSize = true;
            this.lblAppName1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName1.Location = new System.Drawing.Point(591, 252);
            this.lblAppName1.Name = "lblAppName1";
            this.lblAppName1.Size = new System.Drawing.Size(37, 23);
            this.lblAppName1.TabIndex = 11;
            this.lblAppName1.Text = "My";
            // 
            // lblLoggedUser
            // 
            this.lblLoggedUser.AutoSize = true;
            this.lblLoggedUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoggedUser.ForeColor = System.Drawing.Color.SeaGreen;
            this.lblLoggedUser.Location = new System.Drawing.Point(58, 44);
            this.lblLoggedUser.Name = "lblLoggedUser";
            this.lblLoggedUser.Size = new System.Drawing.Size(110, 20);
            this.lblLoggedUser.TabIndex = 10;
            this.lblLoggedUser.Text = "Kushal Neupane";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(6, 43);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(45, 20);
            this.lblUser.TabIndex = 9;
            this.lblUser.Text = "User :";
            // 
            // FormUserDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlFooter);
            this.Controls.Add(this.menuStripTop);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAppName2);
            this.Controls.Add(this.lblAppName1);
            this.Controls.Add(this.lblLoggedUser);
            this.Controls.Add(this.lblUser);
            this.Name = "FormUserDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlFooter.ResumeLayout(false);
            this.pnlFooter.PerformLayout();
            this.menuStripTop.ResumeLayout(false);
            this.menuStripTop.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblDevelopersName;
        private System.Windows.Forms.MenuStrip menuStripTop;
        private System.Windows.Forms.ToolStripMenuItem purchaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventoryToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAppName2;
        private System.Windows.Forms.Label lblAppName1;
        private System.Windows.Forms.Label lblLoggedUser;
        private System.Windows.Forms.Label lblUser;
    }
}