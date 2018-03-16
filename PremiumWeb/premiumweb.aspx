<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="premiumweb.aspx.cs" Inherits="PremiumWeb.premiumweb" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Testing</title>    
    <link rel="StyleSheet" href="Style.css" />    

</head>
<body>
    <h1>Software Testing</h1>
    <form id="form" runat="server">
        <div class="div">
            <asp:Label runat="server" AssociatedControlID="TextboxGender">Gender</asp:Label>
            <asp:TextBox runat="server" ID="TextboxGender"></asp:TextBox>
            <br />
            <asp:Label runat="server" AssociatedControlID="TextboxAge">Age</asp:Label>
            <asp:TextBox runat="server" ID="TextboxAge"></asp:TextBox>
            <br />
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </div>

        <div class="div">            
            <div>
                <asp:Label runat="server" ID="Gender">Gender: </asp:Label>
            </div>
            <div>
                <asp:Label runat="server" ID="Age">Age: </asp:Label>
            </div>
            <div>
                <asp:Label runat="server" ID="Premium">Premium: </asp:Label>
            </div>
        </div>
    </form>
  </body>
</html>
