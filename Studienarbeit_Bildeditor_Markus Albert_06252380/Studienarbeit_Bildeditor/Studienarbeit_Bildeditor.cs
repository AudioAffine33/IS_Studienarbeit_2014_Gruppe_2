using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Studienarbeit_Bildeditor
{
    public partial class Studienarbeit_Bildeditor : Form
    {
        bool Radierer = false;
        bool fuellen = false;
        bool Delete;
        bool Bildauswahl = false;
        bool Farbauswahl = false;
        bool Fontauswahl = false;
        bool TimeGerade = true;
        bool Eingefügt = false;
        bool Einfügen = false;
        int Time = 0;
        int XCoord = 0;
        int YCoord = 0;
        int Hoehe = 299;
        int Breite = 807;
        string AuswahlTyp;
        SolidBrush FontBrush = new SolidBrush(System.Drawing.Color.Black);
        Pen Kontur = new Pen(Brushes.Black);
        Brush Fill = Brushes.Black;
        Pen Bearbeitungsbereich;
        Color AuswahlColor = Color.FromArgb(255,255,255);
        Font FontText;
        Image AuswahlBild;
        Image BearbeitungsbereichBild;



 



        public Studienarbeit_Bildeditor()
        {
            InitializeComponent();
        }

        private void Nmbrs_X_ValueChanged(object sender, EventArgs e)
        {
           
            XCoord = Convert.ToInt16(Nmbrs_X.Value);
            
           if (XCoord + Breite >= 807) {
                Breite = 807-XCoord;
                Nmbrs_Breite.Value = Breite;       
            }
           
            this.pctbx_Bildbereich.Refresh();
        }

        private void Nmbrs_Y_ValueChanged(object sender, EventArgs e)
        {

            YCoord = Convert.ToInt16(Nmbrs_Y.Value);
            if (YCoord + Hoehe >= 299) {
                Hoehe = 299 - YCoord;
                Nmbrs_Hoehe.Value = Hoehe;
            
            }
            this.pctbx_Bildbereich.Refresh();
        }

        private void pctbx_Bildbereich_Click(object sender, EventArgs e)
        {
            MouseEventArgs Mouseklick = (MouseEventArgs)e;

            if (Mouseklick.Button == MouseButtons.Left)
            {
               
                XCoord = Mouseklick.Location.X;
                YCoord = Mouseklick.Location.Y;
                Nmbrs_X.Value = XCoord;
                Nmbrs_Y.Value = YCoord;

            }
            if (Mouseklick.Button == MouseButtons.Right)
            {
                
                Breite = Mouseklick.Location.X - XCoord;
                Hoehe = Mouseklick.Location.Y - YCoord;
                if(Breite <0){
                    Breite = Breite * -1;
                }
                if (Hoehe < 0) {
                    Hoehe = Hoehe * -1;
                
                }
                if (XCoord + Breite >= 807)
                {
                    Breite = 807 - XCoord;
                    Nmbrs_Breite.Value = Breite;
                }
                if (YCoord + Hoehe >= 299)
                {
                    Hoehe = 299 - YCoord;
                    Nmbrs_Hoehe.Value = Hoehe;

                }
                
                Nmbrs_Breite.Value = Breite;
                Nmbrs_Hoehe.Value = Hoehe;
            }
            this.pctbx_Bildbereich.Refresh();
        }

        private void Nmbrs_Breite_ValueChanged(object sender, EventArgs e)
        {
            Breite = Convert.ToInt16(Nmbrs_Breite.Value);
            this.pctbx_Bildbereich.Refresh();
        }

        private void Nmbrs_Hoehe_ValueChanged(object sender, EventArgs e)
        {
            Hoehe = Convert.ToInt16(Nmbrs_Hoehe.Value);
            this.pctbx_Bildbereich.Refresh();
        }

        private void lstbx_typ_SelectedIndexChanged(object sender, EventArgs e)
        {
            AuswahlTyp = lstbx_typ.SelectedItem.ToString();

            if (AuswahlTyp == "Linie" | AuswahlTyp == "Rechteck" | AuswahlTyp == "Text"| AuswahlTyp == "Ellipse")
            {
  
                txtbx_color.Enabled = true;
            }
            else {

                txtbx_color.Enabled = false;
            }
            if (AuswahlTyp == "Text")
            {
                txtbx_text.Text = "Dies ist ein Text";
                txtbx_font.Enabled = true;
                txtbx_text.Enabled = true;
            }
            else {
                txtbx_font.Enabled = false;
                txtbx_text.Enabled = false;
                
            }
            if (AuswahlTyp == "Bild") {

                txtbx_font.Text = "";
                txtbx_text.Text = "";
                txtbx_img.Enabled = true;
            }
            else
            {
                txtbx_img.Enabled = false;
            }
            this.pctbx_Bildbereich.Refresh();   
        }
        

        private void btn_color_Click(object sender, EventArgs e)
        {

            if (AuswahlTyp == "Linie" | AuswahlTyp == "Rechteck" | AuswahlTyp == "Text" | AuswahlTyp == "Ellipse")
            {

                if (cd_color.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    AuswahlColor = cd_color.Color;
                    txtbx_color.BackColor = AuswahlColor;
                   
                    Kontur = new Pen(AuswahlColor);
                    FontBrush = new SolidBrush(AuswahlColor);
                    Fill = new SolidBrush(AuswahlColor);
                    Farbauswahl = true;

                    pctbx_Bildbereich.Refresh();
                }



            }
            else { 
            
                MessageBox.Show("Farbauswahl nur bei Linie, Rechteck, Ellipse und Text möglich");
            }

        }


        private void btn_font_Click(object sender, EventArgs e)
        {
            if (AuswahlTyp == "Text")
            {


                if (fd_font.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    txtbx_font.Text = fd_font.Font.FontFamily.Name+", "+fd_font.Font.Style+", "+fd_font.Font.SizeInPoints+"pt";
                    FontText = fd_font.Font;
                    Fontauswahl = true;
                    pctbx_Bildbereich.Refresh();
                }

            }
            else {

                MessageBox.Show("Schriftauswahl nur bei Text möglich");
            
            }
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            if (AuswahlTyp == "Bild")
            {
                this.ofd_img.Filter = "Images (*.BMP;*;.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|" + "All files (*.*)|*.*";
                this.ofd_img.Title = "Bild auswählen";

                if (ofd_img.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    AuswahlBild = new Bitmap(ofd_img.FileName);
                    txtbx_img.Text = Convert.ToString(ofd_img.FileName);
                    Bildauswahl = true;
                }
            }
            else {

                MessageBox.Show("Bildauswahl nur bei Auswahl von Bild im Typbereich möglich");
            }
        }


        private void fd_font_Apply(object sender, EventArgs e)
        {
            txtbx_font.Text = fd_font.Font.ToString();
        }

        private void pctbx_Bildbereich_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Point Point_LO = new Point(XCoord, YCoord);
            Point Point_RU = new Point(Breite+XCoord, Hoehe+YCoord);

           
            if (Delete == false)
            {
               
                if (Eingefügt == true)
                {
                   
                    g.DrawImage(BearbeitungsbereichBild, -1, -1, pctbx_Bildbereich.Width, pctbx_Bildbereich.Height);
                 
                }
               
            }

                if (TimeGerade == true)
                {
                    if (Farbauswahl == false)
                    {

                        Bearbeitungsbereich = new Pen(Brushes.Black);
                    }
                    else
                    {
                        Bearbeitungsbereich = new Pen(AuswahlColor);
                    }

                    Bearbeitungsbereich.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

                }
                else if (TimeGerade == false)
                {

                    Bearbeitungsbereich = new Pen(Color.White);
                    Bearbeitungsbereich.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                }

                if (Einfügen == true) { }
                else
                {
                    if (XCoord >= 0 | YCoord >= 0 | Breite <= 804 | Hoehe <= 296)
                    {


                        g.DrawRectangle(Bearbeitungsbereich, XCoord, YCoord, Breite, Hoehe);

                    }
                    else
                    {


                        g.DrawRectangle(Bearbeitungsbereich, 0, 0, 804, 296);

                    }

                }

             if (AuswahlTyp == "Text")
            {

                if (Fontauswahl == false) {
                FontText = new Font("Arial", 19);
                txtbx_font.Text = FontText.FontFamily.Name+", "+FontText.Style+", "+FontText.SizeInPoints+"pt";
                }

                g.DrawString(txtbx_text.Text, FontText, FontBrush, new Rectangle(XCoord,YCoord,Breite,Hoehe));
               



            
            }


             else if (AuswahlTyp == "Linie")
             {
                 txtbx_font.Text = "";
                 txtbx_text.Text = "";
                 g.DrawLine(Kontur, Point_LO, Point_RU);



             }

             else if (AuswahlTyp == "Rechteck")
             {
                 txtbx_font.Text = "";
                 txtbx_text.Text = "";
                 if (Radierer == true)
                 {

                     g.FillRectangle(Brushes.White, XCoord, YCoord, Breite, Hoehe);

                 }
                 else
                 {
                     if (fuellen == true)
                     {
                         g.FillRectangle(Fill, XCoord, YCoord, Breite, Hoehe);

                     }
                     else
                     {

                         g.DrawRectangle(Kontur, XCoord, YCoord, Breite, Hoehe);
                     }
                 }
             }
             else if (AuswahlTyp == "Ellipse")
             {

                 txtbx_font.Text = "";
                 txtbx_text.Text = "";
                 if (Radierer == true)
                 {

                     g.FillEllipse(Brushes.White, XCoord, YCoord, Breite, Hoehe);
                 }
                 else
                 {
                     if (fuellen == true)
                     {
                         g.FillEllipse(Fill, XCoord, YCoord, Breite, Hoehe);
                     }
                     else
                     {
                         g.DrawEllipse(Kontur, XCoord, YCoord, Breite, Hoehe);
                     }
                 }
             }

             else if (AuswahlTyp == "Bild")
             {

                 if (Bildauswahl == true)
                 {

                     g.DrawImage(AuswahlBild, XCoord, YCoord, Breite, Hoehe);
                 }

             }
            
             

           
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            XCoord = 0;
            YCoord = 0;
            Breite = 804;
            Hoehe = 296;

            Nmbrs_X.Value = XCoord;
            Nmbrs_Y.Value = YCoord;
            Nmbrs_Breite.Value = Breite;
            Nmbrs_Hoehe.Value = Hoehe;

            this.pctbx_Bildbereich.Refresh();
        }

        private void btn_insert_Click(object sender, EventArgs e)
        {

                Bitmap x = new Bitmap(pctbx_Bildbereich.Width, pctbx_Bildbereich.Height);
                Einfügen = true;
                pctbx_Bildbereich.DrawToBitmap(x, new Rectangle(0, 0, pctbx_Bildbereich.Width, pctbx_Bildbereich.Height));
                BearbeitungsbereichBild = x;
                Einfügen = false;
                Eingefügt = true;
                Delete = false;
            
            this.pctbx_Bildbereich.Refresh();
           
        }

        private void tim_Brbbereich_Tick(object sender, EventArgs e)
        {

            Time++;

            if (Time%2 == 0)
            {

                TimeGerade = true;

            }
            else {

                TimeGerade = false;
       
            }
            
            this.pctbx_Bildbereich.Refresh();
        }

        private void btn_reset_MouseDown(object sender, MouseEventArgs e)
        {
            btn_reset.FlatAppearance.BorderSize = 2;
        }

        private void btn_reset_MouseUp(object sender, MouseEventArgs e)
        {
            btn_reset.FlatAppearance.BorderSize = 0;
        }

        private void btn_insert_MouseDown(object sender, MouseEventArgs e)
        {
            btn_insert.FlatAppearance.BorderSize = 2;
        }

        private void btn_insert_MouseUp(object sender, MouseEventArgs e)
        {
            btn_insert.FlatAppearance.BorderSize = 0;
        }

        private void btn_color_MouseDown(object sender, MouseEventArgs e)
        {
            btn_color.FlatAppearance.BorderSize = 2;
        }

        private void btn_color_MouseUp(object sender, MouseEventArgs e)
        {
            btn_color.FlatAppearance.BorderSize = 0;
        }

        private void btn_font_MouseDown(object sender, MouseEventArgs e)
        {
            btn_font.FlatAppearance.BorderSize = 2;
        }

        private void btn_font_MouseUp(object sender, MouseEventArgs e)
        {
            btn_font.FlatAppearance.BorderSize = 0;
        }

        private void btn_img_MouseDown(object sender, MouseEventArgs e)
        {
            btn_img.FlatAppearance.BorderSize = 2;
        }

        private void btn_img_MouseUp(object sender, MouseEventArgs e)
        {
            btn_img.FlatAppearance.BorderSize = 0;
        }
       

        private void Menu_Neu_Click(object sender, EventArgs e)
        {
         
            
                Delete = true;
            

        }


        private void btn_Speichern_Click(object sender, EventArgs e)
        {

            this.sfd_Speichern.Filter = "Images (*.BMP;)|*.BMP;";
            this.sfd_Speichern.Title = "Datei Speichern";
            this.sfd_Speichern.InitialDirectory = "C:";
            System.Drawing.Imaging.ImageFormat Speicherformat = System.Drawing.Imaging.ImageFormat.Bmp;

            if (sfd_Speichern.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Einfügen = true;
                Bitmap Speicherbild = new Bitmap(pctbx_Bildbereich.Width, pctbx_Bildbereich.Height);
                pctbx_Bildbereich.DrawToBitmap(Speicherbild, new Rectangle(0, 0, pctbx_Bildbereich.Width, pctbx_Bildbereich.Height));
                Speicherbild.Save(sfd_Speichern.FileName, Speicherformat);
                Einfügen = false;
            }
                         
                        
        }

        private void btn_Laden_Click(object sender, EventArgs e)
        {
            this.ofd_Laden.Filter = "Images (*.BMP;)|*.BMP;";
            this.ofd_Laden.Title = "Datei Laden";
            this.ofd_Laden.InitialDirectory = "C:";

            if (ofd_Laden.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
               
                BearbeitungsbereichBild = Image.FromFile(ofd_Laden.FileName);
                Eingefügt = true;

                this.pctbx_Bildbereich.Refresh();
            
            
            }
        }

        private void btn_fill_Click(object sender, EventArgs e)
        {
            if (AuswahlTyp == "Rechteck" | AuswahlTyp == "Ellipse")
            {
                fuellen = true;
            }
            else
            {

                MessageBox.Show("Fuellen nur bei Rechteck oder Ellipse möglich");

            }
        }

        private void btn_kontur_Click(object sender, EventArgs e)
        {
            fuellen = false;
        }

        private void btn_rbract_Click(object sender, EventArgs e)
        {
            if (AuswahlTyp == "Rechteck" | AuswahlTyp == "Ellipse")
            {
                Radierer = true;
            }
            else {

                MessageBox.Show("Für Radierer erst Rechteck oder Ellipse bei der Typauswahl wählen");
            }
        }
        private void btn_rbrdeact_Click(object sender, EventArgs e)
        {
            Radierer = false;
        }


        private void Menu_Beenden_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Wollen Sie das Programm wirklich beenden? Alle nicht gespeicherten Änderungen gehen verloren.", "Programm Beenden", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {



            }
            else
            {

                Application.Exit();
            }
        }
        
      }      
}

