Public Class frmInformation

    Private Sub btnBeginOrder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeginOrder.Click
        ' This code is executed when the user clicks the
        ' Begin Order button. It sees if text was entered 
        ' and if a table is chosen


        If Me.txtName.Text <> "" Then
            frmMenu.Show()
            Me.Hide()
        Else
            MsgBox("Please enter your name before you advance.", , "InputError")
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelpInfo.Click
        ' This code is executed when the use clicks
        ' help. It speaks an introduction to you.

        Dim Speech
        Speech = CreateObject("SAPI.spvoice")
        Speech.Speak("Please enter your name and table number, then click Begin Order.")

    End Sub

    Private Sub frmInformation_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ' When the form loads the text is cleared and
        ' focus is on the textbox.

        Me.txtName.Text = ""
        Me.numTable.Value = 1

    End Sub
End Class