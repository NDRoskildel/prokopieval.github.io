'<moduleinfo>
'   Creator: © Ivan Abramov "Простой софт"
'   Created: 2012-10-09
'   Description: 
'</moduleinfo>

Option Explicit On
Option Strict Off

Imports System.Data
Imports System.Drawing
Imports System.Diagnostics
Imports System.Web.UI.WebControls
Imports Microsoft.VisualBasic
Imports SSCommon

Partial Class SimpleSite
    Inherits System.Web.UI.Page

    Private m_dtSource As DataTable
    Private m_sFolder As String

    '// EVENTS ///////////////////////////////////////////////////////////////////////////////////////////////

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'm_sFolder = BuildPath(Session("AppFolder"), "\App_Data\")
        'm_sFolder = Replace(m_sFolder, "Simple-soft", "SimpleSite", Compare:=CompareMethod.Text)
        m_sFolder = "C:\inetpub\wwwroot\SimpleSite\App_Data\"

        If Not Page.IsPostBack Then
            m_dtSource = GetFilesInFolderDataTable(m_sFolder, sFilesPattern:="*.mdb", bRemoveExtention:=True)
            SSCommon.FillComboByDataTable(ddlDbFiles, m_dtSource, "DemoDatabaseWeb.mdb", sField:="FileName", sItemDataField:="FileName")
            ddlDbFiles.SelectedIndex = GetListIndexByText(ddlDbFiles, "DemoDatabaseWeb")
        End If

        'lblMessage.Text = m_sFolder
        'lblMessage.ForeColor = Color.White
    End Sub

End Class
