<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="CriminalRecordManagement.Register" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <div>  
            <table class="auto-style1">  
                <tr>  
                    <td>FirstName :</td>  
                    <td>  
                        <asp:TextBox ID="txtfirstName" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr> 
                <tr>  
                    <td>LastName :</td>  
                    <td>  
                        <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>  
                    </td>  
  
               </tr>
                <tr>  
                    <td>UserName :</td>  
                    <td>  
                        <asp:TextBox ID="txtusername" runat="server" Height="22px"></asp:TextBox>  
                    </td>  
  
               </tr>
                <tr>  
                    <td>Password :</td>  
                     <td> <asp:TextBox ID="txtpassword" runat="server" TextMode="Password"></asp:TextBox></td>  
                </tr>  
                <tr>  
                    <td>  
                        <asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" />  
                    </td> 
                    <td>  
                        <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />  
                    </td> 
                </tr> 
                
                  <tr>  
                    <td colspan ="2">  
                        <asp:Label ID="lblMessage" runat="server" ForeColor="Green"></asp:Label>
                        <asp:Label ID="lblContinueLogin" runat="server" ForeColor="Black"></asp:Label>
                    </td>  
                </tr> 

            </table>  
        </div>  

</asp:Content>
