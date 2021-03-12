<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Mannschaftsverwaltung.aspx.cs" Inherits="Mannschaftsverwaltung.Views.Mannschaftsverwaltung" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">


    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        <nav id="navbar" runat="server" class="navbar navbar-expand-lg navbar-light bg-light">
          <a class="navbar-brand" href="http://localhost:44380/Views/Gate">Turnierverwaltung</a>
          <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarText" aria-controls="navbarText" aria-expanded="false" aria-label="Toggle navigation">
            <span class="navbar-toggler-icon"></span>
          </button>
          <div class="collapse navbar-collapse" id="navbarText">
            <ul class="navbar-nav mr-auto">
              <li class="nav-item active">
                <a class="nav-link" href="http://localhost:44380/Views/Gate">Home <span class="sr-only">(current)</span></a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="http://localhost:44330/Views/Personenverwaltung">Personenverwaltung</a>
              </li>
              <li class="nav-item">
                <a class="nav-link" href="#">Mannschaftsverwaltung</a>
              </li>
            </ul>
          </div>
        </nav>


            <div class="jumbotron row">
                  <div class="col-md-6">
                      <h1>
                          <br id="abstand1" runat="server" />
                          <asp:Label ID="Label1" runat="server" Text="Personenverwaltung"></asp:Label></h1>

                <asp:Button ID="addbtn" class="btn btn-primary btn-lg btn-block"  runat="server" Text="Person einfügen" Height="45px" Width="170px" />

                      


                      <asp:Table ID="tabl" runat="server" CssClass="table">
                          <asp:TableRow>
                              <asp:TableCell runat="server" ID="TableCell1">
                                  <asp:Label ID="Label2" runat="server" Text="Eine Sportart für die Mannschaft auswählen"></asp:Label>
                              </asp:TableCell>

                              <asp:TableCell runat="server" ID="sportartcell">
                                  <asp:DropDownList class = "form-control" ID="DropDownList2" runat="server" ForeColor="Black"  Height="32px" Width="104px">
                                        <asp:ListItem>Fußball</asp:ListItem>
                                        <asp:ListItem>Handball</asp:ListItem>
                                        <asp:ListItem>Tennis</asp:ListItem>

                                 </asp:DropDownList>
                              </asp:TableCell>  
                              
                              <asp:TableCell runat="server" ID="TableCell2">Name:</asp:TableCell>

                              <asp:TableCell runat="server" ID="namecell"><asp:TextBox ID="Nametxt" runat="server" CssClass="form-control"></asp:TextBox></asp:TableCell>
                             
                        </asp:TableRow>

                        <asp:TableRow>

                              <asp:TableCell runat="server" ID="Einsatzbereichcell1">    
                                        
                                   
                        <asp:CheckBoxList ID="DatenladenSQL" runat="server" CssClass=""> </asp:CheckBoxList>

                              </asp:TableCell>
                     
                             
                        </asp:TableRow>

                        
                      </asp:Table>

                     <br />
                      <br />
                           <asp:Button class="btn btn-danger" ID="abbtn1" runat="server" Text="Abbrechen" Width="183px"   BorderStyle="Solid" />
                           <asp:Button class="btn btn-success" ID="speicherbtn" runat="server" Text="Speichern" Width="183px"   BorderStyle="Solid" OnClick="speicherbtn_Click"  />
                           <asp:Button class="btn btn-success" ID="aenderungspeichernbtn" runat="server" Text="Änderungen speichern" Width="183px"   BorderStyle="Solid"/>

                     
                  </div>
                    <div id="startpage" runat="server" class="col-md-4">
                       <lottie-player src="https://assets2.lottiefiles.com/packages/lf20_spvnlrri.json"  background="transparent"  speed="1"  style="width: 600px; height: 300px;"  loop  autoplay>

                       </lottie-player>
                    </div>    

                    </div>

                <br />
            </div>


        </div>
    </form>
</body>
</html>
