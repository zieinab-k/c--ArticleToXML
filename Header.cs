using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Collections;

namespace XmlCreat1
{
    public partial class Header : Form
    {
        public Header()
        {
            InitializeComponent();
        }
       
       
      
        string[,] arry=new string[20,4];
        string[] arry2=new string[10];
        int j = 0;

       

        private void btnRefA_Click(object sender, EventArgs e)
        {
            arry2[j] = rtxtRefA.Text;
            j++;
            rtxtRefA.Clear();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            Front2 f2 = new Front2();
            Front f = new Front();
            XmlTextWriter writer = new XmlTextWriter("front.xml", System.Text.Encoding.UTF8);

            writer.Formatting = Formatting.Indented;
            //writer.WriteString("<!DOCTYPE article PUBLIC \"-//NLM//DTD Journal Publishing DTD v2.3 20070202//EN\" \"journalpublishing.dtd\">");
            writer.WriteStartElement("article");
            writer.WriteAttributeString("article-type", "research-article");
            writer.WriteAttributeString("xmlns:xlink", "http://www.w3.org/1999/xlink");
            writer.WriteAttributeString("xmlns:mml", "http://www.w3.org/1998/Math/MathML");
            writer.WriteStartElement("front");
            f.jmeta(writer, txtIssnP.Text, txtIssnE.Text,txtJid.Text,txtJtitle.Text,txtAbpub.Text,txtpub.Text);
            writer.WriteStartElement("article-meta");
            writer.WriteStartElement("article-id");
            writer.WriteAttributeString("pub-id-type", "publisher-id");
            writer.WriteString(txtAId.Text);
            writer.WriteEndElement();
            f.artcat(writer,comboBoxArtType.Text);
            f.titlegp(writer, rtxtTitle.Text);
            f.contrib(writer, arry, arry2);
            f.AtrNotes(writer,txtCor.Text, rtxtCor.Text, txtPost.Text, txtPn.Text, txtTel.Text, txtFax.Text, txtEmail.Text);
            f.Pupdate(writer, dateTPpup.Value.Month.ToString(), dateTPpup.Value.Year.ToString(),cmbJournals.Text);
            f.Vol(writer, txtVol.Text, txtIssue.Text, txtFpage.Text, txtLpage.Text);
            f.History(writer, dateTPrev.Value.Day.ToString(), dateTPrev.Value.Month.ToString(), dateTPrev.Value.Year.ToString(), dateTPacc.Value.Day.ToString(), dateTPacc.Value.Month.ToString(), dateTPacc.Value.Year.ToString(), dateTPrec.Value.Day.ToString(), dateTPrec.Value.Month.ToString(), dateTPrec.Value.Year.ToString(), cmbReRec.Text, cmbAcc.Text, cmbRec.Text, cmbJournals.Text);
            f.Permissions(writer, txtPermission.Text,txtpub.Text);
            if (cmbAbstract.Text == "NonStructure")
            {
                f2.AbstractN(writer, arry1);
                f2.Keyword(writer, aryy4, cmbJournals.Text);
            }
            else if (cmbAbstract.Text == "Structure")
            {
            f2.AbstractS(writer, ary2,arry3,cmbJournals.Text );
            f2.Keyword(writer, aryy4, cmbJournals.Text);
           
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.WriteEndElement();
            writer.Close();
            MessageBox.Show("Saved!");
        }


        string[] arry1 = new string[10];
        string[] ary2 = new string[10];
        string[] arry3 = new string[10];
        string[] aryy4 = new string[20];
        int ii = 0;
        int jj = 0;
        int k = 0;
        int n = 0;

        private void btnP_Click(object sender, EventArgs e)
        {

            arry1[ii] = rtxtAbstractN.Text;
            ii++;
            rtxtAbstractN.Clear();
        }

      

        private void btnKey_Click(object sender, EventArgs e)
        {
            string x="";
            Text = txtKey.Text;
            txtKey.Clear();
            foreach(char c in Text)
            {
                if (c != '●')
                {
                    x=x+ c;
                }
                else
                {
                    if (String.IsNullOrEmpty(x) == false)
                    {
                        aryy4[n] = x;
                        x = "";
                        n++;
                    }
                }

            }

            aryy4[n] = txtKey.Text;
            n++;
            txtKey.Clear();
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            ary2[jj] = txtSec.Text;
            jj++;
            txtSec.Clear();
        }

        private void btnPS_Click(object sender, EventArgs e)
        {
            arry3[k] = rtxtS.Text;
            k++;
            rtxtS.Clear();
        }

        private void Header_Load(object sender, EventArgs e)
        {

        }
       
        private void btnJournals_Click(object sender, EventArgs e)
        {
            if (cmbJournals.Text == "IJCBNM")
            {
                txtAId.Text = "IJCBNM-6-4";
                txtJid.Text = "Int J Community Based Nurs Midwifery";
                txtJtitle.Text = "International Journal of Community Based Nursing and Midwifery";
                txtAbpub.Text = "Int J Community Based Nurs Midwifery";
                txtIssnP.Text = "2322-2476";
                txtIssnE.Text = "2322-4835";
                txtpub.Text = "Shiraz University of Medical Sciences";
                txtVol.Text = "6";
                txtIssue.Text = "4";
                txtCor.Text = "Corresponding author:";

            }

            if (cmbJournals.Text == "IJMS")
            {
                txtAId.Text = "IJMS-43-6";
                txtJid.Text = "Iran J Med Sci";
                txtJtitle.Text = "Iranian Journal of Medical Sciences";
                txtAbpub.Text = "Iran J Med Sci";
                txtIssnP.Text = "0253-0716";
                txtIssnE.Text = "1735-3688";
                txtpub.Text = "Iranian Journal of Medical Sciences";
                txtVol.Text = "43";
                txtIssue.Text = "6";
                txtCor.Text = "Correspondence:";
            }


            if (cmbJournals.Text == "JBPE")
            {
                txtAId.Text = "JBPE-8-4";
                txtJid.Text = "J Biomed Phys Eng";
                txtJtitle.Text = "Journal of Biomedical Physics and Engineering";
                txtAbpub.Text = "J Biomed Phys Eng";
                txtIssnP.Text = "";
                txtIssnE.Text = "2251-7200";
                txtpub.Text = "Journal of Biomedical Physics and Engineering";
                txtVol.Text = "8";
                txtIssue.Text = "4";
                txtCor.Text = "*Corresponding author:";
            }
            if (cmbJournals.Text == "JAMP")
            {
                txtAId.Text = "JAMP-6-4";
                txtJid.Text = "J Adv Med Educ Prof";
                txtJtitle.Text = "Journal of Advances in Medical Education & Professionalism";
                txtAbpub.Text = "J Adv Med Educ Prof";
                txtIssnP.Text = "2322-2220";
                txtIssnE.Text = "2322-3561";
                txtpub.Text = "Journal of Advances in Medical Education & Professionalism";
                txtVol.Text = "6";
                txtIssue.Text = "4";
                txtCor.Text = "Correspondence:";
            }
            if (cmbJournals.Text == "JDS")
            {
                txtAId.Text = "JDS-19-3";
                txtJid.Text = "J Dent (Shiraz)";
                txtJtitle.Text = "Journal of Dentistry Shiraz University of Medical Sciences";
                txtAbpub.Text = "J Dent (Shiraz)";
                txtIssnP.Text = "2345-6485";
                txtIssnE.Text = "2345-6418";
                txtpub.Text = "Journal of Dentistry Shiraz University of Medical Sciences";
                txtVol.Text = "19";
                txtIssue.Text = "3";
                txtCor.Text = "Correspondence: ";
            }
            if (cmbJournals.Text == "JDB")
            {
                txtAId.Text = "JDB-5-1";
                txtJid.Text = "J Dent Biomater";
                txtJtitle.Text = "Journal of Dental Biomaterials";
                txtAbpub.Text = "J Dent Biomater";
                txtIssnP.Text = "2383-3971";
                txtIssnE.Text = "2383-398X";
                txtpub.Text = "Journal of Dental Biomaterials";
                txtVol.Text = "5";
                txtIssue.Text = "1";
                txtCor.Text = "*Corresponding Author: ";
            }

        }

        int jn = 0;

        int iin = 0;
        private void btnInsertName_Click(object sender, EventArgs e)
        {
            int f1 = 0;
            int f2 = 0;
            int f3 = 0;
            int f4 = 0;
            int f5 = 0;

            int i1 = 0;
            int j1 = 0;
            string sr = "", a = "";

            string txt = textBox1.Text;
            string x = "";
            foreach (char c in txt)
            {

                if (c != ' ' && f1 == 0 && f2 == 0 && f3 == 0 && f4 == 0 && f5 == 0)
                {
                    if (c == '*')
                    {
                        x = x + ' ';
                    }
                    else
                    {
                        x = x + c;
                    }
                }
                if (c == ' ' && f5 == 0 && f4 != 1)
                {
                    f1 = 1;
                    arry[iin, jn] = x;
                    x = "";
                    jn++;
                }
                if (f1 == 1 && c != ',' && f4 != 1 && c != ';')
                {
                    if (c == '*')
                    {
                        x = x + ' ';
                        i1++;
                    }
                    else
                    {
                        x = x + c;
                        i1++;
                    }

                }
                if ((c == ',' && f3 == 0) || (c == ';' && f3 == 0))
                {

                    foreach (char ch in x)
                    {
                        if (j1 < i1 - 1)
                        {
                            sr = sr + ch;
                            j1++;
                        }
                        else if (j1 == i1 - 1)
                        {
                            a = a + ch;
                            break;
                        }
                    }
                    i1 = 0;
                    j1 = 0;
                    arry[iin, jn] = sr;
                    x = "";
                    jn++;
                    arry[iin, jn] = a;
                    jn++;
                    f3 = 1;
                    sr = "";
                    a = "";


                }
                if (f3 == 1 && c == ',')
                {
                    f4 = 1;

                }
                if (f4 == 1 && c != ',' && c != ';')
                {
                    x = x + c;
                }
                if (c == ';')
                {
                    f1 = 0;
                    f2 = 0;
                    f3 = 0;
                    f4 = 0;
                    arry[iin, jn] = x;
                    x = "";
                    iin++;
                    jn = 0;
                    f5 = 1;

                }
                if (f5 == 1 && c == ' ')
                {
                    f5 = 0;
                }

            }

            textBox1.Clear();
        }

       

       
        

      
        
    }
   
}
