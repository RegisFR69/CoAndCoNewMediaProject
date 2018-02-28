namespace Projet_CoAndCo
{
    partial class frmLogin
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
            this.lblTitre_Login = new System.Windows.Forms.Label();
            this.lblId_Login = new System.Windows.Forms.Label();
            this.lblPass_Login = new System.Windows.Forms.Label();
            this.lblPass2_Login = new System.Windows.Forms.Label();
            this.txtId_Login = new System.Windows.Forms.TextBox();
            this.txtPass_Login = new System.Windows.Forms.TextBox();
            this.txtPass2_Login = new System.Windows.Forms.TextBox();
            this.btnValid_Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre_Login
            // 
            this.lblTitre_Login.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitre_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold);
            this.lblTitre_Login.Location = new System.Drawing.Point(0, 0);
            this.lblTitre_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitre_Login.Name = "lblTitre_Login";
            this.lblTitre_Login.Size = new System.Drawing.Size(294, 25);
            this.lblTitre_Login.TabIndex = 0;
            this.lblTitre_Login.Text = "Nouvel utilisateur";
            this.lblTitre_Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblTitre_Login.Visible = false;
            // 
            // lblId_Login
            // 
            this.lblId_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_Login.Location = new System.Drawing.Point(0, 40);
            this.lblId_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblId_Login.Name = "lblId_Login";
            this.lblId_Login.Size = new System.Drawing.Size(130, 40);
            this.lblId_Login.TabIndex = 1;
            this.lblId_Login.Text = "Identifiant :";
            this.lblId_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPass_Login
            // 
            this.lblPass_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass_Login.Location = new System.Drawing.Point(0, 80);
            this.lblPass_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass_Login.Name = "lblPass_Login";
            this.lblPass_Login.Size = new System.Drawing.Size(130, 40);
            this.lblPass_Login.TabIndex = 2;
            this.lblPass_Login.Text = "Mot de passe :";
            this.lblPass_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPass2_Login
            // 
            this.lblPass2_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass2_Login.Location = new System.Drawing.Point(0, 120);
            this.lblPass2_Login.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPass2_Login.Name = "lblPass2_Login";
            this.lblPass2_Login.Size = new System.Drawing.Size(130, 40);
            this.lblPass2_Login.TabIndex = 3;
            this.lblPass2_Login.Text = "Confirmation mot de passe :";
            this.lblPass2_Login.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPass2_Login.Visible = false;
            // 
            // txtId_Login
            // 
            this.txtId_Login.Location = new System.Drawing.Point(140, 50);
            this.txtId_Login.Margin = new System.Windows.Forms.Padding(2);
            this.txtId_Login.Name = "txtId_Login";
            this.txtId_Login.Size = new System.Drawing.Size(130, 20);
            this.txtId_Login.TabIndex = 4;
            this.txtId_Login.Leave += new System.EventHandler(this.txtId_Login_Leave);
            // 
            // txtPass_Login
            // 
            this.txtPass_Login.Location = new System.Drawing.Point(140, 90);
            this.txtPass_Login.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass_Login.Name = "txtPass_Login";
            this.txtPass_Login.Size = new System.Drawing.Size(130, 20);
            this.txtPass_Login.TabIndex = 5;
            // 
            // txtPass2_Login
            // 
            this.txtPass2_Login.Location = new System.Drawing.Point(140, 130);
            this.txtPass2_Login.Margin = new System.Windows.Forms.Padding(2);
            this.txtPass2_Login.Name = "txtPass2_Login";
            this.txtPass2_Login.Size = new System.Drawing.Size(130, 20);
            this.txtPass2_Login.TabIndex = 6;
            this.txtPass2_Login.Visible = false;
            // 
            // btnValid_Login
            // 
            this.btnValid_Login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnValid_Login.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnValid_Login.Location = new System.Drawing.Point(0, 174);
            this.btnValid_Login.Margin = new System.Windows.Forms.Padding(2);
            this.btnValid_Login.Name = "btnValid_Login";
            this.btnValid_Login.Size = new System.Drawing.Size(294, 37);
            this.btnValid_Login.TabIndex = 7;
            this.btnValid_Login.Text = "Valider";
            this.btnValid_Login.UseVisualStyleBackColor = true;
            this.btnValid_Login.Click += new System.EventHandler(this.btnValid_Login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(294, 211);
            this.Controls.Add(this.btnValid_Login);
            this.Controls.Add(this.txtPass2_Login);
            this.Controls.Add(this.txtPass_Login);
            this.Controls.Add(this.txtId_Login);
            this.Controls.Add(this.lblPass2_Login);
            this.Controls.Add(this.lblPass_Login);
            this.Controls.Add(this.lblId_Login);
            this.Controls.Add(this.lblTitre_Login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 250);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre_Login;
        private System.Windows.Forms.Label lblId_Login;
        private System.Windows.Forms.Label lblPass_Login;
        private System.Windows.Forms.Label lblPass2_Login;
        private System.Windows.Forms.TextBox txtId_Login;
        private System.Windows.Forms.TextBox txtPass_Login;
        private System.Windows.Forms.TextBox txtPass2_Login;
        private System.Windows.Forms.Button btnValid_Login;
    }
}