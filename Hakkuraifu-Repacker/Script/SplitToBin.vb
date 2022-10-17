Imports System
Imports System.IO

Namespace SplitFile
    Class Program
        <Obsolete>
        Shared Sub SplitToBin(ByVal inputf As String, ByVal outputf As String, ByVal maxChunkSize As Long)
            'Dim maxChunkSize As Long

            Dim inputFilePath As String = inputf
            Dim outputFilePathFormat As String = String.Format("{0}{{0:_0}}.bin", outputf)

            Using fsInput As Stream = File.Open(inputFilePath, FileMode.Open, FileAccess.Read, FileShare.Read)
                Dim buffer As Byte() = New Byte(81919) {}
                Dim cOutFileNo As Integer = 0
                Dim destination As Stream = getOutputFile(cOutFileNo, outputFilePathFormat)

                Try
                    Dim read As Integer

                    While CSharpImpl.__Assign(read, fsInput.Read(buffer, 0, buffer.Length)) <> 0

                        If destination.Length + read > maxChunkSize Then
                            destination.Dispose()
                            destination = getOutputFile(cOutFileNo, outputFilePathFormat)
                        End If

                        destination.Write(buffer, 0, read)
                    End While

                Finally
                    destination.Dispose()
                End Try
            End Using
        End Sub

        Private Shared Function getOutputFile(ByRef cOutFileNo As Integer, ByVal outFileFormat As String) As Stream
            Dim filename As String = String.Format(outFileFormat, cOutFileNo)
            cOutFileNo += 1
            Return File.Open(filename, FileMode.CreateNew, FileAccess.Write, FileShare.None)
        End Function

        Private Class CSharpImpl
            <Obsolete("Please refactor calling code to use normal Visual Basic assignment")>
            Shared Function __Assign(Of T)(ByRef target As T, value As T) As T
                target = value
                Return value
            End Function
        End Class
    End Class
End Namespace
