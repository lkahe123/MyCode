<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="test.aspx.cs" Inherits="WebUrl.test" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    


        <asp:Repeater ID="Repeater1" runat="server">
            <ItemTemplate>

                <%#Eval("name") %>
                <br />

            </ItemTemplate>
        </asp:Repeater>




    </div>
    </form>
</body>
</html>
