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
            this.button1 = new System.Windows.Forms.Button();
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
            this.lbl_X.Location = new System.Drawing.Point(6, 22);
            this.lbl_X.Name = "lbl_X";
            this.lbl_X.Size = new System.Drawing.Size(23, 18);
            this.lbl_X.TabIndex = 1;
            this.lbl_X.Text = "&X:";
            // 
            // lbl_Y
            // 
            this.lbl_Y.AutoSize = true;
            this.lbl_Y.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Y.Location = new System.Drawing.Point(9, 54);
            this.lbl_Y.Name = "lbl_Y";
            this.lbl_Y.Size = new System.Drawing.Size(20, 18);
            this.lbl_Y.TabIndex = 2;
            this.lbl_Y.Text = "&Y:";
            // 
            // Nmbrs_X
            // 
            this.Nmbrs_X.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_X.Location = new System.Drawing.Point(35, 19);
            this.Nmbrs_X.Name = "Nmbrs_X";
            this.Nmbrs_X.Size = new System.Drawing.Size(60, 26);
            this.Nmbrs_X.TabIndex = 3;
            this.Nmbrs_X.ValueChanged += new System.EventHandler(this.Nmbrs_X_ValueChanged);
            // 
            // Nmbrs_Y
            // 
            this.Nmbrs_Y.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_Y.Location = new System.Drawing.Point(35, 51);
            this.Nmbrs_Y.Name = "Nmbrs_Y";
            this.Nmbrs_Y.Size = new System.Drawing.Size(60, 26);
            this.Nmbrs_Y.TabIndex = 4;
            this.Nmbrs_Y.ValueChanged += new System.EventHandler(this.Nmbrs_Y_ValueChanged);
            // 
            // lbl_Breite
            // 
            this.lbl_Breite.AutoSize = true;
            this.lbl_Breite.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Breite.Location = new System.Drawing.Point(101, 22);
            this.lbl_Breite.Name = "lbl_Breite";
            this.lbl_Breite.Size = new System.Drawing.Size(54, 18);
            this.lbl_Breite.TabIndex = 5;
            this.lbl_Breite.Text = "&Breite:";
            // 
            // lbl_Hoehe
            // 
            this.lbl_Hoehe.AutoSize = true;
            this.lbl_Hoehe.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Hoehe.Location = new System.Drawing.Point(101, 56);
            this.lbl_Hoehe.Name = "lbl_Hoehe";
            this.lbl_Hoehe.Size = new System.Drawing.Size(49, 18);
            this.lbl_Hoehe.TabIndex = 6;
            this.lbl_Hoehe.Text = "&Höhe:";
            // 
            // Nmbrs_Hoehe
            // 
            this.Nmbrs_Hoehe.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_Hoehe.Location = new System.Drawing.Point(161, 53);
            this.Nmbrs_Hoehe.Maximum = new decimal(new int[] {
            296,
            0,
            0,
            0});
            this.Nmbrs_Hoehe.Name = "Nmbrs_Hoehe";
            this.Nmbrs_Hoehe.Size = new System.Drawing.Size(60, 26);
            this.Nmbrs_Hoehe.TabIndex = 7;
            this.Nmbrs_Hoehe.Value = new decimal(new int[] {
            296,
            0,
            0,
            0});
            this.Nmbrs_Hoehe.ValueChanged += new System.EventHandler(this.Nmbrs_Hoehe_ValueChanged);
            // 
            // Nmbrs_Breite
            // 
            this.Nmbrs_Breite.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nmbrs_Breite.Location = new System.Drawing.Point(161, 19);
            this.Nmbrs_Breite.Maximum = new decimal(new int[] {
            804,
            0,
            0,
            0});
            this.Nmbrs_Breite.Name = "Nmbrs_Breite";
            this.Nmbrs_Breite.Size = new System.Drawing.Size(60, 26);
            this.Nmbrs_Breite.TabIndex = 8;
            this.Nmbrs_Breite.Value = new decimal(new int[] {
            804,
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
            this.lstbx_typ.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstbx_typ.FormattingEnabled = true;
            this.lstbx_typ.ItemHeight = 18;
            this.lstbx_typ.Items.AddRange(new object[] {
            "Bild",
            "Linie",
            "Rechteck",
            "Text"});
            this.lstbx_typ.Location = new System.Drawing.Point(9, 53);
            this.lstbx_typ.Name = "lstbx_typ";
            this.lstbx_typ.Size = new System.Drawing.Size(115, 94);
            this.lstbx_typ.TabIndex = 11;
            this.lstbx_typ.SelectedIndexChanged += new System.EventHandler(this.lstbx_typ_SelectedIndexChanged);
            // 
            // btn_reset
            // 
            this.btn_reset.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(8, 157);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(112, 33);
            this.btn_reset.TabIndex = 12;
            this.btn_reset.Text = "&Zurücksetzen";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(9, 157);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "&Einfügen";
            this.button1.UseVisualStyleBackColor = true;
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
            this.txtbx_color.Enabled = false;
            this.txtbx_color.Location = new System.Drawing.Point(242, 23);
            this.txtbx_color.Name = "txtbx_color";
            this.txtbx_color.ReadOnly = true;
            this.txtbx_color.Size = new System.Drawing.Size(181, 26);
            this.txtbx_color.TabIndex = 15;
            // 
            // btn_color
            // 
            this.btn_color.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_color.Location = new System.Drawing.Point(429, 27);
            this.btn_color.Name = "btn_color";
            this.btn_color.Size = new System.Drawing.Size(33, 20);
            this.btn_color.TabIndex = 16;
            this.btn_color.Text = "...";
            this.btn_color.UseVisualStyleBackColor = true;
            this.btn_color.Click += new System.EventHandler(this.btn_color_Click);
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
            this.txtbx_text.Enabled = false;
            this.txtbx_text.Location = new System.Drawing.Point(242, 67);
            this.txtbx_text.Name = "txtbx_text";
            this.txtbx_text.Size = new System.Drawing.Size(181, 26);
            this.txtbx_text.TabIndex = 18;
            // 
            // lbl_font
            // 
            this.lbl_font.AutoSize = true;
            this.lbl_font.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_font.Location = new System.Drawing.Point(182, 117);
            this.lbl_font.Name = "lbl_font";
            this.lbl_font.Size = new System.Drawing.Size(56, 18);
            this.lbl_font.TabIndex = 19;
            this.lbl_font.Text = "&Schrift:";
            // 
            // txtbx_font
            // 
            this.txtbx_font.Enabled = false;
            this.txtbx_font.Location = new System.Drawing.Point(242, 114);
            this.txtbx_font.Name = "txtbx_font";
            this.txtbx_font.ReadOnly = true;
            this.txtbx_font.Size = new System.Drawing.Size(181, 26);
            this.txtbx_font.TabIndex = 20;
            // 
            // btn_font
            // 
            this.btn_font.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_font.Location = new System.Drawing.Point(429, 118);
            this.btn_font.Name = "btn_font";
            this.btn_font.Size = new System.Drawing.Size(33, 20);
            this.btn_font.TabIndex = 21;
            this.btn_font.Text = "...";
            this.btn_font.UseVisualStyleBackColor = true;
            this.btn_font.Click += new System.EventHandler(this.btn_font_Click);
            // 
            // lbl_img
            // 
            this.lbl_img.AutoSize = true;
            this.lbl_img.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_img.Location = new System.Drawing.Point(182, 164);
            this.lbl_img.Name = "lbl_img";
            this.lbl_img.Size = new System.Drawing.Size(39, 18);
            this.lbl_img.TabIndex = 22;
            this.lbl_img.Text = "B&ild:";
            // 
            // txtbx_img
            // 
            this.txtbx_img.Enabled = false;
            this.txtbx_img.Location = new System.Drawing.Point(242, 161);
            this.txtbx_img.Name = "txtbx_img";
            this.txtbx_img.ReadOnly = true;
            this.txtbx_img.Size = new System.Drawing.Size(181, 26);
            this.txtbx_img.TabIndex = 23;
            // 
            // btn_img
            // 
            this.btn_img.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_img.Location = new System.Drawing.Point(429, 165);
            this.btn_img.Name = "btn_img";
            this.btn_img.Size = new System.Drawing.Size(33, 20);
            this.btn_img.TabIndex = 24;
            this.btn_img.Text = "...";
            this.btn_img.UseVisualStyleBackColor = true;
            this.btn_img.Click += new System.EventHandler(this.btn_img_Click);
            // 
            // fd_font
            // 
            this.fd_font.FontMustExist = true;
            this.fd_font.Apply += new System.EventHandler(this.fd_font_Apply);
            // 
            // ofd_img
            // 
            this.ofd_img.FileOk += new System.ComponentModel.CancelEventHandler(this.ofd_img_FileOk);
            // 
            // grpbx_bldel
            // 
            this.grpbx_bldel.BackColor = System.Drawing.SystemColors.HighlightText;
            this.grpbx_bldel.Controls.Add(this.lbl_typ);
            this.grpbx_bldel.Controls.Add(this.lstbx_typ);
            this.grpbx_bldel.Controls.Add(this.btn_img);
            this.grpbx_bldel.Controls.Add(this.button1);
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
            this.grpbx_bldel.Location = new System.Drawing.Point(337, 38);
            this.grpbx_bldel.Name = "grpbx_bldel";
            this.grpbx_bldel.Size = new System.Drawing.Size(504, 203);
            this.grpbx_bldel.TabIndex = 27;
            this.grpbx_bldel.TabStop = false;
            this.grpbx_bldel.Text = "Bild&element";
            // 
            // grpbx_brbbereich
            // 
            this.grpbx_brbbereich.BackColor = System.Drawing.SystemColors.HighlightText;
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
            this.grpbx_brbbereich.Location = new System.Drawing.Point(21, 38);
            this.grpbx_brbbereich.Name = "grpbx_brbbereich";
            this.grpbx_brbbereich.Size = new System.Drawing.Size(310, 203);
            this.grpbx_brbbereich.TabIndex = 28;
            this.grpbx_brbbereich.TabStop = false;
            this.grpbx_brbbereich.Text = "&Bearbeitungsbereich";
            // 
            // grpbx_bild
            // 
            this.grpbx_bild.Controls.Add(this.pctbx_Bildbereich);
            this.grpbx_bild.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.ms_menu.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ms_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsm_datei});
            this.ms_menu.Location = new System.Drawing.Point(0, 0);
            this.ms_menu.Name = "ms_menu";
            this.ms_menu.Size = new System.Drawing.Size(850, 26);
            this.ms_menu.TabIndex = 25;
            this.ms_menu.Text = "ms_menu";
            // 
            // tsm_datei
            // 
            this.tsm_datei.BackColor = System.Drawing.SystemColors.Highlight;
            this.tsm_datei.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsm_datei.Name = "tsm_datei";
            this.tsm_datei.Size = new System.Drawing.Size(58, 22);
            this.tsm_datei.Text = "&Datei";
            // 
            // Studienarbeit_Bildeditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(4F, 10F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(850, 605);
            this.Controls.Add(this.grpbx_bild);
            this.Controls.Add(this.grpbx_brbbereich);
            this.Controls.Add(this.grpbx_bldel);
            this.Controls.Add(this.ms_menu);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel, ((byte)(0)));
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
        private System.Windows.Forms.Button button1;
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
    }
}

