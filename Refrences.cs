using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace XmlCreat1
{
    public partial class Refrences : Form
    {
        public Refrences()
        {
            InitializeComponent();
        }

        private void Refrences_Load(object sender, EventArgs e)
        {

        }


        string[,] refs = new string[100, 20];
        string[,] gp1 = new string[1000, 7];
        string[,] gp2 = new string[1000, 7];
        string[,] gp3 = new string[1000, 7];
        string[,] gp4 = new string[1000, 7];
        string[,] gp5 = new string[1000, 7];
        string[,] etal = new string[100, 6];
        string[,] collab = new string[1000, 3];
        string[,] date = new string[400, 6];
        string[,] conf = new string[200, 6];
        string[,] volIssu = new string[200, 6];
        string[,] DICitation = new string[500, 4];
        string[,] size = new string[500, 3];
        string[,] seris = new string[500, 2];
        string[,] pubId = new string[400, 3];
        string[,] comment = new string[300, 5];


        int i = 0;
        int num = 0;
        int ij1 = 0;
        int ij2 = 0;
        int ij3 = 0;
        int ij4 = 0;
        int ij5 = 0;
        int ij6 = 0;
        int cm = 0;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (cmbPublicationType.Text == "journal")
            {
                num = Convert.ToInt32(ary1[ij1, 0]);
                for (int pi = 0; pi < ii2; pi++)
                {
                    for (int ll = 1; ll < 15; ll += 2)
                    {
                        if (String.IsNullOrEmpty(ary1[ij1, ll]) == false)
                        {
                            gp1[j1, 0] = ary1[ij1, 0];
                            gp1[j1, 1] = "name";

                            gp1[j1, 2] = ary1[ij1, ll];
                            gp1[j1, 3] = ary1[ij1, ll + 1];

                            j1++;
                        }
                    }

                    date[d, 0] = ary1[ij1, 0];
                    date[d, 1] = "AfterSource";
                    date[d, 2] = ary2[ij2, 2];
                    d++;

                    volIssu[v, 0] = ary1[ij1, 0];
                    volIssu[v, 1] = "AfterSource";
                    volIssu[v, 2] = ary2[ij2, 3];
                    volIssu[v, 3] = ary2[ij2, 4];
                    v++;
                    if (String.IsNullOrEmpty(ary2[ij2, 7]) == false)
                    {
                        pubId[p, 0] = ary1[ij1, 0];
                        pubId[p, 1] = "doi";
                        pubId[p, 2] = ary2[ij2, 7];
                        p++;
                    }
                    if (String.IsNullOrEmpty(ary2[ij2, 8]) == false)
                    {
                        pubId[p, 0] = ary1[ij1, 0];
                        pubId[p, 1] = "pmid";
                        pubId[p, 2] = ary2[ij2, 8];
                        p++;
                    }
                    if (String.IsNullOrEmpty(ary2[ij2, 9]) == false)
                    {
                        pubId[p, 0] = ary1[ij1, 0];
                        pubId[p, 1] = "pmcid";
                        pubId[p, 2] = ary2[ij2, 9];
                        p++;
                    }

                    refs[i, 0] = ary1[ij1, 0];
                    refs[i, 1] = cmbPublicationType.Text;

                    refs[i, 4] = ary2[ij2, 0];
                    refs[i, 5] = ary2[ij2, 1];

                    refs[i, 15] = ary2[ij2, 5];
                    refs[i, 16] = ary2[ij2, 6];
                    refs[i, 1] = cmbPublicationType.Text;
                    i++;


                    ij1++;
                    ij2++;
                }
            }
            else if (cmbPublicationType.Text == "book")
            {
                num = Convert.ToInt32(arry1[ij3, 0]);
                for (int pi = 0; pi < ii4; pi++)
                {
                    for (int ll = 1; ll < 15; ll += 2)
                    {
                        if (String.IsNullOrEmpty(arry1[ij3, ll]) == false)
                        {
                            gp1[j1, 0] = arry1[ij3, 0];
                            gp1[j1, 1] = "name";

                            gp1[j1, 2] = arry1[ij3, ll];
                            gp1[j1, 3] = arry1[ij3, ll + 1];

                            j1++;
                        }
                    }
                    date[d, 0] = arry1[ij3, 0];
                    date[d, 1] = "AfterSource";
                    date[d, 2] = arry2[ij4, 3];
                    d++;

                    refs[i, 0] = arry1[ij3, 0];
                    refs[i, 1] = cmbPublicationType.Text;
                    refs[i, 5] = arry2[ij4, 0];
                    refs[i, 13] = arry2[ij4, 1];
                    refs[i, 14] = arry2[ij4, 2];
                    refs[i, 15] = arry2[ij4, 4];
                    refs[i, 16] = arry2[ij4, 5];
                    refs[i, 1] = cmbPublicationType.Text;
                    i++;
                    ij3++;
                    ij4++;

                }
            }
            else if (cmbPublicationType.Text == "web")
            {
                
                num = Convert.ToInt32(arrye1[ij5, 0]);
                for (int pi = 0; pi < ii6; pi++)
                {
                    for (int ll = 1; ll < 15; ll += 2)
                    {
                        if (String.IsNullOrEmpty(arrye1[ij5, ll]) == false)
                        {
                            gp1[j1, 0] = arrye1[ij5, 0];
                            gp1[j1, 1] = "name";

                            gp1[j1, 2] = arrye1[ij5, ll];
                            gp1[j1, 3] = arrye1[ij5, ll + 1];

                            j1++;
                        }
                    }
                    refs[i, 0] = arrye1[ij5, 0];
                    refs[i, 4] = arrye2[ij6, 0];
                    comment[cm, 0] = arrye1[ij5, 0];
                    comment[cm, 1] = "End";
                    
                    comment[cm, 3] = "Yes";
                    comment[cm, 4] = arrye2[ij6,1];
                    refs[i, 1] = cmbPublicationType.Text;
                    cm++;
                    i++;
                    ij5++;
                    ij6++;

                }
            }
            
        }
        int j1 = 0;
        int d = 0;
        int v = 0;
        int p = 0;
     
        XmlTextWriter writer = new XmlTextWriter("Back.xml", System.Text.Encoding.UTF8);
        Ref r = new Ref();
        private void btnSave_Click(object sender, EventArgs e)
        {
            num =Convert.ToInt32( textBox1.Text);
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("article");
            writer.WriteAttributeString("article-type", "research-article");
            writer.WriteAttributeString("xmlns:xlink", "http://www.w3.org/1999/xlink");
            writer.WriteAttributeString("xmlns:mml", "http://www.w3.org/1998/Math/MathML");
            r.reffs(writer,refs,gp1,gp2,gp3,gp4,gp5,etal,collab,date,conf,volIssu,DICitation,size,seris,pubId,comment,num,ack1,ack2);
            writer.WriteEndElement();
            writer.Close();
            MessageBox.Show("Saved !");
        }

        string ack1;
        string ack2;

        private void btnAck_Click(object sender, EventArgs e)
        {
            if (cmbAck.Text == "Acknowledgement")
            {
                ack1 = rtxtAck.Text;
                rtxtAck.Clear();
            }
            else if (cmbAck.Text == "Conflict of Interest")
            {
                ack2 = rtxtAck.Text;
                rtxtAck.Clear();
            }
        }
        string[,] ary1 = new string[100, 20];
        string[,] ary2 = new string[100, 10];
        int ii1 = 0, ii2 = 0, jj1 = 0;
        private void btnJournals_Click(object sender, EventArgs e)
        {
            if (cmbJournals.Text == "Names")
            {
                int f1 = 0, f2 = 0, f3 = 0;
                string x = "";
                string txt = txtJournals.Text;
                foreach (char ch in txt)
                {

                    if (f1 == 0 && ch != '.')
                    {
                        if (ch == '*')
                        {
                            x = x + ' ';
                        }
                        else
                        {
                            x = x + ch;
                        }
                    }
                    if (f1 == 0 && ch == '.')
                    {
                        f1 = 1;
                        ary1[ii1, jj1] = x;
                        x = "";
                        jj1++;
                    }
                    if (f3 == 0)
                    {
                        if (f2 == 0 && ch != ' ' && f1 == 1 && ch != ',')
                        {

                            if (ch != '.' && ch != '\t')
                            {
                                x = x + ch;
                            }

                        }
                        if (f2 == 0 && ch == ' ' && f3 == 0)
                        {
                            if (String.IsNullOrEmpty(x) == false)
                            {
                                f2 = 1;
                                ary1[ii1, jj1] = x;
                                x = "";
                                jj1++;
                            }
                        }
                        if (ch == '.' && f1 == 1 && f2 == 1)
                        {
                            f3 = 1;

                        }
                        if (f2 == 1 && ch != '.' && f3 == 0)
                        {
                            f1 = 1; f2 = 0;
                        }


                    }


                }
                ii1++;
                jj1 = 0;
                f1 = 0; f2 = 0; f3 = 0;
                txtJournals.Clear();
            }
            else if(cmbJournals.Text=="Others")
            {
                int ff1 = 0, ff2 = 0, ff3 = 0, ff4 = 0, ff5 = 0, ff6 = 0, ff7 = 0, ff8 = 0, ff9 = 0, ff10 = 0;
                string x = "";
                string txt = txtJournals.Text;
                foreach (char ch in txt)
                {
                    if (ff1 == 0 && ch != '.')
                    {
                        x = x + ch;
                    }
                    else if (ff1 == 0 && ch == '.')
                    {
                        ary2[ii2, 0] = x;//title
                        x = "";

                        ff1 = 1;
                    }
                    if (ff1 == 1 && ff2 == 0 && ch != '.')
                    {
                        x = x + ch;
                    }
                    else if (ff1 == 1 && ff2 == 0 && ch == '.')
                    {
                        if (String.IsNullOrEmpty(x) == false)
                        {
                            ary2[ii2, 1] = x;//source
                            x = "";

                            ff2 = 1;
                        }
                    }
                    if (ff3 == 0 && ff2 == 1 && ch != ';' && ch != '.')
                    {
                        x = x + ch;
                    }
                    else if (ff3 == 0 && ff2 == 1 && ch == ';')
                    {
                        ary2[ii2, 2] = x;//year
                        x = "";

                        ff3 = 1;
                    }
                    if (ff4 == 0 && ff3 == 1 && ch != '(' && ch != '.' && ch != ';' && ch != ':')
                    {
                        x = x + ch;
                    }
                    else if (ff4 == 0 && ff3 == 1 && (ch == '(' || ch == ':'))
                    {
                        ary2[ii2, 3] = x;//vol
                        x = "";

                        ff4 = 1;
                    }
                    if (ff5 == 0 && ff4 == 1 && ch != '(' && ch != ')' && ff9==0 && ff10==0)
                    {
                        x = x + ch;
                    }
                    else if (ff5 == 0 && ff4 == 1 && ch == ')')
                    {
                        ary2[ii2, 4] = x;//issue
                        x = "";

                        ff5 = 1;
                    }
                    if (ff4 == 1 && ff5 == 0 && ch == ':')
                    {
                        ff5 = 1;
                        x = "";
                    }
                    if (ff5 == 1 && ff6 == 0 && ch != ':' && ch != ')' && ch != '-' && ff9 == 0 && ff10 == 0)
                    {
                        x = x + ch;
                    }
                    if (ff5 == 1 && ff6 == 0 && ch == '-')
                    {
                        ary2[ii2, 5] = x;//lpage
                        x = "";
                        ff6 = 1;
                    }

                    if (ff6 == 1 && ch != '-' && ff7 == 0 && ch != '.' && ff9 == 0 && ff10 == 0)
                    {
                        x = x + ch;
                    }
                    else if (ff6 == 1 && ch != '-' && ff7 == 0 && ch == '.')
                    {
                        ary2[ii2, 6] = x;//fpage
                        x = "";

                        ff7 = 1;
                    }

                    if (ff7 == 1 && ff8 == 0 && ch != '.' && ch != ':' && ff9 == 0 && ff10 == 0)
                    {
                        x = x + ch;
                    }
                    else if (ff7 == 1 && ff8 == 0 && ch != '.' && ch == ':')
                    {
                        if (x == "doi" || x == " doi")
                        {
                            ff8 = 1;
                            x = "";
                        }
                        else if (ff8 == 0 &&(x == "PubMed PMID" || x == " PubMed PMID"))
                        {
                            ff9 = 1;
                            x = "";
                        }
                        else if (ff9 == 0 && (x == "PubMed PMCID" || x == " PubMed PMCID" || x == " PubMed Central PMCID"))
                        {
                            ff10 = 2;
                            x = "";
                        }
                    }

                    else if (ff8 == 1 && ch != '*' && ff9 == 0 && ff10 == 0)
                    {
                        x = x + ch;

                    }
                    else if (ff8 == 1 && ff9 == 0 && ch == '*')
                    {
                        if (String.IsNullOrEmpty(x) == false)
                        {
                            ary2[ii2, 7] = x;//doi

                            x = "";
                            ff8 = 2;
                        }

                    }


                    if (ff8 == 2 && ff9 == 0 && ch != ':' && ch != '*' && ch != '.' )
                    {
                        x = x + ch;
                    }
                    else if (ff8 == 2 && ff9 == 0 && ch != '.' && ch == ':')
                    {
                        if (x == "PubMed PMID" || x == " PubMed PMID")
                        {
                            ff9 = 1;
                            x = "";
                        }
                        else if (ff9==0 && (x == "PubMed PMCID" || x == " PubMed PMCID"))
                        {
                            ff10 = 2;
                            x = "";
                        }
                    }

                    else if (ff9 == 1 && ff10 == 0 && ch != '.' && ch != ':' && ch != ';' && ch!=' ')
                    {
                        x = x + ch;

                    }
                    else if ((ff9 == 1 && ff10 == 0 && ch == '.') || (ff9 == 1 && ff10 == 0 && ch == ';'))
                    {
                        if (String.IsNullOrEmpty(x) == false)
                        {
                            ary2[ii2, 8] = x;//pmid

                            x = "";
                            ff9 = 2;
                        }
                    }
                    if (ff9 == 2 && ff10 == 0 && (ch == ';' || ch=='.'))
                    {
                        ff10 = 1;
                        x = "";
                    }
                    else if (ff10 == 1 && ch != ';' && ch != ':')
                    {
                        x = x + ch;
                    }
                    else if (ff10 == 1 && ch != ';' && ch == ':')
                    {
                        if (x == "PubMed PMCID" || x == " PubMed PMCID")
                        {
                            ff10 = 2;
                            x = "";
                        }
                    }
                    else if (ff10 == 2 && ch != ':' && ch != '.' && ch!=' '  )
                    {
                        x = x + ch;
                    }
                    else if (ff10 == 2 && ch != ':' && ch == '.')
                    {
                        if (String.IsNullOrEmpty(x) == false)
                        {
                            ary2[ii2, 9] = x;//pmcid

                            x = "";

                        }
                    }
                }
                ii2++;
                txtJournals.Clear();
            }

            
        }
        string[,] arry1 = new string[100, 15];
        string[,] arry2 = new string[100, 10];
        int ii3 = 0, ii4 = 0, jj2 = 0;
        private void btnBook_Click(object sender, EventArgs e)
        {
            if (cmbJournals.Text == "Names")
            {
                int f1 = 0, f2 = 0, f3 = 0;
                string x = "";
                string txt = txtJournals.Text;
                foreach (char ch in txt)
                {

                    if (f1 == 0 && ch != '.')
                    {
                        if (ch == '*')
                        {
                            x = x + ' ';
                        }
                        else
                        {
                            x = x + ch;
                        }
                    }
                    if (f1 == 0 && ch == '.')
                    {
                        f1 = 1;
                        arry1[ii3, jj2] = x;
                        x = "";
                        jj2++;
                    }
                    if (f3 == 0)
                    {
                        if (f2 == 0 && ch != ' ' && f1 == 1 && ch != ',')
                        {

                            if (ch != '.' && ch != '\t')
                            {
                                x = x + ch;
                            }

                        }
                        if (f2 == 0 && ch == ' ' && f3 == 0)
                        {
                            if (String.IsNullOrEmpty(x) == false)
                            {
                                f2 = 1;
                                arry1[ii3, jj2] = x;
                                x = "";
                                jj2++;
                            }
                        }
                        if (ch == '.' && f1 == 1 && f2 == 1)
                        {
                            f3 = 1;

                        }
                        if (f2 == 1 && ch != '.' && f3 == 0)
                        {
                            f1 = 1; f2 = 0;
                        }


                    }


                }
                ii3++;
                jj2 = 0;
                f1 = 0; f2 = 0; f3 = 0;
                txtJournals.Clear();
            }
            else if (cmbJournals.Text == "Others")
            {
                 int ff1 = 0, ff2 = 0, ff3 = 0, ff4 = 0, ff5 = 0, ff6 = 0;
                string x = "";
                string txt = txtJournals.Text;
                foreach (char ch in txt)
                {
                    if (ff1 == 0 && ch != '.')
                    {
                        x = x + ch;
                    }
                    else if (ff1 == 0 && ch == '.')
                    {
                        arry2[ii4, 0] = x;//source
                        x = "";

                        ff1 = 1;
                    }
                    if(ff1==1 && ff2==0 &&ch !=':' && ch!='.')
                    {
                        x = x + ch;
                    }
                    else if (ff1 == 1 && ff2 == 0 && ch == ':')
                    {
                        arry2[ii4, 1] = x;//Pub-loc
                        x = "";

                        ff2 = 1;
                    }
                    if (ff2 == 1 && ff3 == 0 && ch != ';' && ch!=':')
                    {
                        x = x + ch;
                    }
                    else if (ff2 == 1 && ff3 == 0 && ch == ';')
                    {
                        arry2[ii4, 2] = x;//Pub-name
                        x = "";

                        ff3 = 1;
                    }
                    if (ff3 == 1 && ff4 == 0 && ch != ';' && ch != '.')
                    {
                        x = x + ch;
                    }
                    else if (ff3 == 1 && ff4 == 0 && ch == '.')
                    {
                        arry2[ii4, 3] = x;//year
                        x = "";

                        ff4 = 1;
                    }
                    if (ff4 == 1 && ff5 == 0 && ch != '-' && ch != '.')
                    {
                       
                        x = x + ch;
                    }
                    else if ((ff4 == 1 && ff5 == 0 && ch == '-') || (ff4 == 1 && ff5 == 0 && ch == '.'))
                    {
                        arry2[ii4, 4] = x;//fpage
                        x = "";

                        ff5 = 1;
                    }
                    if (ff5 == 1 && ff6 == 0 && ch != '.')
                    {

                        x = x + ch;
                    }
                    else if (ff5 == 1 && ff6 == 0 && ch == '.')
                    {
                        arry2[ii4, 5] = x;//lpage
                        x = "";

                        ff6 = 1;
                    }
                }
                ii4++;
                txtJournals.Clear();
            }

        }
        string[,] arrye1 = new string[100, 15];
        string[,] arrye2 = new string[100, 3];
        int ii5 = 0, ii6 = 0, jj3 = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbJournals.Text == "Names")
            {
                int f1 = 0, f2 = 0, f3 = 0;
                string x = "";
                string txt = txtJournals.Text;
                foreach (char ch in txt)
                {

                    if (f1 == 0 && ch != '.')
                    {
                        if (ch == '*')
                        {
                            x = x + ' ';
                        }
                        else
                        {
                            x = x + ch;
                        }
                    }
                    if (f1 == 0 && ch == '.')
                    {
                        f1 = 1;
                        arrye1[ii5, jj3] = x;
                        x = "";
                        jj3++;
                    }
                    if (f3 == 0)
                    {
                        if (f2 == 0 && ch != ' ' && f1 == 1 && ch != ',')
                        {

                            if (ch != '.' && ch != '\t')
                            {
                                x = x + ch;
                            }

                        }
                        if (f2 == 0 && ch == ' ' && f3 == 0)
                        {
                            if (String.IsNullOrEmpty(x) == false)
                            {
                                f2 = 1;
                                arrye1[ii5, jj3] = x;
                                x = "";
                                jj3++;
                            }
                        }
                        if (ch == '.' && f1 == 1 && f2 == 1)
                        {
                            f3 = 1;

                        }
                        if (f2 == 1 && ch != '.' && f3 == 0)
                        {
                            f1 = 1; f2 = 0;
                        }


                    }


                }
                ii5++;
                jj3 = 0;
                f1 = 0; f2 = 0; f3 = 0;
                txtJournals.Clear();
            }
            else if (cmbJournals.Text == "Others")
            {
                int ff1 = 0, ff2 = 0 ;
                string x = "";
                string txt = txtJournals.Text;
                foreach (char ch in txt)
                {
                    if (ff1 == 0 && ch != '*')
                    {
                        x = x + ch;
                    }
                    else if (ff1 == 0 && ch == '*')
                    {
                        arrye2[ii6, 0] = x;//title
                        x = "";

                        ff1 = 1;
                    }
                    if(ff1==1 && ff2==0 && ch!=':')
                    {
                        x = x + ch;
                    }
                    else if (ff1 == 1 && ff2 == 0 && ch == ':')
                    { 
                            x = "";
                            ff2 = 1;
                    }
                    else if (ff2 == 1 && ch!='*')
                    {
                        x = x + ch;

                    }
                    else if (ff2 == 1 && ch == '*')
                    {
                       
                        arrye2[ii6, 1] = x;//uri
                        x = "";
                        break;
                    }
                }
                ii6++;
                txtJournals.Clear();
            }
        }


      

    }
}
