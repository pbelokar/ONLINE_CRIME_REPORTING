<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MostWanted.aspx.cs" Inherits="CriminalRecordManagement.MostWanted" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <table>

        <style type='text/css'>
            body {
                background-image: url(images/Most-Wantedjpg.jpg);
                height: 100%;
                width: 100%;
                background-size: cover;
            }
        </style>

        <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

            <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
                <label for="title" class="col-sm-2 col-form-label">Most Wanted</label>

            </div>

            <div class="form-group row">
                <label for="lblID" class="col-sm-2 col-form-label">ID:</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="txtID" placeholder="Most Wanted ID" runat="server">
                </div>
            </div>

            <div class="form-group row">
                <label for="lblName" class="col-sm-2 col-form-label">Name:</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="txtName" placeholder="Name" runat="server">
                </div>
            </div>

            <div class="form-group row">
                <label for="lblNickName" class="col-sm-2 col-form-label">Nick Name:</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="txtNickName" placeholder="Nick Name" runat="server">
                </div>
            </div>

            <div class="form-group row">
                <label for="lblAge" class="col-sm-2 col-form-label">Age:</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="txtAge" placeholder="Age" runat="server">
                </div>
            </div>

                        <div class="form-group row">
                <label for="lblSex" class="col-sm-2 col-form-label">Sex:</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="txtSex" placeholder="Sex (M/F)" runat="server">
                </div>
            </div>

                       <div class="form-group row">
                <label for="lblDescription" class="col-sm-2 col-form-label">Description:</label>
                <div class="col-sm-10">
                    <input type="text" class="form-control" id="txtDescription" placeholder="Description" runat="server">
                </div>
            </div>

<div class="form-group row" style="text-align: center">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
</div>

                <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
</asp:Content>
