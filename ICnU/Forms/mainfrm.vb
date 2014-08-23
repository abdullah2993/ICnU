Imports System.Threading
Public Class mainfrm

    Private CImage As Image
    Private ReadOnly Property ImageFile As String
        Get
            Return Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) & "\capture_" & Guid.NewGuid.ToString & ".jpeg"
        End Get
    End Property

    Private _cfp As String = String.Empty
    Private Property CurrentImagePath As String
        Get
            Return _cfp
        End Get
        Set(ByVal value As String)
            _cfp = value
        End Set
    End Property
    Private Sub cfsbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cfsbtn.Click
        If Not Properties.IncludeME Then Me.WindowState = FormWindowState.Minimized
        CImage = SCapture.FullScreen(Properties.IncludeCursor)
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
        If Properties.ShowImage Then
            Using ShomImage As New ShowImage(CImage)
                ShomImage.ShowDialog()
            End Using
        End If
        save()
        If Properties.UploadInstantly Then
            Dim upload_thr As New Thread(AddressOf Upload)
            upload_thr.SetApartmentState(ApartmentState.STA)
            upload_thr.Start()
        End If
    End Sub

    Private Sub crbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles crbtn.Click
        If Not Properties.IncludeME Then Me.WindowState = FormWindowState.Minimized
        Using CapturReg As New capturefrm
            CapturReg.ShowDialog()
            CImage = CapturReg.CapImage
        End Using
        If Me.WindowState = FormWindowState.Minimized Then Me.WindowState = FormWindowState.Normal
        If Properties.ShowImage Then
            Using ShomImage As New ShowImage(CImage)
                ShomImage.ShowDialog()
            End Using
        End If
        save()
        If Properties.UploadInstantly Then
            Dim upload_thr As New Thread(AddressOf Upload)
            upload_thr.SetApartmentState(ApartmentState.STA)
            upload_thr.Start()
        End If
    End Sub

    Private Sub setbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles setbtn.Click
        Using _set As New settingsfrm
            _set.ShowDialog()
        End Using
    End Sub

    Private Sub minbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles minbtn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub exbtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles exbtn.Click
        Me.Close()
    End Sub

    Private Sub save()
        CurrentImagePath = ImageFile
        CImage.Save(CurrentImagePath, Imaging.ImageFormat.Jpeg)
    End Sub

    Private Sub Upload()
        Dim Result As New Services.Imgur.Result
        Using imgurupload As New Services.Imgur(CurrentImagePath, Result)
            If Result.Success Then
                MessageBox.Show("Image Uploaded", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Clipboard.SetText(Result.DirectLink)
            Else
                MessageBox.Show("Upload Failed: " & Result.ErrMsg, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Asterisk)
            End If
        End Using
    End Sub

End Class
