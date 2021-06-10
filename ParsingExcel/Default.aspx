<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ParsingExcel.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Parsing Excel File</title>
</head>
<body bgcolor="grey">
    <form id="form1" runat="server">
        <div style="color: Blue;">
            <h4>
                Article about Parsing Excel File
            </h4>
            <table>
                <tr>
                    <td>
                        Select Excel File
                    </td>
                    <td>
                        <asp:FileUpload ID="ExcelParse_fp" runat="server" />
                    </td>                    
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Parse_btn" runat="server" Text="Upload" OnClick="Parse_btn_Click" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
