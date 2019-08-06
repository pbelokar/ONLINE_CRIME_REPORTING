<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CriminalRegister.aspx.cs" Inherits="CriminalRecordManagement.CriminalRegister" MasterPageFile ="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
        <div>
            <table>

                <tr>
                    <td>
                        <asp:Label ID="lblCriminalNo" runat="server" Text="Criminal No.:"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtCriminalNo" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="crName" runat="server" Text="Criminal Name :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtCriminalName" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblNickName" runat="server" Text="Nick Name :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtcrNickName" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAge" runat="server" Text="Age :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtAge" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblOccupation" runat="server" Text="Occupation :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtOccupation" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblCrimeType" runat="server" Text="Crime Type :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtCrimeType" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblAddress" runat="server" Text="Address :"></asp:Label>

                    </td>
                    <td>
                        <asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>

                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblMostWanted" runat="server" Text="MostWanted :"></asp:Label>

                    </td>
                    <td>
                   
                        <asp:RadioButtonList ID="rdmostWated" runat="server" RepeatDirection ="Horizontal"></asp:RadioButtonList>

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

                        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>

                    </td>
                   
                </tr>

            </table>
        </div>
    </asp:Content>

