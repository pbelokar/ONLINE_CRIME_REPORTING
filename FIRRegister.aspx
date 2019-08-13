<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FIRRegister.aspx.cs" Inherits="CriminalRecordManagement.FIRRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <style type='text/css'>
        body { background-image: url(images/fir.jpg); height:100%; width:100%; background-size:cover; }
    </style>
    
    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
            <label for="title" class="col-sm-2 col-form-label">FIR Registration</label>

        </div>

        <div class="form-group row">
            <label for="lblFIRNo" class="col-sm-2 col-form-label">FIR No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtFirNo" placeholder="FIR No." disabled runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblComplaintNo" class="col-sm-2 col-form-label">Complaint No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtComplaintNo" placeholder="Complaint No" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblDate" class="col-sm-2 col-form-label">Date:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtDate" placeholder="Date of FIR (YYYY/MM/DD hh24:mi:ss)" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblTypeOfInformation" class="col-sm-2 col-form-label">Information:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtTypeofInformation" placeholder="Information type" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblPlaceOfOccurance" class="col-sm-2 col-form-label">Place of Occurance:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtPlaceofOccurance" placeholder="Place of Occurance" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblForeignLocal" class="col-sm-2 col-form-label">Nationality:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtForeignLocal" placeholder="Nationality" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblAct" class="col-sm-2 col-form-label">Action done:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtAct" placeholder="Action done" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblInformantAddress" class="col-sm-2 col-form-label">Informant Address:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtInformantAddress" placeholder="Informant Address" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblPoliceOfficer" class="col-sm-2 col-form-label">On Duty Officer:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtPoliceOfficer" placeholder="Police Officer on Duty" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblReceivedTime" class="col-sm-2 col-form-label">Received Time:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtReceivedTime" placeholder="Received Time (hh24:mi:ss)" runat="server">
            </div>
        </div>

         <div class="form-group row">
            <label for="lblInformationReceived" class="col-sm-2 col-form-label">Received information:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtInformationReceived" placeholder="Information Received" runat="server">
            </div>
        </div>
<div class="form-group row" style="text-align: center">
                <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
</div>

                <asp:Label ID="lblMessage" runat="server" Text ="" ForeColor="Green"></asp:Label>

</div>
</asp:Content>
