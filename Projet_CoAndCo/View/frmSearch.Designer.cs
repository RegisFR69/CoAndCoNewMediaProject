﻿namespace Projet_CoAndCo
{
    partial class frmSearch
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearch));
            this.panelMedia = new System.Windows.Forms.GroupBox();
            this.gpbTri = new System.Windows.Forms.GroupBox();
            this.btnMaxTri = new System.Windows.Forms.Button();
            this.pnlYear = new System.Windows.Forms.Panel();
            this.pnlAlpha = new System.Windows.Forms.Panel();
            this.radYears = new System.Windows.Forms.RadioButton();
            this.radAlpha = new System.Windows.Forms.RadioButton();
            this.btnMinTri = new System.Windows.Forms.Button();
            this.btnSearchTri = new System.Windows.Forms.Button();
            this.imageList_Icon_64 = new System.Windows.Forms.ImageList(this.components);
            this.chkLstBoxGenre = new System.Windows.Forms.CheckedListBox();
            this.lblGenre = new System.Windows.Forms.Label();
            this.trackBar_Min = new System.Windows.Forms.TrackBar();
            this.trackBar_Max = new System.Windows.Forms.TrackBar();
            this.panelTri = new System.Windows.Forms.Panel();
            this.grpBoxFiltre = new System.Windows.Forms.GroupBox();
            this.txtMax = new System.Windows.Forms.TextBox();
            this.txtMin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblNationality = new System.Windows.Forms.Label();
            this.chkLstBoxNationality = new System.Windows.Forms.CheckedListBox();
            this.release_year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet1 = new Projet_CoAndCo.Data.DataSet1();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.genreTableAdapter = new Projet_CoAndCo.Data.DataSet1TableAdapters.GenreTableAdapter();
            this.nationalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nationalityTableAdapter = new Projet_CoAndCo.Data.DataSet1TableAdapters.NationalityTableAdapter();
            this.type_MediaTableAdapter = new Projet_CoAndCo.Data.DataSet1TableAdapters.Type_MediaTableAdapter();
            this.type_MediaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.mediaTableAdapter = new Projet_CoAndCo.Data.DataSet1TableAdapters.MediaTableAdapter();
            this.panelResult = new System.Windows.Forms.Panel();
            this.gpbTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Max)).BeginInit();
            this.panelTri.SuspendLayout();
            this.grpBoxFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_MediaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMedia
            // 
            this.panelMedia.BackColor = System.Drawing.Color.DarkGray;
            this.panelMedia.Location = new System.Drawing.Point(11, 53);
            this.panelMedia.Margin = new System.Windows.Forms.Padding(4);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Padding = new System.Windows.Forms.Padding(4);
            this.panelMedia.Size = new System.Drawing.Size(1027, 70);
            this.panelMedia.TabIndex = 5;
            this.panelMedia.TabStop = false;
            this.panelMedia.Text = "Médias";
            // 
            // gpbTri
            // 
            this.gpbTri.BackColor = System.Drawing.Color.DarkGray;
            this.gpbTri.Controls.Add(this.btnMaxTri);
            this.gpbTri.Controls.Add(this.pnlYear);
            this.gpbTri.Controls.Add(this.pnlAlpha);
            this.gpbTri.Controls.Add(this.radYears);
            this.gpbTri.Controls.Add(this.radAlpha);
            this.gpbTri.Location = new System.Drawing.Point(0, 0);
            this.gpbTri.Margin = new System.Windows.Forms.Padding(4);
            this.gpbTri.Name = "gpbTri";
            this.gpbTri.Padding = new System.Windows.Forms.Padding(4);
            this.gpbTri.Size = new System.Drawing.Size(1027, 107);
            this.gpbTri.TabIndex = 8;
            this.gpbTri.TabStop = false;
            this.gpbTri.Text = "Trier par";
            // 
            // btnMaxTri
            // 
            this.btnMaxTri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMaxTri.BackgroundImage")));
            this.btnMaxTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMaxTri.FlatAppearance.BorderSize = 0;
            this.btnMaxTri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMaxTri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMaxTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxTri.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaxTri.Location = new System.Drawing.Point(453, 74);
            this.btnMaxTri.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaxTri.Name = "btnMaxTri";
            this.btnMaxTri.Size = new System.Drawing.Size(120, 31);
            this.btnMaxTri.TabIndex = 6;
            this.btnMaxTri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMaxTri.UseVisualStyleBackColor = true;
            this.btnMaxTri.Click += new System.EventHandler(this.btnMaxTri_Click);
            this.btnMaxTri.MouseLeave += new System.EventHandler(this.btnMaxTri_MouseLeave);
            this.btnMaxTri.MouseHover += new System.EventHandler(this.btnMaxTri_MouseHover);
            // 
            // pnlYear
            // 
            this.pnlYear.BackColor = System.Drawing.Color.DarkGray;
            this.pnlYear.Location = new System.Drawing.Point(133, 18);
            this.pnlYear.Margin = new System.Windows.Forms.Padding(4);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(867, 62);
            this.pnlYear.TabIndex = 3;
            this.pnlYear.Visible = false;
            // 
            // pnlAlpha
            // 
            this.pnlAlpha.Location = new System.Drawing.Point(133, 18);
            this.pnlAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.pnlAlpha.Name = "pnlAlpha";
            this.pnlAlpha.Size = new System.Drawing.Size(867, 62);
            this.pnlAlpha.TabIndex = 2;
            // 
            // radYears
            // 
            this.radYears.AutoSize = true;
            this.radYears.Location = new System.Drawing.Point(33, 52);
            this.radYears.Margin = new System.Windows.Forms.Padding(4);
            this.radYears.Name = "radYears";
            this.radYears.Size = new System.Drawing.Size(77, 21);
            this.radYears.TabIndex = 1;
            this.radYears.Text = "Années";
            this.radYears.UseVisualStyleBackColor = true;
            this.radYears.CheckedChanged += new System.EventHandler(this.radYears_CheckedChanged);
            // 
            // radAlpha
            // 
            this.radAlpha.AutoSize = true;
            this.radAlpha.Checked = true;
            this.radAlpha.Location = new System.Drawing.Point(33, 23);
            this.radAlpha.Margin = new System.Windows.Forms.Padding(4);
            this.radAlpha.Name = "radAlpha";
            this.radAlpha.Size = new System.Drawing.Size(65, 21);
            this.radAlpha.TabIndex = 0;
            this.radAlpha.TabStop = true;
            this.radAlpha.Text = "Alpha";
            this.radAlpha.UseVisualStyleBackColor = true;
            this.radAlpha.CheckedChanged += new System.EventHandler(this.radAlpha_CheckedChanged);
            // 
            // btnMinTri
            // 
            this.btnMinTri.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMinTri.BackgroundImage")));
            this.btnMinTri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinTri.FlatAppearance.BorderSize = 0;
            this.btnMinTri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.btnMinTri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkGray;
            this.btnMinTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinTri.Location = new System.Drawing.Point(453, 239);
            this.btnMinTri.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinTri.Name = "btnMinTri";
            this.btnMinTri.Size = new System.Drawing.Size(120, 31);
            this.btnMinTri.TabIndex = 7;
            this.btnMinTri.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnMinTri.UseVisualStyleBackColor = true;
            this.btnMinTri.Click += new System.EventHandler(this.btnMinTri_Click);
            this.btnMinTri.MouseLeave += new System.EventHandler(this.btnMinTri_MouseLeave);
            this.btnMinTri.MouseHover += new System.EventHandler(this.btnMinTri_MouseHover);
            // 
            // btnSearchTri
            // 
            this.btnSearchTri.FlatAppearance.BorderSize = 0;
            this.btnSearchTri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.btnSearchTri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchTri.Location = new System.Drawing.Point(453, 263);
            this.btnSearchTri.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchTri.Name = "btnSearchTri";
            this.btnSearchTri.Size = new System.Drawing.Size(120, 37);
            this.btnSearchTri.TabIndex = 5;
            this.btnSearchTri.Text = "Rechercher";
            this.btnSearchTri.UseVisualStyleBackColor = true;
            this.btnSearchTri.Click += new System.EventHandler(this.btnSearchTri_Click);
            // 
            // imageList_Icon_64
            // 
            this.imageList_Icon_64.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList_Icon_64.ImageStream")));
            this.imageList_Icon_64.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList_Icon_64.Images.SetKeyName(0, "Bottom_64_40D0E0.png");
            this.imageList_Icon_64.Images.SetKeyName(1, "Bottom_64_Black.png");
            this.imageList_Icon_64.Images.SetKeyName(2, "Top_64_40D0E0.png");
            this.imageList_Icon_64.Images.SetKeyName(3, "Top_64_Black.png");
            // 
            // chkLstBoxGenre
            // 
            this.chkLstBoxGenre.BackColor = System.Drawing.Color.DarkGray;
            this.chkLstBoxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkLstBoxGenre.FormattingEnabled = true;
            this.chkLstBoxGenre.Location = new System.Drawing.Point(33, 59);
            this.chkLstBoxGenre.Margin = new System.Windows.Forms.Padding(4);
            this.chkLstBoxGenre.Name = "chkLstBoxGenre";
            this.chkLstBoxGenre.Size = new System.Drawing.Size(199, 232);
            this.chkLstBoxGenre.TabIndex = 8;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(25, 36);
            this.lblGenre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(48, 17);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre";
            // 
            // trackBar_Min
            // 
            this.trackBar_Min.Location = new System.Drawing.Point(328, 79);
            this.trackBar_Min.Margin = new System.Windows.Forms.Padding(4);
            this.trackBar_Min.Maximum = 2018;
            this.trackBar_Min.Minimum = 1950;
            this.trackBar_Min.Name = "trackBar_Min";
            this.trackBar_Min.Size = new System.Drawing.Size(365, 56);
            this.trackBar_Min.TabIndex = 12;
            this.trackBar_Min.Value = 1950;
            this.trackBar_Min.Scroll += new System.EventHandler(this.trackBar_Min_Scroll);
            // 
            // trackBar_Max
            // 
            this.trackBar_Max.Location = new System.Drawing.Point(328, 138);
            this.trackBar_Max.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar_Max.Maximum = 2018;
            this.trackBar_Max.Minimum = 1950;
            this.trackBar_Max.Name = "trackBar_Max";
            this.trackBar_Max.Size = new System.Drawing.Size(365, 56);
            this.trackBar_Max.TabIndex = 13;
            this.trackBar_Max.Value = 2018;
            this.trackBar_Max.Scroll += new System.EventHandler(this.trackBar_Max_Scroll);
            // 
            // panelTri
            // 
            this.panelTri.BackColor = System.Drawing.Color.DarkGray;
            this.panelTri.Controls.Add(this.grpBoxFiltre);
            this.panelTri.Controls.Add(this.gpbTri);
            this.panelTri.Location = new System.Drawing.Point(11, 130);
            this.panelTri.Margin = new System.Windows.Forms.Padding(4);
            this.panelTri.Name = "panelTri";
            this.panelTri.Size = new System.Drawing.Size(1027, 452);
            this.panelTri.TabIndex = 9;
            // 
            // grpBoxFiltre
            // 
            this.grpBoxFiltre.Controls.Add(this.txtMax);
            this.grpBoxFiltre.Controls.Add(this.txtMin);
            this.grpBoxFiltre.Controls.Add(this.label3);
            this.grpBoxFiltre.Controls.Add(this.label1);
            this.grpBoxFiltre.Controls.Add(this.label2);
            this.grpBoxFiltre.Controls.Add(this.lblNationality);
            this.grpBoxFiltre.Controls.Add(this.chkLstBoxNationality);
            this.grpBoxFiltre.Controls.Add(this.lblGenre);
            this.grpBoxFiltre.Controls.Add(this.trackBar_Min);
            this.grpBoxFiltre.Controls.Add(this.trackBar_Max);
            this.grpBoxFiltre.Controls.Add(this.chkLstBoxGenre);
            this.grpBoxFiltre.Controls.Add(this.btnSearchTri);
            this.grpBoxFiltre.Controls.Add(this.btnMinTri);
            this.grpBoxFiltre.Location = new System.Drawing.Point(0, 112);
            this.grpBoxFiltre.Margin = new System.Windows.Forms.Padding(4);
            this.grpBoxFiltre.Name = "grpBoxFiltre";
            this.grpBoxFiltre.Padding = new System.Windows.Forms.Padding(0);
            this.grpBoxFiltre.Size = new System.Drawing.Size(1027, 313);
            this.grpBoxFiltre.TabIndex = 9;
            this.grpBoxFiltre.TabStop = false;
            this.grpBoxFiltre.Text = "Filtrer par";
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.Turquoise;
            this.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMax.Location = new System.Drawing.Point(397, 118);
            this.txtMax.Margin = new System.Windows.Forms.Padding(4);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(53, 15);
            this.txtMax.TabIndex = 20;
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtMax_Validating);
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Turquoise;
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMin.Location = new System.Drawing.Point(397, 59);
            this.txtMin.Margin = new System.Windows.Forms.Padding(4);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(53, 15);
            this.txtMin.TabIndex = 19;
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtMin_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(348, 118);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "et";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(348, 59);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 17;
            this.label1.Text = "entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(324, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 16;
            this.label2.Text = "Années";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(796, 36);
            this.lblNationality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(75, 17);
            this.lblNationality.TabIndex = 15;
            this.lblNationality.Text = "Nationalité";
            // 
            // chkLstBoxNationality
            // 
            this.chkLstBoxNationality.BackColor = System.Drawing.Color.DarkGray;
            this.chkLstBoxNationality.FormattingEnabled = true;
            this.chkLstBoxNationality.Location = new System.Drawing.Point(800, 59);
            this.chkLstBoxNationality.Margin = new System.Windows.Forms.Padding(4);
            this.chkLstBoxNationality.Name = "chkLstBoxNationality";
            this.chkLstBoxNationality.Size = new System.Drawing.Size(199, 225);
            this.chkLstBoxNationality.TabIndex = 14;
            // 
            // release_year
            // 
            this.release_year.DataPropertyName = "release_year";
            this.release_year.HeaderText = "release_year";
            this.release_year.Name = "release_year";
            // 
            // mediaBindingSource
            // 
            this.mediaBindingSource.DataMember = "Media";
            this.mediaBindingSource.DataSource = this.dataSet1;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "DataSet1";
            this.dataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.dataSet1;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // nationalityBindingSource
            // 
            this.nationalityBindingSource.DataMember = "Nationality";
            this.nationalityBindingSource.DataSource = this.dataSet1;
            // 
            // nationalityTableAdapter
            // 
            this.nationalityTableAdapter.ClearBeforeFill = true;
            // 
            // type_MediaTableAdapter
            // 
            this.type_MediaTableAdapter.ClearBeforeFill = true;
            // 
            // type_MediaBindingSource
            // 
            this.type_MediaBindingSource.DataMember = "Type_Media";
            this.type_MediaBindingSource.DataSource = this.dataSet1;
            // 
            // mediaTableAdapter
            // 
            this.mediaTableAdapter.ClearBeforeFill = true;
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.DarkGray;
            this.panelResult.Location = new System.Drawing.Point(11, 242);
            this.panelResult.Margin = new System.Windows.Forms.Padding(4);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(1027, 433);
            this.panelResult.TabIndex = 9;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1045, 690);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.panelMedia);
            this.Controls.Add(this.panelTri);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1061, 728);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Co & Co Média";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSearch_FormClosed);
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.Controls.SetChildIndex(this.panelTri, 0);
            this.Controls.SetChildIndex(this.panelMedia, 0);
            this.Controls.SetChildIndex(this.panelResult, 0);
            this.gpbTri.ResumeLayout(false);
            this.gpbTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Max)).EndInit();
            this.panelTri.ResumeLayout(false);
            this.grpBoxFiltre.ResumeLayout(false);
            this.grpBoxFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mediaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nationalityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.type_MediaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox panelMedia;
        private System.Windows.Forms.GroupBox gpbTri;
        private System.Windows.Forms.Button btnSearchTri;
        private System.Windows.Forms.Panel pnlYear;
        private System.Windows.Forms.Panel pnlAlpha;
        private System.Windows.Forms.RadioButton radYears;
        private System.Windows.Forms.RadioButton radAlpha;
        private System.Windows.Forms.Button btnMaxTri;
        private System.Windows.Forms.Button btnMinTri;
        private System.Windows.Forms.ImageList imageList_Icon_64;
        private System.Windows.Forms.Label lblGenre;
        private System.Windows.Forms.CheckedListBox chkLstBoxGenre;
        private System.Windows.Forms.TrackBar trackBar_Min;
        private System.Windows.Forms.TrackBar trackBar_Max;
        private System.Windows.Forms.Panel panelTri;
        private System.Windows.Forms.GroupBox grpBoxFiltre;
        private System.Windows.Forms.TextBox txtMax;
        private System.Windows.Forms.TextBox txtMin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblNationality;
        private System.Windows.Forms.CheckedListBox chkLstBoxNationality;
        private Data.DataSet1 dataSet1;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private Data.DataSet1TableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource nationalityBindingSource;
        private Data.DataSet1TableAdapters.NationalityTableAdapter nationalityTableAdapter;
        private Data.DataSet1TableAdapters.Type_MediaTableAdapter type_MediaTableAdapter;
        private System.Windows.Forms.BindingSource type_MediaBindingSource;
        private System.Windows.Forms.BindingSource mediaBindingSource;
        private Data.DataSet1TableAdapters.MediaTableAdapter mediaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn release_year;
        private System.Windows.Forms.Panel panelResult;
    }
}

