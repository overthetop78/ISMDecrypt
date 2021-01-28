Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"ISM Decrypt Version {My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor} Rev. {My.Application.Info.Version.Revision}"
        'Ouverture d'une boite de dialogue demandant l'installation de Widevine sur Chrome. 
        Dim ResultExtChrome = MsgBox("Widevine Chrome Extension isn't installed ?", vbApplicationModal + vbYesNo + vbExclamation, "Widevine Chrome Extension")
        ' si ce n'est pas installé, on va ouvrir le dossier a dezipper et un fichier texte avec le bloc-note pour donner les infos 
        If MsgBoxResult.No Then
            Dim Proc As New Process
            Proc.Start()
        End If
    End Sub
End Class
