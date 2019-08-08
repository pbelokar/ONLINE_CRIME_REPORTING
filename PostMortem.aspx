<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PostMortem.aspx.cs" Inherits="CriminalRecordManagement.PostMortem" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style type='text/css'>
        body { background-image: url(images/Post_Mortem.png); height:100%; width:100%; background-size:cover; }
    </style>
    
    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
            <label for="title" class="col-sm-2 col-form-label">Post Mortem</label>

        </div>

        <div class="form-group row">
            <label for="lblPostmortemNo" class="col-sm-2 col-form-label">Postmortem No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtPostMortelNo" placeholder="Postmortem No." disabled runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblFIRNo" class="col-sm-2 col-form-label">FIR No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtFirNo" placeholder="FIR No" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblResultOfMortem" class="col-sm-2 col-form-label">Result:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtResultofMortem" placeholder="Result of Mortem" runat="server">
            </div>
        </div>

         <div class="form-group row">
            <label for="lblSex" class="col-sm-2 col-form-label">Sex:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtSex" placeholder="Sex" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblDateOfDeath" class="col-sm-2 col-form-label">Date of Death:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtDateofDeath" placeholder="Date of Death" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblDescriptionOfCase" class="col-sm-2 col-form-label">Description:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtDescriptionofCase" placeholder="Description of Case" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblHouseName" class="col-sm-2 col-form-label">House Name:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtHouseName" placeholder="House Name" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblDoctorsName" class="col-sm-2 col-form-label">Doctor's Name:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtDrName" placeholder="Doctor's Name" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblPoliceStation" class="col-sm-2 col-form-label">Police Station:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtPoliceStation" placeholder="Police Station" runat="server">
            </div>
        </div>
<div class="form-group row" style="text-align: center">
               <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click"/>
                <asp:Button ID="btnCancel" runat="server" Text="Cancel"/>
</div>
        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
</asp:Content>
