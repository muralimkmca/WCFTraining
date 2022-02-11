<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="WCFConsume._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-3.6.0.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("#Button2").click(function () {
              
                var val1 = 5;
                var val2 = 10;
                $.ajax({
                    url: "http://localhost:90/Service.svc/GetData",
                    method: "post",
                    contentType: "application/json:charset=utf-8",
                    data: JSON.stringify({ value1: val1, value2: val2 }),
                    dataType: "json",
                    success: function (data) { data },
                    error: function (err) { alert(err);}
                });
            });
        });
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </div>
        <p>
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Button"  />
        </p>
    </form>
</body>
</html>
