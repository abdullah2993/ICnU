Public NotInheritable Class Properties
    Public Shared ReadOnly Property IncludeCursor As Boolean
        Get
            Return My.Settings.Ic
        End Get
    End Property

    Public Shared ReadOnly Property IncludeME As Boolean
        Get
            Return My.Settings.Im
        End Get
    End Property

    Public Shared ReadOnly Property UploadInstantly As Boolean
        Get
            Return My.Settings.Ui
        End Get
    End Property

    Public Shared ReadOnly Property ShowImage As Boolean
        Get
            Return My.Settings.SI
        End Get
    End Property

End Class
