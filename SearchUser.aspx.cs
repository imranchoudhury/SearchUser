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
using System.Data.SqlClient;

namespace FacultyProfile
{
    public partial class SearchUser : System.Web.UI.Page
    {
        string exceptionText = "";
        string enteredText = "";
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            // string enteredText;
            if (!string.IsNullOrWhiteSpace(TextBox1.Text))
            {
                enteredText = TextBox1.Text;
                string uri = "https://www.digitalmeasures.com/login/service/v4/User/INDIVIDUAL-ACTIVITIES-PublicHealth?lastName=" + enteredText;
                CredentialCache credentialCache = new CredentialCache();
                credentialCache.Add(new Uri("https://www.digitalmeasures.com"), "Basic", new NetworkCredential("uic/web_service_health", "B3rgJN559xq"));
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;

                request.AllowAutoRedirect = true;
                request.PreAuthenticate = true;
                request.Credentials = credentialCache;
                request.AutomaticDecompression = DecompressionMethods.GZip;



                request.Method = "GET";
                HttpWebResponse response = null;
                try
                {
                    ExceptionRegion.InnerHtml = exceptionText;
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
                        byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(root.OuterXml);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
                        myDataSet.ReadXml(ms);
                        int i = myDataSet.Tables.Count;
                        if (i != 0)
                        {
                            GridView1.DataSource = myDataSet.Tables[0];
                            GridView1.DataBind();
                        }
                        else { 
                            ExceptionRegion.InnerHtml = "***PERSON NOT FOUND***";
                        }

                        /////////////////////////////////////////
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


            }
            else
            {
                Response.Redirect("FacultyProfile.aspx");

            }

        }



        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("RetriveWebService.aspx");
        }

        protected void alphaClick(object sender, EventArgs e){
            exceptionText = "";
            LinkButton btn = (LinkButton)sender;
            string enteredText = btn.Text.Substring(0,1);
            
            string uri = "https://www.digitalmeasures.com/login/service/v4/User/INDIVIDUAL-ACTIVITIES-PublicHealth?lastName=" + enteredText;
            CredentialCache credentialCache = new CredentialCache();
            credentialCache.Add(new Uri("https://www.digitalmeasures.com"), "Basic", new NetworkCredential("uic/web_service_health", "B3rgJN559xq"));
            HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;

            request.AllowAutoRedirect = true;
            request.PreAuthenticate = true;
            request.Credentials = credentialCache;
            request.AutomaticDecompression = DecompressionMethods.GZip;


            request.Method = "GET";
            HttpWebResponse response = null;
            try
            {
                ExceptionRegion.InnerHtml = exceptionText;
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
                    if (nodeList.Count.Equals(0))
                    {
                        exceptionText = "***PERSON NOT FOUND***";
                        ExceptionRegion.InnerHtml = exceptionText;
                        GridView1.DataSource = "";
                        GridView1.DataBind();
                    }
                    else
                    {
                        DataSet myDataSet = new DataSet();
                        byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(root.OuterXml);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
                        myDataSet.ReadXml(ms);
                        GridView1.DataSource = myDataSet.Tables[0];
                        GridView1.DataBind();
                    }
                    /*

                    DataSet myDataSet = new DataSet();
                    byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(root.OuterXml);
                    System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
                    myDataSet.ReadXml(ms);
                    GridView1.DataSource = myDataSet.Tables[0];
                    GridView1.DataBind();

                    */
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
        }

 
        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            GridView1.DataSource = null;
            GridView1.DataBind();
            if (DropDownList1.SelectedValue != null)
            {
                string enteredText = DropDownList1.SelectedValue;
                string uri = "https://www.digitalmeasures.com/login/service/v4/User/INDIVIDUAL-ACTIVITIES-PublicHealth/DEPARTMENT:" + enteredText;
                CredentialCache credentialCache = new CredentialCache();
                credentialCache.Add(new Uri("https://www.digitalmeasures.com"), "Basic", new NetworkCredential("uic/web_service_health", "B3rgJN559xq"));
                HttpWebRequest request = WebRequest.Create(uri) as HttpWebRequest;

                request.AllowAutoRedirect = true;
                request.PreAuthenticate = true;
                request.Credentials = credentialCache;
                request.AutomaticDecompression = DecompressionMethods.GZip;



                request.Method = "GET";
                HttpWebResponse response = null;
                try
                {

                    ExceptionRegion.InnerHtml = exceptionText;
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
                        if (nodeList.Count>0) { 
                        DataSet myDataSet = new DataSet();
                        byte[] buf = System.Text.ASCIIEncoding.ASCII.GetBytes(root.OuterXml);
                        System.IO.MemoryStream ms = new System.IO.MemoryStream(buf);
                        myDataSet.ReadXml(ms);
                        GridView1.DataSource = myDataSet.Tables[0];
                        GridView1.DataBind();
                        }
                        /////////////////////////////////////////
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
            }

        }


    }

}
