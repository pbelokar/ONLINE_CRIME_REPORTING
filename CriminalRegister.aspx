<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CriminalRegister.aspx.cs" Inherits="CriminalRecordManagement.CriminalRegister" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <style type='text/css'>
        body {
            background-image: url(images/criminal-records-checks.jpg);
            height: 100%;
            width: 100%;
            background-size: cover;
        }
    </style>

    <tr>
        <td>
            <div class="form-group" style="background-color: white; width:700px; padding:10px;">

               <div class="form-group row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Criminal No.:</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="inputPassword" placeholder="Criminal No.">
                    </div>
                </div>

            </div>


            <table>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="lblCriminalNo" runat="server" Text="Criminal No.:"></asp:Label>

                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtCriminalNo1" runat="server" ></asp:TextBox>--%>

                        <input type="text" class="form-control" id="txtCriminalNo" runat="server">
                    </td>
                </tr>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="crName" runat="server" Text="Criminal Name :"></asp:Label>

                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtCriminalName" runat="server"></asp:TextBox>--%>
                        <input type="text" class="form-control" id="txtCriminalName" placeholder="Criminal Name" runat="server">
                    </td>
                </tr>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="lblNickName" runat="server" Text="Nick Name :"></asp:Label>


                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtcrNickName" runat="server"></asp:TextBox>--%>
                        <input type="text" class="form-control" id="txtcrNickName" placeholder="Nick Name" runat="server">
                    </td>
                </tr>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="lblAge" runat="server" Text="Age :"></asp:Label>

                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtAge" runat="server"></asp:TextBox>--%>
                        <input type="text" class="form-control" id="txtAge" placeholder="Age" runat="server">
                    </td>
                </tr>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="lblOccupation" runat="server" Text="Occupation :"></asp:Label>

                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtOccupation" runat="server"></asp:TextBox>--%>
                        <input type="text" class="form-control" id="txtOccupation" placeholder="Occupation" runat="server">
                    </td>
                </tr>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="lblCrimeType" runat="server" Text="Crime Type :"></asp:Label>

                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtCrimeType" runat="server"></asp:TextBox>--%>
                        <input type="text" class="form-control" id="txtCrimeType" placeholder="Crime Type" runat="server">
                    </td>
                </tr>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="lblAddress" runat="server" Text="Address :"></asp:Label>

                    </td>
                    <td>
                        <%--<asp:TextBox ID="txtAddress" runat="server"></asp:TextBox>--%>
                        <input type="text" class="form-control" id="txtAddress" placeholder="Address" runat="server">
                    </td>
                </tr>
                <tr style="background-color: white;">
                    <td>
                        <asp:Label ID="lblMostWanted" runat="server" Text="MostWanted :"></asp:Label>

                    </td>
                    <td>

                        <%--<asp:RadioButtonList ID="rdmostWated" runat="server" RepeatDirection ="Horizontal"></asp:RadioButtonList>--%>
                        <input class="form-check-input" type="radio" id="rdmostWatedYes" name="rdmostWated" runat="server" value="Yes" />&nbsp;Yes
                        <input class="form-check-input" type="radio" id="rdmostWatedNo" name="rdmostWated" runat="server" value="No" />&nbsp;No
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
                    <td colspan="2">

                        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>

                    </td>

                </tr>

            </table>

        </td>
    </tr>

</asp:Content>

