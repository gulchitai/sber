<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MailOrchestra.WebbApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<div class="col-md-9">
                <details class="importantMails" open>
                    <summary> <%= SelectedGroupName %></summary>
	                <table class="table">
	                <tbody>
			                <% foreach(var item in MailItems){ %>
				                <tr>
					                <td class="mailCheckbox"><input type="checkbox"></td>
					                <td class="mailFrom"><%=item.From %></td>
					                <td class="mailSubject"><%= item.Subj %></span></td>
					                <td class="mailDate"><%=item.Date.ToShortDateString() %></td>
					                <td><input class="star" type="checkbox"></td>
				                </tr>
			                <% } %>
	                </tbody>
	                </table>
                </details>
               <%-- <details class="unimportantMails">
                    <summary> МОЖНО ОТЛОЖИТЬ</summary>
                    <table class="table">
                        <tbody>
                            <tr>
                                <td class="mailCheckbox"><input type="checkbox"></td>
                                <td class="mailFrom">Larry@sberbank.ru</td>
                                <td class="mailSubject">Сопровождение АИС<span class="mailPreview"> - Просьба приложить
                                        в виде инструкции...</span></td>
                                <td class="mailDate">2019-02-01 09:51:45+00:00</td>
                                <td><input class="star" type="checkbox"></td>
                            </tr>
                            <tr>
                                <td class="mailCheckbox"><input type="checkbox"></td>
                                <td class="mailFrom">Larry@sberbank.ru</td>
                                <td class="mailSubject">Сопровождение АИС<span class="mailPreview"> - Просьба приложить
                                        в виде инструкции...</span></td>
                                <td class="mailDate">2019-02-01 09:51:45+00:00</td>
                                <td><input class="star" type="checkbox"></td>
                            </tr>
                            <tr>
                                <td class="mailCheckbox"><input type="checkbox"></td>
                                <td class="mailFrom">Larry@sberbank.ru</td>
                                <td class="mailSubject">Сопровождение АИС<span class="mailPreview"> - Просьба приложить
                                        в виде инструкции...</span></td>
                                <td class="mailDate">2019-02-01 09:51:45+00:00</td>
                                <td><input class="star" type="checkbox"></td>
                            </tr>
                        </tbody>
                    </table>
                </details>--%>
            </div>

</asp:Content>
