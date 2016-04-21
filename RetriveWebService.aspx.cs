using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using System.Data;

namespace FacultyProfile
{
    public partial class RetriveWebService : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

           protected void Button1_Click(object sender, EventArgs e)
        {
            string enteredText = TextBox1.Text;
            Label5.Text = "";
            Label6.Text = "";
            Label7.Text = "";
            Label10.Text = "";
            Label11.Text = "";
            Label12.Text = "";
            Label14.Text = "";
            Label16.Text = "";
            Label35.Text = "";
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
                if (TextBox1.Text != "")
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
                        /////////////////////////////////////////

                        DataSet myDataSet = new DataSet();
                        byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(root.InnerXml);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
                        myDataSet.ReadXml(ms);
                        GridView1.DataSource = myDataSet.Tables[0];
                        GridView1.DataBind();

                        /////////////////////////////////////////
                       
                        Console.WriteLine("Show email:");
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
                                            if (innerItem.Name == "EMAIL")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label7.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "UPLOAD_PHOTO")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    // Image. = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "FNAME")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label5.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "LNAME")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label6.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "MNAME")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label22.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "DTD_DOB")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label33.Text = Label21.Text + " " + itemName;
                                                }
                                            }
                                            if (innerItem.Name == "DTM_DOB")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label33.Text = Label21.Text + " " + itemName;
                                                }
                                            }

                                            if (innerItem.Name == "DTY_DOB")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label33.Text = Label21.Text + " " + itemName;
                                                }
                                            }

                                            if (innerItem.Name == "GENDER")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label10.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "ETHNICITY")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label11.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "CITIZEN")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label12.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "TEACHING_INTERESTS")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label14.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "RESEARCH_INTERESTS")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label16.Text = itemName;
                                                }
                                            }
                                        }

                                    }
                                    if (itemDesc == "ADMIN_PERM")
                                    {
                                        foreach (XmlNode innerItem in item)
                                        {
                                            if (innerItem.Name == "DTD_HIRE")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label21.Text = Label21.Text + " " + itemName;
                                                }
                                            }
                                            if (innerItem.Name == "DTM_HIRE")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label21.Text = Label21.Text + " " + itemName;
                                                }
                                            }

                                            if (innerItem.Name == "DTY_HIRE")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label21.Text = Label21.Text + " " + itemName;
                                                }
                                            }
                                            if (innerItem.Name == "HIRE_START")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label30.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "HIRE_END")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label26.Text = itemName;
                                                }
                                            }

                                        }

                                    }

                                    if (itemDesc == "ADMIN")
                                    {
                                        foreach (XmlNode innerItem in item)
                                        {
                                            if (innerItem.Name == "AC_YEAR")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label29.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "YEAR_START")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label23.Text = itemName;
                                                }
                                            }
                                            if (innerItem.Name == "YEAR_END")
                                            {
                                                if (innerItem.LastChild != null)
                                                {
                                                    String itemName = innerItem.LastChild.Value;
                                                    Label19.Text = itemName;
                                                }
                                            }
                                        }

                                    }

                                }
                            }
                        }

                    }
                  


                }
                else
                    Label35.Text = "Please enter the user name";
              
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
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("SearchUser.aspx");
        }
    }
    
}