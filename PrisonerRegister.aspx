<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PrisonerRegister.aspx.cs" Inherits="CriminalRecordManagement.PrisonerRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td>Prisoner No. :
            </td>
            <td>
                <asp:TextBox ID="txtPrisonerNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>ChargeSheet No. :
            </td>
            <td>
                <asp:TextBox ID="txtChargeSheetNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Nick Name :
            </td>
            <td>
                <asp:TextBox ID="txtNickName" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Type of Crime :
            </td>
            <td>
                <asp:TextBox ID="txtTypeofCrime" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Family Member :
            </td>
            <td>
                <asp:TextBox ID="txtFamilyMember" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Identification Mark :
            </td>
            <td>
                <asp:TextBox ID="txtIdentificationMark" runat="server"></asp:TextBox>
            </td>
        </tr>

          <tr>
            <td>Height :
            </td>
            <td>
                <asp:TextBox ID="txtHeight" runat="server"></asp:TextBox>
            </td>
        </tr>

          <tr>
            <td>Weight :
            </td>
            <td>
                <asp:TextBox ID="txtWeight" runat="server"></asp:TextBox>
            </td>
        </tr>

             <tr>
            <td>Color :
            </td>
            <td>
                <asp:TextBox ID="txtColor" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text ="Save" OnClick="btnSave_Click"/>
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMessage" runat="server" Text="" ForeColor = "Green"></asp:Label>
            </td>
        </tr>

    </table>
</asp:Content>
