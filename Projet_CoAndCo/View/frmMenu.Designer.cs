namespace Projet_CoAndCo
{
    partial class frmMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menuBar_menuFichier = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_itemNewPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_fichier_itemAddPath = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_itemAddFic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_itemAddMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_fichier_itemAddExemplaire = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_itemDeleteExemplaire = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_fichier_itemSearchMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_fichier_separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_fichier_itemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_menuAffichage = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_affichage_itemListe = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_affichage_itemSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_affichage_itemBigIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_affichage_separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_affichage_itemMosaic = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_affichage_separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_affichage_itemYear = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_affichage_itemGender = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_affichage_separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_affichage_itemDiapo = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_menuMedia = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_media_itemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_media_itemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_media_itemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_media_itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_menuPlaylist = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_Playlist_itemAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_playlist_itemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_playlist_itemSearch = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_playlist_itemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_menuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_tools_itemPath = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_tools_itemUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_tools_itemOptions = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_menuHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_help_itemSummary = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_help_itemShortcut = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_aide_separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuBar_help_itemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_btnConnection = new System.Windows.Forms.ToolStripMenuItem();
            this.menuMenuBar = new System.Windows.Forms.MenuStrip();
            this.menuBar_txtMemberName = new System.Windows.Forms.ToolStripMenuItem();
            this.menuBar_lblIdUser = new System.Windows.Forms.ToolStripMenuItem();
            this.typeUserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.coAndCoDBDataSetMenu = new Projet_CoAndCo.CoAndCoDBDataSet();
            this.type_UserTableAdapter = new Projet_CoAndCo.CoAndCoDBDataSetTableAdapters.Type_UserTableAdapter();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Projet_CoAndCo.CoAndCoDBDataSetTableAdapters.UserTableAdapter();
            this.menuMenuBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coAndCoDBDataSetMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuBar_menuFichier
            // 
            this.menuBar_menuFichier.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.menuBar_menuFichier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_fichier_itemNewPlaylist,
            this.menuBar_fichier_separator1,
            this.menuBar_fichier_itemAddPath,
            this.menuBar_fichier_itemAddFic,
            this.menuBar_fichier_itemAddMedia,
            this.menuBar_fichier_separator2,
            this.menuBar_fichier_itemAddExemplaire,
            this.menuBar_fichier_itemDeleteExemplaire,
            this.menuBar_fichier_separator3,
            this.menuBar_fichier_itemSearchMedia,
            this.menuBar_fichier_separator4,
            this.menuBar_fichier_itemExit});
            this.menuBar_menuFichier.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBar_menuFichier.Name = "menuBar_menuFichier";
            this.menuBar_menuFichier.Size = new System.Drawing.Size(54, 20);
            this.menuBar_menuFichier.Text = "Fichier";
            this.menuBar_menuFichier.DropDownClosed += new System.EventHandler(this.menuBar_menuFichier_DropDownClosed);
            this.menuBar_menuFichier.MouseEnter += new System.EventHandler(this.menuBar_menuFichier_MouseEnter);
            this.menuBar_menuFichier.MouseLeave += new System.EventHandler(this.menuBar_menuFichier_MouseLeave);
            // 
            // menuBar_fichier_itemNewPlaylist
            // 
            this.menuBar_fichier_itemNewPlaylist.Name = "menuBar_fichier_itemNewPlaylist";
            this.menuBar_fichier_itemNewPlaylist.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemNewPlaylist.Text = "Nouvelle playlist";
            this.menuBar_fichier_itemNewPlaylist.Visible = false;
            // 
            // menuBar_fichier_separator1
            // 
            this.menuBar_fichier_separator1.Name = "menuBar_fichier_separator1";
            this.menuBar_fichier_separator1.Size = new System.Drawing.Size(223, 6);
            this.menuBar_fichier_separator1.Visible = false;
            // 
            // menuBar_fichier_itemAddPath
            // 
            this.menuBar_fichier_itemAddPath.Name = "menuBar_fichier_itemAddPath";
            this.menuBar_fichier_itemAddPath.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemAddPath.Text = "Ajouter un dossier";
            this.menuBar_fichier_itemAddPath.Visible = false;
            // 
            // menuBar_fichier_itemAddFic
            // 
            this.menuBar_fichier_itemAddFic.Name = "menuBar_fichier_itemAddFic";
            this.menuBar_fichier_itemAddFic.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemAddFic.Text = "Ajouter un fichier";
            this.menuBar_fichier_itemAddFic.Visible = false;
            // 
            // menuBar_fichier_itemAddMedia
            // 
            this.menuBar_fichier_itemAddMedia.Name = "menuBar_fichier_itemAddMedia";
            this.menuBar_fichier_itemAddMedia.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemAddMedia.Text = "Ajouter un média";
            this.menuBar_fichier_itemAddMedia.Visible = false;
            // 
            // menuBar_fichier_separator2
            // 
            this.menuBar_fichier_separator2.Name = "menuBar_fichier_separator2";
            this.menuBar_fichier_separator2.Size = new System.Drawing.Size(223, 6);
            this.menuBar_fichier_separator2.Visible = false;
            // 
            // menuBar_fichier_itemAddExemplaire
            // 
            this.menuBar_fichier_itemAddExemplaire.Name = "menuBar_fichier_itemAddExemplaire";
            this.menuBar_fichier_itemAddExemplaire.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemAddExemplaire.Text = "Ajouter un exemplaire";
            this.menuBar_fichier_itemAddExemplaire.Visible = false;
            // 
            // menuBar_fichier_itemDeleteExemplaire
            // 
            this.menuBar_fichier_itemDeleteExemplaire.Name = "menuBar_fichier_itemDeleteExemplaire";
            this.menuBar_fichier_itemDeleteExemplaire.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemDeleteExemplaire.Text = "Supprimer un exemplaire";
            this.menuBar_fichier_itemDeleteExemplaire.Visible = false;
            // 
            // menuBar_fichier_separator3
            // 
            this.menuBar_fichier_separator3.Name = "menuBar_fichier_separator3";
            this.menuBar_fichier_separator3.Size = new System.Drawing.Size(223, 6);
            this.menuBar_fichier_separator3.Visible = false;
            // 
            // menuBar_fichier_itemSearchMedia
            // 
            this.menuBar_fichier_itemSearchMedia.Name = "menuBar_fichier_itemSearchMedia";
            this.menuBar_fichier_itemSearchMedia.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.menuBar_fichier_itemSearchMedia.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemSearchMedia.Text = "Rechercher un média";
            // 
            // menuBar_fichier_separator4
            // 
            this.menuBar_fichier_separator4.Name = "menuBar_fichier_separator4";
            this.menuBar_fichier_separator4.Size = new System.Drawing.Size(223, 6);
            // 
            // menuBar_fichier_itemExit
            // 
            this.menuBar_fichier_itemExit.Name = "menuBar_fichier_itemExit";
            this.menuBar_fichier_itemExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.menuBar_fichier_itemExit.Size = new System.Drawing.Size(226, 22);
            this.menuBar_fichier_itemExit.Text = "Quitter";
            // 
            // menuBar_menuAffichage
            // 
            this.menuBar_menuAffichage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_affichage_itemListe,
            this.menuBar_affichage_itemSmallIcon,
            this.menuBar_affichage_itemBigIcon,
            this.menuBar_affichage_separator1,
            this.menuBar_affichage_itemMosaic,
            this.menuBar_affichage_separator2,
            this.menuBar_affichage_itemYear,
            this.menuBar_affichage_itemGender,
            this.menuBar_affichage_separator3,
            this.menuBar_affichage_itemDiapo});
            this.menuBar_menuAffichage.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBar_menuAffichage.Name = "menuBar_menuAffichage";
            this.menuBar_menuAffichage.Size = new System.Drawing.Size(70, 20);
            this.menuBar_menuAffichage.Text = "Affichage";
            this.menuBar_menuAffichage.DropDownClosed += new System.EventHandler(this.menuBar_menuAffichage_DropDownClosed);
            this.menuBar_menuAffichage.MouseEnter += new System.EventHandler(this.menuBar_menuAffichage_MouseEnter);
            this.menuBar_menuAffichage.MouseLeave += new System.EventHandler(this.menuBar_menuAffichage_MouseLeave);
            // 
            // menuBar_affichage_itemListe
            // 
            this.menuBar_affichage_itemListe.Name = "menuBar_affichage_itemListe";
            this.menuBar_affichage_itemListe.Size = new System.Drawing.Size(154, 22);
            this.menuBar_affichage_itemListe.Text = "Liste";
            // 
            // menuBar_affichage_itemSmallIcon
            // 
            this.menuBar_affichage_itemSmallIcon.Name = "menuBar_affichage_itemSmallIcon";
            this.menuBar_affichage_itemSmallIcon.Size = new System.Drawing.Size(154, 22);
            this.menuBar_affichage_itemSmallIcon.Text = "Petites icones";
            // 
            // menuBar_affichage_itemBigIcon
            // 
            this.menuBar_affichage_itemBigIcon.Name = "menuBar_affichage_itemBigIcon";
            this.menuBar_affichage_itemBigIcon.Size = new System.Drawing.Size(154, 22);
            this.menuBar_affichage_itemBigIcon.Text = "Grandes icones";
            // 
            // menuBar_affichage_separator1
            // 
            this.menuBar_affichage_separator1.Name = "menuBar_affichage_separator1";
            this.menuBar_affichage_separator1.Size = new System.Drawing.Size(151, 6);
            // 
            // menuBar_affichage_itemMosaic
            // 
            this.menuBar_affichage_itemMosaic.Name = "menuBar_affichage_itemMosaic";
            this.menuBar_affichage_itemMosaic.ShowShortcutKeys = false;
            this.menuBar_affichage_itemMosaic.Size = new System.Drawing.Size(154, 22);
            this.menuBar_affichage_itemMosaic.Text = "Mosaïques";
            // 
            // menuBar_affichage_separator2
            // 
            this.menuBar_affichage_separator2.Name = "menuBar_affichage_separator2";
            this.menuBar_affichage_separator2.Size = new System.Drawing.Size(151, 6);
            // 
            // menuBar_affichage_itemYear
            // 
            this.menuBar_affichage_itemYear.CheckOnClick = true;
            this.menuBar_affichage_itemYear.Name = "menuBar_affichage_itemYear";
            this.menuBar_affichage_itemYear.Size = new System.Drawing.Size(154, 22);
            this.menuBar_affichage_itemYear.Text = "Année";
            // 
            // menuBar_affichage_itemGender
            // 
            this.menuBar_affichage_itemGender.CheckOnClick = true;
            this.menuBar_affichage_itemGender.Name = "menuBar_affichage_itemGender";
            this.menuBar_affichage_itemGender.Size = new System.Drawing.Size(154, 22);
            this.menuBar_affichage_itemGender.Text = "Genre";
            // 
            // menuBar_affichage_separator3
            // 
            this.menuBar_affichage_separator3.Name = "menuBar_affichage_separator3";
            this.menuBar_affichage_separator3.Size = new System.Drawing.Size(151, 6);
            // 
            // menuBar_affichage_itemDiapo
            // 
            this.menuBar_affichage_itemDiapo.Name = "menuBar_affichage_itemDiapo";
            this.menuBar_affichage_itemDiapo.Size = new System.Drawing.Size(154, 22);
            this.menuBar_affichage_itemDiapo.Text = "Diaporama";
            // 
            // menuBar_menuMedia
            // 
            this.menuBar_menuMedia.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_media_itemAdd,
            this.menuBar_media_itemUpdate,
            this.menuBar_media_itemSearch,
            this.menuBar_media_itemDelete});
            this.menuBar_menuMedia.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBar_menuMedia.Name = "menuBar_menuMedia";
            this.menuBar_menuMedia.Size = new System.Drawing.Size(52, 20);
            this.menuBar_menuMedia.Text = "Media";
            this.menuBar_menuMedia.DropDownClosed += new System.EventHandler(this.menuBar_menuMedia_DropDownClosed);
            this.menuBar_menuMedia.MouseEnter += new System.EventHandler(this.menuBar_menuMedia_MouseEnter);
            this.menuBar_menuMedia.MouseLeave += new System.EventHandler(this.menuBar_menuMedia_MouseLeave);
            // 
            // menuBar_media_itemAdd
            // 
            this.menuBar_media_itemAdd.Name = "menuBar_media_itemAdd";
            this.menuBar_media_itemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.menuBar_media_itemAdd.Size = new System.Drawing.Size(155, 22);
            this.menuBar_media_itemAdd.Text = "Ajouter";
            // 
            // menuBar_media_itemUpdate
            // 
            this.menuBar_media_itemUpdate.Name = "menuBar_media_itemUpdate";
            this.menuBar_media_itemUpdate.Size = new System.Drawing.Size(155, 22);
            this.menuBar_media_itemUpdate.Text = "Modifier";
            // 
            // menuBar_media_itemSearch
            // 
            this.menuBar_media_itemSearch.Name = "menuBar_media_itemSearch";
            this.menuBar_media_itemSearch.Size = new System.Drawing.Size(155, 22);
            this.menuBar_media_itemSearch.Text = "Rechercher";
            // 
            // menuBar_media_itemDelete
            // 
            this.menuBar_media_itemDelete.Name = "menuBar_media_itemDelete";
            this.menuBar_media_itemDelete.Size = new System.Drawing.Size(155, 22);
            this.menuBar_media_itemDelete.Text = "Supprimer";
            // 
            // menuBar_menuPlaylist
            // 
            this.menuBar_menuPlaylist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_Playlist_itemAdd,
            this.menuBar_playlist_itemUpdate,
            this.menuBar_playlist_itemSearch,
            this.menuBar_playlist_itemDelete});
            this.menuBar_menuPlaylist.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBar_menuPlaylist.Name = "menuBar_menuPlaylist";
            this.menuBar_menuPlaylist.Size = new System.Drawing.Size(56, 20);
            this.menuBar_menuPlaylist.Text = "Playlist";
            this.menuBar_menuPlaylist.DropDownClosed += new System.EventHandler(this.menuBar_menuPlaylist_DropDownClosed);
            this.menuBar_menuPlaylist.MouseEnter += new System.EventHandler(this.menuBar_menuPlaylist_MouseEnter);
            this.menuBar_menuPlaylist.MouseLeave += new System.EventHandler(this.menuBar_menuPlaylist_MouseLeave);
            // 
            // menuBar_Playlist_itemAdd
            // 
            this.menuBar_Playlist_itemAdd.Name = "menuBar_Playlist_itemAdd";
            this.menuBar_Playlist_itemAdd.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.menuBar_Playlist_itemAdd.Size = new System.Drawing.Size(152, 22);
            this.menuBar_Playlist_itemAdd.Text = "Ajouter";
            // 
            // menuBar_playlist_itemUpdate
            // 
            this.menuBar_playlist_itemUpdate.Name = "menuBar_playlist_itemUpdate";
            this.menuBar_playlist_itemUpdate.Size = new System.Drawing.Size(152, 22);
            this.menuBar_playlist_itemUpdate.Text = "Modifier";
            // 
            // menuBar_playlist_itemSearch
            // 
            this.menuBar_playlist_itemSearch.Name = "menuBar_playlist_itemSearch";
            this.menuBar_playlist_itemSearch.Size = new System.Drawing.Size(152, 22);
            this.menuBar_playlist_itemSearch.Text = "Rechercher";
            // 
            // menuBar_playlist_itemDelete
            // 
            this.menuBar_playlist_itemDelete.Name = "menuBar_playlist_itemDelete";
            this.menuBar_playlist_itemDelete.Size = new System.Drawing.Size(152, 22);
            this.menuBar_playlist_itemDelete.Text = "Supprimer";
            // 
            // menuBar_menuTools
            // 
            this.menuBar_menuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_tools_itemPath,
            this.menuBar_tools_itemUsers,
            this.menuBar_tools_itemOptions});
            this.menuBar_menuTools.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBar_menuTools.Name = "menuBar_menuTools";
            this.menuBar_menuTools.Size = new System.Drawing.Size(50, 20);
            this.menuBar_menuTools.Text = "Outils";
            this.menuBar_menuTools.DropDownClosed += new System.EventHandler(this.menuBar_menuTools_DropDownClosed);
            this.menuBar_menuTools.MouseEnter += new System.EventHandler(this.menuBar_menuTools_MouseEnter);
            this.menuBar_menuTools.MouseLeave += new System.EventHandler(this.menuBar_menuTools_MouseLeave);
            // 
            // menuBar_tools_itemPath
            // 
            this.menuBar_tools_itemPath.Name = "menuBar_tools_itemPath";
            this.menuBar_tools_itemPath.Size = new System.Drawing.Size(196, 22);
            this.menuBar_tools_itemPath.Text = "Gestionnaire de dossier";
            // 
            // menuBar_tools_itemUsers
            // 
            this.menuBar_tools_itemUsers.Name = "menuBar_tools_itemUsers";
            this.menuBar_tools_itemUsers.Size = new System.Drawing.Size(196, 22);
            this.menuBar_tools_itemUsers.Text = "Gestionnaire utilisateur";
            // 
            // menuBar_tools_itemOptions
            // 
            this.menuBar_tools_itemOptions.Name = "menuBar_tools_itemOptions";
            this.menuBar_tools_itemOptions.Size = new System.Drawing.Size(196, 22);
            this.menuBar_tools_itemOptions.Text = "Options";
            // 
            // menuBar_menuHelp
            // 
            this.menuBar_menuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_help_itemSummary,
            this.menuBar_help_itemShortcut,
            this.menuBar_aide_separator1,
            this.menuBar_help_itemAbout});
            this.menuBar_menuHelp.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuBar_menuHelp.Name = "menuBar_menuHelp";
            this.menuBar_menuHelp.Size = new System.Drawing.Size(43, 20);
            this.menuBar_menuHelp.Text = "Aide";
            this.menuBar_menuHelp.DropDownClosed += new System.EventHandler(this.menuBar_menuHelp_DropDownClosed);
            this.menuBar_menuHelp.MouseEnter += new System.EventHandler(this.menuBar_menuHelp_MouseEnter);
            this.menuBar_menuHelp.MouseLeave += new System.EventHandler(this.menuBar_menuHelp_MouseLeave);
            // 
            // menuBar_help_itemSummary
            // 
            this.menuBar_help_itemSummary.Name = "menuBar_help_itemSummary";
            this.menuBar_help_itemSummary.Size = new System.Drawing.Size(168, 22);
            this.menuBar_help_itemSummary.Text = "Sommaire";
            this.menuBar_help_itemSummary.Visible = false;
            // 
            // menuBar_help_itemShortcut
            // 
            this.menuBar_help_itemShortcut.Name = "menuBar_help_itemShortcut";
            this.menuBar_help_itemShortcut.Size = new System.Drawing.Size(168, 22);
            this.menuBar_help_itemShortcut.Text = "Raccourcis clavier";
            this.menuBar_help_itemShortcut.Visible = false;
            // 
            // menuBar_aide_separator1
            // 
            this.menuBar_aide_separator1.Name = "menuBar_aide_separator1";
            this.menuBar_aide_separator1.Size = new System.Drawing.Size(165, 6);
            this.menuBar_aide_separator1.Visible = false;
            // 
            // menuBar_help_itemAbout
            // 
            this.menuBar_help_itemAbout.Name = "menuBar_help_itemAbout";
            this.menuBar_help_itemAbout.Size = new System.Drawing.Size(168, 22);
            this.menuBar_help_itemAbout.Text = "A propos de ";
            // 
            // menuBar_btnConnection
            // 
            this.menuBar_btnConnection.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuBar_btnConnection.BackColor = System.Drawing.Color.Turquoise;
            this.menuBar_btnConnection.Name = "menuBar_btnConnection";
            this.menuBar_btnConnection.Size = new System.Drawing.Size(76, 20);
            this.menuBar_btnConnection.Text = "Connexion";
            this.menuBar_btnConnection.Click += new System.EventHandler(this.buttonConnection_Click);
            // 
            // menuMenuBar
            // 
            this.menuMenuBar.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.menuMenuBar.GripMargin = new System.Windows.Forms.Padding(2);
            this.menuMenuBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuMenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuBar_menuFichier,
            this.menuBar_menuAffichage,
            this.menuBar_menuMedia,
            this.menuBar_menuPlaylist,
            this.menuBar_menuTools,
            this.menuBar_menuHelp,
            this.menuBar_btnConnection,
            this.menuBar_txtMemberName,
            this.menuBar_lblIdUser});
            this.menuMenuBar.Location = new System.Drawing.Point(0, 0);
            this.menuMenuBar.Name = "menuMenuBar";
            this.menuMenuBar.Padding = new System.Windows.Forms.Padding(6, 2, 6, 2);
            this.menuMenuBar.Size = new System.Drawing.Size(784, 24);
            this.menuMenuBar.TabIndex = 8;
            this.menuMenuBar.Text = "menuStrip1";
            // 
            // menuBar_txtMemberName
            // 
            this.menuBar_txtMemberName.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuBar_txtMemberName.Enabled = false;
            this.menuBar_txtMemberName.ForeColor = System.Drawing.Color.White;
            this.menuBar_txtMemberName.Name = "menuBar_txtMemberName";
            this.menuBar_txtMemberName.Size = new System.Drawing.Size(87, 20);
            this.menuBar_txtMemberName.Text = "unknow user";
            // 
            // menuBar_lblIdUser
            // 
            this.menuBar_lblIdUser.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.menuBar_lblIdUser.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuBar_lblIdUser.Name = "menuBar_lblIdUser";
            this.menuBar_lblIdUser.Size = new System.Drawing.Size(25, 20);
            this.menuBar_lblIdUser.Text = "0";
            this.menuBar_lblIdUser.Visible = false;
            this.menuBar_lblIdUser.TextChanged += new System.EventHandler(this.menuBar_lblIdUser_TextChanged);
            // 
            // typeUserBindingSource
            // 
            this.typeUserBindingSource.DataMember = "Type_User";
            this.typeUserBindingSource.DataSource = this.coAndCoDBDataSetMenu;
            // 
            // coAndCoDBDataSetMenu
            // 
            this.coAndCoDBDataSetMenu.DataSetName = "CoAndCoDBDataSetMenu";
            this.coAndCoDBDataSetMenu.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // type_UserTableAdapter
            // 
            this.type_UserTableAdapter.ClearBeforeFill = true;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.coAndCoDBDataSetMenu;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.menuMenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMenu";
            this.Text = "frmMenu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuMenuBar.ResumeLayout(false);
            this.menuMenuBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.typeUserBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coAndCoDBDataSetMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem menuBar_menuFichier;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemNewPlaylist;
        private System.Windows.Forms.ToolStripSeparator menuBar_fichier_separator1;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemAddPath;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemAddFic;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemAddMedia;
        private System.Windows.Forms.ToolStripSeparator menuBar_fichier_separator2;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemAddExemplaire;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemDeleteExemplaire;
        private System.Windows.Forms.ToolStripSeparator menuBar_fichier_separator3;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemSearchMedia;
        private System.Windows.Forms.ToolStripSeparator menuBar_fichier_separator4;
        private System.Windows.Forms.ToolStripMenuItem menuBar_fichier_itemExit;
        private System.Windows.Forms.ToolStripMenuItem menuBar_menuAffichage;
        private System.Windows.Forms.ToolStripMenuItem menuBar_affichage_itemListe;
        private System.Windows.Forms.ToolStripMenuItem menuBar_affichage_itemSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem menuBar_affichage_itemBigIcon;
        private System.Windows.Forms.ToolStripSeparator menuBar_affichage_separator1;
        private System.Windows.Forms.ToolStripMenuItem menuBar_affichage_itemMosaic;
        private System.Windows.Forms.ToolStripSeparator menuBar_affichage_separator2;
        private System.Windows.Forms.ToolStripMenuItem menuBar_affichage_itemYear;
        private System.Windows.Forms.ToolStripMenuItem menuBar_affichage_itemGender;
        private System.Windows.Forms.ToolStripSeparator menuBar_affichage_separator3;
        private System.Windows.Forms.ToolStripMenuItem menuBar_affichage_itemDiapo;
        private System.Windows.Forms.ToolStripMenuItem menuBar_menuMedia;
        private System.Windows.Forms.ToolStripMenuItem menuBar_media_itemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuBar_media_itemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuBar_media_itemSearch;
        private System.Windows.Forms.ToolStripMenuItem menuBar_media_itemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuBar_menuPlaylist;
        private System.Windows.Forms.ToolStripMenuItem menuBar_Playlist_itemAdd;
        private System.Windows.Forms.ToolStripMenuItem menuBar_playlist_itemUpdate;
        private System.Windows.Forms.ToolStripMenuItem menuBar_playlist_itemSearch;
        private System.Windows.Forms.ToolStripMenuItem menuBar_playlist_itemDelete;
        private System.Windows.Forms.ToolStripMenuItem menuBar_menuTools;
        private System.Windows.Forms.ToolStripMenuItem menuBar_tools_itemPath;
        private System.Windows.Forms.ToolStripMenuItem menuBar_tools_itemUsers;
        private System.Windows.Forms.ToolStripMenuItem menuBar_tools_itemOptions;
        private System.Windows.Forms.ToolStripMenuItem menuBar_menuHelp;
        private System.Windows.Forms.ToolStripMenuItem menuBar_help_itemSummary;
        private System.Windows.Forms.ToolStripMenuItem menuBar_help_itemShortcut;
        private System.Windows.Forms.ToolStripSeparator menuBar_aide_separator1;
        private System.Windows.Forms.ToolStripMenuItem menuBar_help_itemAbout;
        private System.Windows.Forms.ToolStripMenuItem menuBar_btnConnection;
        private System.Windows.Forms.MenuStrip menuMenuBar;
        private System.Windows.Forms.ToolStripMenuItem menuBar_txtMemberName;
        private System.Windows.Forms.ToolStripMenuItem menuBar_lblIdUser;
        protected CoAndCoDBDataSet coAndCoDBDataSetMenu;
        private CoAndCoDBDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private System.Windows.Forms.BindingSource typeUserBindingSource;
        private CoAndCoDBDataSetTableAdapters.Type_UserTableAdapter type_UserTableAdapter;
        private System.Windows.Forms.BindingSource userBindingSource;
        private CoAndCoDBDataSetTableAdapters.UserTableAdapter userTableAdapter1;
    }
}