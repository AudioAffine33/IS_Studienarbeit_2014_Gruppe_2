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
        bool TimeGerade = true;
        bool Texteingabe = false;
        int Time = 0;
        int XCoord = 0;
        int YCoord = 0;
        int Hoehe = 296;
        int Breite = 804;
        string AuswahlTyp;
        Brush Fontcolor = Brushes.Black;
        Pen LiniePen = new Pen(Brushes.Black);
        Pen RechteckPen = new Pen(Brushes.Black);
        Pen Bearbeitungsbereich = new Pen(Color.Black);
        Color AuswahlColor = Color.FromArgb(255,255,255);
        Font FontText;
 



        public Studienarbeit_Bildeditor()
        {
            InitializeComponent();
        }

        private void Nmbrs_X_ValueChanged(object sender, EventArgs e)
        {
           
            XCoord = Convert.ToInt16(Nmbrs_X.Value);
            this.pctbx_Bildbereich.Refresh();
        }

        private void Nmbrs_Y_ValueChanged(object sender, EventArgs e)
        {
            YCoord = Convert.ToInt16(Nmbrs_Y.Value);
            this.pctbx_Bildbereich.Refresh();
        }

        private void pctbx_Bildbereich_Click(object sender, EventArgs e)
        {
            MouseEventArgs Mouseklick = (MouseEventArgs)e;

            if (Mouseklick.Button == MouseButtons.Left)
            {
                XCoord = Mouseklick.Location.X;
                YCoord = Mouseklick.Location.Y;


            }
            if (Mouseklick.Button == MouseButtons.Right)
            {
                Breite = Mouseklick.Location.X - XCoord;
                Hoehe = Mouseklick.Location.Y - YCoord;

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
                txtbx_font.Enabled = true;
                txtbx_text.Enabled = true;
            }
            else {
                txtbx_font.Enabled = false;
                txtbx_text.Enabled = false;
                
            }
            if (AuswahlTyp == "Bild") {

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
                cd_color.ShowDialog();
                if (cd_color.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                    AuswahlColor = cd_color.Color;
                    txtbx_color.BackColor = AuswahlColor;

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
                fd_font.ShowDialog();

                if (fd_font.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                    txtbx_font.Text = fd_font.Font.FontFamily.Name;
                    FontText = fd_font.Font;
                }
            }
            else {

                MessageBox.Show("Schriftauswahl nur bei Text möglich");
            
            }
        }

        private void btn_img_Click(object sender, EventArgs e)
        {
            if (AuswahlTyp == "Bild") {

                ofd_img.ShowDialog();
            }
        }

        private void ofd_img_FileOk(object sender, CancelEventArgs e)
        {
            txtbx_img.Text = ofd_img.FileName;

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
            FontText = new Font("Arial", 19);


            //if (TimeGerade == true)
            //{
                Bearbeitungsbereich = new Pen(Color.Black);
                Bearbeitungsbereich.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
             
            //}
           // else if (TimeGerade == false) {

           //     Bearbeitungsbereich = new Pen(Color.White);
           //     }

             if (XCoord >= 0 | YCoord >= 0 | Breite <= 804 | Hoehe <= 296)
                {

                    g.DrawRectangle(Bearbeitungsbereich, XCoord, YCoord, Breite, Hoehe);

                }
             else
                {

                    g.DrawRectangle(Bearbeitungsbereich, 0, 0, 804, 296);
                }
            

            if (Texteingabe == true)
            {

                g.DrawString(txtbx_text.Text, Font, Fontcolor, XCoord, YCoord);

                pctbx_Bildbereich.Refresh();
            }
            else if (AuswahlTyp == "Linie")
            {

                g.DrawLine(LiniePen, Point_LO, Point_RU);
                pctbx_Bildbereich.Refresh();
            }

            else if (AuswahlTyp == "Rechteck")
            {

                g.DrawRectangle(RechteckPen, XCoord, YCoord, Breite, Hoehe);
                pctbx_Bildbereich.Refresh();
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

        private void txtbx_text_TextChanged(object sender, EventArgs e)
        {
            Texteingabe = true;
          
        }

        private void tim_Brbbereich_Tick(object sender, EventArgs e)
        {

            Time++;

            if (Time / 2 == 0)
            {

                TimeGerade = true;

            }
            else {

                TimeGerade = false;
       
            }

            this.pctbx_Bildbereich.Refresh();
        }


       
       
    }
}
