Module Variable
    Public WidevineL3Zip As String = $"{Application.StartupPath}\Addon\widevineL3Decryptor_Chrome_Extension.zip"
    Public DecryptApp As String = $"{Application.StartupPath}\Util\bin\mp4decrypt.exe"
    Public BentoZip As String = $"{Application.StartupPath}\Addon\Bento4.zip"
    Public PathDocument As String = $"{My.Computer.FileSystem.SpecialDirectories.MyDocuments}"
    Public PathUtil As String = $"{Application.StartupPath}\Util\"
    Public ChromeApp As String = $"{My.Computer.FileSystem.SpecialDirectories.ProgramFiles}\Google\Chrome\Application\chrome.exe"
    Public PageExtension As String = $"chrome{Chr(58)}//extensions"
End Module
