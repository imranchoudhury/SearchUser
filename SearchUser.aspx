<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchUser.aspx.cs" Inherits="FacultyProfile.SearchUser" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">

    <link type="text/css" rel="stylesheet" href="http://drupal2.sph.uic.edu/sites/default/files//css/css_pbm0lsQQJ7A7WCCIMgxLho6mI_kBNgznNUWmTWcnfoE.css" media="all" />
<link type="text/css" rel="stylesheet" href="http://drupal2.sph.uic.edu/sites/default/files//css/css_vZ7OMldNxT0kN_1nW7_5iIquAxAdcU-aJ-ucVab5t40.css" media="all" />
<link type="text/css" rel="stylesheet" href="http://drupal2.sph.uic.edu/sites/default/files//css/css_PAK1MIyEgEk9Ho9-XDzVwTe4Zf3Ul_58Y7HhL7toz98.css" media="all" />
<style type="text/css" media="all">
<!--/*--><![CDATA[/*><!--*/
.md-layer-6-0-0{z-index:999 !important;color:#fdfdfd !important;text-align:justify;font-size:8.33333333333em;font-weight:800;font-family:"Open Sans";}

/*]]>*/-->
</style>
<link type="text/css" rel="stylesheet" href="http://drupal2.sph.uic.edu/sites/default/files//css/css_fF3Kvn-GuyrehhsMT63DK886jUtDT3g3YTVJcyCqW7Y.css" media="all" />
<link type="text/css" rel="stylesheet" href="http://fonts.googleapis.com/css?family=Open+Sans:400,600,800" media="all" />
<link type="text/css" rel="stylesheet" href="http://drupal2.sph.uic.edu/sites/default/files//css/css_mDsumyA3N03--8UBjNFzj0S8fPKLf-b6AGUIBHperUY.css" media="all" />
<link type="text/css" rel="stylesheet" href="http://drupal2.sph.uic.edu/sites/default/files//css/css_NO7dpxmyXAPMZmAlgUmG06qZdANUZP-XQfv1pDT5ll0.css" media="all" />
<style type="text/css" media="all">


    <style type="text/css">
        #form1 {
            height: 1947px;
            
        }

        body {
            
            background-repeat: no-repeat;
            background-position: initial;
            
            background-attachment: inherit;
        }

        div#alpha
        {
            margin-left: 100px;
        }
        #container {
            width: 800px;
            margin-left: 4px;
            margin-right: auto;
        }


        #SearchArea {
                     
        }


        #MainDisplay {
            height: 1654px;
            
        }

        #form {
            
        }

        #modalBackground {
            filter: alpha(opacity=80);
            opacity: 0.8;
            z-index: 10000;
        }
    </style>





<body>
    <div id="container">
         <div>
          <div id="SearchArea">
              <form id="form1" runat="server" class="auto-style1" align="left">


                  <div id="#alpha">
                 
                <asp:LinkButton ID="LinkButton8" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 183px; position: absolute; height: 19px; width: 12px; bottom: 8px;" ForeColor="Maroon">H|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton7" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left:161px; position: absolute; height: 13px; width: 13px; " ForeColor="Maroon">G|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton6" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 143px; position: absolute; width: 12px" ForeColor="Maroon">F|</asp:LinkButton>                    
                <asp:LinkButton ID="LinkButton5" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 126px; position: absolute; height: 15px; width: 12px; " ForeColor="Maroon">E|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton4" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 107px;  position: absolute; height: 16px; right: 1468px; width: 14px" ForeColor="Maroon">D|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton3" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 88px; position: absolute; height: 19px; width: 20px; right: 1481px;" ForeColor="Maroon">C|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton2" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 70px; position: absolute; height: 16px; width: 15px; right: 1504px;" ForeColor="Maroon">B|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton1" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 51px; position: absolute; height: 19px; width: 14px; right: 1524px;" ForeColor="Maroon">A|</asp:LinkButton>
          

                <asp:LinkButton ID="LinkButton26" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 532px; position: absolute; height: 17px; width: 10px" ForeColor="Maroon">Z|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton25" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 513px; position: absolute; height: 17px; width: 13px; bottom: 161px; right: 1061px;" ForeColor="Maroon">Y|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton18" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 408px; position: absolute; height: 17px; width: 12px; bottom: 33px" ForeColor="Maroon">T|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton13" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 270px; position: absolute; height: 18px; width: 16px; right: 1303px;" ForeColor="Maroon">M|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton12" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 253px; position: absolute; height: 17px; width: 12px; right: 1324px;" ForeColor="Maroon">L|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton11" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 233px; position: absolute; height: 14px; width: 14px" ForeColor="Maroon">K|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton10" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 218px; position: absolute; height: 18px; width: 9px" ForeColor="Maroon">J|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton9" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 203px; position: absolute; height: 18px; width: 10px; right: 1376px;" ForeColor="Maroon">I|</asp:LinkButton>
               
               
                   
                

                <asp:LinkButton ID="LinkButton20" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 390px; position: absolute; height: 17px; width: 10px;" ForeColor="Maroon">S|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton14" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 371px; position: absolute; width: 13px; height: 17px;" ForeColor="Maroon">R|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton19" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 350px; position: absolute; height: 17px; width: 12px" ForeColor="Maroon">Q|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton21" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; position: absolute; height: 16px; width: 11px; left: 494px;" ForeColor="Maroon">X|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton22" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 469px; position: absolute; height: 18px; width: 17px" ForeColor="Maroon">W|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton23" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; position: absolute; height: 17px; width: 8px; left: 448px;" ForeColor="Maroon">V|</asp:LinkButton>
                <asp:LinkButton ID="LinkButton24" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 426px; position: absolute; height: 17px; width: 13px; right: 1150px;" ForeColor="Maroon">U|</asp:LinkButton>
                   <asp:LinkButton ID="LinkButton15" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 334px; position: absolute; height: 17px; width: 9px; right: 1246px; bottom: 36px;" ForeColor="Maroon">P|</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton16" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 312px; position: absolute; height: 16px; width: 11px; right: 1266px; bottom: 37px;" ForeColor="Maroon">O|</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton17" runat="server" Font-Bold="True" OnClick="alphaClick" Style="top: 130px; left: 293px; position: absolute; height: 18px; width: 18px; bottom: 35px;" ForeColor="Maroon">N|</asp:LinkButton>

                  
               
                     </div>
                  
                  
                  
                  <asp:Label ID="Label1" runat="server" Font-Bold="True" Style="top: 51px; left: 33px; position: absolute; height: 29px; width: 220px; right: 1336px;" Text="Enter Last Name" Font-Size="Large" Font-Names="Segoe UI Black" ForeColor="Maroon"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server" BackColor="White" Font-Bold="True" Style="top: 54px; left: 248px; position: absolute; height: 22px; width: 205px"></asp:TextBox>
                    <asp:Button ID="Button1" runat="server" Font-Bold="True" OnClick="Button1_Click" Style="top: 54px; left: 504px; position: absolute; height: 45px; width: 112px" Text="Search" BackColor="Maroon" Font-Names="Segoe UI" ForeColor="White" />
                    
                  
                  
                  <asp:DropDownList ID="DropDownList1" AppendDataBoundItems="true" AutoPostBack="True" runat="server" Style="top: 196px; left: 30px; position: absolute; height: 40px; width: 336px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                  
                        
                        <asp:ListItem Text="">Select a Division</asp:ListItem>
                        <asp:ListItem>Community Health Sciences</asp:ListItem>
                        <asp:ListItem Value="Environmental and Occupational Health Sciences">Environmental &amp; Occupational Health Sciences</asp:ListItem>
                        <asp:ListItem Value="Epidemiology and Biostatistics">Epidemiology &amp; Biostatistics</asp:ListItem>
                        <asp:ListItem Value="Health Policy and Administration">Health Policy &amp; Administration</asp:ListItem>
                      <asp:ListItem Value="Dean's Office">Dean's Office</asp:ListItem>
                      <asp:ListItem Value="Information Technology">Information Technology</asp:ListItem>
                    </asp:DropDownList>
                 
                <div id="noData"></div>
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderWidth="0px" CellPadding="4" Style="top: 254px; left: 23px; position: absolute; height: 145px; width: 557px" CellSpacing="2" Font-Names="Segoe UI" Font-Size="Large" BorderColor="White" GridLines="None" BorderStyle="None">
                    <AlternatingRowStyle BorderColor="White" BorderStyle="None" />
                    <Columns>

                        
                      



                        <asp:TemplateField HeaderText="First Name" HeaderStyle-ForeColor="white">
                             <ItemTemplate>
                             <a href='<%#"FacultyProfile.aspx?UserName="+DataBinder.Eval(Container.DataItem,"UserName") %>'><%#Eval("FirstName") %>
                                                          </ItemTemplate>
                        </asp:TemplateField>

                         <asp:TemplateField HeaderText="Last Name" HeaderStyle-ForeColor="white">
                             <ItemTemplate>
                             <a href='<%#"FacultyProfile.aspx?UserName="+DataBinder.Eval(Container.DataItem,"UserName") %>'><%#Eval("LastName") %>
                                                          </ItemTemplate>
                        </asp:TemplateField>
                                                
                         <asp:TemplateField HeaderText="NetID" HeaderStyle-ForeColor="white">
                             <ItemTemplate>
                             <a href='<%#"FacultyProfile.aspx?UserName="+DataBinder.Eval(Container.DataItem,"UserName") %>'><%#Eval("UserName") %>
                                                          </ItemTemplate>
                        </asp:TemplateField>
                        <asp:TemplateField HeaderText="Email" HeaderStyle-ForeColor="white">
                            <ItemTemplate>
                                
                          <a href="mailto:"+<%#DataBinder.Eval(Container.DataItem,"Email")%>><%#Eval("Email") %>
                                    
                                                                    </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>

                    <EditRowStyle BorderColor="White" BorderWidth="0px" />

                    <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                    <HeaderStyle BackColor="Maroon" Font-Bold="True" ForeColor="White" BorderColor="White" BorderStyle="None" Font-Names="Segoe UI" Font-Size="Large" />
                    <PagerStyle ForeColor="Black" HorizontalAlign="Right" BackColor="White" />
                    <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#F7F7F7" />
                    <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                    <SortedDescendingCellStyle BackColor="#E5E5E5" />
                    <SortedDescendingHeaderStyle BackColor="#242121" />

                </asp:GridView>
                


                   <div id="ExceptionRegion" runat="server" style="font-weight: bold; color:#800000; width: 600px; font-size:large; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div>
                
                  </form>

                </div>
                


            
        </div>
    </div>
</body>

</html>