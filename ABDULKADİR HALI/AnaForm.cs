using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bezier_Egrisi
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        private PointF[] Noktalar = new PointF[84];

        private void Cizim_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Cizim.BackColor);
                                                                             //BAYRAK ÖLÇÜSÜ ORJİNAL TÜRK BAYRAĞI ÖLÇÜSÜNE UYGUN OLARAK 1*1.5 ŞEKLİNDE HESAPLANIP YAPILMIŞTIR.
            
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,    
                Noktalar[0], Noktalar[1], Noktalar[2], Noktalar[3]);  
      
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[4], Noktalar[5], Noktalar[6], Noktalar[7]);
            
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[8], Noktalar[9], Noktalar[10], Noktalar[11]);
           
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[12], Noktalar[13], Noktalar[14], Noktalar[15]);
           
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[16], Noktalar[17], Noktalar[18], Noktalar[19]);
           
            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[20], Noktalar[21], Noktalar[22], Noktalar[23]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,     
                  Noktalar[24], Noktalar[25], Noktalar[26], Noktalar[27]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,      
                  Noktalar[28], Noktalar[29], Noktalar[30], Noktalar[31]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[32], Noktalar[33], Noktalar[34], Noktalar[35]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,      
                  Noktalar[36], Noktalar[37], Noktalar[38], Noktalar[39]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[40], Noktalar[41], Noktalar[42], Noktalar[43]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,      
                  Noktalar[44], Noktalar[45], Noktalar[46], Noktalar[47]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[48], Noktalar[49], Noktalar[50], Noktalar[51]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[52], Noktalar[53], Noktalar[54], Noktalar[55]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[56], Noktalar[57], Noktalar[58], Noktalar[59]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[60], Noktalar[61], Noktalar[62], Noktalar[63]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[64], Noktalar[65], Noktalar[66], Noktalar[67]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[68], Noktalar[69], Noktalar[70], Noktalar[71]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[72], Noktalar[73], Noktalar[74], Noktalar[75]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[76], Noktalar[77], Noktalar[78], Noktalar[79]);

            Bezier_Egrisi.Bezier_Ciz(e.Graphics, Pens.Red, 0.01f,       
                  Noktalar[80], Noktalar[81], Noktalar[82], Noktalar[83]);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Noktalar[0].X = 50; 
            Noktalar[0].Y = 50;
            Noktalar[1].X = 110;
            Noktalar[1].Y = 33;              //SOL ÜST EĞRİ
            Noktalar[2].X = 170;  
            Noktalar[2].Y = 33;
            Noktalar[3].X = 230; 
            Noktalar[3].Y = 50;

            Noktalar[4].X = 230;
            Noktalar[4].Y = 50;
            Noktalar[5].X = 290;
            Noktalar[5].Y = 67;               //SAĞ ÜST EĞRİ
            Noktalar[6].X = 350;
            Noktalar[6].Y = 67;
            Noktalar[7].X = 410;
            Noktalar[7].Y = 50;

            Noktalar[8].X = 50;
            Noktalar[8].Y = 50;
            Noktalar[9].X = 50;
            Noktalar[9].Y = 50;               //SOL DİK ÇİZGİ
            Noktalar[10].X = 50;
            Noktalar[10].Y = 20;
            Noktalar[11].X = 50;
            Noktalar[11].Y = 290;

            Noktalar[12].X = 50;
            Noktalar[12].Y = 290;
            Noktalar[13].X = 110;
            Noktalar[13].Y = 273;             //SOL ALT EĞRİ
            Noktalar[14].X = 170;
            Noktalar[14].Y = 273;
            Noktalar[15].X = 230;
            Noktalar[15].Y = 290;

            Noktalar[16].X = 230;
            Noktalar[16].Y = 290;
            Noktalar[17].X = 290;
            Noktalar[17].Y = 307;
            Noktalar[18].X = 350;            //SAĞ ALT EĞRİ
            Noktalar[18].Y = 307;
            Noktalar[19].X = 410;
            Noktalar[19].Y = 290;

            Noktalar[20].X = 410;
            Noktalar[20].Y = 50;
            Noktalar[21].X = 410;
            Noktalar[21].Y = 50;             //SAĞ DİK ÇİZGİ
            Noktalar[22].X = 410;
            Noktalar[22].Y = 230;
            Noktalar[23].X = 410;
            Noktalar[23].Y = 290;


            Noktalar[24].X = 218;
            Noktalar[24].Y = 130;
            Noktalar[25].X = 50;
            Noktalar[25].Y = 10;            //HİLAL SOL PARÇA
            Noktalar[26].X = 50;
            Noktalar[26].Y = 310;
            Noktalar[27].X = 218;
            Noktalar[27].Y = 190;


            Noktalar[28].X = 218;
            Noktalar[28].Y = 130;
            Noktalar[29].X = 90;
            Noktalar[29].Y = 68;            //HİLAL SAĞ PARÇA
            Noktalar[30].X = 90;
            Noktalar[30].Y = 252;
            Noktalar[31].X = 218;
            Noktalar[31].Y = 190;

            Noktalar[32].X = 285;
            Noktalar[32].Y = 125;
            Noktalar[33].X = 285;
            Noktalar[33].Y = 125;           //YILDIZ ÜST SOL ÇİZGİ
            Noktalar[34].X = 275;
            Noktalar[34].Y = 155;
            Noktalar[35].X = 275;
            Noktalar[35].Y = 155;
            
            Noktalar[36].X = 285;
            Noktalar[36].Y = 125;
            Noktalar[37].X = 285;
            Noktalar[37].Y = 125;           //YILDIZ ÜST SAĞ ÇİZGİ
            Noktalar[38].X = 295;
            Noktalar[38].Y = 155;
            Noktalar[39].X = 295;
            Noktalar[39].Y = 155;

            Noktalar[40].X = 245;
            Noktalar[40].Y = 155;
            Noktalar[41].X = 245;
            Noktalar[41].Y = 155;           //YILDIZ ORTA SOL ÜST
            Noktalar[42].X = 275;
            Noktalar[42].Y = 155;
            Noktalar[43].X = 275;
            Noktalar[43].Y = 155;

            Noktalar[44].X = 325;
            Noktalar[44].Y = 155;
            Noktalar[45].X = 325;
            Noktalar[45].Y = 155;           //YILDIZ ORTA SAĞ ÜST
            Noktalar[46].X = 295;
            Noktalar[46].Y = 155;
            Noktalar[47].X = 295;
            Noktalar[47].Y = 155;

            Noktalar[48].X = 325;
            Noktalar[48].Y = 155;
            Noktalar[49].X = 325;
            Noktalar[49].Y = 155;          //YILDIZ ORTA SAĞ ALT
            Noktalar[50].X = 300;
            Noktalar[50].Y = 171;
            Noktalar[51].X = 300;
            Noktalar[51].Y = 171;

            Noktalar[52].X = 245;
            Noktalar[52].Y = 156;
            Noktalar[53].X = 245;
            Noktalar[53].Y = 156;          //YILDIZ ORTA SOL ALT
            Noktalar[54].X = 270;
            Noktalar[54].Y = 171;
            Noktalar[55].X = 270;
            Noktalar[55].Y = 171;

            Noktalar[56].X = 260;
            Noktalar[56].Y = 196;
            Noktalar[57].X = 260;
            Noktalar[57].Y = 196;          //YILDIZ SOL ALT AYAĞIN SOLU
            Noktalar[58].X = 270;
            Noktalar[58].Y = 171;
            Noktalar[59].X = 270;
            Noktalar[59].Y = 171;

            Noktalar[60].X = 310;
            Noktalar[60].Y = 196;
            Noktalar[61].X = 310;
            Noktalar[61].Y = 196;          //YILDIZ SAĞ ALT AYAĞIN SAĞI
            Noktalar[62].X = 300;
            Noktalar[62].Y = 171;
            Noktalar[63].X = 300;
            Noktalar[63].Y = 171;

            Noktalar[64].X = 310;
            Noktalar[64].Y = 196;
            Noktalar[65].X = 310;
            Noktalar[65].Y = 196;          //YILDIZIN SAĞ ALT AYAĞININ SOLU
            Noktalar[66].X = 285;
            Noktalar[66].Y = 178;
            Noktalar[67].X = 285;
            Noktalar[67].Y = 178;

            Noktalar[68].X = 260;
            Noktalar[68].Y = 196;
            Noktalar[69].X = 260;
            Noktalar[69].Y = 196;          //YILDIZ SOL ALT AYAĞIN SAĞI
            Noktalar[70].X = 285;
            Noktalar[70].Y = 178;
            Noktalar[71].X = 285;
            Noktalar[71].Y = 178;

            Noktalar[72].X = 45;
            Noktalar[72].Y = 50;
            Noktalar[73].X = 45;
            Noktalar[73].Y = 50;           //AYRINTI SOL
            Noktalar[74].X = 45;
            Noktalar[74].Y = 20;
            Noktalar[75].X = 45;
            Noktalar[75].Y = 290;

            Noktalar[76].X = 45;
            Noktalar[76].Y = 50;
            Noktalar[77].X = 45;
            Noktalar[77].Y = 50;          //AYRINTI ÜST
            Noktalar[78].X = 50;
            Noktalar[78].Y = 50;
            Noktalar[79].X = 50;
            Noktalar[79].Y = 50;

            Noktalar[80].X = 45;
            Noktalar[80].Y = 290;
            Noktalar[81].X = 45;
            Noktalar[81].Y = 290;         //AYRINTI ALT
            Noktalar[82].X = 50;
            Noktalar[82].Y = 290;
            Noktalar[83].X = 50;
            Noktalar[83].Y = 290;


            Cizim.Invalidate();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Noktalar[0].X = 0;
            Noktalar[0].Y = 0;
            Noktalar[1].X = 0;
            Noktalar[1].Y = 0;        // SOL ÜST EĞRİ
            Noktalar[2].X = 0;
            Noktalar[2].Y = 0;
            Noktalar[3].X = 0;
            Noktalar[3].Y = 0;      

            Noktalar[4].X = 0;
            Noktalar[4].Y = 0;
            Noktalar[5].X = 0;
            Noktalar[5].Y = 0;         //SAĞ ÜST EĞRİ
            Noktalar[6].X = 0;
            Noktalar[6].Y = 0;
            Noktalar[7].X = 0;
            Noktalar[7].Y = 0;

            Noktalar[8].X = 0;
            Noktalar[8].Y = 0;
            Noktalar[9].X = 0;
            Noktalar[9].Y = 0;         //SOL DİK ÇİZGİ
            Noktalar[10].X = 0;
            Noktalar[10].Y = 0;
            Noktalar[11].X = 0;
            Noktalar[11].Y = 0;

            Noktalar[12].X = 0;
            Noktalar[12].Y = 0;
            Noktalar[13].X = 0;
            Noktalar[13].Y = 0;        //SOL ALT EĞRİ
            Noktalar[14].X = 0;
            Noktalar[14].Y = 0;
            Noktalar[15].X = 0;
            Noktalar[15].Y = 0;

            Noktalar[16].X = 0;
            Noktalar[16].Y = 0;
            Noktalar[17].X = 0;
            Noktalar[17].Y = 0;
            Noktalar[18].X = 0;       //SAĞ ALT EĞRİ
            Noktalar[18].Y = 0;
            Noktalar[19].X = 0;
            Noktalar[19].Y = 0;

            Noktalar[20].X = 0;
            Noktalar[20].Y = 0;
            Noktalar[21].X = 0;
            Noktalar[21].Y = 0;        //SAĞ DİK ÇİZGİ
            Noktalar[22].X = 0;
            Noktalar[22].Y = 0;
            Noktalar[23].X = 0;
            Noktalar[23].Y = 0;


            Noktalar[24].X = 0;
            Noktalar[24].Y = 0;
            Noktalar[25].X = 0;
            Noktalar[25].Y = 0;       //HİLAL SOL PARÇA
            Noktalar[26].X = 0;
            Noktalar[26].Y = 0;
            Noktalar[27].X = 0;
            Noktalar[27].Y = 0;


            Noktalar[28].X = 0;
            Noktalar[28].Y = 0;
            Noktalar[29].X = 0;
            Noktalar[29].Y = 0;       //HİLAL SAĞ PARÇA
            Noktalar[30].X = 0;
            Noktalar[30].Y = 0;
            Noktalar[31].X = 0;
            Noktalar[31].Y = 0;

            Noktalar[32].X = 0;
            Noktalar[32].Y = 0;
            Noktalar[33].X = 0;
            Noktalar[33].Y = 0;       //YILDIZ ÜST SOL ÇİZGİ
            Noktalar[34].X = 0;
            Noktalar[34].Y = 0;
            Noktalar[35].X = 0;
            Noktalar[35].Y = 0;

            Noktalar[36].X = 0;
            Noktalar[36].Y = 0;
            Noktalar[37].X = 0;
            Noktalar[37].Y = 0;       //YILDIZ ÜST SAĞ ÇİZGİ
            Noktalar[38].X = 0;
            Noktalar[38].Y = 0;
            Noktalar[39].X = 0;
            Noktalar[39].Y = 0;

            Noktalar[40].X = 0;
            Noktalar[40].Y = 0;
            Noktalar[41].X = 0;
            Noktalar[41].Y = 0;       //YILDIZ ORTA SOL ÜST
            Noktalar[42].X = 0;
            Noktalar[42].Y = 0;
            Noktalar[43].X = 0;
            Noktalar[43].Y = 0;

            Noktalar[44].X = 0;
            Noktalar[44].Y = 0;
            Noktalar[45].X = 0;
            Noktalar[45].Y = 0;     //YILDIZ ORTA SAĞ ÜST
            Noktalar[46].X = 0;
            Noktalar[46].Y = 0;
            Noktalar[47].X = 0;
            Noktalar[47].Y = 0;

            Noktalar[48].X = 0;
            Noktalar[48].Y = 0;
            Noktalar[49].X = 0;
            Noktalar[49].Y = 0;     //YILDIZ ORTA SAĞ ALT
            Noktalar[50].X = 0;
            Noktalar[50].Y = 0;
            Noktalar[51].X = 0;
            Noktalar[51].Y = 0;

            Noktalar[52].X = 0;
            Noktalar[52].Y = 0;
            Noktalar[53].X = 0;
            Noktalar[53].Y = 0;     //YILDIZ ORTA SOL ALT
            Noktalar[54].X = 0;
            Noktalar[54].Y = 0;
            Noktalar[55].X = 0;
            Noktalar[55].Y = 0;

            Noktalar[56].X = 0;
            Noktalar[56].Y = 0;
            Noktalar[57].X = 0;
            Noktalar[57].Y = 0;     //YILDIZ SOL ALT AYAĞIN SOLU
            Noktalar[58].X = 0;
            Noktalar[58].Y = 0;
            Noktalar[59].X = 0;
            Noktalar[59].Y = 0;
            
            Noktalar[60].X = 0;
            Noktalar[60].Y = 0;
            Noktalar[61].X = 0;
            Noktalar[61].Y = 0;       //YILDIZ SAĞ ALT AYAĞIN SAĞI
            Noktalar[62].X = 0;
            Noktalar[62].Y = 0;
            Noktalar[63].X = 0;
            Noktalar[63].Y = 0;

            Noktalar[64].X = 0;
            Noktalar[64].Y = 0;
            Noktalar[65].X = 0;
            Noktalar[65].Y = 0;      //YILDIZIN SAĞ ALT AYAĞININ SOLU
            Noktalar[66].X = 0;
            Noktalar[66].Y = 0;
            Noktalar[67].X = 0;
            Noktalar[67].Y = 0;

            Noktalar[68].X = 0;
            Noktalar[68].Y = 0;
            Noktalar[69].X = 0;
            Noktalar[69].Y = 0;      //YILDIZ SOL ALT AYAĞIN SAĞI
            Noktalar[70].X = 0;
            Noktalar[70].Y = 0;
            Noktalar[71].X = 0;
            Noktalar[71].Y = 0;

            Noktalar[72].X = 0;
            Noktalar[72].Y = 0;
            Noktalar[73].X = 0;
            Noktalar[73].Y = 0;      //AYRINTI SOL
            Noktalar[74].X = 0;
            Noktalar[74].Y = 0;
            Noktalar[75].X = 0;
            Noktalar[75].Y = 0;

            Noktalar[76].X = 0;
            Noktalar[76].Y = 0;
            Noktalar[77].X = 0;
            Noktalar[77].Y = 0;      //AYRINTI ÜST
            Noktalar[78].X = 0;
            Noktalar[78].Y = 0;
            Noktalar[79].X = 0;
            Noktalar[79].Y = 0;

            Noktalar[80].X = 0;
            Noktalar[80].Y = 0;
            Noktalar[81].X = 0;
            Noktalar[81].Y = 0;      //AYRINTI ALT
            Noktalar[82].X = 0;
            Noktalar[82].Y = 0;
            Noktalar[83].X = 0;
            Noktalar[83].Y = 0;

            Cizim.Invalidate();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cizim_Click(object sender, EventArgs e)
        {

        }

    }
}
       