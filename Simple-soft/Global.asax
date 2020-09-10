<%@ Application Language="VB" %>

<script runat="server">
    '<moduleinfo>
    '   Creator: © Ivan Abramov "Простой софт"
    '   Created: 2012-10-10
    '   Description: project Simple-Soft
    '</moduleinfo>

    '// Application //
    Sub Application_Start(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Sub Application_End(ByVal sender As Object, ByVal e As EventArgs) 'application shutdown 

    End Sub
    
    '// Session //
    Sub Session_Start(ByVal sender As Object, ByVal e As EventArgs)
        Session.Timeout = 540 '9 hours
        Session("AccessDb") = "SSClients.mdb"
        Session("AppFolder") = Server.MapPath("") '"C:\Inetpub\wwwroot\Simple-soft\" or "E:\Personal\Projects\Simple-soft"
        'Session("AppFolder") = SSCommon.TranslateToWebFolder(Session("AppFolder"), "Simple-soft") '"E:\Personal\Projects\SimpleSite" -> "C:\Inetpub\wwwroot\SimpleSite\"
        
    End Sub
</script>