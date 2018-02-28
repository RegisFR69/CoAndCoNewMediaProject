namespace Projet_CoAndCo
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
            this.ckbBD = new System.Windows.Forms.CheckBox();
            this.ckbBook = new System.Windows.Forms.CheckBox();
            this.ckbSerie = new System.Windows.Forms.CheckBox();
            this.ckbMovie = new System.Windows.Forms.CheckBox();
            this.ckbMusic = new System.Windows.Forms.CheckBox();
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
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.genreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coAndCoDBDataSet = new Projet_CoAndCo.CoAndCoDBDataSet();
            this.genreTableAdapter = new Projet_CoAndCo.CoAndCoDBDataSetTableAdapters.GenreTableAdapter();
            this.NationalityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panelMedia.SuspendLayout();
            this.gpbTri.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Max)).BeginInit();
            this.panelTri.SuspendLayout();
            this.grpBoxFiltre.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coAndCoDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationalityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMedia
            // 
            this.panelMedia.BackColor = System.Drawing.Color.DarkGray;
            this.panelMedia.Controls.Add(this.ckbBD);
            this.panelMedia.Controls.Add(this.ckbBook);
            this.panelMedia.Controls.Add(this.ckbSerie);
            this.panelMedia.Controls.Add(this.ckbMovie);
            this.panelMedia.Controls.Add(this.ckbMusic);
            this.panelMedia.Location = new System.Drawing.Point(8, 43);
            this.panelMedia.Name = "panelMedia";
            this.panelMedia.Size = new System.Drawing.Size(770, 57);
            this.panelMedia.TabIndex = 5;
            this.panelMedia.TabStop = false;
            this.panelMedia.Text = "Médias";
            // 
            // ckbBD
            // 
            this.ckbBD.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbBD.BackColor = System.Drawing.Color.DarkGray;
            this.ckbBD.FlatAppearance.BorderSize = 0;
            this.ckbBD.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise;
            this.ckbBD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.ckbBD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbBD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBD.Location = new System.Drawing.Point(120, 19);
            this.ckbBD.Name = "ckbBD";
            this.ckbBD.Size = new System.Drawing.Size(90, 23);
            this.ckbBD.TabIndex = 4;
            this.ckbBD.Text = "Bande Dessiné";
            this.ckbBD.UseVisualStyleBackColor = false;
            // 
            // ckbBook
            // 
            this.ckbBook.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbBook.BackColor = System.Drawing.Color.DarkGray;
            this.ckbBook.FlatAppearance.BorderSize = 0;
            this.ckbBook.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise;
            this.ckbBook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.ckbBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbBook.Location = new System.Drawing.Point(440, 19);
            this.ckbBook.Name = "ckbBook";
            this.ckbBook.Size = new System.Drawing.Size(90, 23);
            this.ckbBook.TabIndex = 3;
            this.ckbBook.Text = "Livres";
            this.ckbBook.UseVisualStyleBackColor = false;
            this.ckbBook.CheckedChanged += new System.EventHandler(this.ckbBook_CheckedChanged);
            // 
            // ckbSerie
            // 
            this.ckbSerie.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbSerie.BackColor = System.Drawing.Color.DarkGray;
            this.ckbSerie.FlatAppearance.BorderSize = 0;
            this.ckbSerie.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise;
            this.ckbSerie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.ckbSerie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbSerie.Location = new System.Drawing.Point(226, 19);
            this.ckbSerie.Name = "ckbSerie";
            this.ckbSerie.Size = new System.Drawing.Size(90, 23);
            this.ckbSerie.TabIndex = 2;
            this.ckbSerie.Text = "Séries";
            this.ckbSerie.UseVisualStyleBackColor = false;
            // 
            // ckbMovie
            // 
            this.ckbMovie.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbMovie.BackColor = System.Drawing.Color.DarkGray;
            this.ckbMovie.FlatAppearance.BorderSize = 0;
            this.ckbMovie.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise;
            this.ckbMovie.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.ckbMovie.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMovie.Location = new System.Drawing.Point(332, 19);
            this.ckbMovie.Name = "ckbMovie";
            this.ckbMovie.Size = new System.Drawing.Size(90, 23);
            this.ckbMovie.TabIndex = 1;
            this.ckbMovie.Text = "Films";
            this.ckbMovie.UseVisualStyleBackColor = false;
            this.ckbMovie.CheckedChanged += new System.EventHandler(this.ckbMovie_CheckedChanged_1);
            // 
            // ckbMusic
            // 
            this.ckbMusic.Appearance = System.Windows.Forms.Appearance.Button;
            this.ckbMusic.BackColor = System.Drawing.Color.DarkGray;
            this.ckbMusic.FlatAppearance.BorderSize = 0;
            this.ckbMusic.FlatAppearance.CheckedBackColor = System.Drawing.Color.Turquoise;
            this.ckbMusic.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Turquoise;
            this.ckbMusic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ckbMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ckbMusic.Location = new System.Drawing.Point(11, 19);
            this.ckbMusic.Name = "ckbMusic";
            this.ckbMusic.Size = new System.Drawing.Size(90, 23);
            this.ckbMusic.TabIndex = 0;
            this.ckbMusic.Text = "Musique";
            this.ckbMusic.UseVisualStyleBackColor = false;
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
            this.gpbTri.Name = "gpbTri";
            this.gpbTri.Size = new System.Drawing.Size(770, 87);
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
            this.btnMaxTri.Location = new System.Drawing.Point(340, 60);
            this.btnMaxTri.Name = "btnMaxTri";
            this.btnMaxTri.Size = new System.Drawing.Size(90, 25);
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
            this.pnlYear.Location = new System.Drawing.Point(100, 15);
            this.pnlYear.Name = "pnlYear";
            this.pnlYear.Size = new System.Drawing.Size(650, 50);
            this.pnlYear.TabIndex = 3;
            this.pnlYear.Visible = false;
            // 
            // pnlAlpha
            // 
            this.pnlAlpha.Location = new System.Drawing.Point(100, 15);
            this.pnlAlpha.Name = "pnlAlpha";
            this.pnlAlpha.Size = new System.Drawing.Size(650, 50);
            this.pnlAlpha.TabIndex = 2;
            // 
            // radYears
            // 
            this.radYears.AutoSize = true;
            this.radYears.Location = new System.Drawing.Point(25, 42);
            this.radYears.Name = "radYears";
            this.radYears.Size = new System.Drawing.Size(61, 17);
            this.radYears.TabIndex = 1;
            this.radYears.Text = "Années";
            this.radYears.UseVisualStyleBackColor = true;
            this.radYears.CheckedChanged += new System.EventHandler(this.radYears_CheckedChanged);
            // 
            // radAlpha
            // 
            this.radAlpha.AutoSize = true;
            this.radAlpha.Checked = true;
            this.radAlpha.Location = new System.Drawing.Point(25, 19);
            this.radAlpha.Name = "radAlpha";
            this.radAlpha.Size = new System.Drawing.Size(52, 17);
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
            this.btnMinTri.Location = new System.Drawing.Point(340, 194);
            this.btnMinTri.Name = "btnMinTri";
            this.btnMinTri.Size = new System.Drawing.Size(90, 25);
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
            this.btnSearchTri.Location = new System.Drawing.Point(340, 214);
            this.btnSearchTri.Name = "btnSearchTri";
            this.btnSearchTri.Size = new System.Drawing.Size(90, 30);
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
            this.chkLstBoxGenre.Location = new System.Drawing.Point(25, 48);
            this.chkLstBoxGenre.Name = "chkLstBoxGenre";
            this.chkLstBoxGenre.Size = new System.Drawing.Size(150, 196);
            this.chkLstBoxGenre.TabIndex = 8;
            // 
            // lblGenre
            // 
            this.lblGenre.AutoSize = true;
            this.lblGenre.Location = new System.Drawing.Point(19, 29);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(36, 13);
            this.lblGenre.TabIndex = 9;
            this.lblGenre.Text = "Genre";
            // 
            // trackBar_Min
            // 
            this.trackBar_Min.Location = new System.Drawing.Point(246, 64);
            this.trackBar_Min.Maximum = 2018;
            this.trackBar_Min.Minimum = 1950;
            this.trackBar_Min.Name = "trackBar_Min";
            this.trackBar_Min.Size = new System.Drawing.Size(274, 45);
            this.trackBar_Min.TabIndex = 12;
            this.trackBar_Min.Value = 1950;
            this.trackBar_Min.Scroll += new System.EventHandler(this.trackBar_Min_Scroll);
            // 
            // trackBar_Max
            // 
            this.trackBar_Max.Location = new System.Drawing.Point(246, 112);
            this.trackBar_Max.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar_Max.Maximum = 2018;
            this.trackBar_Max.Minimum = 1950;
            this.trackBar_Max.Name = "trackBar_Max";
            this.trackBar_Max.Size = new System.Drawing.Size(274, 45);
            this.trackBar_Max.TabIndex = 13;
            this.trackBar_Max.Value = 2018;
            this.trackBar_Max.Scroll += new System.EventHandler(this.trackBar_Max_Scroll);
            // 
            // panelTri
            // 
            this.panelTri.BackColor = System.Drawing.Color.DarkGray;
            this.panelTri.Controls.Add(this.grpBoxFiltre);
            this.panelTri.Controls.Add(this.gpbTri);
            this.panelTri.Location = new System.Drawing.Point(8, 106);
            this.panelTri.Name = "panelTri";
            this.panelTri.Size = new System.Drawing.Size(770, 367);
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
            this.grpBoxFiltre.Controls.Add(this.checkedListBox1);
            this.grpBoxFiltre.Controls.Add(this.lblGenre);
            this.grpBoxFiltre.Controls.Add(this.trackBar_Min);
            this.grpBoxFiltre.Controls.Add(this.trackBar_Max);
            this.grpBoxFiltre.Controls.Add(this.chkLstBoxGenre);
            this.grpBoxFiltre.Controls.Add(this.btnSearchTri);
            this.grpBoxFiltre.Controls.Add(this.btnMinTri);
            this.grpBoxFiltre.Location = new System.Drawing.Point(0, 91);
            this.grpBoxFiltre.Name = "grpBoxFiltre";
            this.grpBoxFiltre.Padding = new System.Windows.Forms.Padding(0);
            this.grpBoxFiltre.Size = new System.Drawing.Size(770, 254);
            this.grpBoxFiltre.TabIndex = 9;
            this.grpBoxFiltre.TabStop = false;
            this.grpBoxFiltre.Text = "Filtrer par";
            // 
            // txtMax
            // 
            this.txtMax.BackColor = System.Drawing.Color.Turquoise;
            this.txtMax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMax.Location = new System.Drawing.Point(298, 96);
            this.txtMax.Name = "txtMax";
            this.txtMax.Size = new System.Drawing.Size(40, 13);
            this.txtMax.TabIndex = 20;
            this.txtMax.Text = "2018";
            this.txtMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMax.Validating += new System.ComponentModel.CancelEventHandler(this.txtMax_Validating);
            // 
            // txtMin
            // 
            this.txtMin.BackColor = System.Drawing.Color.Turquoise;
            this.txtMin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMin.Location = new System.Drawing.Point(298, 48);
            this.txtMin.Name = "txtMin";
            this.txtMin.Size = new System.Drawing.Size(40, 13);
            this.txtMin.TabIndex = 19;
            this.txtMin.Text = "1950";
            this.txtMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMin.Validating += new System.ComponentModel.CancelEventHandler(this.txtMin_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(261, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "et";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "entre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(243, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Années";
            // 
            // lblNationality
            // 
            this.lblNationality.AutoSize = true;
            this.lblNationality.Location = new System.Drawing.Point(597, 29);
            this.lblNationality.Name = "lblNationality";
            this.lblNationality.Size = new System.Drawing.Size(57, 13);
            this.lblNationality.TabIndex = 15;
            this.lblNationality.Text = "Nationalité";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.BackColor = System.Drawing.Color.DarkGray;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "France",
            "U.S.A.",
            "Allemagne",
            "Grande-Bretagne",
            "Italie",
            "Inde",
            "Espagne"});
            this.checkedListBox1.Location = new System.Drawing.Point(600, 48);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(150, 184);
            this.checkedListBox1.TabIndex = 14;
            // 
            // genreBindingSource
            // 
            this.genreBindingSource.DataMember = "Genre";
            this.genreBindingSource.DataSource = this.coAndCoDBDataSet;
            this.genreBindingSource.CurrentChanged += new System.EventHandler(this.genreBindingSource_CurrentChanged);
            // 
            // coAndCoDBDataSet
            // 
            this.coAndCoDBDataSet.DataSetName = "CoAndCoDBDataSet";
            this.coAndCoDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // genreTableAdapter
            // 
            this.genreTableAdapter.ClearBeforeFill = true;
            // 
            // frmSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelMedia);
            this.Controls.Add(this.panelTri);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "frmSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Co & Co Média";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSearch_FormClosed);
            this.Load += new System.EventHandler(this.frmSearch_Load);
            this.Controls.SetChildIndex(this.panelTri, 0);
            this.Controls.SetChildIndex(this.panelMedia, 0);
            this.panelMedia.ResumeLayout(false);
            this.gpbTri.ResumeLayout(false);
            this.gpbTri.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_Max)).EndInit();
            this.panelTri.ResumeLayout(false);
            this.grpBoxFiltre.ResumeLayout(false);
            this.grpBoxFiltre.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.genreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coAndCoDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NationalityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox panelMedia;
        private System.Windows.Forms.CheckBox ckbBD;
        private System.Windows.Forms.CheckBox ckbBook;
        private System.Windows.Forms.CheckBox ckbSerie;
        private System.Windows.Forms.CheckBox ckbMovie;
        private System.Windows.Forms.CheckBox ckbMusic;
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
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private CoAndCoDBDataSet coAndCoDBDataSet;
        private System.Windows.Forms.BindingSource genreBindingSource;
        private CoAndCoDBDataSetTableAdapters.GenreTableAdapter genreTableAdapter;
        private System.Windows.Forms.BindingSource NationalityBindingSource;
    }
}

