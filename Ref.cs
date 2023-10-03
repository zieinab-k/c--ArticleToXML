using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace XmlCreat1
{
    class Ref
    {
        public Ref()
        {
            ToString();
        }

        public void reffs(XmlTextWriter writer, string[,] refs, string[,] gp1, string[,] gp2, string[,] gp3, string[,] gp4, string[,] gp5, string[,] etal, string[,] collab, string[,] date, string[,] conf, string[,] volIssu, string[,] DICitation, string[,] size, string[,] seris, string[,] pubId,string[,] comment,int num,string ack1,string ack2)
        {
            writer.WriteStartElement("back");
            if(String.IsNullOrEmpty(ack1)==false || String.IsNullOrEmpty(ack2)==false)
            {
            writer.WriteStartElement("ack");
            if (String.IsNullOrEmpty(ack1) == false)
                {
            writer.WriteStartElement("title");
            writer.WriteString("Acknowledgement");

            //writer.WriteString("A");
            //writer.WriteStartElement("sc");
            //writer.WriteString("CKNOWLEDGEMENT");
            //writer.WriteEndElement();

            writer.WriteEndElement();
            writer.WriteStartElement("p");
            writer.WriteString(ack1);
            writer.WriteEndElement();
                }
            if (String.IsNullOrEmpty(ack2) == false)
            {
                writer.WriteStartElement("p");
                writer.WriteStartElement("bold");
                writer.WriteString("Conflict of Interest:");
                writer.WriteEndElement();
                writer.WriteString(ack2);
                writer.WriteEndElement();
            }
            writer.WriteEndElement();
            
            }
            int j1 = 0;
            int j2 = 0;
            int j3 = 0;
            int j4 = 0;
            int j5 = 0;
            int j6 = 0;
            int k = 0;
            int d = 0;
            int f = 0;
            int v = 0;
            int cm = 0;
            int dt = 0;
            int s = 0;
            int sr = 0;
            int p = 0;
            writer.WriteStartElement("ref-list");
            writer.WriteStartElement("title");
            writer.WriteString("References");

            //writer.WriteString("R");
            //writer.WriteStartElement("sc");
            //writer.WriteString("EFRENCES");
            //writer.WriteEndElement();

            writer.WriteEndElement();//end of title
            for (int i = 0; i < num;i++ )
            {
                
                writer.WriteStartElement("ref");//
                writer.WriteAttributeString("id", "ref" + refs[i, 0]);
                writer.WriteStartElement("label");
                writer.WriteString(refs[i, 0]);
                writer.WriteEndElement();//end of label

                writer.WriteStartElement("nlm-citation");//
                writer.WriteAttributeString("citation-type", refs[i, 1]);
                if (String.IsNullOrEmpty(refs[i, 2]) == false)
                {
                    writer.WriteAttributeString("citation-format", refs[i, 2]);
                }
                if (String.IsNullOrEmpty(refs[i, 2]) == false)
                {
                    writer.WriteAttributeString("publisher-type", refs[i, 3]);
                }

                if (String.IsNullOrEmpty(gp1[j1, 1]) == false && gp1[j1, 0] == (i+1).ToString())
                {
                    
                writer.WriteStartElement("person-group");//
                writer.WriteAttributeString("person-group-type", "author");
                while (gp1[j1, 0] == (i + 1).ToString())
                {
                writer.WriteStartElement(gp1[j1,1]);//
                writer.WriteStartElement("surname");
                writer.WriteString(gp1[j1,2]);
                writer.WriteEndElement();
                writer.WriteStartElement("given-names");
                writer.WriteString(gp1[j1, 3]);
                writer.WriteEndElement();
                if (String.IsNullOrEmpty(gp1[j1, 4]) == false)
                {
                    writer.WriteStartElement("suffix");
                    writer.WriteString(gp1[j1, 4]);
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();//end of name
                if (String.IsNullOrEmpty(gp1[j1, 5]) == false)
                    {
                        writer.WriteStartElement("aff");
                        writer.WriteString(gp1[j1, 4]);
                        if (String.IsNullOrEmpty(gp1[j1, 6]) == false)
                    {
                        writer.WriteStartElement("email");
                        writer.WriteString(gp1[j1, 4]);
                        writer.WriteEndElement();
                    }
                        writer.WriteEndElement();//end of aff
                    }
             
              
              
                j1++;
                }
                if (etal[j6, 0] == (i + 1).ToString() && etal[j6, 1] == "Yes")
                {
                    writer.WriteStartElement("etal");
                    writer.WriteEndElement();
                }
                writer.WriteEndElement();//end of person-group-author
                }


                if (String.IsNullOrEmpty(gp2[j2, 1]) == false && gp2[j2, 0] == (i + 1).ToString())
                {
                    writer.WriteStartElement("person-group");//
                    writer.WriteAttributeString("person-group-type", "editor");
                    while (gp2[j2, 0] == (i + 1).ToString())
                    {
                        writer.WriteStartElement(gp2[j2, 1]);//
                        writer.WriteStartElement("surname");
                        writer.WriteString(gp2[j2, 2]);
                        writer.WriteEndElement();
                        writer.WriteStartElement("given-names");
                        writer.WriteString(gp2[j2, 3]);
                        writer.WriteEndElement();
                        if (String.IsNullOrEmpty(gp2[j2, 4]) == false)
                        {
                            writer.WriteStartElement("suffix");
                            writer.WriteString(gp2[j2, 4]);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();//end of name
                        if (String.IsNullOrEmpty(gp2[j2, 5]) == false)
                        {
                            writer.WriteStartElement("aff");
                            writer.WriteString(gp2[j2, 4]);
                            if (String.IsNullOrEmpty(gp2[j2, 6]) == false)
                            {
                                writer.WriteStartElement("email");
                                writer.WriteString(gp2[j2, 4]);
                                writer.WriteEndElement();
                            }
                            writer.WriteEndElement();//end of aff
                        }
                      
                      
                        j2++;
                    }
                    if (etal[j6, 0] == (i + 1).ToString() && etal[j6, 2] == "Yes")
                    {
                        writer.WriteStartElement("etal");
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();//end of person-group-editor
                }

                if (String.IsNullOrEmpty(gp3[j3, 1]) == false && gp3[j3, 0] == (i + 1).ToString())
                {
                    writer.WriteStartElement("person-group");//
                    writer.WriteAttributeString("person-group-type", "compiler");
                    while (gp3[j3, 0] == (i + 1).ToString())
                    {
                        writer.WriteStartElement(gp3[j3, 1]);
                        writer.WriteStartElement("surname");
                        writer.WriteString(gp3[j3, 2]);
                        writer.WriteEndElement();
                        writer.WriteStartElement("given-names");
                        writer.WriteString(gp3[j3, 3]);
                        writer.WriteEndElement();
                        if (String.IsNullOrEmpty(gp3[j3, 4]) == false)
                        {
                            writer.WriteStartElement("suffix");
                            writer.WriteString(gp3[j3, 4]);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();//end of name
                        if (String.IsNullOrEmpty(gp3[j3, 5]) == false)
                        {
                            writer.WriteStartElement("aff");
                            writer.WriteString(gp3[j3, 4]);
                            if (String.IsNullOrEmpty(gp3[j3, 6]) == false)
                            {
                                writer.WriteStartElement("email");
                                writer.WriteString(gp3[j3, 4]);
                                writer.WriteEndElement();
                            }
                            writer.WriteEndElement();
                        }



                        j3++;

                    }
                    if (etal[j6, 0] == (i + 1).ToString() && etal[j6, 3] == "Yes")
                    {
                        writer.WriteStartElement("etal");
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();//end of person-group
                }

                if (String.IsNullOrEmpty(gp4[j4, 1]) == false && gp4[j4, 0] == (i + 1).ToString())
                {
                    writer.WriteStartElement("person-group");//
                    writer.WriteAttributeString("person-group-type", "inventor");
                    while (gp4[j4, 0] == (i + 1).ToString())
                    {
                        writer.WriteStartElement(gp4[j4, 1]);//
                        writer.WriteStartElement("surname");
                        writer.WriteString(gp4[j4, 2]);
                        writer.WriteEndElement();
                        writer.WriteStartElement("given-names");
                        writer.WriteString(gp4[j4, 3]);
                        writer.WriteEndElement();
                        if (String.IsNullOrEmpty(gp4[j4, 4]) == false)
                        {
                            writer.WriteStartElement("suffix");
                            writer.WriteString(gp4[j4, 4]);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();//end of name
                        if (String.IsNullOrEmpty(gp4[j4, 5]) == false)
                        {
                            writer.WriteStartElement("aff");
                            writer.WriteString(gp4[j4, 4]);
                            if (String.IsNullOrEmpty(gp4[j4, 6]) == false)
                            {
                                writer.WriteStartElement("email");
                                writer.WriteString(gp4[j4, 4]);
                                writer.WriteEndElement();
                            }
                            writer.WriteEndElement();
                        }
                       
                        j4++;
                    }
                    if (etal[j6, 0] == (i + 1).ToString() && etal[j6, 4] == "Yes")
                    {
                        writer.WriteStartElement("etal");
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();//end of person-group
                }

                if (String.IsNullOrEmpty(gp5[j5, 1]) == false && gp5[j5, 0] == (i + 1).ToString())
                {
                    writer.WriteStartElement("person-group");//
                    writer.WriteAttributeString("person-group-type", "assignee");
                    while (gp5[j5, 0] == (i + 1).ToString())
                    {
                        writer.WriteStartElement(gp5[j5, 1]);//
                        writer.WriteStartElement("surname");
                        writer.WriteString(gp5[j5, 2]);
                        writer.WriteEndElement();
                        writer.WriteStartElement("given-names");
                        writer.WriteString(gp5[j5, 3]);
                        writer.WriteEndElement();
                        if (String.IsNullOrEmpty(gp5[j5, 4]) == false)
                        {
                            writer.WriteStartElement("suffix");
                            writer.WriteString(gp5[j5, 4]);
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();//end of name
                        if (String.IsNullOrEmpty(gp5[j5, 5]) == false)
                        {
                            writer.WriteStartElement("aff");
                            writer.WriteString(gp5[j5, 4]);
                            if (String.IsNullOrEmpty(gp5[j5, 6]) == false)
                            {
                                writer.WriteStartElement("email");
                                writer.WriteString(gp5[j5, 4]);
                                writer.WriteEndElement();
                            }
                            writer.WriteEndElement();
                        }
                       
                       
                        j5++;
                    }
                    if (etal[j6, 0] == (i + 1).ToString() && etal[j6, 5] == "Yes")
                    {
                        writer.WriteStartElement("etal");
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();//end of person group
                }

                while (collab[k, 0] == (i + 1).ToString())
               {
                   writer.WriteStartElement("collab");
                   if (String.IsNullOrEmpty(collab[k, 1]) == false)
                   {
                       writer.WriteAttributeString("collab-type", collab[k, 1]);
                   }
                   writer.WriteString(collab[k,2]);
                   writer.WriteEndElement();
                   k++;
               }
                if (String.IsNullOrEmpty(refs[i, 4]) == false)
                {
                    writer.WriteStartElement("article-title");
                    writer.WriteString(refs[i, 4]);
                    writer.WriteEndElement();
                }

               if (date[d, 0] == (i + 1).ToString() && date[d, 1] == "AfterArticle")
                {
                    if (String.IsNullOrEmpty(date[d, 2]) == false)
                    {
                        writer.WriteStartElement("year");
                        writer.WriteString(date[d, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 3]) == false)
                    {
                        writer.WriteStartElement("month");
                        writer.WriteString(date[d, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 4]) == false)
                    {
                        writer.WriteStartElement("day");
                        writer.WriteString(date[d, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 5]) == false)
                    {
                        writer.WriteStartElement("season");
                        writer.WriteString(date[d, 5]);
                        writer.WriteEndElement();
                    }
                    d++;
                }

                if (String.IsNullOrEmpty(refs[i, 5]) == false)
                {
                    writer.WriteStartElement("source");
                    writer.WriteStartElement("italic");
                    writer.WriteString(refs[i,5]);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(refs[i, 6]) == false)
                {
                    writer.WriteStartElement("patent");
                    if (String.IsNullOrEmpty(refs[i, 7]) == false)
                    writer.WriteAttributeString("patent-country", refs[i, 7]);

                    writer.WriteString(refs[i, 5]);
                    writer.WriteEndElement();
                }

                if (conf[f, 0] == (i + 1).ToString() && conf[f, 1] == "AfterSource")
                {
                    if (String.IsNullOrEmpty(conf[f, 2]) == false)
                    {
                        writer.WriteStartElement("conf-name");
                        writer.WriteString(conf[f, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(conf[f, 3]) == false)
                    {
                        writer.WriteStartElement("conf-date");
                        writer.WriteString(conf[f, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(conf[f, 4]) == false)
                    {
                        writer.WriteStartElement("conf-loc");
                        writer.WriteString(conf[f, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(conf[f, 5]) == false)
                    {
                        writer.WriteStartElement("conf-sponsor");
                        writer.WriteString(conf[f, 5]);
                        writer.WriteEndElement();
                    }
                    f++;
                }

                if (date[d, 0] == (i + 1).ToString() && date[d, 1] == "AfterSource")
                {
                    if (String.IsNullOrEmpty(date[d, 2]) == false)
                    {
                        writer.WriteStartElement("year");
                        writer.WriteString(date[d, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 3]) == false)
                    {
                        writer.WriteStartElement("month");
                        writer.WriteString(date[d, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 4]) == false)
                    {
                        writer.WriteStartElement("day");
                        writer.WriteString(date[d, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 5]) == false)
                    {
                        writer.WriteStartElement("season");
                        writer.WriteString(date[d, 5]);
                        writer.WriteEndElement();
                    }
                    d++;
                }

                if (String.IsNullOrEmpty(refs[i, 8]) == false)
                {
                    writer.WriteStartElement("content-title");
                    writer.WriteString(refs[i,8]);
                    writer.WriteEndElement();
                }

                if (volIssu[v, 0] == (i + 1).ToString() && volIssu[v, 1] == "AfterSource")
                {
                    if (String.IsNullOrEmpty(volIssu[v, 2]) == false)
                    {
                        writer.WriteStartElement("volume");
                        writer.WriteString(volIssu[v, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(volIssu[v, 3]) == false)
                    {
                        writer.WriteStartElement("issue");
                        writer.WriteString(volIssu[v, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(volIssu[v, 4]) == false)
                    {
                        writer.WriteStartElement("issue-part");
                        writer.WriteString(volIssu[v, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(volIssu[v, 5]) == false)
                    {
                        writer.WriteStartElement("issue-title");
                        writer.WriteString(volIssu[v, 5]);
                        writer.WriteEndElement();
                    }
                    v++;
                }

                if (String.IsNullOrEmpty(refs[i, 9]) == false)
                {
                    writer.WriteStartElement("elocation-id");
                    writer.WriteString(refs[i,9]);
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(refs[i, 10]) == false)
                {
                    writer.WriteStartElement("edition");
                    writer.WriteString(refs[i, 10]);
                    writer.WriteEndElement();
                }

                if (date[d, 0] == (i + 1).ToString() && date[d, 1] == "AfterEdition")
                {
                    if (String.IsNullOrEmpty(date[d, 2]) == false)
                    {
                        writer.WriteStartElement("year");
                        writer.WriteString(date[d, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 3]) == false)
                    {
                        writer.WriteStartElement("month");
                        writer.WriteString(date[d, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 4]) == false)
                    {
                        writer.WriteStartElement("day");
                        writer.WriteString(date[d, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 5]) == false)
                    {
                        writer.WriteStartElement("season");
                        writer.WriteString(date[d, 5]);
                        writer.WriteEndElement();
                    }
                    d++;
                }


                if (comment[cm, 0] == (i + 1).ToString() && comment[cm, 1] == "AfterEdition")
                {
                    
                        writer.WriteStartElement("comment");
                        writer.WriteString(comment[cm, 2]);
                       
                    
                    if (String.IsNullOrEmpty(comment[cm, 3]) == false)
                    {
                       
                        writer.WriteString("Available from: ");
                      
                    }
                    if (String.IsNullOrEmpty(comment[cm, 4]) == false)
                    {
                        writer.WriteStartElement("uri");
                        writer.WriteString(comment[cm, 4]);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    cm++;
                }

                if (volIssu[v, 0] == (i + 1).ToString() && volIssu[v, 1] == "AfterEdition")
                {
                    if (String.IsNullOrEmpty(volIssu[v, 2]) == false)
                    {
                        writer.WriteStartElement("volume");
                        writer.WriteString(volIssu[v, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(volIssu[v, 3]) == false)
                    {
                        writer.WriteStartElement("issue");
                        writer.WriteString(volIssu[v, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(volIssu[v, 4]) == false)
                    {
                        writer.WriteStartElement("issue-part");
                        writer.WriteString(volIssu[v, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(volIssu[v, 5]) == false)
                    {
                        writer.WriteStartElement("issue-title");
                        writer.WriteString(volIssu[v, 5]);
                        writer.WriteEndElement();
                    }
                    v++;
                }

                if (String.IsNullOrEmpty(refs[i, 11]) == false)
                {
                    writer.WriteStartElement("supplement");
                    writer.WriteString(refs[i, 11]);
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(refs[i, 12]) == false)
                {
                    writer.WriteStartElement("access-date");
                    writer.WriteString(refs[i, 12]);
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(refs[i, 13]) == false)
                {
                    writer.WriteStartElement("publisher-loc");
                    writer.WriteString(refs[i, 13]);
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(refs[i, 14]) == false)
                {
                    writer.WriteStartElement("publisher-name");
                    writer.WriteString(refs[i, 14]);
                    writer.WriteEndElement();
                }

                if (date[d, 0] == (i + 1).ToString() && date[d, 1] == "AfterPublisherLoc")
                {
                    if (String.IsNullOrEmpty(date[d, 2]) == false)
                    {
                        writer.WriteStartElement("year");
                        writer.WriteString(date[d, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 3]) == false)
                    {
                        writer.WriteStartElement("month");
                        writer.WriteString(date[d, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 4]) == false)
                    {
                        writer.WriteStartElement("day");
                        writer.WriteString(date[d, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(date[d, 5]) == false)
                    {
                        writer.WriteStartElement("season");
                        writer.WriteString(date[d, 5]);
                        writer.WriteEndElement();
                    }
                    d++;
                }

                if (conf[f, 0] == (i + 1).ToString() && conf[f, 1] == "AfterPublisherLoc")
                {
                    if (String.IsNullOrEmpty(conf[f, 2]) == false)
                    {
                        writer.WriteStartElement("conf-name");
                        writer.WriteString(conf[f, 2]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(conf[f, 3]) == false)
                    {
                        writer.WriteStartElement("conf-date");
                        writer.WriteString(conf[f, 3]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(conf[f, 4]) == false)
                    {
                        writer.WriteStartElement("conf-loc");
                        writer.WriteString(conf[f, 4]);
                        writer.WriteEndElement();
                    }
                    if (String.IsNullOrEmpty(conf[f, 5]) == false)
                    {
                        writer.WriteStartElement("conf-sponsor");
                        writer.WriteString(conf[f, 5]);
                        writer.WriteEndElement();
                    }
                    f++;
                }

                while (String.IsNullOrEmpty(DICitation[dt, 1]) == false && DICitation[dt, 0] == (i + 1).ToString())
                {
                    writer.WriteStartElement("date-in-citation");
                    writer.WriteAttributeString("content-type",DICitation[dt,2]);
                    writer.WriteString(DICitation[dt, 1]);
                    writer.WriteEndElement();
                    if (String.IsNullOrEmpty(DICitation[dt, 3]) == false)
                    {
                        writer.WriteStartElement("chapter-title");
                        writer.WriteString(DICitation[dt, 3]);
                        writer.WriteEndElement();
                    }
                    dt++;
                }

                if (String.IsNullOrEmpty(refs[i, 15]) == false)
                {
                    writer.WriteStartElement("fpage");
                    writer.WriteString(refs[i, 15]);
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(refs[i, 16]) == false)
                {
                    writer.WriteStartElement("lpage");
                    writer.WriteString(refs[i, 16]);
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(refs[i, 17]) == false)
                {
                    writer.WriteStartElement("page-range");
                    writer.WriteString(refs[i, 17]);
                    writer.WriteEndElement();
                }

                if (String.IsNullOrEmpty(size[s, 1]) == false && size[s, 0] == (i + 1).ToString())
                {
                    writer.WriteStartElement("size");
                    writer.WriteAttributeString("units","");
                    writer.WriteString(size[s, 2]);
                    writer.WriteEndElement();
                    s++;
                }

                if (String.IsNullOrEmpty(refs[i, 18]) == false)
                {
                    writer.WriteStartElement("part-title");
                    writer.WriteString(refs[i, 18]);
                    writer.WriteEndElement();
                }

                while (String.IsNullOrEmpty(seris[sr, 1]) == false && seris[sr, 0] == (i + 1).ToString())
                {
                    writer.WriteStartElement("serise");
                    writer.WriteString(seris[sr, 1]);
                    writer.WriteEndElement();
                    sr++;
                }

                if (String.IsNullOrEmpty(refs[i, 19]) == false)
                {
                    writer.WriteStartElement("isbn");
                    writer.WriteString(refs[i, 18]);
                    writer.WriteEndElement();
                }

                if (comment[cm, 0] == (i + 1).ToString() && comment[cm, 1] == "AfterSeris")
                {
                   
                        writer.WriteStartElement("comment");
                        writer.WriteString(comment[cm, 2]);
                        
                   
                    if (String.IsNullOrEmpty(comment[cm, 3]) == false)
                    {

                        writer.WriteString("Available from: ");

                    }
                    if (String.IsNullOrEmpty(comment[cm, 4]) == false)
                    {
                        writer.WriteStartElement("uri");
                        writer.WriteString(comment[cm, 4]);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    cm++;
                }

                while (String.IsNullOrEmpty(pubId[p, 2]) == false && pubId[p, 0] == (i + 1).ToString())
                {
                    if (pubId[p, 1] == "pmcid")
                    {
                        writer.WriteStartElement("comment");
                        writer.WriteString("[");
                        writer.WriteStartElement("ext-link");
                        writer.WriteAttributeString("ext-link-type", "uri");
                        writer.WriteAttributeString("xmlns:xlink", "http://www.w3.org/1999/xlink");
                        writer.WriteAttributeString("xlink:href", "http://www.ncbi.nlm.nih.gov/pmc/articles/" + pubId[p, 2]);
                        writer.WriteString("PMC Free Article");
                        writer.WriteEndElement();
                        writer.WriteString("]");
                        writer.WriteEndElement();
                        
                    }
                    if (pubId[p, 1] == "doi")
                    {
                        writer.WriteStartElement("pub-id");
                        writer.WriteAttributeString("pub-id-type", "doi");
                        writer.WriteString(pubId[p,2]);
                        writer.WriteEndElement();
                       
                    }
                    if (pubId[p, 1] == "pmid")
                    {
                        writer.WriteStartElement("pub-id");
                        writer.WriteAttributeString("pub-id-type", "pmid");
                        writer.WriteString(pubId[p, 2]);
                        writer.WriteEndElement();
                    }
                    p++;
                }

                if (comment[cm, 0] == (i + 1).ToString() && comment[cm, 1] == "End")
                {
                    
                        writer.WriteStartElement("comment");
                        writer.WriteString(comment[cm, 2]);
                       
                   
                    if (String.IsNullOrEmpty(comment[cm, 3]) == false)
                    {

                        writer.WriteString("Available from: ");

                    }
                    if (String.IsNullOrEmpty(comment[cm, 4]) == false)
                    {
                        writer.WriteStartElement("uri");
                        writer.WriteString(comment[cm, 4]);
                        writer.WriteEndElement();
                    }
                    writer.WriteEndElement();
                    cm++;
                }

                writer.WriteEndElement();//end of citation
                writer.WriteEndElement();//end of ref
              
            }
            writer.WriteEndElement();//end of ref list
            writer.WriteEndElement();//end of back
        }
    }
}
