using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace XmlCreat1
{
    public partial class Paper : Form
    {
        public Paper()
        {
            InitializeComponent();
        }
        XmlDocument XDoc = new XmlDocument();
        private void button1_Click(object sender, EventArgs e)
        {
            Header h = new Header();
            h.Show();
        }

        
        private void btnMerge_Click(object sender, EventArgs e)
        {

            var doc = XDocument.Load("front.xml");
            var doc2 = XDocument.Load("body.xml");
            var doc3 = XDocument.Load("back.xml");

            doc.Root.Add(doc2.Root.Elements());
            doc.Root.Add(doc3.Root.Elements());

            doc.Save(txtFileName.Text+".xml");
            MessageBox.Show("Merge saved");

        }

        private void bynBody_Click(object sender, EventArgs e)
        {
            Body3 b = new Body3();
            b.Show();
        }

        private void Paper_Load(object sender, EventArgs e)
        {

        }
       
        private void btnRefrence_Click(object sender, EventArgs e)
        {
            Refrences rf = new Refrences();
            rf.Show();
        }

        
    }
}
