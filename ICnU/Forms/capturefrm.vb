Public Class capturefrm
    Private imagei As Image
    Private MoveControl As New MoveControl(Me)
    Public ReadOnly Property CapImage As Image
        Get
            Return imagei
        End Get
    End Property

    Private Sub capturefrm_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        CaptureRec()
    End Sub

    Private Sub capturefrm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.C Then CaptureRec()
        If e.KeyCode = Keys.Enter Then CaptureRec()
    End Sub

    Private Sub CaptureRec()
        Me.Hide()
        imagei = SCapture.ScreenRectangle(New Rectangle(Me.Location.X, Me.Location.Y, Me.Width - 1, Me.Height - 1), Properties.IncludeCursor)
    End Sub

End Class