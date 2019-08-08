<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserManagement.aspx.cs" Inherits="CriminalRecordManagement.UserManagement" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row">
            <label for="lblName" class="col-sm-2 col-form-label">Users :</label>
            <div class="col-sm-10">

                <asp:DropDownList ID="ddlUserNames" runat="server">
                </asp:DropDownList>&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnapprove" runat="server" Text="Approve" OnClick="btnapprove_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnreject" runat="server" Text="Reject" OnClick="btnreject_Click" />
            </div>
        </div>

        <div>
            <asp:GridView ID="grdUser" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Userid" HeaderText="User ID" />
                    <asp:BoundField DataField="UserName" HeaderText="User Name" />
                    <asp:BoundField DataField="FirstName" HeaderText="First Name" />
                    <asp:BoundField DataField="LastName" HeaderText="Last Name" />
                    <asp:BoundField DataField="RoleId" HeaderText="Role Id" />
                    <asp:BoundField DataField="IsActive" HeaderText="Active" />
                </Columns>
            </asp:GridView>
        </div>
    </div>
</asp:Content>
