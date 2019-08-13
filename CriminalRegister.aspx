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

    <%--  <tr>
        <td>--%>
    <%--<div class="form-group" style="background-color: white; width: 700px; padding: 10px;">

                <div class="form-group row">
                    <label for="inputPassword" class="col-sm-2 col-form-label">Criminal No.:</label>
                    <div class="col-sm-10">
                        <input type="text" class="form-control" id="inputPassword" placeholder="Criminal No.">
                    </div>
                </div>

            </div>--%>


    <%--   <table>--%>
    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
            <label for="title" class="col-sm-2 col-form-label">Criminal Registration</label>

        </div>

        <div class="form-group row">
            <label for="lblCriminalNo" class="col-sm-2 col-form-label">Criminal No.:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtCriminalNo" placeholder="Criminal No." disabled runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblName" class="col-sm-2 col-form-label">Criminal Name:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtCriminalName" placeholder="Criminal Name" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblNickName" class="col-sm-2 col-form-label">Nick Name:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtcrNickName" placeholder="Criminal Nick Name" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblAge" class="col-sm-2 col-form-label">Age :</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtAge" placeholder="Age" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblCrimeType" class="col-sm-2 col-form-label">Crime Type :</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtCrimeType" placeholder="CrimeType" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblAddress" class="col-sm-2 col-form-label">Address :</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtAddress" placeholder="Address of criminal" runat="server">
            </div>
        </div>
        <div class="form-group row">
            <label for="lblMostWanted" class="col-sm-2 col-form-label">Most Wanted : &nbsp;</label>
            <%--<asp:Label ID="lblMostWanted" runat="server" Text="MostWanted :"></asp:Label>--%>
            <div class="col-sm-10">
                <%--<asp:RadioButtonList ID="rdmostWated" runat="server" RepeatDirection ="Horizontal"></asp:RadioButtonList>--%>
                <input class="form-check-input" type="radio" id="rdmostWatedYes" name="rdmostWated" runat="server" value="Yes" />&nbsp;Yes
                        <input class="form-check-input" type="radio" id="rdmostWatedNo" name="rdmostWated" runat="server" value="No" />&nbsp;No
            </div>
        </div>

        <div class="form-group row" style="text-align: center">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />&nbsp;&nbsp;&nbsp;&nbsp;

                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>

        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
    </div>
    <%--</table>--%>

    <%--  </td>
    </tr>--%>
</asp:Content>

