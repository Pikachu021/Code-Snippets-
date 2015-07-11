
Partial Class Test
    Inherits System.Web.UI.Page

    Dim var As String 

    Protected Sub Page_Init(sender As Object, e As EventArgs) Handles Me.Init
        Dim onBlurScript = Page.ClientScript.GetPostBackEventReference(TextBox1, "OnBlur")
        TextBox1.Attributes.Add("onblur", onBlurScript)
    End Sub

    Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
        If IsPostBack Then
            Dim ctrName = Request.Params(Page.postEventSourceID)
            Dim args = Request.Params(Page.postEventArgumentID)
            HandleCustomPostbackEvent(ctrName, args)
        End If
    End Sub

    Protected Sub HandleCustomPostbackEvent(ctrName As String, args As String)
        If ctrName = TextBox1.UniqueID And args = "OnBlur" Then
            Response.Write("On Blur Event" + TextBox1.Text)
        End If
    End Sub

    Protected Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        var = "Hola mundo!"
        Response.Write("Button Event Fired")
    End Sub


End Class
