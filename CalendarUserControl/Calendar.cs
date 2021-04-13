﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalendarUserControl
{
    public partial class Calendar : UserControl
    {
        public List<Label> lstDates = new List<Label>();
        public Calendar()
        {
            InitializeComponent();
        }
        private void LabelOnClick(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            MessageBox.Show(lbl.Name);
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            AssigningOnClicks();
        }





        #region Labels
        private void AddingLabels()
        {
            lstDates.Add(lblJan1);
            lstDates.Add(lblJan2);
            lstDates.Add(lblJan3);
            lstDates.Add(lblJan4);
            lstDates.Add(lblJan5);
            lstDates.Add(lblJan6);
            lstDates.Add(lblJan7);
            lstDates.Add(lblJan8);
            lstDates.Add(lblJan9);
            lstDates.Add(lblJan10);
            lstDates.Add(lblJan11);
            lstDates.Add(lblJan12);
            lstDates.Add(lblJan13);
            lstDates.Add(lblJan14);
            lstDates.Add(lblJan15);
            lstDates.Add(lblJan16);
            lstDates.Add(lblJan17);
            lstDates.Add(lblJan18);
            lstDates.Add(lblJan19);
            lstDates.Add(lblJan20);
            lstDates.Add(lblJan21);
            lstDates.Add(lblJan22);
            lstDates.Add(lblJan23);
            lstDates.Add(lblJan24);
            lstDates.Add(lblJan25);
            lstDates.Add(lblJan26);
            lstDates.Add(lblJan27);
            lstDates.Add(lblJan28);
            lstDates.Add(lblJan29);
            lstDates.Add(lblJan30);
            lstDates.Add(lblJan31);
            lstDates.Add(lblJan32);
            lstDates.Add(lblJan33);
            lstDates.Add(lblJan34);
            lstDates.Add(lblJan35);
            lstDates.Add(lblJan36);
            lstDates.Add(lblJan37);

            lstDates.Add(lblFeb1);
            lstDates.Add(lblFeb2);
            lstDates.Add(lblFeb3);
            lstDates.Add(lblFeb4);
            lstDates.Add(lblFeb5);
            lstDates.Add(lblFeb6);
            lstDates.Add(lblFeb7);
            lstDates.Add(lblFeb8);
            lstDates.Add(lblFeb9);
            lstDates.Add(lblFeb10);
            lstDates.Add(lblFeb11);
            lstDates.Add(lblFeb12);
            lstDates.Add(lblFeb13);
            lstDates.Add(lblFeb14);
            lstDates.Add(lblFeb15);
            lstDates.Add(lblFeb16);
            lstDates.Add(lblFeb17);
            lstDates.Add(lblFeb18);
            lstDates.Add(lblFeb19);
            lstDates.Add(lblFeb20);
            lstDates.Add(lblFeb21);
            lstDates.Add(lblFeb22);
            lstDates.Add(lblFeb23);
            lstDates.Add(lblFeb24);
            lstDates.Add(lblFeb25);
            lstDates.Add(lblFeb26);
            lstDates.Add(lblFeb27);
            lstDates.Add(lblFeb28);
            lstDates.Add(lblFeb29);
            lstDates.Add(lblFeb30);
            lstDates.Add(lblFeb31);
            lstDates.Add(lblFeb32);
            lstDates.Add(lblFeb33);
            lstDates.Add(lblFeb34);
            lstDates.Add(lblFeb35);
            lstDates.Add(lblFeb36);
            lstDates.Add(lblFeb37);

            lstDates.Add(lblMar1);
            lstDates.Add(lblMar2);
            lstDates.Add(lblMar3);
            lstDates.Add(lblMar4);
            lstDates.Add(lblMar5);
            lstDates.Add(lblMar6);
            lstDates.Add(lblMar7);
            lstDates.Add(lblMar8);
            lstDates.Add(lblMar9);
            lstDates.Add(lblMar10);
            lstDates.Add(lblMar11);
            lstDates.Add(lblMar12);
            lstDates.Add(lblMar13);
            lstDates.Add(lblMar14);
            lstDates.Add(lblMar15);
            lstDates.Add(lblMar16);
            lstDates.Add(lblMar17);
            lstDates.Add(lblMar18);
            lstDates.Add(lblMar19);
            lstDates.Add(lblMar20);
            lstDates.Add(lblMar21);
            lstDates.Add(lblMar22);
            lstDates.Add(lblMar23);
            lstDates.Add(lblMar24);
            lstDates.Add(lblMar25);
            lstDates.Add(lblMar26);
            lstDates.Add(lblMar27);
            lstDates.Add(lblMar28);
            lstDates.Add(lblMar29);
            lstDates.Add(lblMar30);
            lstDates.Add(lblMar31);
            lstDates.Add(lblMar32);
            lstDates.Add(lblMar33);
            lstDates.Add(lblMar34);
            lstDates.Add(lblMar35);
            lstDates.Add(lblMar36);
            lstDates.Add(lblMar37);

            lstDates.Add(lblApr1);
            lstDates.Add(lblApr2);
            lstDates.Add(lblApr3);
            lstDates.Add(lblApr4);
            lstDates.Add(lblApr5);
            lstDates.Add(lblApr6);
            lstDates.Add(lblApr7);
            lstDates.Add(lblApr8);
            lstDates.Add(lblApr9);
            lstDates.Add(lblApr10);
            lstDates.Add(lblApr11);
            lstDates.Add(lblApr12);
            lstDates.Add(lblApr13);
            lstDates.Add(lblApr14);
            lstDates.Add(lblApr15);
            lstDates.Add(lblApr16);
            lstDates.Add(lblApr17);
            lstDates.Add(lblApr18);
            lstDates.Add(lblApr19);
            lstDates.Add(lblApr20);
            lstDates.Add(lblApr21);
            lstDates.Add(lblApr22);
            lstDates.Add(lblApr23);
            lstDates.Add(lblApr24);
            lstDates.Add(lblApr25);
            lstDates.Add(lblApr26);
            lstDates.Add(lblApr27);
            lstDates.Add(lblApr28);
            lstDates.Add(lblApr29);
            lstDates.Add(lblApr30);
            lstDates.Add(lblApr31);
            lstDates.Add(lblApr32);
            lstDates.Add(lblApr33);
            lstDates.Add(lblApr34);
            lstDates.Add(lblApr35);
            lstDates.Add(lblApr36);
            lstDates.Add(lblApr37);
            
            lstDates.Add(lblMay1);
            lstDates.Add(lblMay2);
            lstDates.Add(lblMay3);
            lstDates.Add(lblMay4);
            lstDates.Add(lblMay5);
            lstDates.Add(lblMay6);
            lstDates.Add(lblMay7);
            lstDates.Add(lblMay8);
            lstDates.Add(lblMay9);
            lstDates.Add(lblMay10);
            lstDates.Add(lblMay11);
            lstDates.Add(lblMay12);
            lstDates.Add(lblMay13);
            lstDates.Add(lblMay14);
            lstDates.Add(lblMay15);
            lstDates.Add(lblMay16);
            lstDates.Add(lblMay17);
            lstDates.Add(lblMay18);
            lstDates.Add(lblMay19);
            lstDates.Add(lblMay20);
            lstDates.Add(lblMay21);
            lstDates.Add(lblMay22);
            lstDates.Add(lblMay23);
            lstDates.Add(lblMay24);
            lstDates.Add(lblMay25);
            lstDates.Add(lblMay26);
            lstDates.Add(lblMay27);
            lstDates.Add(lblMay28);
            lstDates.Add(lblMay29);
            lstDates.Add(lblMay30);
            lstDates.Add(lblMay31);
            lstDates.Add(lblMay32);
            lstDates.Add(lblMay33);
            lstDates.Add(lblMay34);
            lstDates.Add(lblMay35);
            lstDates.Add(lblMay36);
            lstDates.Add(lblMay37);
            
            lstDates.Add(lblJun1);
            lstDates.Add(lblJun2);
            lstDates.Add(lblJun3);
            lstDates.Add(lblJun4);
            lstDates.Add(lblJun5);
            lstDates.Add(lblJun6);
            lstDates.Add(lblJun7);
            lstDates.Add(lblJun8);
            lstDates.Add(lblJun9);
            lstDates.Add(lblJun10);
            lstDates.Add(lblJun11);
            lstDates.Add(lblJun12);
            lstDates.Add(lblJun13);
            lstDates.Add(lblJun14);
            lstDates.Add(lblJun15);
            lstDates.Add(lblJun16);
            lstDates.Add(lblJun17);
            lstDates.Add(lblJun18);
            lstDates.Add(lblJun19);
            lstDates.Add(lblJun20);
            lstDates.Add(lblJun21);
            lstDates.Add(lblJun22);
            lstDates.Add(lblJun23);
            lstDates.Add(lblJun24);
            lstDates.Add(lblJun25);
            lstDates.Add(lblJun26);
            lstDates.Add(lblJun27);
            lstDates.Add(lblJun28);
            lstDates.Add(lblJun29);
            lstDates.Add(lblJun30);
            lstDates.Add(lblJun31);
            lstDates.Add(lblJun32);
            lstDates.Add(lblJun33);
            lstDates.Add(lblJun34);
            lstDates.Add(lblJun35);
            lstDates.Add(lblJun36);
            lstDates.Add(lblJun37);

            lstDates.Add(lblJul1);
            lstDates.Add(lblJul2);
            lstDates.Add(lblJul3);
            lstDates.Add(lblJul4);
            lstDates.Add(lblJul5);
            lstDates.Add(lblJul6);
            lstDates.Add(lblJul7);
            lstDates.Add(lblJul8);
            lstDates.Add(lblJul9);
            lstDates.Add(lblJul10);
            lstDates.Add(lblJul11);
            lstDates.Add(lblJul12);
            lstDates.Add(lblJul13);
            lstDates.Add(lblJul14);
            lstDates.Add(lblJul15);
            lstDates.Add(lblJul16);
            lstDates.Add(lblJul17);
            lstDates.Add(lblJul18);
            lstDates.Add(lblJul19);
            lstDates.Add(lblJul20);
            lstDates.Add(lblJul21);
            lstDates.Add(lblJul22);
            lstDates.Add(lblJul23);
            lstDates.Add(lblJul24);
            lstDates.Add(lblJul25);
            lstDates.Add(lblJul26);
            lstDates.Add(lblJul27);
            lstDates.Add(lblJul28);
            lstDates.Add(lblJul29);
            lstDates.Add(lblJul30);
            lstDates.Add(lblJul31);
            lstDates.Add(lblJul32);
            lstDates.Add(lblJul33);
            lstDates.Add(lblJul34);
            lstDates.Add(lblJul35);
            lstDates.Add(lblJul36);
            lstDates.Add(lblJul37);

            lstDates.Add(lblAug1);
            lstDates.Add(lblAug2);
            lstDates.Add(lblAug3);
            lstDates.Add(lblAug4);
            lstDates.Add(lblAug5);
            lstDates.Add(lblAug6);
            lstDates.Add(lblAug7);
            lstDates.Add(lblAug8);
            lstDates.Add(lblAug9);
            lstDates.Add(lblAug10);
            lstDates.Add(lblAug11);
            lstDates.Add(lblAug12);
            lstDates.Add(lblAug13);
            lstDates.Add(lblAug14);
            lstDates.Add(lblAug15);
            lstDates.Add(lblAug16);
            lstDates.Add(lblAug17);
            lstDates.Add(lblAug18);
            lstDates.Add(lblAug19);
            lstDates.Add(lblAug20);
            lstDates.Add(lblAug21);
            lstDates.Add(lblAug22);
            lstDates.Add(lblAug23);
            lstDates.Add(lblAug24);
            lstDates.Add(lblAug25);
            lstDates.Add(lblAug26);
            lstDates.Add(lblAug27);
            lstDates.Add(lblAug28);
            lstDates.Add(lblAug29);
            lstDates.Add(lblAug30);
            lstDates.Add(lblAug31);
            lstDates.Add(lblAug32);
            lstDates.Add(lblAug33);
            lstDates.Add(lblAug34);
            lstDates.Add(lblAug35);
            lstDates.Add(lblAug36);
            lstDates.Add(lblAug37);

            lstDates.Add(lblSep1);
            lstDates.Add(lblSep2);
            lstDates.Add(lblSep3);
            lstDates.Add(lblSep4);
            lstDates.Add(lblSep5);
            lstDates.Add(lblSep6);
            lstDates.Add(lblSep7);
            lstDates.Add(lblSep8);
            lstDates.Add(lblSep9);
            lstDates.Add(lblSep10);
            lstDates.Add(lblSep11);
            lstDates.Add(lblSep12);
            lstDates.Add(lblSep13);
            lstDates.Add(lblSep14);
            lstDates.Add(lblSep15);
            lstDates.Add(lblSep16);
            lstDates.Add(lblSep17);
            lstDates.Add(lblSep18);
            lstDates.Add(lblSep19);
            lstDates.Add(lblSep20);
            lstDates.Add(lblSep21);
            lstDates.Add(lblSep22);
            lstDates.Add(lblSep23);
            lstDates.Add(lblSep24);
            lstDates.Add(lblSep25);
            lstDates.Add(lblSep26);
            lstDates.Add(lblSep27);
            lstDates.Add(lblSep28);
            lstDates.Add(lblSep29);
            lstDates.Add(lblSep30);
            lstDates.Add(lblSep31);
            lstDates.Add(lblSep32);
            lstDates.Add(lblSep33);
            lstDates.Add(lblSep34);
            lstDates.Add(lblSep35);
            lstDates.Add(lblSep36);
            lstDates.Add(lblSep37);

            lstDates.Add(lblOct1);
            lstDates.Add(lblOct2);
            lstDates.Add(lblOct3);
            lstDates.Add(lblOct4);
            lstDates.Add(lblOct5);
            lstDates.Add(lblOct6);
            lstDates.Add(lblOct7);
            lstDates.Add(lblOct8);
            lstDates.Add(lblOct9);
            lstDates.Add(lblOct10);
            lstDates.Add(lblOct11);
            lstDates.Add(lblOct12);
            lstDates.Add(lblOct13);
            lstDates.Add(lblOct14);
            lstDates.Add(lblOct15);
            lstDates.Add(lblOct16);
            lstDates.Add(lblOct17);
            lstDates.Add(lblOct18);
            lstDates.Add(lblOct19);
            lstDates.Add(lblOct20);
            lstDates.Add(lblOct21);
            lstDates.Add(lblOct22);
            lstDates.Add(lblOct23);
            lstDates.Add(lblOct24);
            lstDates.Add(lblOct25);
            lstDates.Add(lblOct26);
            lstDates.Add(lblOct27);
            lstDates.Add(lblOct28);
            lstDates.Add(lblOct29);
            lstDates.Add(lblOct30);
            lstDates.Add(lblOct31);
            lstDates.Add(lblOct32);
            lstDates.Add(lblOct33);
            lstDates.Add(lblOct34);
            lstDates.Add(lblOct35);
            lstDates.Add(lblOct36);
            lstDates.Add(lblOct37);

            lstDates.Add(lblNov1);
            lstDates.Add(lblNov2);
            lstDates.Add(lblNov3);
            lstDates.Add(lblNov4);
            lstDates.Add(lblNov5);
            lstDates.Add(lblNov6);
            lstDates.Add(lblNov7);
            lstDates.Add(lblNov8);
            lstDates.Add(lblNov9);
            lstDates.Add(lblNov10);
            lstDates.Add(lblNov11);
            lstDates.Add(lblNov12);
            lstDates.Add(lblNov13);
            lstDates.Add(lblNov14);
            lstDates.Add(lblNov15);
            lstDates.Add(lblNov16);
            lstDates.Add(lblNov17);
            lstDates.Add(lblNov18);
            lstDates.Add(lblNov19);
            lstDates.Add(lblNov20);
            lstDates.Add(lblNov21);
            lstDates.Add(lblNov22);
            lstDates.Add(lblNov23);
            lstDates.Add(lblNov24);
            lstDates.Add(lblNov25);
            lstDates.Add(lblNov26);
            lstDates.Add(lblNov27);
            lstDates.Add(lblNov28);
            lstDates.Add(lblNov29);
            lstDates.Add(lblNov30);
            lstDates.Add(lblNov31);
            lstDates.Add(lblNov32);
            lstDates.Add(lblNov33);
            lstDates.Add(lblNov34);
            lstDates.Add(lblNov35);
            lstDates.Add(lblNov36);
            lstDates.Add(lblNov37);

            lstDates.Add(lblDec1);
            lstDates.Add(lblDec2);
            lstDates.Add(lblDec3);
            lstDates.Add(lblDec4);
            lstDates.Add(lblDec5);
            lstDates.Add(lblDec6);
            lstDates.Add(lblDec7);
            lstDates.Add(lblDec8);
            lstDates.Add(lblDec9);
            lstDates.Add(lblDec10);
            lstDates.Add(lblDec11);
            lstDates.Add(lblDec12);
            lstDates.Add(lblDec13);
            lstDates.Add(lblDec14);
            lstDates.Add(lblDec15);
            lstDates.Add(lblDec16);
            lstDates.Add(lblDec17);
            lstDates.Add(lblDec18);
            lstDates.Add(lblDec19);
            lstDates.Add(lblDec20);
            lstDates.Add(lblDec21);
            lstDates.Add(lblDec22);
            lstDates.Add(lblDec23);
            lstDates.Add(lblDec24);
            lstDates.Add(lblDec25);
            lstDates.Add(lblDec26);
            lstDates.Add(lblDec27);
            lstDates.Add(lblDec28);
            lstDates.Add(lblDec29);
            lstDates.Add(lblDec30);
            lstDates.Add(lblDec31);
            lstDates.Add(lblDec32);
            lstDates.Add(lblDec33);
            lstDates.Add(lblDec34);
            lstDates.Add(lblDec35);
            lstDates.Add(lblDec36);
            lstDates.Add(lblDec37);
        }

        #endregion

        private void AssigningOnClicks()
        {
            AddingLabels();
            for (int i = 0; i < lstDates.Count; i++)
            {
                lstDates[i].Click += LabelOnClick;
            }
        }
    }
}
