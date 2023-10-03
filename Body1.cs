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
    public partial class Body1 : Form
    {
        public Body1()
        {
            InitializeComponent();
        }
        XmlTextWriter writer = new XmlTextWriter("body.xml", System.Text.Encoding.UTF8);
        Body body = new Body();
        int i = 0, j = 0;
        //string[] arrySec;
        //string[] arryTitle;
        string[] b;
        string[] a;
        int x;
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (i < x)
            {
                a[i] = rtxtSec.Text;
                b[i] = txtTitle.Text;
                i++;
                rtxtSec.Clear();
                txtTitle.Clear();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            writer.Formatting = Formatting.Indented;
            body.Section(writer,a,i,b,j);
            
        }

        private void btnNSec_Click(object sender, EventArgs e)
        {
             x = Convert.ToInt32(txtNSec.Text);
            a = new string[x];
            b = new string[x];
        }

    }
}
