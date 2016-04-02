<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ExerciseBase.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Exercise 5</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--a. Create a function--%>
            <table width="400px" align="center">
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblNumber" runat="server" Text="Enter a Number: "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtNumber" runat="server" ToolTip="Enter any number..." TextMode="Number"/>
                    </td>
                </tr>
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblString" runat="server" Text="Enter a word: "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtString" runat="server" ToolTip="Enter any word..."/>
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Button ID="btnProcess" runat="server" Text="Process" OnClick="btnProcess_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Label ID="lblResult" runat="server" Text="Test"/>
                    </td>
                </tr>
            </table>
            
            <%--b. Create another function--%>
            <table width="400px" align="center">
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblFirstNumber" runat="server" Text="Enter 1st Number: "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtFirstNumber" runat="server" ToolTip="Enter any number..." TextMode="Number"/>
                    </td>
                </tr>
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblSecondNumber" runat="server" Text="Enter 2nd Number : "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtSecondNumber" runat="server" ToolTip="Enter any number..." TextMode="Number" />
                    </td>
                </tr>
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblThirdNumber" runat="server" Text="Enter 3rd Number : "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtThirdNumber" runat="server" ToolTip="Enter any number..." TextMode="Number" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Label ID="lblTotal" runat="server" Text="Total"/>
                    </td>
                </tr>
            </table>

            <%--c. Create another function--%>
            <table width="400px" align="center">
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblNum1" runat="server" Text="Enter 1st Number: "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtNum1" runat="server" ToolTip="Enter any number..." TextMode="Number"/>
                    </td>
                </tr>
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblNum2" runat="server" Text="Enter 2nd Number : "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtNum2" runat="server" ToolTip="Enter any number..." TextMode="Number" />
                    </td>
                </tr>
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblNum3" runat="server" Text="Enter 3rd Number : "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtNum3" runat="server" ToolTip="Enter any number..." TextMode="Number" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Button ID="btnCalc2" runat="server" Text="Calculate" OnClick="btnCalc2_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Label ID="lblTotal2" runat="server" Text="Total"/>
                    </td>
                </tr>
            </table>

            <%--d. Create another function--%>
            <table width="400px" align="center">
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblBool" runat="server" Text="Enter T/F: "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtBool" runat="server" ToolTip="Enter T or F..." />
                    </td>
                </tr>
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblNumber2" runat="server" Text="Enter 2nd Number : "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtNumber2" runat="server" ToolTip="Enter any number..." TextMode="Number" />
                    </td>
                </tr>
                <tr valign="top">
                    <td align="right"><asp:Label ID="lblNumber3" runat="server" Text="Enter 3rd Number : "/>
                    </td>
                    <td align="left"><asp:TextBox ID="txtNumber3" runat="server" ToolTip="Enter any word..." TextMode="Number" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Button ID="btnProceed" runat="server" Text="Proceed" OnClick="btnProceed_Click" />
                    </td>
                </tr>
                <tr>
                    <td colspan="2" align="center"><asp:Label ID="lblOutPut" runat="server" Text="OutPut"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
