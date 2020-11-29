<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MailOrchestra.WebbApp._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

	<div class="col-md-9">
                <details class="importantMails" open>
                    <summary> НУЖНО ОБРАТИТЬ ВНИМАНИЕ</summary>
                    <table class="table">
                        <tbody>
                            <tr>
                                <td class="mailCheckbox"><input type="checkbox"></td>
                                <td class="mailFrom">Mark@sberbank.ru</td>
                                <td class="mailSubject">Сопровождение АИС<span class="mailPreview"> - Просьба приложить
                                        в виде инструкции...</span></td>
                                <td class="mailDate">2019-02-01 09:51:45+00:00</td>
                                <td><input class="star" type="checkbox"></td>
                            </tr>
                            <tr>
                                <td class="mailCheckbox"><input type="checkbox"></td>
                                <td class="mailFrom">Jacob@sberbank.ru</td>
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
                </details>
                <details class="unimportantMails">
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
                </details>
            </div>

</asp:Content>
