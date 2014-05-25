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
        bool Bildauswahl = false;
        bool Farbauswahl = false;
        bool Fontauswahl = false;
        bool TimeGerade = true;
        bool Texteingabe = false;
        bool Eingefügt = false;
        int Time = 0;
        int XCoord = 0;
        int YCoord = 0;
        int Hoehe = 299;
        int Breite = 807;
        string AuswahlTyp;
        SolidBrush FontBrush = new SolidBrush(System.Drawing.Color.Black);
        Pen LiniePen = new Pen(Brushes.Black);
        Pen RechteckPen = new Pen(Brushes.Black);
        Pen Bearbeitungsbereich;
        Color AuswahlColor = Color.FromArgb(255,255,255);
        Font FontText;
        Image AuswahlBild;
        Image BearbeitungsbereichBild;
        int Textbreite;
 



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

            if (AuswahlTyp == "Linie" | AuswahlTyp == "Rechteck" | AuswahlTyp == "Text")
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

            if (AuswahlTyp == "Linie" | AuswahlTyp == "Rechteck" | AuswahlTyp == "Text")
            {

                if (cd_color.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    AuswahlColor = cd_color.Color;
                    txtbx_color.BackColor = AuswahlColor;
                    LiniePen = new Pen(AuswahlColor);
                    RechteckPen = new Pen(AuswahlColor);
                    FontBrush = new SolidBrush(AuswahlColor);
                    Farbauswahl = true;

                    pctbx_Bildbereich.Refresh();
                }



            }
            else { 
            
                MessageBox.Show("Farbauswahl nur bei Linie, Rechteck und Text möglich");
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



            if( Eingefügt == true){
                
                g.DrawImage(BearbeitungsbereichBild,0,0,807,299);

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
            else if (TimeGerade == false) {

                Bearbeitungsbereich = new Pen(Color.White);
                }

             if (XCoord >= 0 | YCoord >= 0 | Breite <= 804 | Hoehe <= 296)
                {


                    g.DrawRectangle(Bearbeitungsbereich, XCoord, YCoord, Breite, Hoehe);

                }
             else
                {


                    g.DrawRectangle(Bearbeitungsbereich, 0, 0, 804, 296);

                }


             if (AuswahlTyp == "Text")
            {

                if (Fontauswahl == false) {
                FontText = new Font("Arial", 19);
                txtbx_font.Text = FontText.FontFamily.Name+", "+FontText.Style+", "+FontText.SizeInPoints+"pt";
                }

                g.DrawString(txtbx_text.Text, FontText, FontBrush, XCoord, YCoord);





            }
            else if (AuswahlTyp == "Linie")
            {
                txtbx_font.Text = "";
                txtbx_text.Text = "";
                g.DrawLine(LiniePen, Point_LO, Point_RU);



            }

            else if (AuswahlTyp == "Rechteck")
            {
                txtbx_font.Text = "";
                txtbx_text.Text = "";
                g.DrawRectangle(RechteckPen, XCoord, YCoord, Breite, Hoehe);

            }
             else if (AuswahlTyp == "Bild") {

                 if (Bildauswahl == true) {

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
            if (pctbx_Bildbereich.Image != null)
            {
                BearbeitungsbereichBild = pctbx_Bildbereich.Image;
                Eingefügt = true;
            }
            this.pctbx_Bildbereich.Refresh();
        }

        private void txtbx_text_TextChanged(object sender, EventArgs e)
        {
            
            Texteingabe = true;
          
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

        


       
       
    }
}
