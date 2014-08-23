Imports ICnU.Utility.Http
Imports System.IO
Imports System.Collections.Specialized

Namespace Services
    Public Class Imgur
        Implements IDisposable
#Region "Declerations"

        Private http As Utility.Http = Nothing

#End Region

#Region "Structures"

        Public Structure Result
            Dim Success As Boolean
            Dim ErrMsg As String
            Dim iLink As String
            Dim DirectLink As String
        End Structure

#End Region

#Region "Properties"

        Private _filepath As String = String.Empty
        Public Property FilePath As String
            Get
                Return _filepath
            End Get
            Set(ByVal value As String)
                _filepath = value
            End Set
        End Property

        Public ReadOnly Property FileName As String
            Get
                Return New FileInfo(FilePath).Name
            End Get
        End Property

        Private ReadOnly Property FileExtension As String
            Get
                Return New FileInfo(FilePath).Extension
            End Get
        End Property

        Private ReadOnly Property Headers As NameValueCollection
            Get
                Dim _Headers As New NameValueCollection
                _Headers.Add("X-Requested-With", "XMLHttpRequest")
                _Headers.Add("Pragma", "no-cache")
                _Headers.Add("Cache-Control", "no-cache")
                Return _Headers
            End Get
        End Property

        Private ReadOnly Property Fields As NameValueCollection
            Get
                Dim _fields As New NameValueCollection
                _fields.Add("album_title", "Optional Album Title")
                _fields.Add("layout", "b")
                Return _fields
            End Get
        End Property

        Private ReadOnly Property UploadArgs As UploadData
            Get
                Return New UploadData(File.ReadAllBytes(FilePath), FileName, "file")
            End Get
        End Property

#End Region

#Region "Constructor"

        Public Sub New()
            Me.NewSession()
        End Sub

        Public Sub New(ByVal imagepath As String)
            Me.NewSession()
            FilePath = imagepath
        End Sub

        Public Sub New(ByVal imagepath As String, ByRef result As Result)
            Me.NewSession()
            FilePath = imagepath
            result = Upload()
        End Sub

#End Region

#Region "Private Methods"

        Private Sub NewSession()
            If Not IsNothing(http) Then http.Dispose()
            http = New Utility.Http
        End Sub

        Private Function GetHash() As String
            Dim res As HttpResponse = http.GetResponse(Verb._GET, "http://imgur.com/")
            If Not IsNothing(res.RequestError) Then Throw New Exception(res.RequestError.Message)
            Return http.ParseBetween(res.Html, "var sid_hash   = '", "';", "var sid_hash   = '".Length)
        End Function

#End Region

#Region "upload"

        Public Function Upload() As Result

            If Not IsNothing(http) Then http.Dispose()
            Me.NewSession()

            With http

                Dim Result As New Result
                Try
                    .TimeOut = -1
                    .Accept = "application/json, text/javascript, */*; q=0.01"
                    .Referer = "http://imgur.com/"
                    Dim res As HttpResponse = .GetResponse(Verb._POST, String.Format("http://imgur.com/upload?sid_hash={0}", GetHash()), Headers, Fields, UploadArgs)
                    If Not IsNothing(res.RequestError) Then
                        Result.ErrMsg = res.RequestError.Message
                    Else
                        Dim postfix As String = .ParseBetween(res.Html, """hash"":""", """", """hash"":""".Length)
                        Result.Success = True
                        Result.iLink = "http://imgur.com/" & postfix
                        Result.DirectLink = "http://imgur.com/" & postfix & FileExtension
                    End If
                Catch ex As Exception
                    Result.ErrMsg = ex.Message
                End Try
                Return Result

            End With

        End Function

#End Region

#Region "Destructor"

        Private disposedValue As Boolean '
        Protected Overridable Sub Dispose(ByVal disposing As Boolean)
            If Not Me.disposedValue Then
                If disposing Then
                    If Not IsNothing(http) Then http.Dispose()
                End If
            End If
            Me.disposedValue = True
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Dispose(True)
            GC.SuppressFinalize(Me)
        End Sub

#End Region

    End Class

End Namespace
