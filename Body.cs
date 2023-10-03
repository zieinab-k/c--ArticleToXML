using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Collections;
using System.Xml.XPath;

namespace XmlCreat1
{
    class Body
    {
        public Body()
        {
            ToString();
        }
        public void Section(XmlTextWriter writer, string[, , ,] Sec, string[] tsec, string[,] tsub, int[,] reff, string[,] ff, int x, string knwon, string knew, string[,] figure, string[] title, string[,] ary1, string[,] ary2, string[,] footer, string[,] ref1, string[,] ref2, string[,] stylh, string[,] stylb,string[,] bgcolor,string Jname)
        {
            int figflag = 0;
            int tbflag = 0;
            //int flagn = 0;
            writer.WriteStartElement("body");
            if (String.IsNullOrEmpty(knwon) == false || String.IsNullOrEmpty(knew) == false)
            {
                if (String.IsNullOrEmpty(knwon) == false)
                {
                    writer.WriteStartElement("p");
                    writer.WriteStartElement("bold");
                    writer.WriteString("What&#x2019;s Known");
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                    writer.WriteStartElement("p");
                    writer.WriteStartElement("list");
                    writer.WriteAttributeString("list-type", "bullet");
                    writer.WriteStartElement("list-item");
                    writer.WriteStartElement("p");
                    writer.WriteString(knwon);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }
                if (String.IsNullOrEmpty(knew) == false)
                {

                    writer.WriteStartElement("p");
                    writer.WriteStartElement("bold");
                    writer.WriteString("What&#x2019;s New");
                    writer.WriteEndElement();
                    writer.WriteEndElement();

                    writer.WriteStartElement("p");
                    writer.WriteStartElement("list");
                    writer.WriteAttributeString("list-type", "bullet");
                    writer.WriteStartElement("list-item");
                    writer.WriteStartElement("p");
                    writer.WriteString(knew);
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                    writer.WriteEndElement();
                }

            }
            int j = 0, p = 0, q = 0, m = 0, n = 0;
            string ijc1="";int ijc2=0;
            for (int i = 0; i < x; i++)
            {
                if (String.IsNullOrEmpty( tsec[i])==false)
                {
                j = 0;
                writer.WriteStartElement("sec");
                writer.WriteAttributeString("id", "sec1-" + (i + 1).ToString());
                writer.WriteAttributeString("sec-type", tsec[i]);
                writer.WriteStartElement("title");
                if (Jname == "IJCBNM")
                {
                    foreach (char ijc in tsec[i])
                    {
                        if (ijc2 == 0)
                        {
                            writer.WriteString(ijc.ToString());
                            ijc2 = 1;
                        }
                        else
                            ijc1 += ijc;
                    }
                        writer.WriteStartElement("sc");
                        writer.WriteString(ijc1);
                        writer.WriteEndElement();
                        ijc1 = "";
                        ijc2 = 0;
                    
                    
                }
                else
                {
                    writer.WriteString(tsec[i]);
                }
                writer.WriteEndElement();
                if (String.IsNullOrEmpty(tsub[i, j]) == false)
                {
                    for (j = 0; j < 20; j++)
                    {
                        if (String.IsNullOrEmpty(tsub[i, j]) == true)
                        {
                            break;
                        }
                        writer.WriteStartElement("sec");
                        writer.WriteAttributeString("id", "sec" + (i + 1).ToString() + "-" + (j + 1).ToString());
                        writer.WriteStartElement("title");
                        if (Jname == "IJMS" || Jname == "IJCBNM" || Jname == "JAMP" || Jname == "JDB")
                        {
                            writer.WriteStartElement("italic");
                        }
                        writer.WriteString(tsub[i, j]);
                        if (Jname == "IJMS" || Jname == "IJCBNM" || Jname == "JAMP" || Jname == "JDB")
                        {
                            writer.WriteEndElement();
                        }
                        writer.WriteEndElement();
                        for (p = 0; p < 20; p++)
                        {
                            figflag = 0;
                            tbflag = 0;
                            if (String.IsNullOrEmpty(Sec[i, j, p, 0]) == true)
                            {
                                break;
                            }
                            writer.WriteStartElement("p");
                            for (q = 0; q < 20; q++)
                            {
                                if (String.IsNullOrEmpty(Sec[i, j, p, q]) == true)
                                {
                                    break;
                                }
                                writer.WriteString(Sec[i, j, p, q]);
                                n = 0;
                                if (reff[m, n] != 0)
                                {
                                    if (reff[m, n] > 0 && reff[m, n] < 500)
                                    {
                                        if (Jname == "IJMS" || Jname == "IJCBNM")
                                        {
                                            writer.WriteStartElement("sup");
                                        }
                                        if (Jname == "JBPE" || Jname == "JDS" || Jname == "JDB")
                                        {
                                            writer.WriteString("[");
                                        }
                                        if (Jname == "JAMP")
                                        {
                                            writer.WriteString("(");
                                        }
                                        for (n = 0; n < 20; n++)
                                        {
                                            if (reff[m, n] == 0)
                                                break;

                                            writer.WriteStartElement("xref");

                                            writer.WriteAttributeString("ref-type", "bibr");
                                            writer.WriteAttributeString("rid", "ref" + reff[m, n].ToString());
                                            writer.WriteString(reff[m, n].ToString());




                                            writer.WriteEndElement();
                                            if (String.IsNullOrEmpty(ff[m, n]) == false)
                                            {
                                                writer.WriteString(ff[m, n]);
                                            }



                                        }
                                        if (Jname == "IJMS" || Jname == "IJCBNM")
                                        {
                                            writer.WriteEndElement();
                                        }
                                        if (Jname == "JBPE" || Jname == "JDS" || Jname == "JDB")
                                        {
                                            writer.WriteString("]");
                                           
                                        }
                                        if (Jname == "JAMP")
                                        {
                                            writer.WriteString(")");
                                        }
                                    }

                                   
                                    else if (reff[m, n] > 7000 && reff[m, n] < 8000)
                                    {
                                        writer.WriteStartElement("sub");
                                        int w = reff[m, n] % 1000;
                                        writer.WriteString(ff[m, n]);
                                        writer.WriteEndElement();
                                    }

                                    else if (reff[m, n] > 1000 && reff[m, n] < 2000)
                                    {
                                        writer.WriteStartElement("xref");
                                        writer.WriteAttributeString("ref-type", "fig");
                                        writer.WriteAttributeString("rid", ff[m, n]+".tif");
                                        int w = reff[m, n] % 1000;
                                        if (Jname == "IJMS" || Jname == "IJCBNM")
                                        {
                                            writer.WriteString("figure " + w.ToString());
                                        }
                                        else
                                        {
                                            writer.WriteString("Figure " + w.ToString());
                                        }
                                        writer.WriteEndElement();
                                    }
                                    else if (reff[m, n] > 2000 && reff[m, n] < 3000)
                                    {
                                        writer.WriteStartElement("xref");
                                        writer.WriteAttributeString("ref-type", "table");
                                        writer.WriteAttributeString("rid", ff[m, n]);
                                        int w = reff[m, n] % 2000;
                                        if (Jname == "IJMS" || Jname == "IJCBNM")
                                        {
                                            writer.WriteString("Table " + w.ToString());
                                        }
                                        else
                                        {
                                            writer.WriteString("Table " + w.ToString());
                                        }
                                        writer.WriteEndElement();
                                    }
                                    else if (reff[m, n] > 3000 && reff[m, n] < 4000)
                                    {
                                        writer.WriteStartElement("p");
                                        writer.WriteStartElement("inline-graphic");
                                        writer.WriteAttributeString("xmlns:xlink", "http://www.w3.org/1999/xlink");
                                        writer.WriteAttributeString("xlink:href", ff[m, n]);
                                        writer.WriteEndElement();
                                        writer.WriteEndElement();


                                    }
                                    else if (reff[m, n] > 4000 && reff[m, n] < 5000)
                                    {
                                        writer.WriteString("(");
                                        writer.WriteStartElement("ext-link");
                                        writer.WriteAttributeString("ext-link-type", "uri");
                                        writer.WriteAttributeString("xlink:href", " http://" + ff[m, n]);
                                        writer.WriteString(ff[m, n]);
                                        writer.WriteEndElement();
                                        writer.WriteString(")");


                                    }
                                    else if (reff[m, n] > 5000 && reff[m, n] < 6000)
                                    {
                                        writer.WriteEndElement();
                                        Figure(writer, figure, ff[m, n]);
                                        figflag = 1;
                                    }
                                    else if (reff[m, n] > 6000 && reff[m, n] < 7000)
                                    {
                                        if (figflag == 0)
                                        {
                                            writer.WriteEndElement();
                                        }
                                        TabelT(writer, ff[m, n], title, ary1, ary2, footer, ref1, ref2, stylh, stylb,bgcolor,Jname);
                                        tbflag = 1;
                                    }
                                }
                                m++;
                            }
                            if (figflag == 0 && tbflag == 0)
                            {
                                writer.WriteEndElement();
                            }
                        }


                        writer.WriteEndElement();
                    }
                }
                else
                {
                    for (p = 0; p < 20; p++)
                    {
                        figflag = 0;
                        tbflag = 0;
                        if (Sec[i, j, p, 0] == null)
                            break;
                        writer.WriteStartElement("p");
                        for (q = 0; q < 20; q++)
                        {
                            if (Sec[i, j, p, q] == null)
                                break;

                            writer.WriteString(Sec[i, j, p, q]);
                            n = 0;
                            if (reff[m, n] != 0)
                            {
                                if (reff[m, n] > 0 && reff[m, n] < 500)
                                {
                                    if (Jname == "IJMS" || Jname == "IJCBNM")
                                    {
                                        writer.WriteStartElement("sup");
                                    }
                                    if (Jname == "JBPE" || Jname == "JDS" || Jname == "JDB")
                                    {
                                        writer.WriteString("[");

                                    }
                                    if (Jname == "JAMP")
                                    {
                                        writer.WriteString("(");
                                    }
                                    for (n = 0; n < 20; n++)
                                    {
                                        if (reff[m, n] == 0)
                                            break;

                                        writer.WriteStartElement("xref");

                                        writer.WriteAttributeString("ref-type", "bibr");
                                        writer.WriteAttributeString("rid", "ref" + reff[m, n].ToString());
                                        writer.WriteString(reff[m, n].ToString());




                                        writer.WriteEndElement();
                                        if (String.IsNullOrEmpty(ff[m, n]) == false)
                                        {
                                            writer.WriteString(ff[m, n]);
                                        }



                                    }
                                    if (Jname == "IJMS" || Jname == "IJCBNM")
                                    {
                                        writer.WriteEndElement();
                                    }
                                    if (Jname == "JBPE" || Jname == "JDS" || Jname == "JDB")
                                    {
                                        writer.WriteString("]");
                                    }
                                    if (Jname == "JAMP")
                                    {
                                        writer.WriteString(")");
                                    }
                                }

                             

                                //else if (reff[m, n] > 500 && reff[m, n] < 1000)
                                //{

                                   
                                //    writer.WriteString("[");
                                  
                                //    for (n = 0; n < 20; n++)
                                //    {
                                //        if (reff[m, n] == 0)
                                //            break;
                                //        int rf = (reff[m, n] % 500);
                                //        writer.WriteStartElement("xref");

                                //        writer.WriteAttributeString("ref-type", "bibr");
                                //        writer.WriteAttributeString("rid", "ref" + rf.ToString());
                                //        writer.WriteString(rf.ToString());
                                //        writer.WriteEndElement();
                                //        if (String.IsNullOrEmpty(ff[m, n]) == false)
                                //        {
                                //            writer.WriteString(ff[m, n]);
                                //        }



                                //    }
                                    
                                //    writer.WriteString("]");
                                   
                                //}
                                else if (reff[m, n] > 1000 && reff[m, n] < 2000)
                                {
                                    writer.WriteStartElement("xref");
                                    writer.WriteAttributeString("ref-type", "fig");
                                    writer.WriteAttributeString("rid", ff[m, n]+".tif");
                                    int w = reff[m, n] % 1000;
                                    if (Jname == "IJMS" || Jname == "IJCBNM")
                                    {
                                        writer.WriteString("figure " + w.ToString());
                                    }
                                    else
                                    {
                                        writer.WriteString("Figure " + w.ToString());
                                    }
                                    writer.WriteEndElement();
                                }
                                else if (reff[m, n] > 2000 && reff[m, n] < 3000)
                                {
                                    writer.WriteStartElement("xref");
                                    writer.WriteAttributeString("ref-type", "table");
                                    writer.WriteAttributeString("rid", ff[m, n]);
                                    int w = reff[m, n] % 2000;
                                    if (Jname == "IJMS" || Jname == "IJCBNM")
                                    {
                                        writer.WriteString("Table " + w.ToString());
                                    }
                                    else
                                    {
                                        writer.WriteString("Table " + w.ToString());
                                    }
                                    writer.WriteEndElement();
                                }
                                else if (reff[m, n] > 3000 && reff[m, n] < 4000)
                                {
                                    writer.WriteStartElement("p");
                                    writer.WriteStartElement("inline-graphic");
                                    writer.WriteAttributeString("xmlns:xlink", "http://www.w3.org/1999/xlink");
                                    writer.WriteAttributeString("xlink:href", ff[m, n]);
                                    writer.WriteEndElement();
                                    writer.WriteEndElement();

                                }
                                else if (reff[m, n] > 4000 && reff[m, n] < 5000)
                                {
                                    writer.WriteString("(");
                                    writer.WriteStartElement("ext-link");
                                    writer.WriteAttributeString("ext-link-type", "uri");
                                    writer.WriteAttributeString("xlink:href", " http://" + ff[m, n]);
                                    writer.WriteString(ff[m, n]);
                                    writer.WriteEndElement();
                                    writer.WriteString(")");


                                }
                                else if (reff[m, n] > 5000 && reff[m, n] < 6000)
                                {
                                    writer.WriteEndElement();
                                    Figure(writer, figure, ff[m, n]);
                                    figflag = 1;
                                }
                                else if (reff[m, n] > 6000 && reff[m, n] < 7000)
                                {
                                    if (figflag == 0)
                                    {
                                        writer.WriteEndElement();
                                    }
                                    TabelT(writer, ff[m, n], title, ary1, ary2, footer, ref1, ref2, stylh, stylb,bgcolor,Jname);
                                    tbflag = 1;
                                }
                            }
                            m++;
                        }
                        if (figflag == 0 && tbflag == 0)
                        {
                            writer.WriteEndElement();
                        }
                    }

                }
                writer.WriteEndElement();
            }
        }
            writer.WriteEndElement();


        }

        public void Figure(XmlTextWriter writer, string[,] figure, string num)
        {
            for (int i = 0; i < 50; i++)
            {

                if (figure[i, 1] == num)
                {

                    if (String.IsNullOrEmpty(figure[i, 0]) == false)
                    {
                        writer.WriteStartElement("fig");
                        writer.WriteAttributeString("id", figure[i, 0]+".tif");
                        writer.WriteAttributeString("position", "float");
                        writer.WriteStartElement("label");
                        writer.WriteString("Figure" + figure[i, 1]);
                        writer.WriteEndElement();
                        writer.WriteStartElement("caption");
                        writer.WriteStartElement("p");
                        writer.WriteString(figure[i, 2]);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        writer.WriteStartElement("graphic");
                        writer.WriteAttributeString("xmlns:xlink", "http://www.w3.org/1999/xlink");
                        writer.WriteAttributeString("xlink:href", figure[i, 0]+".tif");
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                    }

                }
            }
        }

        public void TabelT(XmlTextWriter writer, string num,string[] title, string[,] ary1, string[,] ary2, string[,] footer, string[,] ref1, string[,] ref2, string[,] stylh, string[,] stylb,string[,] bgcolor,string Jname)
        {
            int f = 0;
            int f1 = 0;
            int f2 = 0;
            int t = Convert.ToInt32(num) - 1;
            int r1 = 1;
            writer.WriteStartElement("table-wrap");
            writer.WriteAttributeString("id", "T" + num);
            writer.WriteAttributeString("position", "float");
            writer.WriteStartElement("label");
            writer.WriteString("Table " + num);
            writer.WriteEndElement();
            writer.WriteStartElement("caption");
            writer.WriteStartElement("p");
            writer.WriteString(title[t]);
            writer.WriteEndElement();
            writer.WriteEndElement();

            writer.WriteStartElement("table");
            writer.WriteAttributeString("frame", "hsides");
            writer.WriteAttributeString("rules", "groups");
            writer.WriteAttributeString("width", "100%");
            writer.WriteStartElement("thead");

            int fa1 = 0, fa2 = 0;
            for (int ia = 0; ia < 200; ia++)
            {
                if (ary1[ia, 0] == num)
                {
                    fa1 = ia;
                    break;
                }
            }

            for (int ia = 0; ia < 2000; ia++)
            {
                if (ary2[ia, 0] == num)
                {
                    fa2 = ia;
                    break;
                }
            }
            int i = fa1;

           
            while (ary1[i, 0] == num)
            {
                f = 0;
                writer.WriteStartElement("tr");
                if (Jname == "IJCBNM" )
                {
                    if (stylh[i, 1] == "Yes")
                    {
                        writer.WriteAttributeString("style", "background-color:#b2b3b6; color:#231f20;");
                    }
                }
                if (Jname == "IJMS")
                {
                    if (stylh[i, 1] == "Yes")
                    {
                        writer.WriteAttributeString("style", "background-color:#494c9f; color:#ffffff;");
                    }
                }
                if (Jname == "JAMP")
                {
                    if (stylh[i, 1] == "Yes")
                    {
                        writer.WriteAttributeString("style", "background-color:#DFD8E8; color:#231f20;");
                    }
                }
                for (int ia = 0; ia < 200; ia++)
                {
                    if (String.IsNullOrEmpty( ary2[i, ia])==false)
                    {
                        f++;     
                    }
                }
                for (int j = 1; j <=f; j++)
                {
                    if (String.IsNullOrEmpty(ary1[i, j]) == false)
                    {
                       
                        writer.WriteStartElement("th");
                        if (Jname == "JBPE" && j!=f-1)
                        {
                           // writer.WriteAttributeString("style", "color:#000000;border-top:none;border-left:none;border-right:solid windowtext 1.0pt;border-bottom:solid #650000 1.0pt;");
                            writer.WriteAttributeString("style", "color:#000000;border-top:none;border-left:none;border-right:none 1.0pt;border-bottom:solid #650000 1.0pt;");
                        }
                        else if (Jname == "JBPE" && j == f-1)
                        {
                            writer.WriteAttributeString("style", "color:#000000;border-top:none;border-left:none;border-right:none 1.0pt;border-bottom:solid #650000 1.0pt;");
                        }

                        if (Jname == "JDS" && j != f - 1)
                        {
                            // writer.WriteAttributeString("style", " color:#000000;background-color:#BFBFBF;background-color:#BFBFBF;border-top:solid windowtext 1.0pt;border-left:none;border-right:none;border-bottom:none 1.0pt;");
                            writer.WriteAttributeString("style", " color:#000000;background-color:#BFBFBF;background-color:#BFBFBF;border-top:solid windowtext 1.0pt;border-left:none;border-right:none;border-bottom:solid windowtext 1.0pt;");
                        }
                        //if (Jname == "JAMP")
                        //{
                        //    writer.WriteAttributeString("style"," color:#000000;background-color:#DFD8E8;border-top:none;border-left: none;border-right:solid #8064A2 1.0pt;border-bottom:solid #8064A2 1.0pt;");
                        //}
                        
                        writer.WriteAttributeString("align", "left");
                        writer.WriteAttributeString("colspan", "1");
                        writer.WriteAttributeString("rowspan", "1");
                        writer.WriteAttributeString("valign", "top");
                        writer.WriteString(ary1[i, j]);
                        if (String.IsNullOrEmpty(ref1[i, j]) == false)
                        {
                            writer.WriteStartElement("xref");
                            writer.WriteAttributeString("ref-type", "table-fn");
                            writer.WriteAttributeString("rid", "t" + num + "f" + r1.ToString());
                            writer.WriteString(ref1[i, j]);
                            writer.WriteEndElement();
                            r1++;
                        }

                        writer.WriteEndElement();
                    }
                    
                }
                writer.WriteEndElement();
                i++;
            }
            writer.WriteEndElement();//end of thead
            writer.WriteStartElement("tbody");
            i = fa2;
            while (ary2[i, 0] == num)
            {
                f1 = 0;
                writer.WriteStartElement("tr");
                if (Jname == "IJCBNM")
                {
                    if (stylh[i, 1] == "Yes")
                    {
                        writer.WriteAttributeString("style", "background-color:#b2b3b6; color:#231f20;");
                    }
                }
                if (Jname == "IJMS")
                {
                    if (stylh[i, 1] == "Yes")
                    {
                        writer.WriteAttributeString("style", "background-color:#f2f2f9; color:#231f20;");
                    }
                }
                if (Jname == "JAMP")
                {
                    if (stylh[i, 1] == "Yes")
                    {
                        writer.WriteAttributeString("style", "background-color:#DFD8E8; color:#231f20;");
                    }
                }
                for (int ia = 0; ia < 200; ia++)
                {
                    if (String.IsNullOrEmpty(ary2[i, ia]) == false)
                    {
                        f1++;
                    }
                }
                for (int j = 1; j <=f1; j++)
                {
                    if (String.IsNullOrEmpty(ary2[i, j]) == false)
                    {
                        writer.WriteStartElement("td");
                        if (Jname == "JBPE" && j != f1 - 1)
                        {
                           // writer.WriteAttributeString("style", "color:#000000;border-top:none;border-left:none;border-right:solid windowtext 1.0pt;border-bottom:solid #A30F63 1.0pt;");
                            writer.WriteAttributeString("style", "color:#000000;border-top:none;border-left:none;border-right:none 1.0pt;border-bottom:solid #A30F63 1.0pt;");
                        }
                        else if (Jname == "JBPE" && j == f1 - 1)
                        {
                            writer.WriteAttributeString("style", "color:#000000;border-top:none;border-left:none;border-right:none 1.0pt;border-bottom:solid #A30F63 1.0pt;");
                        }
                        if (Jname == "JDS")
                        {
                            // writer.WriteAttributeString("style"," color:#000000;background-color:#BFBFBF;border:none;border-bottom:none 1.0pt;");
                            writer.WriteAttributeString("style", " color:#000000;background-color:#BFBFBF;border:none;border-bottom:none;");
                        }
                        //if (Jname == "JAMP")
                        //{
                        //    writer.WriteAttributeString("style", " color:#000000;background-color:#DFD8E8;border-top:none;border-left: none;border-right:solid #8064A2 1.0pt;border-bottom:solid #8064A2 1.0pt;");
                           
                        //    //writer.WriteAttributeString("style", " color:#000000;border-top:none;border-left: none;border-right:solid #8064A2 1.0pt;border-bottom:solid #8064A2 1.0pt;");
                        //}
                        writer.WriteAttributeString("align", "left");
                        writer.WriteAttributeString("colspan", "1");
                        writer.WriteAttributeString("rowspan", "1");
                        writer.WriteAttributeString("valign", "top");
                        writer.WriteString(ary2[i, j]);
                        if (String.IsNullOrEmpty(ref2[i, j]) == false)
                        {
                            writer.WriteStartElement("xref");
                            writer.WriteAttributeString("ref-type", "table-fn");
                            writer.WriteAttributeString("rid", "t" + num + "f" + r1.ToString());
                            writer.WriteString(ref2[i, j]);
                            writer.WriteEndElement();
                            r1++;
                        }

                        writer.WriteEndElement();
                    }
                }

                writer.WriteEndElement();
                i++;
            }
            writer.WriteEndElement();//end of tbody

            writer.WriteEndElement();//end of table
            int fa3 = 0;
            for (int ii = 0; ii < 200; ii++)
            {
                if (footer[ii, 0] == num)
                {
                    fa3 = ii;
                    break;
                }
            }
            for (int ii = 0; ii < 200; ii++)
            {
                if (footer[ii, 0] == num)
                {
                    f2 = ii;
                    
                }
            }
            f2=f2+fa3;
            int r2 = 1;
            if (String.IsNullOrEmpty(footer[fa3, 1]) == false)
            {
                writer.WriteStartElement("table-wrap-foot");
                for (int ii = fa3; ii <=f2 ; ii++)
                {
                    if (String.IsNullOrEmpty(footer[ii, 1]) == false)
                    {
                        writer.WriteStartElement("fn");
                        writer.WriteAttributeString("id", "t" + num + "f" + r2.ToString());
                        writer.WriteStartElement("label");
                        writer.WriteString(footer[ii, 1]);
                        writer.WriteEndElement();
                        writer.WriteStartElement("p");
                        writer.WriteString(footer[ii, 2]);
                        writer.WriteEndElement();
                        writer.WriteEndElement();
                        r2++;
                    }
               }
               writer.WriteEndElement();//end of footer
            }
            writer.WriteEndElement();//end of table warp       
        }
    }
}
        
     