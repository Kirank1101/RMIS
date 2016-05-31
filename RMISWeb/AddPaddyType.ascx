﻿<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddPaddyType.ascx.cs" Inherits="AddPaddyType" %>
<%@ Register Assembly="RMIS.CustomControls" Namespace="RMIS.CustomControls" TagPrefix="asp" %>
<div class="table-responsive">

<asp:PagingGridView ID="rptPaddyType"  runat="server"  AllowSorting="true" 
					 AllowPaging="True" CellPadding="4"  PageSize="5" AutoGenerateColumns="false"
                    					 SelectedIndex="0"   OrderBy="">
					<Columns>
                    <asp:TemplateField >
   
        <HeaderTemplate>
            <table class="table table-striped table-bordered">
                <thead>
                    <tr>
                        <th>
                            <asp:Label runat="server" ID="lblHPaddyType" Text="<%$Resources:Resource,PaddyType%>"></asp:Label>
                        </th>
                        <th>
                            <asp:Label runat="server" ID="lblHObsInd" Text="<%$Resources:Resource,IsPaddyDeleted%>"></asp:Label>
                        </th>
                    </tr>
                </thead>
        </HeaderTemplate>
        <ItemTemplate>
            <tbody>
                <tr>
                    <td>
                        <asp:Label runat="server" ID="lblPaddyType" Text='<%# Eval("PaddyType") %>' />
                    </td>
                    <td>
                        <asp:Label runat="server" ID="lblObsInd" Text='<%# Eval("Indicator") %>' />
                    </td>
                </tr>
            </tbody>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
        </asp:TemplateField>
    </Columns>
				  <PagerSettings Mode="NumericFirstLast" />	
				</asp:PagingGridView>
				
				
    <table>
        <tr>
            <td>
                <h4>
                    Paddy Type</h4>
            </td>
            <td>
                <asp:TextBox runat="server" ID="txtPaddyType" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnSubmit" runat="server" Text="Submit" OnClick="btnSubmit_Click" />
                <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
            </td>
        </tr>
    </table>
</div>