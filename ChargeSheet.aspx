<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ChargeSheet.aspx.cs" Inherits="CriminalRecordManagement.ChargeSheet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <style type='text/css'>
        body {
            background-image: url(images/Charge_Sheet.jpg);
            height: 100%;
            width: 100%;
            background-size: cover;
        }
    </style>

    <div class="form-group" style="background-color: white; width: 500px; padding: 10px;">

        <div class="form-group row col-sm-10" style="text-align: center; width: 152%">
            <label for="title" class="col-sm-2 col-form-label">Charge Sheet</label>

        </div>

        <div class="form-group row">
            <label for="lblChargeSheet" class="col-sm-2 col-form-label">Charge Sheet No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtChargeSheetNo" placeholder="Charge Sheet No." disabled runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblNameOfPoliceStation" class="col-sm-2 col-form-label">Police Station:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtNameofPoliceStation" placeholder="Name of Police Station" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblDate" class="col-sm-2 col-form-label">Date:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtDate" placeholder="Date (YYYY/MM/DD HH24:MI:SS)" runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblFirNo" class="col-sm-2 col-form-label">FIR No:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtFIRNo" placeholder="FIR No." runat="server">
            </div>
        </div>

        <div class="form-group row">
            <label for="lblDistrict" class="col-sm-2 col-form-label">District:</label>
            <div class="col-sm-10">
                <input type="text" class="form-control" id="txtDistrict" placeholder="District" runat="server">
            </div>
        </div>

        <div class="form-group row" style="text-align: center">
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>

        <asp:Label ID="lblMessage" runat="server" Text="" ForeColor="Green"></asp:Label>

    </div>

</asp:Content>
