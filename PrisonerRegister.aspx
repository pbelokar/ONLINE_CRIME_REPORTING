<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PrisonerRegister.aspx.cs" Inherits="CriminalRecordManagement.PrisonerRegister" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type='text/css'>
        body {
            background-image: url(images/Prisoner_Register.jpg);
            height: 100%;
            width: 100%;
            background-size: cover;
        }
    </style>

    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
            <label for="title" class="col-sm-2 col-form-label">Prisoner Register</label>

        </div>

        <div class="form-group row">
            <label for="lblPrisonerNo" class="col-sm-2 col-form-label">Prisoner No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtPrisonerNo" placeholder="Prisoner No." disabled runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblChargeSheetNo" class="col-sm-2 col-form-label">ChargeSheet No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtChargeSheetNo" placeholder="ChargeSheet No." runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblTypeOfCrime" class="col-sm-2 col-form-label">Crime:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtTypeofCrime" placeholder="Type of Crime" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblIdentificationMark" class="col-sm-2 col-form-label">ID Mark:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtIdentificationMark" placeholder="Identification Mark" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblHeight" class="col-sm-2 col-form-label">Height:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtHeight" placeholder="Height" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblWeight" class="col-sm-2 col-form-label">Weight:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtWeight" placeholder="Weight" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblColor" class="col-sm-2 col-form-label">Color:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtColor" placeholder="Color" runat="server">
            </div>
        </div>

        <div class="form-group row" style="text-align: center">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>
</asp:Content>
