Public Class Form1


    Public Sub Alert(msg As String, type As frmAlert.alertTypeEnum)
        Dim f As frmAlert = New frmAlert
        f.setAlert(msg, type)
    End Sub
    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Alert("Success message", frmAlert.alertTypeEnum.Success)
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        Alert("Warning message", frmAlert.alertTypeEnum.Warning)
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Alert("Error message", frmAlert.alertTypeEnum.Error)
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        Alert("Info message", frmAlert.alertTypeEnum.Info)
    End Sub
End Class
