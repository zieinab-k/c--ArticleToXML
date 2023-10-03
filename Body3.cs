using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Data.SqlClient;
using System.Xml.XPath;

namespace XmlCreat1
{
    public partial class Body3 : Form
    {
        public Body3()
        {
            InitializeComponent();
        }
        XmlTextWriter writer = new XmlTextWriter("body.xml", System.Text.Encoding.UTF8);
        Body body = new Body();
        
        string[]tsec=new string[20];
        string[,] tsub = new string[20, 20];
        string[, , ,] sec = new string[20, 20, 20, 20];
        int[,] reff = new int[1000, 20];
        string[,] ff = new string[1000, 20];
        int x=20;
        int i=0, j=0, z=0,n=0, l=0, p=0, q=0, r=0, s=0;
        int v = 0;
      

        private void btnSave_Click(object sender, EventArgs e)
        {
            writer.Formatting = Formatting.Indented;
            writer.WriteStartElement("article");
            writer.WriteAttributeString("article-type", "research-article");
            writer.WriteAttributeString("xmlns:xlink", "http://www.w3.org/1999/xlink");
            writer.WriteAttributeString("xmlns:mml", "http://www.w3.org/1998/Math/MathML");
            body.Section(writer, sec, tsec, tsub, reff, ff, x, known, knew, figure,title, ary1,ary2,footer,ref1,ref2,stylh,stylb,bgcolor,cmbJournals.Text);
            writer.WriteEndElement();
            writer.Close();
            MessageBox.Show("Saved!");

        }
        

        private void Body3_Load(object sender, EventArgs e)
        {

        }
   
        string[,] figure=new string[50,3];
        int k = 0;
    
        private void btnInsertFig_Click(object sender, EventArgs e)
        {
            figure[k, 0] = txtIdFig.Text;
            figure[k, 1] = txtNumFig.Text;
            figure[k, 2] = rtxtTitleFig.Text;
            k++;
            txtIdFig.Clear();
            txtNumFig.Clear();
            rtxtTitleFig.Clear();
        }

       
        private void btnSec_Click(object sender, EventArgs e)
        {

            tsec[i] = txtTitle.Text;
            i++;
          
            l = 0;
            n = 0;
            z = 0;
            v = 0;
            txtTitle.Clear();
            j++;

        }
        private void btnSubSec_Click(object sender, EventArgs e)
        {
            v = z;
            tsub[j-1, z] = txtSub.Text;
            txtSub.Clear();
            z++;
            n= 0;
            l = 0;
            
        }

        

        private void btnP_Click(object sender, EventArgs e)
        {
            n++;
            l = 0;
        }
        private void btnStr_Click(object sender, EventArgs e)
        {
            q = 0;
            p++;
            s = 0;
            r++;
            
            sec[i-1, v, n, l] = rtxtSec.Text;
            l++;
            rtxtSec.Clear();
        }

        private void btnNumRef_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtRef.Text) == false)
            {
                reff[p, q] = Convert.ToInt32(txtRef.Text);
                q++;
                txtRef.Clear();

                ff[r, s] = txtff.Text;
                txtff.Clear();
                s++;
            }
          
           
        }

      
        string known;
        string knew;
            
        private void button1_Click(object sender, EventArgs e)
        {
            if (cmbWhats.Text == "Whats known")
            {
                known = rtxtWhats.Text;
                rtxtWhats.Clear();

            }
            else if (cmbWhats.Text == "Whats new")
            {
                knew = rtxtWhats.Text;
                rtxtWhats.Clear();
            }
        }
        string num;
        string[] title = new string[20];
        string[,] ary1 = new string[2000, 2000];
        string[,] ary2 = new string[20000, 2000];
        int ii1 = 0, ii2 = 0, jj1 = 1, jj2 = 1;
        int t = 0;
        
        string[,] stylh = new string[2000, 2];
        string[,] stylb = new string[20000, 2];
        string[,] ref1 = new string[2000, 2000];
        string[,] ref2 = new string[20000, 2000];
        string[,] bgcolor = new string[20, 3];
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            num = textBox1.Text;
            bgcolor[t, 0] = num;
            bgcolor[t,1] = comboBox1.Text;
            title[t] = richTextBox2.Text;
            string x = "";
            string r = "";
            string txt = richTextBox1.Text;
            ary1[ii1, 0] = num;
            stylh[ii1, 0] = num;
            ref1[ii1, 0] = num;
            foreach (char c in txt)
            {
                if (c != '\n' && c != '$' && c != '@')
                {
                    if (c == '*' || c == '‡' || c == '#' || c == '†')
                    {
                        r = r + c;
                    }
                    else
                    {
                        x = x + c;
                    }
                }
                else if (c == '\n')
                {
                    if (String.IsNullOrEmpty(x) == false)
                    {
                        ary1[ii1, jj1] = x;
                        x = "";
                        ref1[ii1, jj1] = r;
                        jj1++;
                        r = "";
                    }
                }
                else if (c == '$')
                {
                    ii1++;
                    ary1[ii1, 0] = num;
                    jj1 = 1;
                    x = "";
                    ref1[ii1, 0] = num;
                    stylh[ii1, 0] = num;
                }
                else if (c == '@')
                {
                    stylh[ii1, 1] = "Yes";
                }
            }
            ii1++;
            jj1 = 1;
            x = "";
           
            richTextBox1.Clear();
            richTextBox2.Clear();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bgcolor[t, 2] = comboBox1.Text;
            string x = "";
            string r = "";
            string txt = richTextBox1.Text;
            ary2[ii2, 0] = num;
            stylb[ii2, 0] = num;
            ref2[ii2, 0] = num;
            foreach (char c in txt)
            {
                if (c != '\n' && c != '$' && c != '@')
                {
                    if (c == '*' || c == '‡' || c == '#' || c == '†')
                    {
                        r = r + c;
                    }
                    else
                    {
                        x = x + c;
                    }

                }
                else if (c == '\n')
                {
                    if (String.IsNullOrEmpty(x) == false)
                    {
                        ary2[ii2, jj2] = x;
                        x = "";
                        ref2[ii2, jj2] = r;
                        jj2++;

                        r = "";
                    }
                }
                else if (c == '$')
                {
                    ii2++;
                    jj2 = 1;
                    x = "";
                    ref2[ii2, 0] = num;
                    stylb[ii2, 0] = num;
                    ary2[ii2, 0] = num;
                }
                else if (c == '@')
                {
                    stylb[ii2, 1] = "Yes";
                }
            }
            ii2++;
            jj2 = 1;
            x = "";
            t++;
            richTextBox1.Clear();
        }
        string[,] footer = new string[200, 3];
        int m1 = 0;
        private void button4_Click(object sender, EventArgs e)
        {
            num = textBox1.Text;
            footer[m1, 0] = num;
            footer[m1, 1] = textBox2.Text;
            footer[m1, 2] = richTextBox3.Text;
            m1++;
            textBox2.Clear();
            richTextBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(textBox3.Text);
            textBox3.Clear();
        }

        private void cmbJournals_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
       
        

         
       
    }
}
