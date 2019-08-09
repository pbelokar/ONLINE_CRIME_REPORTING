<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ComplaintRegister.aspx.cs" Inherits="CriminalRecordManagement.ComplaintRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type='text/css'>
        body {
            background-image: url(images/Complaint_Register.jpg);
            height: 100%;
            width: 100%;
            background-size: cover;
        }
    </style>

    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
            <label for="title" class="col-sm-2 col-form-label">Complaint Registration</label>
        </div>

        <div class="form-group row">
            <label for="lblComplaintNo" class="col-sm-2 col-form-label">Complaint No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtComplaintNo" placeholder="Complaint No." disabled runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblName" class="col-sm-2 col-form-label">Name:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtName" placeholder="Name" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblOccupation" class="col-sm-2 col-form-label">Occupation:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtOccupation" placeholder="Occupation" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblDetailsOfSuspect" class="col-sm-2 col-form-label">Details:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtDetailsofSuspect" placeholder="Details of Suspect" runat="server">
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
            <label for="lblSex" class="col-sm-2 col-form-label">Guardian Name:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtFatherHusbandName" placeholder="Father's / Husband's Name" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblComplaintDate" class="col-sm-2 col-form-label">Complaint Date:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtComplaintDate" placeholder="Complaint Date (YYYY/MM/DD HH24:MI:SS)" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblNationality" class="col-sm-2 col-form-label">Nationality:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtNationality" placeholder="Nationality" runat="server">
            </div>
        </div>

        <div class="form-group row" style="text-align: center">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>

        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
</asp:Content>
