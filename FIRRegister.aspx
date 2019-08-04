<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FIRRegister.aspx.cs" Inherits="CriminalRecordManagement.FIRRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>

        <tr>
            <td>FIR No. :
            </td>
            <td>
                <asp:TextBox ID="txtFirNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Complaint No. :
            </td>
            <td>
                <asp:TextBox ID="txtComplaintNo" runat="server"></asp:TextBox>
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
            <td>Time :
            </td>
            <td>
                <asp:TextBox ID="txtTime" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Type of Information :
            </td>
            <td>
                <asp:TextBox ID="txtTypeofInformation" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Place of Occurance :
            </td>
            <td>
                <asp:TextBox ID="txtPlaceofOccurance" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Foreign/Local :
            </td>
            <td>
                <asp:TextBox ID="txtForeignLocal" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Act :
            </td>
            <td>
                <asp:TextBox ID="txtAct" runat="server"></asp:TextBox>
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
            <td>Informant Address :
            </td>
            <td>
                <asp:TextBox ID="txtInformantAddress" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Passport No. :
            </td>
            <td>
                <asp:TextBox ID="txtPassportNo" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Police Officer :
            </td>
            <td>
                <asp:TextBox ID="txtPoliceOfficer" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Received Time:
            </td>
            <td>
                <asp:TextBox ID="txtReceivedTime" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>Information Received :
            </td>
            <td>
                <asp:TextBox ID="txtInformationReceived" runat="server"></asp:TextBox>
            </td>
        </tr>

        <tr>
            <td>
                <asp:Button ID="btnSave" runat="server" Text="Save" />
            </td>
            <td>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>

    </table>
</asp:Content>
