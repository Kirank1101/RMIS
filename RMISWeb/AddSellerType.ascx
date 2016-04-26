<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AddSellerType.ascx.cs" Inherits="AddSellerType" %>

<asp:Panel ID="pnlSellerType" runat="server">
    <asp:Repeater ID="rptSellerType" runat="server">
    <HeaderTemplate>
              <table>
              <tr>
                 <th><asp:Label runat="server" ID="lblHSellerType" 
                    text="<%$Resources:Resource,SellerType%>" ></asp:Label></th>
                 <th>"<asp:Label runat="server" ID="lblHObsInd" 
                    text="<%$Resources:Resource,IsSellerTypeDeleted%>" ></asp:Label></th>
              </tr>
          </HeaderTemplate>

          <ItemTemplate>
          <tr>
              <td >
                <asp:Label runat="server" ID="lblSellerType" 
                    text='<%# Eval("SellerType") %>' />
              </td>
              <td >
                  <asp:Label runat="server" ID="lblObsInd" 
                      text='<%# Eval("Indicator") %>' />
              </td>
          </tr>
          </ItemTemplate>          

          <FooterTemplate>
              </table>
          </FooterTemplate>

    </asp:Repeater>

    <table>
    <tr>
    <th><asp:Label runat="server" ID="lblHSellerType" 
                    text="<%$Resources:Resource,SellerType%>" ></asp:Label></th>
                     <td >
                  <asp:TextBox runat="server" ID="txtSellerType" 
                       />
                                     </td>

    </tr>

    <tr>
    <td>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            onclick="btnSubmit_Click" />
        <asp:Button ID="btnCancel"
            runat="server" Text="Cancel" />
    
    
    </td>
    </tr>
    </table>


</asp:Panel>
