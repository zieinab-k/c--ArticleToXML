using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
namespace XmlCreat1
{
    class Front2
    {

           public Front2()
        {
            ToString();
        }

           public void AbstractN(XmlTextWriter writer, string []abst)
           {
               writer.WriteStartElement("abstract");
               for (int i = 0; i < 10; i++)
               {
                   if (String.IsNullOrEmpty(abst[i]) == false)
                   {
                       writer.WriteStartElement("p");
                       writer.WriteString(abst[i]);
                       writer.WriteEndElement();
                   }
               }
               writer.WriteEndElement();
       
           }
           public void AbstractS(XmlTextWriter writer, string[] title,string[] sec ,string jname)
           {
               int j = 1;
               writer.WriteStartElement("abstract");

               if (jname == "IJCBNM")
               {
                   writer.WriteStartElement("title");
                   writer.WriteString("A");
                   writer.WriteStartElement("sc");
                   writer.WriteString("BSTRACT");
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }

               for (int i = 0; i < 10; i++)
               {
                   if (String.IsNullOrEmpty(title[i]) == false)
                   {
                       writer.WriteStartElement("sec");
                       writer.WriteAttributeString("id", "st" + j.ToString());
                       writer.WriteStartElement("title");
                       if(jname=="JDB"){
                           writer.WriteStartElement("italic");
                       }
                       writer.WriteString(title[i]);
                       if (jname == "JDB")
                       {
                           writer.WriteEndElement();
                       }
                       writer.WriteEndElement();
                       writer.WriteStartElement("p");
                       writer.WriteString(sec[i]);
                       writer.WriteEndElement();
                       writer.WriteEndElement();
                       j++;
                   }
               }

               writer.WriteEndElement();

           }
           public void Keyword(XmlTextWriter writer, string[] key, string jname)
           {
               writer.WriteStartElement("kwd-group");
               if (jname == "IJCBNM")
               {
                   writer.WriteStartElement("title");
                   writer.WriteString("K");
                   writer.WriteStartElement("sc");
                   writer.WriteString("EYWORDS");
                   writer.WriteEndElement();
                   writer.WriteEndElement();
               }
               for (int k = 0; k < 20; k++)
               {
                   if (String.IsNullOrEmpty(key[k]) == false)
                   {
                       writer.WriteStartElement("kwd");
                       writer.WriteString(key[k]);
                       writer.WriteEndElement();
                   }
               }
               writer.WriteEndElement();
             
           }
    }

}
