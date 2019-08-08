<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="CriminalRecordManagement.Reports" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <%--<style type='text/css'>
        body {
            background-image: url(images/criminal-records-checks.jpg);
            height: 100%;
            width: 100%;
            background-size: cover;
        }
    </style>--%>



    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
            <label for="title" class="col-sm-2 col-form-label">Report</label>

        </div>

        

        <div class="form-group row">
            <label for="lblName" class="col-sm-2 col-form-label">Report Type :</label>
            <div class="col-sm-10">
                
                <asp:DropDownList ID="ddlSearch" runat="server">

                </asp:DropDownList>
            </div>
        </div>

        <div class="form-group row">
            <label for="lblNickName" class="col-sm-2 col-form-label"> Value :</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtSearch" placeholder="Search" runat="server">
            </div>
        </div>
              

        <div class="form-group row" style="text-align: center">
            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click"  />&nbsp;&nbsp;&nbsp;&nbsp;

                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>

        <div class="form-group row" style="text-align: center">
            <asp:GridView ID="grdReport" runat="server"></asp:GridView>
        </div>

        <%--<asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>--%>
    </div>

</asp:Content>
