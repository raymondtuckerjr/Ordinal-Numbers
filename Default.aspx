<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Ordinal Number</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Ordinal Numbers</h1>
             <hr />

            <p>
                Cardinal number:
                <asp:TextBox ID="cardinalNumber" runat="server" />
                <asp:CompareValidator ID="numValidator" runat="server" type="Integer" ControlToValidate="cardinalNumber" Operator="DataTypeCheck">You must enter an integer greater than 0 </asp:CompareValidator><br /> Ordinal Number: <asp:Label ID="ordinalNumber" runat="server" />
                </p>
            <p>
                <asp:Button ID="convert" runat="server" Text="Convert" />
            </p>
        </div>
    </form>
</body>
</html>
