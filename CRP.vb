Public Class CRP
    Shared tc As Int32
    Shared Property TickCount() As Int32
        Get
            Return tc
        End Get
        Set(ByVal value As Int32)
            tc = value
        End Set
    End Property

    Private Sub cmdCr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCr.Click
        Me.Text = "Criptografando"
        txtCr.Text = Nothing
        Cursor = Cursors.WaitCursor
        prgSt.Maximum = Criptografia.Texto.Length
        For Each c As Char In Criptografia.Texto
            If AscW(c) = 10 Then
                txtCr.Text = txtCr.Text & "#pg"
            Else
                txtCr.Text = txtCr.Text & ChrW(AscW(c) + 17) & ChrW(AscW(c) + 34) & ChrW(AscW(c) + 51) & _
                ChrW(AscW(c) + 68) & ChrW(AscW(c) + 85)
            End If
            prgSt.PerformStep()
            lblPrVl.Text = prgSt.Value & "%"
        Next
        lblPrVl.Text = "0%"
        Cursor = Cursors.Default
        prgSt.Value = 0
        Me.Text = My.Application.Info.Title
    End Sub

    Private Sub cmdDc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDc.Click
        Me.Text = "Descriptografando"
        txtDr.Text = Nothing
        Cursor = Cursors.WaitCursor
        Dim c() As Char = Descriptografia.Texto
        prgSt.Maximum = Descriptografia.Texto.Length
        For i = 0 To UBound(c)
            If i + 1 < UBound(c) Then
                Do
                    If Chr(Asc(c(i))) = "#" And _
                        Chr(Asc(c(i + 1))) = "p" And _
                        Chr(Asc(c(i + 2))) = "g" Then
                        txtDr.Text = txtDr.Text & Chr(13)
                        If i < UBound(c) - 3 Then
                            i += 3
                        Else
                            Exit For
                        End If
                    End If
                Loop Until (Chr(Asc(c(i))) = "#" And _
                    Chr(Asc(c(i + 1))) = "p" And _
                    Chr(Asc(c(i + 2))) = "g") = False
            End If
            txtDr.Text = txtDr.Text & ChrW(AscW(c(i)) - 17)
            i += 4
            prgSt.PerformStep()
            lblPrVl.Text = prgSt.Value & "%"
        Next
        Cursor = Cursors.Default
        lblPrVl.Text = "0%"
        prgSt.Value = 0
        Me.Text = My.Application.Info.Title
    End Sub

    Private Sub cmdAb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAb.Click
        dlgAb.Title = "Abrir"
        If dlgAb.ShowDialog = Windows.Forms.DialogResult.OK Then
            If Arquivo.Versão(dlgAb.FileName) = Programa.Versão Then
                If Arquivo.Criador(dlgAb.FileName) = Programa.Nome Then
                    If Arquivo.Tipo(dlgAb.FileName) = 0 Then
                        Dim d() As String = IO.File.ReadAllLines(dlgAb.FileName, System.Text.Encoding.Default)
                        txtCr.Text = ""
                        For i = 1 To UBound(d)
                            For Each c As Char In d(i)
                                txtCr.Text = txtCr.Text & c
                            Next c
                        Next i
                    ElseIf Arquivo.Tipo(dlgAb.FileName) = 1 Then
                        Dim d() As String = IO.File.ReadAllLines(dlgAb.FileName, System.Text.Encoding.Default)
                        txtDr.Text = ""
                        For i = 1 To UBound(d)
                            For Each c As Char In d(i)
                                txtDr.Text = txtDr.Text & c
                            Next c
                        Next i
                    End If
                End If
            End If
        End If
    End Sub

    Private Sub cmdLmCr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLmCr.Click
        txtCr.Text = ""
    End Sub

    Private Sub cmdLmDr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLmDr.Click
        txtDr.Text = ""
    End Sub

    Private Sub cmdSvDr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSvDr.Click
        dlgSv.Title = "Salvar texto descriptografado"
        If dlgSv.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileOpen(1, dlgSv.FileName, 2)
            PrintLine(1, "type=decrypted program=" & Programa.Nome & " version=" & _
                      Programa.Versão & " date=" & Date.Today)
            Print(1, txtDr.Text)
            FileClose(1)
        End If
    End Sub

    Private Sub cmdSvCr_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSvCr.Click
        dlgSv.Title = "Salvar texto criptografado"
        If dlgSv.ShowDialog = Windows.Forms.DialogResult.OK Then
            FileOpen(1, dlgSv.FileName, 2)
            For Each c As Char In ("type=decrypted program=" & Programa.Nome & " version=" & _
                      Programa.Versão & " date=" & Date.Today)
                Print(1, ChrW(AscW(c) + 17) & ChrW(AscW(c) + 34) & ChrW(AscW(c) + 51) & _
                ChrW(AscW(c) + 68) & ChrW(AscW(c) + 85))
            Next
            PrintLine(1)
            Dim d() As Char = txtCr.Text
            For i = 0 To UBound(d)
                If i + 1 < UBound(d) Then
                    Do
                        If d(i) = "#" And _
                            d(i + 1) = "p" And _
                            d(i + 2) = "g" = True Then
                            PrintLine(1)
                            i += 1
                        Else
                            Exit Do
                        End If
                    Loop Until d(i) = "#" And _
                    d(i + 1) = "p" And _
                    d(i + 2) = "g" = False
                End If
                Print(1, d(i))
            Next i
            FileClose(1)
        End If
    End Sub
    ''' <summary>
    ''' Permite acesso a informações básicas sobre o programa em uso.
    ''' </summary>
    ''' <remarks></remarks>
    Class Programa
        ''' <summary>
        ''' Retorna a versão do programa que está sendo usado.
        ''' </summary>
        Shared ReadOnly Property Versão() As String
            Get
                Return My.Application.Info.Version.Major & "." & My.Application.Info.Version.Minor & "." & _
                        My.Application.Info.Version.Build & "." & My.Application.Info.Version.Revision
            End Get
        End Property
        Shared ReadOnly Property Nome() As String
            Get
                Return My.Application.Info.Title
            End Get
        End Property
    End Class
    ''' <summary>
    ''' Permite acesso à leitura de metadados do arquivo.
    ''' </summary>
    ''' <remarks></remarks>
    Class Arquivo
        Enum TipoDeArquivo
            Encrypted = 0
            Decrypted = 1
        End Enum
        ''' <summary>
        ''' Retorna se o tipo do arquivo selecionado é criptografado ou não.
        ''' </summary>
        ''' <param name="arquivo">Caminho completo do arquivo.</param>
        Shared ReadOnly Property Tipo(ByVal arquivo As String) As TipoDeArquivo
            Get
                Dim d() As String = IO.File.ReadAllLines(arquivo, System.Text.Encoding.Default)
                For i = 0 To UBound(d)
                    If d(i).ToLower.StartsWith("type=") = False Then
                        Return 0
                    End If
                    Dim n() As String
                    n = Split(d(i), " ")
                    Dim p() As String
                    For j = 0 To UBound(n)
                        p = Split(n(0), "=")
                        If Trim(p(1)).ToLower = "decrypted" Then
                            Return 1
                        End If
                    Next
                Next
            End Get
        End Property
        ''' <summary>
        ''' Retorna o criador do arquivo, i.e., quais dos sistemas SAKCript gerou o arquivo.
        ''' </summary>
        ''' <param name="arquivo">Caminho completo do arquivo.</param>
        Shared ReadOnly Property Criador(ByVal arquivo As String) As String
            Get
                If Tipo(arquivo) = 1 Then
                    Dim d() As String = IO.File.ReadAllLines(arquivo, System.Text.Encoding.Default)
                    For i = 0 To UBound(d)
                        Dim n() As String
                        n = Split(d(i), " ")
                        Dim p() As String
                        For j = 0 To UBound(n)
                            p = Split(n(1), "=")
                            Return Trim(p(1))
                        Next
                    Next
                ElseIf Tipo(arquivo) = 0 Then
                    Dim d() As String = IO.File.ReadAllLines(arquivo, System.Text.Encoding.Default)
                    For i = 0 To UBound(d)
                        Dim n() As String
                        n = Split(d(i), ChrW(AscW(" ") + 17) & ChrW(AscW(" ") + 34) & ChrW(AscW(" ") + 51) & _
                ChrW(AscW(" ") + 68) & ChrW(AscW(" ") + 85))
                        Dim p() As String
                        For j = 0 To UBound(n)
                            p = Split(n(1), ChrW(AscW("=") + 17) & ChrW(AscW("=") + 34) & ChrW(AscW("=") + 51) & _
                ChrW(AscW("=") + 68) & ChrW(AscW("=") + 85))
                            Return Trim(p(1))
                        Next
                    Next
                End If
            End Get
        End Property
        ''' <summary>
        ''' Retorna a versão do programa usada para criar o arquivo.
        ''' </summary>
        ''' <param name="arquivo">Caminho completo do arquivo.</param>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Shared ReadOnly Property Versão(ByVal arquivo As String) As String
            Get
                If Tipo(arquivo) = 1 Then
                    Dim d() As String = IO.File.ReadAllLines(arquivo, System.Text.Encoding.Default)
                    For i = 0 To UBound(d)
                        Dim n() As String
                        n = Split(d(i), " ")
                        Dim p() As String
                        For j = 0 To UBound(n)
                            p = Split(n(2), "=")
                            Return Trim(p(1))
                        Next
                    Next
                ElseIf Tipo(arquivo) = 0 Then
                    Dim d() As String = IO.File.ReadAllLines(arquivo, System.Text.Encoding.Unicode)
                    For i = 0 To UBound(d)
                        Dim n() As String
                        n = Split(d(i), ChrW(AscW(" ") + 17) & ChrW(AscW(" ") + 34) & ChrW(AscW(" ") + 51) & _
                            ChrW(AscW(" ") + 68) & ChrW(AscW(" ") + 85))
                        Dim p() As String
                        p = Split(n(2), ChrW(AscW("=") + 17) & ChrW(AscW("=") + 34) & ChrW(AscW("=") + 51) & _
                            ChrW(AscW("=") + 68) & ChrW(AscW("=") + 85))
                        Return p(1)
                    Next
                End If
            End Get
        End Property
        ''' <summary>
        ''' Retorna a data de criação do arquivo.
        ''' </summary>
        ''' <param name="arquivo">Caminho completo do arquivo.</param>
        ''' <value></value>
        ''' <returns></returns>
        ''' <remarks></remarks>
        Shared ReadOnly Property Data(ByVal arquivo As String) As Date
            Get
                If Tipo(arquivo) = 1 Then
                    Dim d() As String = IO.File.ReadAllLines(arquivo, System.Text.Encoding.Default)
                    For i = 0 To UBound(d)
                        Dim n() As String
                        n = Split(d(i), " ")
                        Dim p() As String
                        For j = 0 To UBound(n)
                            p = Split(n(3), "=")
                            Return Convert.ToDateTime(Trim(p(1)))
                        Next
                    Next
                ElseIf Tipo(arquivo) = 0 Then
                    Dim d() As String = IO.File.ReadAllLines(arquivo, System.Text.Encoding.Default)
                    For i = 0 To UBound(d)
                        Dim n() As String
                        n = Split(d(i), ChrW(AscW(" ") + 17) & ChrW(AscW(" ") + 34) & ChrW(AscW(" ") + 51) & _
                ChrW(AscW(" ") + 68) & ChrW(AscW(" ") + 85))
                        Dim p() As String
                        For j = 0 To UBound(n)
                            p = Split(n(3), ChrW(AscW("=") + 17) & ChrW(AscW("=") + 34) & ChrW(AscW("=") + 51) & _
                ChrW(AscW("=") + 68) & ChrW(AscW("=") + 85))
                            Return Trim(p(1))
                        Next
                    Next
                End If
            End Get
        End Property
    End Class
    Class Descriptografia
        Shared dtx As String
        ''' <summary>
        ''' Retorna o conteúdo do campo "Texto criptografado".
        ''' </summary>
        ''' <returns>Retorna todo o texto que será descriptografado.</returns>
        ''' <remarks></remarks>
        Shared Property Texto() As String
            Get
                Return CRP.txtCr.Text
            End Get
            Set(ByVal value As String)
                dtx = value
            End Set
        End Property
    End Class
    Class Criptografia
        Shared ctx As String
        ''' <summary>
        ''' Retorna o conteúdo do campo "Texto descriptografado".
        ''' </summary>
        ''' <returns>Retorna todo o texto que será criptografado.</returns>
        ''' <remarks></remarks>
        Shared Property Texto() As String
            Get
                Return CRP.txtDr.Text
            End Get
            Set(ByVal value As String)
                ctx = value
            End Set
        End Property
    End Class
End Class