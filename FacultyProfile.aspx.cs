using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Diagnostics;

using System.Data;
using System.Data.SqlClient;
using System.Xml;


namespace FacultyProfile
{
    public partial class FacultyProfile : System.Web.UI.Page
    {
        string enteredText;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["UserName"] != null)
            {
                enteredText = Request.QueryString["UserName"];
                Button1_Click(null, null);
            }

            //  Label13.Text = "";
            Label14.Text = "";
            // Label16.Text = "";
            // Label17.Text = "";
            Label7.Text = "";
            Label8.Text = "";
            Label9.Text = "";
            //Label3.Text = "";
            //Label5.Text = "";
            //Label10.Text = "";
            Label12.Text = "";

        Label20.Text = "";
        Label21.Text = "";
            Label22.Text = "";
            Label23.Text = "";
           
            string uri = "https://www.digitalmeasures.com/login/service/v4/SchemaData/INDIVIDUAL-ACTIVITIES-PublicHealth/USERNAME:" + enteredText;
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new Uri("https://www.digitalmeasures.com"), "Basic", new NetworkCredential("uic/web_service_health", "B3rgJN559xq"));
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;


            request.AllowAutoRedirect = true;
            request.PreAuthenticate = true;
            request.Credentials = credentialCache;
            request.AutomaticDecompression = DecompressionMethods.GZip;

            /* Uncomment to send data
            request.Method = "POST";
            request.ContentType = "text/xml";
            request.ContentLength = contentByteArray.Length;
                using(Stream requestData = request.GetRequestStream()){
                requestData.Write(contentByteArray, 0, contentByteArray.Length);
                }
            */
            request.Method = "GET";
            HttpWebResponse response = null;
            try
            {

                if (request.GetResponse() != null)
                {
                    if (enteredText != null)
                    {
                        response = (HttpWebResponse)request.GetResponse();
                        HttpStatusCode statusCode = response.StatusCode;
                        using (Stream responseData = response.GetResponseStream())
                        {
                            XmlDocument xmlDoc = new XmlDocument();
                            xmlDoc.Load(response.GetResponseStream());
                            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xmlDoc.NameTable);
                            nsmgr.AddNamespace("dmd", "https://www.digitalmeasures.com/schema/data-metadata");
                            XmlNode root = xmlDoc.DocumentElement;
                            XmlNodeList nodeList = root.ChildNodes;

                            /* //////////////////////////////////////////////////////////////////
                              XmlNodeList Photo = xmlDoc.GetElementsByTagName("UPLOAD_PHOTO");
                              string image = Photo.Item(0).InnerText;
                              byte[] arrpicture = System.Convert.FromBase64String(image);
                              Response.ContentType = "Image/BMP";
                              Response.BinaryWrite(arrpicture);
                              ///////////////////////////////////////////////////////////////
                              */
                            XmlNodeList Intellcont = xmlDoc.GetElementsByTagName("INTELLCONT");
                            if (Intellcont != null)
                            {
                                //1st publication


                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(0) != null)
                                    {
                                        XmlNodeList Intellcont0 = Intellcont.Item(0).ChildNodes;
                                        foreach (XmlNode node in Intellcont0)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                PublicationName.InnerHtml = "PUBLICATIONS"; 

                                               

                                                Publication.InnerHtml = Publication.InnerHtml;
                                            }

                                            {
                                                foreach (XmlNode nodeAuth in node)


                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                  Label18.Text = Label18.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                Label18.Text = Label18.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }




                                            }


                                            if (node.Name == "TITLE")
                                            {
                                                //Label10.Text = Label10.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;

                                            }

                                        }

                                        //Label10.Text = Label10.Text + "\r\n";

                                        Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";

                                    }
                                }
                                
                                    //Label10.Text = "Nothing to display";















                      //publications repeat start









                                    if (Intellcont.Count != 0)
                                    {
                                        if (Intellcont.Item(1) != null)
                                        {
                                            XmlNodeList Intellcont1 = Intellcont.Item(1).ChildNodes;
                                            foreach (XmlNode node in Intellcont1)
                                            {
                                                if (node.Name == "INTELLCONT_AUTH")
                                                {
                                                    foreach (XmlNode nodeAuth in node)
                                                    {
                                                        if (nodeAuth.Name == "FNAME")
                                                        {
                                                            //                  Label18.Text = Label18.Text + " " + nodeAuth.InnerText;

                                                            Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                        }

                                                        if (nodeAuth.Name == "LNAME")
                                                        {
                                                            //                Label18.Text = Label18.Text + " " + nodeAuth.InnerText + ",";

                                                            Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                        }
                                                    }

                                                }

                                                if (node.Name == "TITLE")
                                                {
                                                    //      Label18.Text = Label18.Text + " " + node.InnerText;

                                                    Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                                }

                                            }
                                        }
                                    }

                                //      Label10.Text = Label10.Text + "\r\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                    Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";





                                //repeat start


                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(2) != null)
                                    {
                                        XmlNodeList Intellcont2 = Intellcont.Item(2).ChildNodes;
                                        foreach (XmlNode node in Intellcont2)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                  Label19.Text = Label19.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" +" " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                Label19.Text = Label19.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //      Label19.Text = Label19.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }

                                //      Label10.Text = Label10.Text + "\r\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";







                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(3) != null)
                                    {
                                        XmlNodeList Intellcont3 = Intellcont.Item(3).ChildNodes;
                                        foreach (XmlNode node in Intellcont3)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                  Label20.Text = Label20.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                Label20.Text = Label20.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //      Label18.Text = Label18.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }

                                //      Label10.Text = Label10.Text + "\r\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";








                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(4) != null)
                                    {
                                        XmlNodeList Intellcont4 = Intellcont.Item(4).ChildNodes;
                                        foreach (XmlNode node in Intellcont4)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                  Label18.Text = Label18.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                Label18.Text = Label18.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //      Label18.Text = Label18.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }

                                //      Label10.Text = Label10.Text + "\r\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";








                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(5) != null)
                                    {
                                        XmlNodeList Intellcont5 = Intellcont.Item(5).ChildNodes;
                                        foreach (XmlNode node in Intellcont5)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                  Label18.Text = Label18.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                Label18.Text = Label18.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //      Label18.Text = Label18.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }

                                //      Label10.Text = Label10.Text + "\r\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";










                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(6) != null)
                                    {
                                        XmlNodeList Intellcont6 = Intellcont.Item(6).ChildNodes;
                                        foreach (XmlNode node in Intellcont6)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                  Label18.Text = Label18.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                Label18.Text = Label18.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //      Label18.Text = Label18.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }

                                //      Label10.Text = Label10.Text + "\r\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";









                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(7) != null)
                                    {
                                        XmlNodeList Intellcont7 = Intellcont.Item(7).ChildNodes;
                                        foreach (XmlNode node in Intellcont7)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                  Label18.Text = Label18.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                Label18.Text = Label18.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //      Label18.Text = Label18.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }

                                //      Label10.Text = Label10.Text + "\r\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + "<br/>";

















                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(8) != null)
                                    {

                                        int x = Intellcont.Count;
                                        XmlNodeList Intellcont8 = Intellcont.Item(8).ChildNodes;
                                        foreach (XmlNode node in Intellcont8)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label20.Text = Label20.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label20.Text = Label20.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label20.Text = Label20.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }


                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + " <br/>" + "<br/>";
























                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(9) != null)
                                    {
                                        XmlNodeList Intellcont9 = Intellcont.Item(9).ChildNodes;
                                        foreach (XmlNode node in Intellcont9)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label22.Text = Label22.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label22.Text = Label22.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label22.Text = Label22.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }


                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";









                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(10) != null)
                                    {
                                        XmlNodeList Intellcont10 = Intellcont.Item(10).ChildNodes;
                                        foreach (XmlNode node in Intellcont10)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";










                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(11) != null)
                                    {
                                        XmlNodeList Intellcont11 = Intellcont.Item(11).ChildNodes;
                                        foreach (XmlNode node in Intellcont11)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";



                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(12) != null)
                                    {
                                        XmlNodeList Intellcont12 = Intellcont.Item(12).ChildNodes;
                                        foreach (XmlNode node in Intellcont12)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";




                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(13) != null)
                                    {
                                        XmlNodeList Intellcont13 = Intellcont.Item(13).ChildNodes;
                                        foreach (XmlNode node in Intellcont13)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";



                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(14) != null)
                                    {
                                        XmlNodeList Intellcont14 = Intellcont.Item(14).ChildNodes;
                                        foreach (XmlNode node in Intellcont14)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";



                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(15) != null)
                                    {
                                        XmlNodeList Intellcont15 = Intellcont.Item(15).ChildNodes;
                                        foreach (XmlNode node in Intellcont15)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";






                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(16) != null)
                                    {
                                        XmlNodeList Intellcont16 = Intellcont.Item(16).ChildNodes;
                                        foreach (XmlNode node in Intellcont16)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";




                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(17) != null)
                                    {
                                        XmlNodeList Intellcont17 = Intellcont.Item(17).ChildNodes;
                                        foreach (XmlNode node in Intellcont17)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";



                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(18) != null)
                                    {
                                        XmlNodeList Intellcont18 = Intellcont.Item(18).ChildNodes;
                                        foreach (XmlNode node in Intellcont18)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";




                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(19) != null)
                                    {
                                        XmlNodeList Intellcont19 = Intellcont.Item(19).ChildNodes;
                                        foreach (XmlNode node in Intellcont19)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";



                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(20) != null)
                                    {
                                        XmlNodeList Intellcont20 = Intellcont.Item(20).ChildNodes;
                                        foreach (XmlNode node in Intellcont20)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //                      Label23.Text = Label23.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //                    Label23.Text = Label23.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //          Label23.Text = Label23.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }
                                // Label10.Text = Label10.Text + "\n";
                                //Label10.Text = Label10.Text + Environment.NewLine;

                                Publication.InnerHtml = Publication.InnerHtml + "<br/>" + " <br/>";










                                if (Intellcont.Count != 0)
                                {
                                    if (Intellcont.Item(21) != null)
                                    {
                                        XmlNodeList Intellcont21 = Intellcont.Item(21).ChildNodes;
                                        foreach (XmlNode node in Intellcont21)
                                        {
                                            if (node.Name == "INTELLCONT_AUTH")
                                            {
                                                foreach (XmlNode nodeAuth in node)
                                                {
                                                    if (nodeAuth.Name == "FNAME")
                                                    {
                                                        //               Label21.Text = Label21.Text + " " + nodeAuth.InnerText;

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + "\u23D0" + " " + nodeAuth.InnerText;
                                                    }

                                                    if (nodeAuth.Name == "LNAME")
                                                    {
                                                        //             Label21.Text = Label21.Text + " " + nodeAuth.InnerText + ",";

                                                        Publication.InnerHtml = Publication.InnerHtml + " " + nodeAuth.InnerText;
                                                    }
                                                }

                                            }

                                            if (node.Name == "TITLE")
                                            {
                                                //   Label21.Text = Label21.Text + " " + node.InnerText;

                                                Publication.InnerHtml = Publication.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText;
                                            }

                                        }
                                    }
                                }

                            }
                            //publications repeat end



                            //start academic background

                            XmlNodeList EducationList = xmlDoc.GetElementsByTagName("EDUCATION");

                            if (EducationList != null)
                            {

                                //Label15.Text = "Academic Background";
                                // Label11.Text = "Teaching Interests";
                                // Label4.Text = "Research Interests";
                                // Label6.Text = "Publications";


                                if (EducationList.Count != 0)
                                {
                                    AcademicbackgroundName.InnerHtml = "ACADEMIC BACKGROUND";

                              //      AcademicBackground.InnerHtml = ;
                                    if (EducationList.Item(0) != null)
                                    {
                                        XmlNodeList EducationList0 = EducationList.Item(0).ChildNodes;
                                        foreach (XmlNode node in EducationList0)
                                        {
                                            if (node.Name == "DEG")
                                            {
                                                //               Label13.Text = Label13.Text + " " + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                            }
                                            if (node.Name == "SCHOOL")
                                            {
                                                //             Label13.Text = Label13.Text + "," + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + node.InnerText;
                                            }
                                            if (node.Name == "MAJOR")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + node.InnerText;
                                            }

                                            if (node.Name == "DTY_COMP")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + "\u23D0" + " " + node.InnerText;
                                            }

                                        }
                                        AcademicBackground.InnerHtml =  AcademicBackground.InnerHtml + " <br/> <br/>";
                                    }

                                   
                                }
                                
                                    //Label13.Text = "Nothing to Display";
                                    if (EducationList.Count != 0)
                                    {
                                        if (EducationList.Item(1) != null)
                                        {

                                            XmlNodeList EducationList1 = EducationList.Item(1).ChildNodes;
                                            foreach (XmlNode node in EducationList1)
                                            {
                                                if (node.Name == "DEG")
                                                {
                                                    //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                    AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }
                                                if (node.Name == "SCHOOL")
                                                {
                                                    //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                    AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + node.InnerText;
                                                }
                                                if (node.Name == "MAJOR")
                                                {
                                                    //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                    AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + node.InnerText;
                                                }

                                                if (node.Name == "DTY_COMP")
                                                {
                                                    //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                    AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " "  +"\u23D0" + " " + node.InnerText;
                                                }

                                            }
                                            AcademicBackground.InnerHtml =  AcademicBackground.InnerHtml + " <br/> <br/>";
                                        }
                                       
                                    }

                                    

                                if (EducationList.Count != 0)
                                {
                                    if (EducationList.Item(2) != null)
                                    {
                                        XmlNodeList EducationList2 = EducationList.Item(2).ChildNodes;
                                        foreach (XmlNode node in EducationList2)
                                        {
                                            if (node.Name == "DEG")
                                            {
                                                //    Label17.Text = Label17.Text + " " + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";


                                            }
                                            if (node.Name == "SCHOOL")
                                            {
                                                //  Label17.Text = Label17.Text + "," + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + node.InnerText;
                                            }
                                            if (node.Name == "MAJOR")
                                            {
                                                //Label17.Text = Label17.Text + "," + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + node.InnerText;
                                            }

                                            if (node.Name == "DTY_COMP")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " " + "\u23D0" + " " + node.InnerText;
                                            }
                                        }
                                        AcademicBackground.InnerHtml = "<br/>" + AcademicBackground.InnerHtml;
                                    }
                                    
                                }

                                AcademicBackground.InnerHtml = AcademicBackground.InnerHtml + " <br/> <br/>";

                            }


//end education


    //start administrative assignments




                            XmlNodeList Admin_AssignmentsList = xmlDoc.GetElementsByTagName("ADMIN_ASSIGNMENTS");

                            if (Admin_AssignmentsList != null)
                            {

                                //Label15.Text = "Academic Background";
                                // Label11.Text = "Teaching Interests";
                                // Label4.Text = "Research Interests";
                                // Label6.Text = "Publications";


                                if (Admin_AssignmentsList.Count != 0)
                                {
                                    AdminAssignmentsName.InnerHtml = "ADMINISTRATIVE ASSIGNMENTS";

                                    //      AcademicBackground.InnerHtml = ;
                                    if (Admin_AssignmentsList.Item(0) != null)
                                    {
                                        XmlNodeList Admin_AssignmentsList0 = Admin_AssignmentsList.Item(0).ChildNodes;
                                        foreach (XmlNode node in Admin_AssignmentsList0)
                                        {
                                            if (node.Name == "ROLE")
                                            {
                                                //               Label13.Text = Label13.Text + " " + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                            }
                                            if (node.Name == "SCOPE")
                                            {
                                                //             Label13.Text = Label13.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + node.InnerText;
                                            }
                                            if (node.Name == "DESC")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + node.InnerText;
                                            }

                                            if (node.Name == "DTY_START")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + "\u23D0" + " " + node.InnerText;
                                            }

                                        }
                                        AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " <br/> <br/>";
                                    }


                                }

                                //Label13.Text = "Nothing to Display";
                                if (Admin_AssignmentsList.Count != 0)
                                {
                                    if (Admin_AssignmentsList.Item(1) != null)
                                    {

                                        XmlNodeList Admin_AssignmentsList1 = Admin_AssignmentsList.Item(1).ChildNodes;
                                        foreach (XmlNode node in Admin_AssignmentsList1)
                                        {
                                            if (node.Name == "ROLE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                            }
                                            if (node.Name == "SCOPE")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + node.InnerText;
                                            }
                                            if (node.Name == "DESC")
                                            {
                                                //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + node.InnerText;
                                            }

                                            if (node.Name == "DTY_START")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + "\u23D0" + " " + node.InnerText;
                                            }

                                        }
                                        AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " <br/> <br/>";
                                    }

                                }



                                if (Admin_AssignmentsList.Count != 0)
                                {
                                    if (Admin_AssignmentsList.Item(2) != null)
                                    {
                                        XmlNodeList Admin_AssignmentsList2 = Admin_AssignmentsList.Item(2).ChildNodes;
                                        foreach (XmlNode node in Admin_AssignmentsList2)
                                        {
                                            if (node.Name == "ROLE")
                                            {
                                                //    Label17.Text = Label17.Text + " " + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";


                                            }
                                            if (node.Name == "SCOPE")
                                            {
                                                //  Label17.Text = Label17.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + node.InnerText;
                                            }
                                            if (node.Name == "DESC")
                                            {
                                                //Label17.Text = Label17.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + node.InnerText;
                                            }

                                            if (node.Name == "DTY_START")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " " + "\u23D0" + " " + node.InnerText;
                                            }
                                        }
                                        AdminAssignments.InnerHtml = "<br/>" + AdminAssignments.InnerHtml;
                                    }

                                }

                                AdminAssignments.InnerHtml = AdminAssignments.InnerHtml + " <br/> <br/>";

                            }           

                                
                            
                        
                    



//end administrative assignments










                            
                            
                            
                            
                            
                            
                            
                            
                            
                            //start awards

                            XmlNodeList AwardhonorList = xmlDoc.GetElementsByTagName("AWARDHONOR");
                            String nodeName = "";
                            String nodeType = "";

                            if (AwardhonorList != null)
                            {

                                //Label15.Text = "Academic Background";
                                // Label11.Text = "Teaching Interests";
                                // Label4.Text = "Research Interests";
                                // Label6.Text = "Publications";


                                if (AwardhonorList.Count != 0)
                                {
                                    AwardsName.InnerHtml = "AWARDS";

                                    //      AcademicBackground.InnerHtml = ;
                                    if (AwardhonorList.Item(0) != null)
                                    {
                                        XmlNodeList AwardhonorList0 = AwardhonorList.Item(0).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList0)
                                        {
                                            
                                            
                                            if (node.Name == "TYPE")
                                            {
                                                //               Label13.Text = Label13.Text + " " + node.InnerText;
                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }
                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }
                                            }
                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //             Label13.Text = Label13.Text + "," + node.InnerText;
                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }
                                            }
                                            if (node.Name == "ORG")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                            }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                            Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }


                                }

                                //Label13.Text = "Nothing to Display";
                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(1) != null)
                                    {

                                        XmlNodeList AwardhonorList1 = AwardhonorList.Item(1).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList1)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;
                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }
                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }
                                            }
                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                               // Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }

                                            }
                                            if (node.Name == "ORG")
                                            {
                                                //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                            }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                            Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }

                                }





                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(2) != null)
                                    {

                                        XmlNodeList AwardhonorList2 = AwardhonorList.Item(2).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList2)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                               nodeName = node.InnerText;
                                               if (nodeName != "Other")
                                               {
                                                   Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                               }
                                               else
                                               {
                                                   Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                               }
                                            }
                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;
                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }
                                            }
                                            if (node.Name == "ORG")
                                            {
                                                //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                            }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        if (nodeName != "Other" || nodeType != "Other")
                                        {
                                            Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                        }
                                    }

                                }



                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(3) != null)
                                    {

                                        XmlNodeList AwardhonorList3 = AwardhonorList.Item(3).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList3)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }
                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }


                                            }



                                            if (node.Name == "NAME")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }


                                            }



                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                var nodeNameOther = node.InnerText;
                                                if (nodeNameOther != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                }

                                            }

                                            else

                                                if (node.Name == "ORG")
                                                {
                                                    //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }

                                }




                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(4) != null)
                                    {

                                        XmlNodeList AwardhonorList4 = AwardhonorList.Item(4).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList4)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                    }

                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }


                                            }


                         
                                            if (node.Name == "NAME")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }
                                            }

                                          

                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                var nodeNameOther = node.InnerText;
                                                if (nodeNameOther != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                }                                              

                                            }

                                            else

                                            if (node.Name == "ORG")
                                            {
                                                //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                            }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }

                                }










                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(5) != null)
                                    {

                                        XmlNodeList AwardhonorList5 = AwardhonorList.Item(5).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList5)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }

                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }


                                            }



                                            if (node.Name == "NAME")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }
                                            }



                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                var nodeNameOther = node.InnerText;
                                                if (nodeNameOther != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                }

                                            }

                                            else

                                                if (node.Name == "ORG")
                                                {
                                                    //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }

                                }










                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(6) != null)
                                    {

                                        XmlNodeList AwardhonorList6 = AwardhonorList.Item(6).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList6)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }

                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }


                                            }



                                            if (node.Name == "NAME")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }
                                            }



                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                var nodeNameOther = node.InnerText;
                                                if (nodeNameOther != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                }

                                            }

                                            else

                                                if (node.Name == "ORG")
                                                {
                                                    //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }

                                }














                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(7) != null)
                                    {

                                        XmlNodeList AwardhonorList7 = AwardhonorList.Item(7).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList7)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }

                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }


                                            }



                                            if (node.Name == "NAME")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }



                                               


                                            }



                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                var nodeNameOther = node.InnerText;
                                                if (nodeNameOther != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                }

                                            }

                                          

                                                if (node.Name == "ORG")
                                                {
                                                    //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }

                                }










                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(8) != null)
                                    {

                                        XmlNodeList AwardhonorList8 = AwardhonorList.Item(8).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList8)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }


                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }


                                            }



                                            if (node.Name == "NAME")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }
                                            }



                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                var nodeNameOther = node.InnerText;
                                                if (nodeNameOther != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                }

                                            }
                                            if (node.Name == "ORG")
                                            {
                                                //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                            }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";
                                    }

                                }









                                if (AwardhonorList.Count != 0)
                                {
                                    if (AwardhonorList.Item(9) != null)
                                    {

                                        XmlNodeList AwardhonorList9 = AwardhonorList.Item(9).ChildNodes;
                                        foreach (XmlNode node in AwardhonorList9)
                                        {
                                            if (node.Name == "TYPE")
                                            {
                                                //          Label16.Text = Label16.Text + " " + node.InnerText;

                                                nodeType = node.InnerText;
                                                if (nodeType != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t" + node.InnerText + " " + "\u23D0";
                                                }


                                                else
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + "\u25A0" + "\t" + "\t";
                                                }


                                            }



                                            if (node.Name == "NAME")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                nodeName = node.InnerText;
                                                if (nodeName != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                                }

                                            }



                                            if (node.Name == "NAME_OTHER")
                                            {
                                                //        Label16.Text = Label16.Text + "," + node.InnerText;

                                                var nodeNameOther = node.InnerText;
                                                if (nodeNameOther != "Other")
                                                {
                                                    Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";

                                                }

                                            }
                                            if (node.Name == "ORG")
                                            {
                                                //      Label16.Text = Label16.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText + " " + "\u23D0";
                                            }

                                            if (node.Name == "DTY_DATE")
                                            {
                                                //           Label13.Text = Label13.Text + "," + node.InnerText;

                                                Awards.InnerHtml = Awards.InnerHtml + " " + node.InnerText;
                                            }

                                        }
                                        Awards.InnerHtml = Awards.InnerHtml + " <br/> <br/>";


                                    }

                                }



                            }


                            //end awards

































                            //  Console.WriteLine("Show email:");
                            foreach (XmlNode node in nodeList)
                            {
                                if (node.Name == "Record")
                                {
                                    foreach (XmlNode item in node)
                                    {
                                        String itemDesc = item.Name;
                                        if (itemDesc == "PCI")
                                        {

                                            foreach (XmlNode innerItem in item)
                                            {
                                                if (innerItem.Name == "FNAME")
                                                {
                                                    if (innerItem.LastChild != null)
                                                    {
                                                        String itemName = innerItem.LastChild.Value;
                                                        Label12.Text = Label12.Text + " " + itemName;
                                                    }
                                                }
                                                if (innerItem.Name == "LNAME")
                                                {
                                                    if (innerItem.LastChild != null)
                                                    {
                                                        String itemName = innerItem.LastChild.Value;
                                                        Label12.Text = Label12.Text + " " + itemName;


                                                    }
                                                }
                                                if (innerItem.Name == "MNAME")
                                                {
                                                    if (innerItem.LastChild != null)
                                                    {
                                                        String itemName = innerItem.LastChild.Value;
                                                        Label12.Text = Label12.Text + " " + itemName;
                                                    }
                                                }








                                                {
                                                    if (innerItem.Name == "BUILDING")
                                                    {
                                                        if (innerItem.LastChild != null)
                                                        {
                                                            String itemName = innerItem.LastChild.Value;
                                                            Label22.Text = Label22.Text + " " + itemName + " ";
                                                        }
                                                    }
                                                    if (innerItem.Name == "ROOMNUM")
                                                    {
                                                        if (innerItem.LastChild != null)
                                                        {
                                                            String itemName = innerItem.LastChild.Value;
                                                            Label22.Text = Label22.Text + itemName;


                                                        }
                                                    }
                                                }







                                      










                                                {
                                                    if (innerItem.Name == "OPHONE1")
                                                    {
                                                        if (innerItem.LastChild != null)
                                                        {
                                                            String itemName = innerItem.LastChild.Value;
                                                            Label21.Text = Label21.Text + " " + itemName + "\u23BC";
                                                        }
                                                    }
                                                    if (innerItem.Name == "OPHONE2")
                                                    {
                                                        if (innerItem.LastChild != null)
                                                        {
                                                            String itemName = innerItem.LastChild.Value;
                                                            Label21.Text = Label21.Text + itemName + "\u23BC";


                                                        }
                                                    }
                                                    if (innerItem.Name == "OPHONE3")
                                                    {
                                                        if (innerItem.LastChild != null)
                                                        {
                                                            String itemName = innerItem.LastChild.Value;
                                                            Label21.Text = Label21.Text + itemName;
                                                        }
                                                    }
                                                }


















                                                if (innerItem.Name == "EMAIL")
                                                {
                                                    if (innerItem.LastChild != null)
                                                    {
                                                        String itemName = innerItem.LastChild.Value;
                                                        Label20.Text = Label20.Text + " " + itemName;
                                                    }
                                                }

















                                                if (innerItem.Name == "TEACHING_INTERESTS")
                                                {
                                                    if (innerItem.LastChild != null)
                                                    {
                                                        String itemName = innerItem.LastChild.Value;
                                                        //      Label3.Text = itemName;

                                                        TeachingInterestName.InnerHtml = "TEACHING INTERESTS";

                                                        TeachingInterest.InnerHtml = "<br/>" + itemName + "<br/><br/>";

                                                    }
                                                }
                                                else
                                                    //Label3.Text = "Nothing to Display";

                                                    if (innerItem.Name == "RESEARCH_INTERESTS")
                                                    {
                                                        if (innerItem.LastChild != null)
                                                        {
                                                            String itemName = innerItem.LastChild.Value;
                                                            //  Label5.Text = itemName;

                                                            ResearchInterestName.InnerHtml = "RESEARCH INTERESTS";

                                                            ResearchInterest.InnerHtml = "<br/>" + itemName + "<br/><br/>";
                                                            //ResearchInterest.InnerHtml = ResearchInterest.InnerHtml + "<br/>";

                                                        }

                                                    }
                                                    else



                                                        if (innerItem.Name == "BIO")
                                                        {
                                                            if (innerItem.LastChild != null)
                                                            {
                                                                String itemName = innerItem.LastChild.Value;
                                                                //  Label5.Text = itemName;

                                                                BIOName.InnerHtml = "BIOGRAPHY";

                                                                BIO.InnerHtml = "<br/>" + itemName + "<br/><br/>";
                                                                //ResearchInterest.InnerHtml = ResearchInterest.InnerHtml + "<br/>";

                                                            }

                                                        }
                                                        else








                                                        













                                                            //Label5.Text = "Nothing to Display";

                                                            if (innerItem.Name == "WEBSITE")
                                                            {
                                                                if (innerItem.LastChild != null)
                                                                {
                                                                    String itemName = innerItem.LastChild.Value;
                                                                    Label14.Text = itemName;
                                                                }
                                                            }
                                                            else
                                                            {
                                                                //          Label14.Text = "Nothing to Display";

                                                            }
                                            }
                                        }




















                           
                                         


















                                        

                                        if (itemDesc == "ADMIN")
                                        {

                                            foreach (XmlNode innerItem in item)
                                            {
                                                if (innerItem.Name == "RANK")
                                                {
                                                    if (innerItem.LastChild != null)
                                                    {
                                                        String itemName = innerItem.LastChild.Value;
                                                        Label7.Text = itemName;
                                                    }
                                                }
                                            }
                                        }
                                        if (itemDesc == "ADMIN")
                                        {

                                            foreach (XmlNode innerItem in item)
                                            {
                                                if (innerItem.Name == "ADMIN_DEP")
                                                {
                                                    foreach (XmlNode innermostItem in innerItem)
                                                    {
                                                        if (innermostItem.Name == "DEP")
                                                        {
                                                            if (innermostItem.LastChild != null)
                                                            {
                                                                String itemName = innermostItem.LastChild.Value;
                                                                Label8.Text = itemName;
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                        /* if (itemDesc == "EDUCATION")
                                         {

                                             foreach (XmlNode innerItem in item)
                                             {
                                                 if (innerItem.Name == "DEG")
                                                 {
                                                     if (innerItem.LastChild != null)
                                                     {
                                                         String itemName = innerItem.LastChild.Value;
                                                         Label13.Text = itemName;
                                                     }
                                                 }
                                             }
                                         }*/


                                    }
                                }
                            }
                        }
                    }

                }

                else
                {
                    Response.Redirect("SearchUser.aspx");
                }
            }



            catch (IOException ex)
            {

                Debug.WriteLine(ex.Message);

            }

            finally
            {
                if (response != null)
                {
                    Console.WriteLine(response);
                    response.Close();
                }
            }
            ///////////////////////////////

            DataTable dt = new DataTable();
            String strConnString = "Data Source=sph-sql2014;Initial Catalog=FacultyProfile;Integrated Security=True";
            string strQuery = "select ImagePath from dbo.FacultyImagePaths where Username='" + enteredText + "'";
            SqlCommand cmd = new SqlCommand(strQuery);
            SqlConnection con = new SqlConnection(strConnString);
            SqlDataAdapter sda = new SqlDataAdapter();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = con;
            try
            {
                con.Open();
                sda.SelectCommand = cmd;
                sda.Fill(dt);
                GridView1.DataSource = dt;
                GridView1.DataBind();
            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                con.Close();
                sda.Dispose();
                con.Dispose();
            }
                                    

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           

        }



        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchUser.aspx");
        }


    }
}