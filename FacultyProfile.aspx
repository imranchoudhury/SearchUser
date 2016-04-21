<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FacultyProfile.aspx.cs" Inherits="FacultyProfile.FacultyProfile" %>
    <!-- <link href="Content/Site.css" rel="stylesheet" /> -->


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



    <style type="text/css">
        #form1 {
            height: 850px;
           
        }

        body {
           
            background-repeat: no-repeat;
            background-position: initial;
            
        }


        #container {
            width: 800px;
            margin-left: 4px;
            margin-right: auto;
        }

        #header {
            
            text-align: center;
            height: 88px;
            position: relative;
            padding: 40px;
          
            top: 30px;
            left: 0px;
        }

        #SearchArea {
            height: 60px;
            width: 786px;
            margin-left: 0px;
            bottom: 200px;
            top: 200px;
               
            display: table-cell;
            vertical-align: middle;
    
            
        }


        #MainDisplay {
            padding: 10px;
            height: 275px;
            
           
            top: 70px;
            width: 856px;
            left:0px;
            margin-top: 0px;
        }
        .TextBox1 {
            left:25%;width:50%;height:50%;top:25%;

        }
              

        #form {
            
        }

        #modalBackground {
            filter: alpha(opacity=80);
            opacity: 0.8;
            z-index: 10000;
        }

        #BIOName
        {
            width: 600px;
            border-bottom: solid hidden red;
        }
        
        #AcademicbackgroundName {
            width: 600px;
          
           border-bottom: solid 0px red;
        }
        #TeachingInterestName {
            width: 600px;
            
           border-bottom: solid 0px red;
        }
        #ResearchInterestName {
            width: 600px;
           
            border-bottom: solid 0px red;
        }
        #PublicationName {
            width: 600px;
           
            border-bottom: solid 0px red;
        }
        ul.b {
            
            list-style-type: square;

        }

    #BIO
    {
        width: 660px;
    }
        #AcademicBackground
        {
            width: 660px;

        }
        #TeachingInterest
        {
            width: 660px;
        }
        #ResearchInterest
        {
            width: 660px;
        }
        #Publication
        {
            width: 660px;
        }
          #Awards
        {
            width: 660px;
        }
          #AdminAssignments
          {
             width: 660px;
        }
        
        
        
         <!--From Drupal-->

        p {
    font-size: 14px;
}

p {
    font-family: "HelveticaNeue-Light", "Helvetica Neue Light", "Helvetica Neue", Helvetica, Arial, "Lucida Grande", sans-serif; 
   font-weight: 300;
} 

h2 {
    color:#FF2A2A;
}

h3 {
    color:#007ACC; font-weight: bold;
}

strong {
    font-weight: 900;
}


em {
    font-style: italic;
}

ol {
    list-style-type: square; font-size: 14px;
}



        
    </style>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
   
 

<body>
    <div id="modalBackground">
        <div id="container">
       

            <form id="form1" runat="server" class="auto-style1">

               

                <div id="SearchArea" style="clear:left">
                    <asp:Button ID="Button2" runat="server" Font-Bold="True" OnClick="Button2_Click" Style="top: 10px; left: 21px; position: absolute; height: 48px; width: 123px" Text="Back" Font-Size="Medium" BackColor="Maroon" ForeColor="White" />
                </div>

                <div id="MainDisplay" runat="server" >
                    <asp:Label ID="Label7" runat="server"  Style="top: 154px; left: 244px; position: absolute; height: 16px; width: 457px" ForeColor="#333333" Font-Names="Segoe UI" Font-Size="Medium" Font-Bold="True"></asp:Label>
                                        <asp:Label ID="Label20" runat="server" Style="top: 237px; left: 244px; position: absolute; height: 16px; width: 498px" ForeColor="Maroon" Font-Names="Segoe UI" Font-Size="Medium"></asp:Label>
                    <asp:Label ID="Label9" runat="server" Style="top: 281px; left: 244px; position: absolute; height: 21px; width: 323px" Font-Names="Segoe UI" ForeColor="Maroon" Font-Size="Medium"></asp:Label>
                    <asp:Label ID="Label14" runat="server" Font-Bold="False" Font-Size="Medium" Style="top: 260px; left: 244px; position: absolute; height: 19px; width: 302px" Font-Italic="False" ForeColor="Maroon"></asp:Label>
                    <asp:Label ID="Label12" runat="server" Font-Bold="True" Font-Size="XX-Large" Style="top: 90px; left: 244px; position: absolute; height: 38px; width: 460px; right: 660px" Font-Names="Segoe UI Black" ForeColor="Maroon"></asp:Label>
                    <asp:Label ID="Label8" runat="server" Style="top: 174px; left: 244px; position: absolute; height: 21px; width: 467px" Font-Names="Segoe UI" ForeColor="Maroon" Font-Size="Medium"></asp:Label>
                                        <asp:Label ID="Label21" runat="server" Style="top: 216px; left: 244px; position: absolute; height: 16px; width: 498px" ForeColor="Maroon" Font-Names="Segoe UI" Font-Size="Medium"></asp:Label>
                                        <asp:Label ID="Label22" runat="server" Style="top: 195px; left: 244px; position: absolute; height: 16px; width: 498px" ForeColor="Maroon" Font-Names="Segoe UI" Font-Size="Medium"></asp:Label>
                                        <asp:Label ID="Label23" runat="server" Style="top: 133px; left: 244px; position: absolute; height: 16px; width: 498px" ForeColor="Maroon" Font-Names="Segoe UI" Font-Size="Medium"></asp:Label>
                </div>

                
                <div id="AdminAssignmentsName" runat="server" style="font-weight: bold; color:#800000; width: 600px; font-size:large; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div>
                <div id="AdminAssignments" runat="server" style="text-align:justify; color:black; font-size:14px;" >
                   </div>
                
                
                
                <div id="BIOName" runat="server" style="font-weight: bold; color:#800000; width: 600px; font-size:large; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div>
                <div id="BIO" runat="server" style="text-align:justify; color:black; font-size:14px;" >
                   </div>

                 <div id="AwardsName" runat="server" style="font-weight: bold; color:#800000; width: 600px; font-size:large; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div>
                <br />
                <div id="Awards" runat="server" style="text-align:justify; color:black; font-size:14px;" >
                   </div>
                


                <div id="AcademicbackgroundName" runat="server" style="font-weight: bold; color:#800000; width: 600px; font-size:large; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div> 
                
                
                <div id="AcademicBackground" runat="server" style="color:black; font-size:14px;" >
                   </div>
                
                <div id="TeachingInterestName" runat="server" style="font-weight: bold; color:#800000; width: 600px; font-size:large; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div>
                <div id="TeachingInterest" runat="server" style="text-align:justify; color:black; font-size:14px;" >
                   </div>

                <div id="ResearchInterestName" runat="server" style="font-weight: bold; color:#800000;  width: 600px;  font-size:large; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div>
                <div id="ResearchInterest" runat="server" style="text-align:justify; color:black; font-size:14px;" >
                   </div>

               <div id="PublicationName" runat="server" style="font-weight: bold; color:#800000; width: 600px;  font-size:large; margin-top: 0px; font-family: 'Segoe UI', Tahoma, Geneva, Verdana, sans-serif;">
                   </div>
                <br />
              <div id="Publication" runat="server" style="text-align:justify; color:black; font-size:14px;" >
                   </div>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=sph-sql2014-dev;Initial Catalog=FacultyProfile;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [images] FROM [FacultyImagePaths]"></asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="Data Source=sph-sql2014-dev;Initial Catalog=FacultyProfile;Integrated Security=True" SelectCommand="SELECT [images] FROM [FacultyImagePaths]"></asp:SqlDataSource>


                <asp:GridView ID="GridView1" BorderWidth="0" HorizontalAlign="Left" runat="server" ShowHeader="False" AutoGenerateColumns="False" Style="top: 83px; left: 18px; position: absolute; height: 218px; width: 198px">
                    <Columns>
                        <asp:ImageField DataImageUrlField="ImagePath"  ControlStyle-Width="190"   ControlStyle-Height = "225"  HeaderText="Preview Image" />
                    </Columns>
                </asp:GridView>


            </form>
        </div>
    </div>
</body>
</html>




