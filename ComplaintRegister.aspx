<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComplaintRegister.aspx.cs" Inherits="CriminalRecordManagement.ComplaintRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server" >

    <style type='text/css'>
        body { background-image: url(images/Complaint_Register.jpg); height:100%; width:100%; background-size:cover; }
    </style>

    <tr>
    <td><table>

        <tr>
            <td>Complaint No. :
            </td>
            <td>
                <asp:TextBox ID="txtComplaintNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Name :
            </td>
            <td>
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Occupation :
            </td>
            <td>
                <asp:TextBox ID="txtOccupation" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Details of Suspect:
            </td>
            <td>
                <asp:TextBox ID="txtDetailsofSuspect" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Age :
            </td>
            <td>
                <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Sex:
            </td>
            <td>
                <asp:TextBox ID="txtSex" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td> Father's / Husband's Name :
            </td>
            <td>
                <asp:TextBox ID="txtFatherHusbandName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Complaint Date :
            </td>
            <td>
                <asp:TextBox ID="txtComplaintDate" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Nationality :
            </td>
            <td>
                <asp:TextBox ID="txtNationality" runat="server"></asp:TextBox>
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
                <asp:Label ID="lblMessage" runat ="server" Text ="" ForeColor ="Green"></asp:Label>
            </td>
            
        </tr>

    </table>

    </td>
</tr>

</asp:Content>
