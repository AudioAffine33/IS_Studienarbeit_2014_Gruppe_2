namespace Studienarbeit_Bildeditor
{
    partial class Studienarbeit_Bildeditor
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Studienarbeit_Bildeditor));
            this.lbl_X = new System.Windows.Forms.Label();
            this.lbl_Y = new System.Windows.Forms.Label();
            this.Nmbrs_X = new System.Windows.Forms.NumericUpDown();
            this.Nmbrs_Y = new System.Windows.Forms.NumericUpDown();
            this.lbl_Breite = new System.Windows.Forms.Label();
            this.lbl_Hoehe = new System.Windows.Forms.Label();
            this.Nmbrs_Hoehe = new System.Windows.Forms.NumericUpDown();
            this.Nmbrs_Breite = new System.Windows.Forms.NumericUpDown();
            this.lbl_typ = new System.Windows.Forms.Label();
            this.lstbx_typ = new System.Windows.Forms.ListBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_insert = new System.Windows.Forms.Button();
            this.lbl_color = new System.Windows.Forms.Label();
            this.txtbx_color = new System.Windows.Forms.TextBox();
            this.btn_color = new System.Windows.Forms.Button();
            this.lbl_text = new System.Windows.Forms.Label();
            this.txtbx_text = new System.Windows.Forms.TextBox();
            this.lbl_font = new System.Windows.Forms.Label();
            this.txtbx_font = new System.Windows.Forms.TextBox();
            this.btn_font = new System.Windows.Forms.Button();
            this.lbl_img = new System.Windows.Forms.Label();
            this.txtbx_img = new System.Windows.Forms.TextBox();
            this.btn_img = new System.Windows.Forms.Button();
            this.cd_color = new System.Windows.Forms.ColorDialog();
            this.fd_font = new System.Windows.Forms.FontDialog();
            this.ofd_img = new System.Windows.Forms.OpenFileDialog();
            this.grpbx_bldel = new System.Windows.Forms.GroupBox();
            this.grpbx_brbbereich = new System.Windows.Forms.GroupBox();
            this.grpbx_bild = new System.Windows.Forms.GroupBox();
            this.pctbx_Bildbereich = new System.Windows.Forms.PictureBox();
            this.ms_menu = new System.Windows.Forms.MenuStrip();
            this.tsm_datei = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Neu = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Speichern = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_Laden = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Beenden = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Flaeche = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_fill = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_kontur = new System.Windows.Forms.ToolStripMenuItem();
            this.tim_Brbbereich = new System.Windows.Forms.Timer(this.components);
            this.ofd_Laden = new System.Windows.Forms.OpenFileDialog();
            this.sfd_Speichern = new System.Windows.Forms.SaveFileDialog();
            this.radiergummiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rbract = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_rbrdeact = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_Y)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_Hoehe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_Breite)).BeginInit();
            this.grpbx_bldel.SuspendLayout();
            this.grpbx_brbbereich.SuspendLayout();
            this.grpbx_bild.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Bildbereich)).BeginInit();
            this.ms_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_X
            // 
            this.lbl_X.AutoSize = true;
            this.lbl_X.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_X.Location = new System.Drawing.Point(6, 26);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(23, 18);
            this.lbl_X.TabIndex = 1;
            this.lbl_X.Text = "&X:";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Y.Location = new System.Drawing.Point(9, 58);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(20, 18);
            this.lbl_Y.TabIndex = 2;
            this.lbl_Y.Text = "&Y:";
            // 
            // Nmbrs_X
            // 
            this.Nmbrs_X.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nmbrs_X.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_X.Location = new System.Drawing.Point(35, 24);
            this.Nmbrs_X.Maximum = new decimal(new int[] {
            807,
            0,
            0,
            0});
            this.Nmbrs_X.Name = "Nmbrs_X";
            this.Nmbrs_X.Size = new System.Drawing.Size(60, 22);
            this.Nmbrs_X.TabIndex = 3;
            this.Nmbrs_X.ValueChanged += new System.EventHandler(this.Nmbrs_X_ValueChanged);
            // 
            // Nmbrs_Y
            // 
            this.Nmbrs_Y.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nmbrs_Y.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_Y.Location = new System.Drawing.Point(35, 56);
            this.Nmbrs_Y.Maximum = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.Nmbrs_Y.Name = "Nmbrs_Y";
            this.Nmbrs_Y.Size = new System.Drawing.Size(60, 22);
            this.Nmbrs_Y.TabIndex = 4;
            this.Nmbrs_Y.ValueChanged += new System.EventHandler(this.Nmbrs_Y_ValueChanged);
            // 
            // lbl_Breite
            // 
            this.lbl_Breite.AutoSize = true;
            this.lbl_Breite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Breite.Location = new System.Drawing.Point(101, 24);
            this.lbl_Breite.Name = "lbl_Breite";
            this.lbl_Breite.Size = new System.Drawing.Size(54, 18);
            this.lbl_Breite.TabIndex = 5;
            this.lbl_Breite.Text = "&Breite:";
            // 
            // lbl_Hoehe
            // 
            this.lbl_Hoehe.AutoSize = true;
            this.lbl_Hoehe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoehe.Location = new System.Drawing.Point(101, 58);
            this.lbl_Hoehe.Name = "lbl_Hoehe";
            this.lbl_Hoehe.Size = new System.Drawing.Size(49, 18);
            this.lbl_Hoehe.TabIndex = 6;
            this.lbl_Hoehe.Text = "&Höhe:";
            // 
            // Nmbrs_Hoehe
            // 
            this.Nmbrs_Hoehe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nmbrs_Hoehe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_Hoehe.Location = new System.Drawing.Point(161, 56);
            this.Nmbrs_Hoehe.Maximum = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.Nmbrs_Hoehe.Name = "Nmbrs_Hoehe";
            this.Nmbrs_Hoehe.Size = new System.Drawing.Size(60, 22);
            this.Nmbrs_Hoehe.TabIndex = 7;
            this.Nmbrs_Hoehe.Value = new decimal(new int[] {
            299,
            0,
            0,
            0});
            this.Nmbrs_Hoehe.ValueChanged += new System.EventHandler(this.Nmbrs_Hoehe_ValueChanged);
            // 
            // Nmbrs_Breite
            // 
            this.Nmbrs_Breite.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Nmbrs_Breite.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_Breite.Location = new System.Drawing.Point(161, 24);
            this.Nmbrs_Breite.Maximum = new decimal(new int[] {
            807,
            0,
            0,
            0});
            this.Nmbrs_Breite.Name = "Nmbrs_Breite";
            this.Nmbrs_Breite.Size = new System.Drawing.Size(60, 22);
            this.Nmbrs_Breite.TabIndex = 8;
            this.Nmbrs_Breite.Value = new decimal(new int[] {
            807,
            0,
            0,
            0});
            this.Nmbrs_Breite.ValueChanged += new System.EventHandler(this.Nmbrs_Breite_ValueChanged);
            // 
            // lbl_typ
            // 
            this.lbl_typ.AutoSize = true;
            this.lbl_typ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_typ.Location = new System.Drawing.Point(6, 26);
            this.lbl_typ.Name = "lbl_typ";
            this.lbl_typ.Size = new System.Drawing.Size(36, 18);
            this.lbl_typ.TabIndex = 10;
            this.lbl_typ.Text = "&Typ:";
            // 
            // lstbx_typ
            // 
            this.lstbx_typ.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstbx_typ.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lstbx_typ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx_typ.FormattingEnabled = true;
            this.lstbx_typ.ItemHeight = 18;
            this.lstbx_typ.Items.AddRange(new object[] {
            "Bild",
            "Linie",
            "Rechteck",
            "Ellipse",
            "Text"});
            this.lstbx_typ.Location = new System.Drawing.Point(9, 53);
            this.lstbx_typ.Name = "lstbx_typ";
            this.lstbx_typ.Size = new System.Drawing.Size(115, 90);
            this.lstbx_typ.TabIndex = 11;
            this.lstbx_typ.SelectedIndexChanged += new System.EventHandler(this.lstbx_typ_SelectedIndexChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_reset.BackgroundImage")));
            this.btn_reset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_reset.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_reset.FlatAppearance.BorderSize = 0;
            this.btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.White;
            this.btn_reset.Location = new System.Drawing.Point(8, 157);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(112, 33);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "&Zurücksetzen";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            this.btn_reset.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_reset_MouseDown);
            this.btn_reset.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_reset_MouseUp);
            // 
            // btn_insert
            // 
            this.btn_insert.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_insert.BackgroundImage")));
            this.btn_insert.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_insert.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_insert.FlatAppearance.BorderSize = 0;
            this.btn_insert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_insert.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_insert.Location = new System.Drawing.Point(9, 157);
            this.btn_insert.Name = "btn_insert";
            this.btn_insert.Size = new System.Drawing.Size(93, 33);
            this.btn_insert.TabIndex = 13;
            this.btn_insert.Text = "&Einfügen";
            this.btn_insert.UseVisualStyleBackColor = true;
            this.btn_insert.Click += new System.EventHandler(this.btn_insert_Click);
            this.btn_insert.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseDown);
            this.btn_insert.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_insert_MouseUp);
            // 
            // lbl_color
            // 
            this.lbl_color.AutoSize = true;
            this.lbl_color.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_color.Location = new System.Drawing.Point(182, 26);
            this.lbl_color.Name = "lbl_color";
            this.lbl_color.Size = new System.Drawing.Size(54, 18);
            this.lbl_color.TabIndex = 14;
            this.lbl_color.Text = "&Farbe:";
            // 
            // txtbx_color
            // 
            this.txtbx_color.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_color.Enabled = false;
            this.txtbx_color.Location = new System.Drawing.Point(242, 28);
            this.txtbx_color.Name = "txtbx_color";
            this.txtbx_color.ReadOnly = true;
            this.txtbx_color.Size = new System.Drawing.Size(181, 19);
            this.txtbx_color.TabIndex = 15;
            // 
            // btn_color
            // 
            this.btn_color.BackColor = System.Drawing.Color.Transparent;
            this.btn_color.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_color.BackgroundImage")));
            this.btn_color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_color.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_color.FlatAppearance.BorderSize = 0;
            this.btn_color.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_color.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(429, 27);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(33, 20);
            this.btn_color.TabIndex = 16;
            this.btn_color.Text = "...";
            this.btn_color.UseVisualStyleBackColor = false;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
            this.btn_color.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_color_MouseDown);
            this.btn_color.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_color_MouseUp);
            // 
            // lbl_text
            // 
            this.lbl_text.AutoSize = true;
            this.lbl_text.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_text.Location = new System.Drawing.Point(182, 70);
            this.lbl_text.Name = "lbl_text";
            this.lbl_text.Size = new System.Drawing.Size(39, 18);
            this.lbl_text.TabIndex = 17;
            this.lbl_text.Text = "&Text:";
            // 
            // txtbx_text
            // 
            this.txtbx_text.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_text.Enabled = false;
            this.txtbx_text.Location = new System.Drawing.Point(242, 69);
            this.txtbx_text.Name = "txtbx_text";
            this.txtbx_text.Size = new System.Drawing.Size(181, 19);
            this.txtbx_text.TabIndex = 18;
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_font.Location = new System.Drawing.Point(182, 120);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(56, 18);
            this.lbl_font.TabIndex = 19;
            this.lbl_font.Text = "&Schrift:";
            // 
            // txtbx_font
            // 
            this.txtbx_font.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_font.Enabled = false;
            this.txtbx_font.Location = new System.Drawing.Point(242, 119);
            this.txtbx_font.Name = "txtbx_font";
            this.txtbx_font.ReadOnly = true;
            this.txtbx_font.Size = new System.Drawing.Size(181, 19);
            this.txtbx_font.TabIndex = 20;
            // 
            // btn_font
            // 
            this.btn_font.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_font.BackgroundImage")));
            this.btn_font.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_font.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_font.FlatAppearance.BorderSize = 0;
            this.btn_font.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_font.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_font.Location = new System.Drawing.Point(429, 118);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(33, 20);
            this.btn_font.TabIndex = 21;
            this.btn_font.Text = "...";
            this.btn_font.UseVisualStyleBackColor = true;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            this.btn_font.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_font_MouseDown);
            this.btn_font.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_font_MouseUp);
            // 
            // lbl_img
            // 
            this.lbl_img.AutoSize = true;
            this.lbl_img.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img.Location = new System.Drawing.Point(182, 167);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(39, 18);
            this.lbl_img.TabIndex = 22;
            this.lbl_img.Text = "B&ild:";
            // 
            // txtbx_img
            // 
            this.txtbx_img.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbx_img.Enabled = false;
            this.txtbx_img.Location = new System.Drawing.Point(242, 166);
            this.txtbx_img.Name = "txtbx_img";
            this.txtbx_img.ReadOnly = true;
            this.txtbx_img.Size = new System.Drawing.Size(181, 19);
            this.txtbx_img.TabIndex = 23;
            // 
            // btn_img
            // 
            this.btn_img.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_img.BackgroundImage")));
            this.btn_img.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_img.FlatAppearance.BorderColor = System.Drawing.Color.Aqua;
            this.btn_img.FlatAppearance.BorderSize = 0;
            this.btn_img.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_img.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_img.Location = new System.Drawing.Point(429, 165);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(33, 20);
            this.btn_img.TabIndex = 24;
            this.btn_img.Text = "...";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            this.btn_img.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_img_MouseDown);
            this.btn_img.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_img_MouseUp);
            // 
            // fd_font
            // 
            this.fd_font.FontMustExist = true;
            this.fd_font.Apply += new System.EventHandler(this.fd_font_Apply);
            // 
            // grpbx_bldel
            // 
            this.grpbx_bldel.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_bldel.Controls.Add(this.lbl_typ);
            this.grpbx_bldel.Controls.Add(this.lstbx_typ);
            this.grpbx_bldel.Controls.Add(this.btn_img);
            this.grpbx_bldel.Controls.Add(this.btn_insert);
            this.grpbx_bldel.Controls.Add(this.txtbx_img);
            this.grpbx_bldel.Controls.Add(this.lbl_color);
            this.grpbx_bldel.Controls.Add(this.lbl_img);
            this.grpbx_bldel.Controls.Add(this.txtbx_color);
            this.grpbx_bldel.Controls.Add(this.btn_font);
            this.grpbx_bldel.Controls.Add(this.btn_color);
            this.grpbx_bldel.Controls.Add(this.txtbx_font);
            this.grpbx_bldel.Controls.Add(this.lbl_text);
            this.grpbx_bldel.Controls.Add(this.lbl_font);
            this.grpbx_bldel.Controls.Add(this.txtbx_text);
            this.grpbx_bldel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_bldel.ForeColor = System.Drawing.Color.White;
            this.grpbx_bldel.Location = new System.Drawing.Point(337, 38);
            this.grpbx_bldel.Name = "grpbx_bldel";
            this.grpbx_bldel.Size = new System.Drawing.Size(504, 203);
            this.grpbx_bldel.TabIndex = 27;
            this.grpbx_bldel.TabStop = false;
            this.grpbx_bldel.Text = "Bild&element";
            // 
            // grpbx_brbbereich
            // 
            this.grpbx_brbbereich.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_brbbereich.Controls.Add(this.lbl_X);
            this.grpbx_brbbereich.Controls.Add(this.lbl_Y);
            this.grpbx_brbbereich.Controls.Add(this.Nmbrs_X);
            this.grpbx_brbbereich.Controls.Add(this.btn_reset);
            this.grpbx_brbbereich.Controls.Add(this.Nmbrs_Y);
            this.grpbx_brbbereich.Controls.Add(this.Nmbrs_Breite);
            this.grpbx_brbbereich.Controls.Add(this.lbl_Breite);
            this.grpbx_brbbereich.Controls.Add(this.Nmbrs_Hoehe);
            this.grpbx_brbbereich.Controls.Add(this.lbl_Hoehe);
            this.grpbx_brbbereich.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_brbbereich.ForeColor = System.Drawing.Color.White;
            this.grpbx_brbbereich.Location = new System.Drawing.Point(21, 38);
            this.grpbx_brbbereich.Name = "grpbx_brbbereich";
            this.grpbx_brbbereich.Size = new System.Drawing.Size(310, 203);
            this.grpbx_brbbereich.TabIndex = 28;
            this.grpbx_brbbereich.TabStop = false;
            this.grpbx_brbbereich.Text = "&Bearbeitungsbereich";
            // 
            // grpbx_bild
            // 
            this.grpbx_bild.BackColor = System.Drawing.Color.Transparent;
            this.grpbx_bild.Controls.Add(this.pctbx_Bildbereich);
            this.grpbx_bild.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbx_bild.ForeColor = System.Drawing.Color.White;
            this.grpbx_bild.Location = new System.Drawing.Point(21, 262);
            this.grpbx_bild.Name = "grpbx_bild";
            this.grpbx_bild.Size = new System.Drawing.Size(820, 331);
            this.grpbx_bild.TabIndex = 29;
            this.grpbx_bild.TabStop = false;
            this.grpbx_bild.Text = "Bild";
            // 
            // pctbx_Bildbereich
            // 
            this.pctbx_Bildbereich.BackColor = System.Drawing.SystemColors.Window;
            this.pctbx_Bildbereich.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pctbx_Bildbereich.Location = new System.Drawing.Point(7, 26);
            this.pctbx_Bildbereich.Name = "pctbx_Bildbereich";
            this.pctbx_Bildbereich.Size = new System.Drawing.Size(807, 299);
            this.pctbx_Bildbereich.TabIndex = 0;
            this.pctbx_Bildbereich.TabStop = false;
            this.pctbx_Bildbereich.Click += new System.EventHandler(this.pctbx_Bildbereich_Click);
            this.pctbx_Bildbereich.Paint += new System.Windows.Forms.PaintEventHandler(this.pctbx_Bildbereich_Paint);
            // 
            // ms_menu
            // 
            this.ms_menu.BackColor = System.Drawing.Color.Transparent;
            this.ms_menu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ms_menu.BackgroundImage")));
            this.ms_menu.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_datei,
            this.Menu_Flaeche,
            this.radiergummiToolStripMenuItem});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.MaximumSize = new System.Drawing.Size(850, 26);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(850, 26);
            this.ms_menu.TabIndex = 25;
            this.ms_menu.Text = "ms_menu";
            // 
            // tsm_datei
            // 
            this.tsm_datei.BackColor = System.Drawing.Color.Transparent;
            this.tsm_datei.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("tsm_datei.BackgroundImage")));
            this.tsm_datei.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Neu,
            this.btn_Speichern,
            this.btn_Laden,
            this.Menu_Beenden});
            this.tsm_datei.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_datei.ForeColor = System.Drawing.Color.White;
            this.tsm_datei.ImageTransparentColor = System.Drawing.Color.White;
            this.tsm_datei.Name = "tsm_datei";
            this.tsm_datei.Size = new System.Drawing.Size(58, 22);
            this.tsm_datei.Text = "&Datei";
            // 
            // Menu_Neu
            // 
            this.Menu_Neu.BackColor = System.Drawing.Color.Navy;
            this.Menu_Neu.ForeColor = System.Drawing.Color.White;
            this.Menu_Neu.Name = "Menu_Neu";
            this.Menu_Neu.Size = new System.Drawing.Size(147, 22);
            this.Menu_Neu.Text = "Neu";
            this.Menu_Neu.Click += new System.EventHandler(this.Menu_Neu_Click);
            // 
            // btn_Speichern
            // 
            this.btn_Speichern.BackColor = System.Drawing.Color.Navy;
            this.btn_Speichern.ForeColor = System.Drawing.Color.White;
            this.btn_Speichern.Name = "btn_Speichern";
            this.btn_Speichern.Size = new System.Drawing.Size(147, 22);
            this.btn_Speichern.Text = "Speichern";
            this.btn_Speichern.Click += new System.EventHandler(this.btn_Speichern_Click);
            // 
            // btn_Laden
            // 
            this.btn_Laden.BackColor = System.Drawing.Color.Navy;
            this.btn_Laden.ForeColor = System.Drawing.Color.White;
            this.btn_Laden.Name = "btn_Laden";
            this.btn_Laden.Size = new System.Drawing.Size(147, 22);
            this.btn_Laden.Text = "Laden";
            this.btn_Laden.Click += new System.EventHandler(this.btn_Laden_Click);
            // 
            // Menu_Beenden
            // 
            this.Menu_Beenden.BackColor = System.Drawing.Color.Navy;
            this.Menu_Beenden.ForeColor = System.Drawing.Color.White;
            this.Menu_Beenden.Name = "Menu_Beenden";
            this.Menu_Beenden.Size = new System.Drawing.Size(147, 22);
            this.Menu_Beenden.Text = "Beenden";
            this.Menu_Beenden.Click += new System.EventHandler(this.Menu_Beenden_Click);
            // 
            // Menu_Flaeche
            // 
            this.Menu_Flaeche.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Menu_Flaeche.BackgroundImage")));
            this.Menu_Flaeche.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_fill,
            this.btn_kontur});
            this.Menu_Flaeche.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Menu_Flaeche.ForeColor = System.Drawing.Color.White;
            this.Menu_Flaeche.Name = "Menu_Flaeche";
            this.Menu_Flaeche.Size = new System.Drawing.Size(67, 22);
            this.Menu_Flaeche.Text = "&Fläche";
            // 
            // btn_fill
            // 
            this.btn_fill.BackColor = System.Drawing.Color.Transparent;
            this.btn_fill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_fill.BackgroundImage")));
            this.btn_fill.ForeColor = System.Drawing.Color.White;
            this.btn_fill.Name = "btn_fill";
            this.btn_fill.Size = new System.Drawing.Size(152, 22);
            this.btn_fill.Text = "Füllen";
            this.btn_fill.Click += new System.EventHandler(this.btn_fill_Click);
            // 
            // btn_kontur
            // 
            this.btn_kontur.BackColor = System.Drawing.Color.Transparent;
            this.btn_kontur.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_kontur.BackgroundImage")));
            this.btn_kontur.ForeColor = System.Drawing.Color.White;
            this.btn_kontur.Name = "btn_kontur";
            this.btn_kontur.Size = new System.Drawing.Size(152, 22);
            this.btn_kontur.Text = "Kontur";
            this.btn_kontur.Click += new System.EventHandler(this.btn_kontur_Click);
            // 
            // tim_Brbbereich
            // 
            this.tim_Brbbereich.Enabled = true;
            this.tim_Brbbereich.Tick += new System.EventHandler(this.tim_Brbbereich_Tick);
            // 
            // ofd_Laden
            // 
            this.ofd_Laden.FileName = "openFileDialog1";
            // 
            // radiergummiToolStripMenuItem
            // 
            this.radiergummiToolStripMenuItem.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("radiergummiToolStripMenuItem.BackgroundImage")));
            this.radiergummiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_rbract,
            this.btn_rbrdeact});
            this.radiergummiToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.radiergummiToolStripMenuItem.Name = "radiergummiToolStripMenuItem";
            this.radiergummiToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.radiergummiToolStripMenuItem.Text = "&Radiergummi";
            // 
            // btn_rbract
            // 
            this.btn_rbract.BackColor = System.Drawing.Color.Transparent;
            this.btn_rbract.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rbract.BackgroundImage")));
            this.btn_rbract.ForeColor = System.Drawing.Color.White;
            this.btn_rbract.Name = "btn_rbract";
            this.btn_rbract.Size = new System.Drawing.Size(164, 22);
            this.btn_rbract.Text = "Aktivieren";
            this.btn_rbract.Click += new System.EventHandler(this.btn_rbract_Click);
            // 
            // btn_rbrdeact
            // 
            this.btn_rbrdeact.BackColor = System.Drawing.Color.Transparent;
            this.btn_rbrdeact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rbrdeact.BackgroundImage")));
            this.btn_rbrdeact.ForeColor = System.Drawing.Color.White;
            this.btn_rbrdeact.Name = "btn_rbrdeact";
            this.btn_rbrdeact.Size = new System.Drawing.Size(164, 22);
            this.btn_rbrdeact.Text = "Deaktivieren";
            this.btn_rbrdeact.Click += new System.EventHandler(this.btn_rbrdeact_Click);
            // 
            // Studienarbeit_Bildeditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.grpbx_bild);
            this.Controls.Add(this.grpbx_brbbereich);
            this.Controls.Add(this.grpbx_bldel);
            this.Controls.Add(this.ms_menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.ms_menu;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Studienarbeit_Bildeditor";
            this.Text = "Bildeditor";
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_Y)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_Hoehe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Nmbrs_Breite)).EndInit();
            this.grpbx_bldel.ResumeLayout(false);
            this.grpbx_bldel.PerformLayout();
            this.grpbx_brbbereich.ResumeLayout(false);
            this.grpbx_brbbereich.PerformLayout();
            this.grpbx_bild.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pctbx_Bildbereich)).EndInit();
            this.ms_menu.ResumeLayout(false);
            this.ms_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_X;
        private System.Windows.Forms.Label lbl_Y;
        private System.Windows.Forms.NumericUpDown Nmbrs_X;
        private System.Windows.Forms.NumericUpDown Nmbrs_Y;
        private System.Windows.Forms.Label lbl_Breite;
        private System.Windows.Forms.Label lbl_Hoehe;
        private System.Windows.Forms.NumericUpDown Nmbrs_Hoehe;
        private System.Windows.Forms.NumericUpDown Nmbrs_Breite;
        private System.Windows.Forms.Label lbl_typ;
        private System.Windows.Forms.ListBox lstbx_typ;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_insert;
        private System.Windows.Forms.Label lbl_color;
        private System.Windows.Forms.TextBox txtbx_color;
        private System.Windows.Forms.Button btn_color;
        private System.Windows.Forms.Label lbl_text;
        private System.Windows.Forms.TextBox txtbx_text;
        private System.Windows.Forms.Label lbl_font;
        private System.Windows.Forms.TextBox txtbx_font;
        private System.Windows.Forms.Button btn_font;
        private System.Windows.Forms.Label lbl_img;
        private System.Windows.Forms.TextBox txtbx_img;
        private System.Windows.Forms.Button btn_img;
        private System.Windows.Forms.ColorDialog cd_color;
        private System.Windows.Forms.FontDialog fd_font;
        private System.Windows.Forms.OpenFileDialog ofd_img;
        private System.Windows.Forms.GroupBox grpbx_bldel;
        private System.Windows.Forms.GroupBox grpbx_brbbereich;
        private System.Windows.Forms.GroupBox grpbx_bild;
        private System.Windows.Forms.MenuStrip ms_menu;
        private System.Windows.Forms.ToolStripMenuItem tsm_datei;
        private System.Windows.Forms.PictureBox pctbx_Bildbereich;
        private System.Windows.Forms.Timer tim_Brbbereich;
        private System.Windows.Forms.ToolStripMenuItem btn_Speichern;
        private System.Windows.Forms.ToolStripMenuItem btn_Laden;
        private System.Windows.Forms.ToolStripMenuItem Menu_Beenden;
        private System.Windows.Forms.OpenFileDialog ofd_Laden;
        private System.Windows.Forms.SaveFileDialog sfd_Speichern;
        private System.Windows.Forms.ToolStripMenuItem Menu_Neu;
        private System.Windows.Forms.ToolStripMenuItem Menu_Flaeche;
        private System.Windows.Forms.ToolStripMenuItem btn_fill;
        private System.Windows.Forms.ToolStripMenuItem btn_kontur;
        private System.Windows.Forms.ToolStripMenuItem radiergummiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btn_rbract;
        private System.Windows.Forms.ToolStripMenuItem btn_rbrdeact;
    }
}

