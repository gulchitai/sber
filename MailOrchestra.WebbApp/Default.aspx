<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MailOrchestra.WebbApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

		<div class="col-md-9">
				<div class="menu">
					<div class="menuBorder">
						<div class="menuBar">
							<i class="fas fa-check-square"></i>
							<i class="fas fa-chart-line"></i>
							<i class="fas fa-star"></i>
							<i class="fas fa-clock"></i>
							<i class="fas fa-exclamation-triangle"></i>
							<i class="fas fa-cog"></i>
							<i class="fas fa-user-alt"></i>
						</div>
					</div>
				</div>
                <details class="importantMails" open>
                    <summary> <%= SelectedGroupName %></summary>
	                <table class="table">
	                <tbody>
			                <% foreach(var item in MailItems){ %>
				                <tr>
					                <td class="mailCheckbox"><input type="checkbox"></td>
					                <td class="mailFrom"><%=item.From %></td>
					                <td class="mailSubject"><a href="MailEdit.aspx?id=<%= item.Num %>"><%= item.Subj %></a></span></td>
					                <td class="mailDate"><%=item.Date.ToShortDateString() %></td>
					                <td><input class="star" type="checkbox"></td>
				                </tr>
			                <% } %>
	                </tbody>
	                </table>
                </details>
            </div>
</asp:Content>
