<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChargeSheet.aspx.cs" Inherits="CriminalRecordManagement.ChargeSheet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type='text/css'>
        body { background-image: url(images/Charge_Sheet.jpg); height:100%; width:100%; background-size:cover; }
    </style>

    <tr>
    <td><table>

        <tr>
            <td>Charge Sheet No. :
            </td>
            <td>
                <asp:TextBox ID="txtChargeSheetNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Name of Police Station :
            </td>
            <td>
                <asp:TextBox ID="txtNameofPoliceStation" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Date :
            </td>
            <td>
                <asp:TextBox ID="txtDate" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>FIR No. :
            </td>
            <td>
                <asp:TextBox ID="txtFIRNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>District :
            </td>
            <td>
                <asp:TextBox ID="txtDistrict" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>

        <tr>
            <td colspan ="2">
                <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
            </td>
            
        </tr>

    </table>

    </td>
</tr>

</asp:Content>
