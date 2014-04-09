<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Peakbyte.UI.Web._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>Calculator</h1>

    </div>

    <div class="row">
        <div class="col-md-4">
            <div class="form-group">
                <label for="operations">Operation</label>
                <select class="form-control" id="operations">
                    <option value="1">Add</option>
                    <option value="2">Subtract</option>
                    <option value="3">Multiply</option>
                    <option value="4">Divide</option>
                </select>
            </div>
            <div class="form-group">
                <label for="operand1">First operand</label>
                <input class="form-control" type="text" id="operand1" />
            </div>
            <div class="form-group">
                <label for="operand2">Second operand</label>
                <input class="form-control" type="text" id="operand2" />
            </div>
            <div class="form-group">
                <button class="form-control" id="calculate">Calculate</button>
            </div>

        </div>
    </div>
    <%: Scripts.Render("~/scripts/app/app.js") %>
</asp:Content>
