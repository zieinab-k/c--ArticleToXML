using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace XmlCreat1
{
    class Front
    {
          public Front()
        {
            ToString();
        }

       public void jmeta( XmlTextWriter writer,string isp,string ise,string JID,string JTitle,string Abpub,string pub)
       {
           
           writer.WriteStartElement("journal-meta");
           writer.WriteStartElement("journal-id");
           writer.WriteAttributeString(" journal-id-type", "nlm-ta");
           writer.WriteString(JID);
           writer.WriteEndElement(); 
           writer.WriteStartElement("journal-title");
           writer.WriteString(JTitle);
           writer.WriteEndElement();
           writer.WriteStartElement("abbrev-journal-title");
           writer.WriteAttributeString("abbrev-type", "publisher");
           writer.WriteString(Abpub);
           writer.WriteEndElement();

           writer.WriteStartElement("issn");
           writer.WriteAttributeString("pub-type", "ppub");
           writer.WriteString(isp);
           writer.WriteEndElement();
           writer.WriteStartElement("issn");
           writer.WriteAttributeString("pub-type", "epub");
           writer.WriteString(ise);
           writer.WriteEndElement();

           writer.WriteStartElement("publisher");
           writer.WriteStartElement("publisher-name");
           writer.WriteString(pub);
           writer.WriteEndElement();
           writer.WriteStartElement("publisher-loc");
           writer.WriteString("Iran");
           writer.WriteEndElement();

           writer.WriteEndElement();

          
           writer.WriteEndElement();
         
       }
       public void artcat(XmlTextWriter writer , string art)
       {
           writer.WriteStartElement("article-categories");
           writer.WriteStartElement("subj-group");
           writer.WriteAttributeString(" subj-group-type", "heading");
           writer.WriteStartElement("subject");
           writer.WriteString(art);
           writer.WriteEndElement();
           writer.WriteEndElement();
           writer.WriteEndElement();
       }
       public void titlegp(XmlTextWriter writer,string title)
       {
           writer.WriteStartElement("title-group");
           writer.WriteStartElement("article-title");
           writer.WriteString(title);
            writer.WriteEndElement();
            writer.WriteEndElement();
       }
       public void contrib(XmlTextWriter writer,string [,] arry,string[] arry2)
       {
          
           int k=1;
           writer.WriteStartElement("contrib-group");
           for (int i = 0; i < 20; i++)
           {
               if (String.IsNullOrEmpty(arry[i, 0]) == false)
               {
                   writer.WriteStartElement("contrib");
                   writer.WriteAttributeString("contrib-type", "author");
                   writer.WriteStartElement("name");
                   writer.WriteStartElement("surname");
                   writer.WriteString(arry[i, 1]);
                   writer.WriteEndElement();
                   writer.WriteStartElement("given-names");
                   writer.WriteString(arry[i, 0]);
                   writer.WriteEndElement();
                   if (String.IsNullOrEmpty(arry[i, 3]) == false)
                   {
                   writer.WriteStartElement("suffix");
                   writer.WriteString(arry[i, 3]);
                   writer.WriteEndElement();
                   }
                   writer.WriteEndElement();
                   writer.WriteStartElement("xref");
                   writer.WriteAttributeString("ref-type", "aff");
                   writer.WriteAttributeString("rid", "aff" + arry[i, 2]);
                   writer.WriteString(arry[i, 2]);
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
           }
           writer.WriteEndElement();

           for (int j = 0; j < 10; j++)
           {
               if (String.IsNullOrEmpty(arry2[j]) == false)
               {
                   writer.WriteStartElement("aff");
                   writer.WriteAttributeString("id", "aff" + k.ToString());
                   writer.WriteStartElement("label");
                   writer.WriteString(k.ToString());
                   writer.WriteEndElement();
                   writer.WriteString(arry2[j]);
                   writer.WriteEndElement();
                   k++;
               }
           }

       }
       public void AtrNotes(XmlTextWriter writer,string cor ,string not, string post, string pn, string tel, string fax, string email)
       {
           writer.WriteStartElement("author-notes");
           
           writer.WriteStartElement("corresp");
           writer.WriteAttributeString("id", "cor1");
           writer.WriteStartElement("bold");
           writer.WriteString(cor);
           writer.WriteEndElement();
           writer.WriteString(not+pn);
           if(String.IsNullOrEmpty(post)==false)
           {
           writer.WriteString("  P. O. Box: " + post);
           }
           if(String.IsNullOrEmpty(tel)==false)
           {
           writer.WriteStartElement("bold");
           writer.WriteString(" Tel:");
           writer.WriteEndElement();
           writer.WriteString(tel);
           }
           if(String.IsNullOrEmpty(fax)==false)
           {
           writer.WriteStartElement("bold");
           writer.WriteString("  Fax:");
           writer.WriteEndElement();
           writer.WriteString(fax);
           }
           writer.WriteEndElement();
           
           writer.WriteStartElement("corresp");
           writer.WriteAttributeString("id", "cor2");
           writer.WriteString("E-mail : ");
           writer.WriteStartElement("email");
           writer.WriteString(email);
           writer.WriteEndElement();
           writer.WriteEndElement();
           writer.WriteEndElement();
       }
       public void Pupdate(XmlTextWriter writer,string month,string year, string jname)
       {
           if (jname == "JBPE")
           {
               writer.WriteStartElement("pub-date");
               writer.WriteAttributeString(" pub-type", "collection");
               writer.WriteStartElement("month");
               writer.WriteString(month);
               writer.WriteEndElement();
               writer.WriteStartElement("year");
               writer.WriteString(year);
               writer.WriteEndElement();
               writer.WriteEndElement();

               writer.WriteStartElement("pub-date");
               writer.WriteAttributeString(" pub-type", "epub");
               writer.WriteStartElement("day");
               writer.WriteString("01");
               writer.WriteEndElement();
               writer.WriteStartElement("month");
               writer.WriteString(month);
               writer.WriteEndElement();
               writer.WriteStartElement("year");
               writer.WriteString(year);
               writer.WriteEndElement();
               writer.WriteEndElement();

           }
           else
           {
               writer.WriteStartElement("pub-date");
               writer.WriteAttributeString(" pub-type", "ppub");
               writer.WriteStartElement("month");
               writer.WriteString(month);
               writer.WriteEndElement();
               writer.WriteStartElement("year");
               writer.WriteString(year);
               writer.WriteEndElement();
               writer.WriteEndElement();
           }

       }
       public void Vol(XmlTextWriter writer,string vol, string issue, string fpage,string lpage)
       {
           
           writer.WriteStartElement("volume");
           writer.WriteString(vol);
           writer.WriteEndElement();
           writer.WriteStartElement("issue");
           writer.WriteString(issue);
           writer.WriteEndElement();
           writer.WriteStartElement("fpage");
           writer.WriteString(fpage);
           writer.WriteEndElement();
           writer.WriteStartElement("lpage");
           writer.WriteString(lpage);
           writer.WriteEndElement();
          
       }
       public void History(XmlTextWriter writer, string d1, string m1, string y1, string d2, string m2, string y2, string d3, string m3, string y3, string rerec, string acc, string rec, string jname)
       {
           if(rerec=="Yes" || acc=="Yes" || rec=="Yes")
           {
           writer.WriteStartElement("history");
           if (jname == "JDS")
           {
               if (rerec == "Yes")
               {
                   writer.WriteStartElement("date");
                   writer.WriteAttributeString(" date-type", "rev-recd");
                   writer.WriteStartElement("month");
                   writer.WriteString(m1);
                   writer.WriteEndElement();
                   writer.WriteStartElement("year");
                   writer.WriteString(y1);
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
               if (acc == "Yes")
               {
                   writer.WriteStartElement("date");
                   writer.WriteAttributeString("date-type", "accepted");
                   writer.WriteStartElement("month");
                   writer.WriteString(m2);
                   writer.WriteEndElement();
                   writer.WriteStartElement("year");
                   writer.WriteString(y2);
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
               if (rec == "Yes")
               {
                   writer.WriteStartElement("date");
                   writer.WriteAttributeString("date-type", "received");
                   writer.WriteStartElement("month");
                   writer.WriteString(m3);
                   writer.WriteEndElement();
                   writer.WriteStartElement("year");
                   writer.WriteString(y3);
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
           }
           else
           {
               if (rerec == "Yes")
               {
                   writer.WriteStartElement("date");
                   writer.WriteAttributeString(" date-type", "rev-recd");
                   writer.WriteStartElement("day");
                   writer.WriteString(d1);
                   writer.WriteEndElement();
                   writer.WriteStartElement("month");
                   writer.WriteString(m1);
                   writer.WriteEndElement();
                   writer.WriteStartElement("year");
                   writer.WriteString(y1);
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
               if (acc == "Yes")
               {
                   writer.WriteStartElement("date");
                   writer.WriteAttributeString("date-type", "accepted");
                   writer.WriteStartElement("day");
                   writer.WriteString(d2);
                   writer.WriteEndElement();
                   writer.WriteStartElement("month");
                   writer.WriteString(m2);
                   writer.WriteEndElement();
                   writer.WriteStartElement("year");
                   writer.WriteString(y2);
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
               if (rec == "Yes")
               {
                   writer.WriteStartElement("date");
                   writer.WriteAttributeString("date-type", "received");
                   writer.WriteStartElement("day");
                   writer.WriteString(d3);
                   writer.WriteEndElement();
                   writer.WriteStartElement("month");
                   writer.WriteString(m3);
                   writer.WriteEndElement();
                   writer.WriteStartElement("year");
                   writer.WriteString(y3);
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
           }
           writer.WriteEndElement();
           }
       }
       public void Permissions(XmlTextWriter writer,string year,string name)
       {
           writer.WriteStartElement("permissions");
           writer.WriteStartElement("copyright-statement");
           writer.WriteString("Copyright: &#x000a9; "+name);
           writer.WriteEndElement();
           writer.WriteStartElement("copyright-year");
           writer.WriteString(year);
           writer.WriteEndElement();
           writer.WriteStartElement("license");
           writer.WriteAttributeString("license-type", "open-access");
           writer.WriteAttributeString("xlink:href", "http://creativecommons.org/licenses/by-nc-sa/3.0");
           writer.WriteStartElement("p");
           writer.WriteString("This is an open-access article distributed under the terms of the Creative Commons Attribution-Noncommercial-Share Alike 3.0 Unported, which permits unrestricted use, distribution, and reproduction in any medium, provided the original work is properly cited.");
           writer.WriteEndElement();
           writer.WriteEndElement();
           writer.WriteEndElement();
       }
     
   
    }
}
