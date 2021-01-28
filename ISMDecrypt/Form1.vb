Imports System.IO.Compression
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = $"ISM Decrypt Version {My.Application.Info.Version.Major}.{My.Application.Info.Version.Minor} Rev. {My.Application.Info.Version.Revision}"
        'Ouverture d'une boite de dialogue demandant l'installation de Widevine sur Chrome. 
        Dim ResultExtChrome = MsgBox("Widevine Chrome Extension isn't installed ?", vbApplicationModal + vbYesNo + vbExclamation, "Widevine Chrome Extension")
        ' si ce n'est pas installé, on va ouvrir le dossier a dezipper et un fichier texte avec le bloc-note pour donner les infos 
        If MsgBoxResult.No Then
            Try
                MsgBox("Widevine is installed in Documents Folder", vbApplicationModal + vbOKOnly + vbInformation, "Information")
                If IO.Directory.Exists($"{PathDocument}\Widevine\") = False Then
                    ZipFile.ExtractToDirectory(WidevineL3Zip, $"{PathDocument}\Widevine\", False)
                End If
                ' Process.Start("explorer.exe", $"{PathDocument}\Widevine\")
                Process.Start(ChromeApp, PageExtension)

            Catch ex As Exception
                MsgBox($"Error: {ex.Message}{vbCrLf} Folder Addon or files not found.", vbApplicationModal + vbExclamation + vbOKOnly, $"Error {ex.HResult}")
                ' L'erreur est présente mais on continue quand même 
            End Try
        End If
        'On doit aussi décompresser le fichier Bento.zip dans le dossier de l'application
        If IO.File.Exists(DecryptApp) = False Then
            Try
                MsgBox("Bento is installed in Util Folder", vbApplicationModal + vbOKOnly + vbInformation, "Information")
                ZipFile.ExtractToDirectory(BentoZip, $"{PathUtil}", False)

            Catch ex As Exception
                MsgBox($"Error: {ex.Message}{vbCrLf} Folder Addon or files not found.", vbApplicationModal + vbExclamation + vbOKOnly, $"Error {ex.HResult}")
            End Try
        End If
    End Sub
End Class
