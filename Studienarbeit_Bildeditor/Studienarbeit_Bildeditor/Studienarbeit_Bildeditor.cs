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

        int XCoord = 0;
        int YCoord = 0;
        int Hoehe = 296;
        int Breite = 804;
        string AuswahlTyp;
        

        public Studienarbeit_Bildeditor()
        {
            InitializeComponent();
        }

        private void Nmbrs_X_ValueChanged(object sender, EventArgs e)
        {
           
            XCoord = Convert.ToInt16(Nmbrs_X.Value);
        }

        private void Nmbrs_Y_ValueChanged(object sender, EventArgs e)
        {
            YCoord = Convert.ToInt16(Nmbrs_Y.Value); 
     
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
                Breite = Mouseklick.Location.X;
                Hoehe = Mouseklick.Location.Y;

            }

        }

        private void Nmbrs_Breite_ValueChanged(object sender, EventArgs e)
        {
            Breite = Convert.ToInt16(Nmbrs_Breite.Value);
        }

        private void Nmbrs_Hoehe_ValueChanged(object sender, EventArgs e)
        {
            Hoehe = Convert.ToInt16(Nmbrs_Hoehe.Value);
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
             
        }
        

        private void btn_color_Click(object sender, EventArgs e)
        {

            if (AuswahlTyp == "Linie" | AuswahlTyp == "Rechteck" | AuswahlTyp == "Text")
            {
                cd_color.ShowDialog();
            }

        }

        private void btn_font_Click(object sender, EventArgs e)
        {
            if (AuswahlTyp == "Text")
            {
                fd_font.ShowDialog();
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
            Pen Bearbeitungsbereich = new Pen(Color.Black);
            Bearbeitungsbereich.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;

            if (XCoord != 0 | YCoord != 0 | Breite != 804 | Hoehe != 296)
            {

                g.DrawRectangle(Bearbeitungsbereich, XCoord, YCoord, Breite, Hoehe);

                pctbx_Bildbereich.Refresh();

            }
            else { 

            g.DrawRectangle(Bearbeitungsbereich,0,0,804,296);

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

        }

       
       
    }
}
