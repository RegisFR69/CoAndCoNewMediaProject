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
            this.components = new System.ComponentModel.Container();
            this.lblTitre_Login = new System.Windows.Forms.Label();
            this.lblLogin = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblPass2_Login = new System.Windows.Forms.Label();
            this.txtLogin = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtPassword2 = new System.Windows.Forms.TextBox();
            this.btnValid_Login = new System.Windows.Forms.Button();
            this.coAndCoDBDataSetLogin = new Projet_CoAndCo.CoAndCoDBDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Projet_CoAndCo.CoAndCoDBDataSetTableAdapters.UserTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.coAndCoDBDataSetLogin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
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
            // lblLogin
            // 
            this.lblLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogin.Location = new System.Drawing.Point(0, 40);
            this.lblLogin.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLogin.Name = "lblLogin";
            this.lblLogin.Size = new System.Drawing.Size(130, 40);
            this.lblLogin.TabIndex = 1;
            this.lblLogin.Text = "Login :";
            this.lblLogin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPassword
            // 
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(0, 80);
            this.lblPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(130, 40);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Mot de passe :";
            this.lblPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            // txtLogin
            // 
            this.txtLogin.Location = new System.Drawing.Point(140, 50);
            this.txtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtLogin.Name = "txtLogin";
            this.txtLogin.Size = new System.Drawing.Size(130, 20);
            this.txtLogin.TabIndex = 4;
            this.txtLogin.Validating += new System.ComponentModel.CancelEventHandler(this.txtLogin_Validating);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(140, 90);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(130, 20);
            this.txtPassword.TabIndex = 5;
            // 
            // txtPassword2
            // 
            this.txtPassword2.Location = new System.Drawing.Point(140, 130);
            this.txtPassword2.Margin = new System.Windows.Forms.Padding(2);
            this.txtPassword2.Name = "txtPassword2";
            this.txtPassword2.Size = new System.Drawing.Size(130, 20);
            this.txtPassword2.TabIndex = 6;
            this.txtPassword2.Visible = false;
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
            // coAndCoDBDataSetLogin
            // 
            this.coAndCoDBDataSetLogin.DataSetName = "CoAndCoDBDataSet";
            this.coAndCoDBDataSetLogin.Locale = new System.Globalization.CultureInfo("fr-FR");
            this.coAndCoDBDataSetLogin.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.coAndCoDBDataSetLogin;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Turquoise;
            this.ClientSize = new System.Drawing.Size(294, 211);
            this.Controls.Add(this.btnValid_Login);
            this.Controls.Add(this.txtPassword2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtLogin);
            this.Controls.Add(this.lblPass2_Login);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblLogin);
            this.Controls.Add(this.lblTitre_Login);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(310, 250);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(310, 250);
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Connection";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.coAndCoDBDataSetLogin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre_Login;
        private System.Windows.Forms.Label lblLogin;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblPass2_Login;
        private System.Windows.Forms.TextBox txtLogin;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtPassword2;
        private System.Windows.Forms.Button btnValid_Login;
        private CoAndCoDBDataSet coAndCoDBDataSetLogin;
        private System.Windows.Forms.BindingSource userBindingSource;
        private CoAndCoDBDataSetTableAdapters.UserTableAdapter userTableAdapter;
    }
}