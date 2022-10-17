Imports System.IO
Imports System.IO.Compression
Imports SharpCompress
Imports Brotli
Imports XZ.NET
Imports BrotliStream = Brotli.BrotliStream

Public Class Compress

    Shared Sub CompressFileZtsd(ByVal toCompress As String, ByVal FileSave As String)
        Using originalFileStream As FileStream = File.Open(toCompress, FileMode.Open)

            Using compressedFileStream As FileStream = File.Create(FileSave)
                Using compressor = New ZstdNet.CompressionStream(compressedFileStream, CompressionLevel.SmallestSize)
                    originalFileStream.CopyTo(compressor)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub CompressFileXZ(ByVal toCompress As String, ByVal FileSave As String)
        Using originalFileStream As FileStream = File.Open(toCompress, FileMode.Open)
            Using compressedFileStream As FileStream = File.Create(FileSave)
                Using compressor = New XZOutputStream(compressedFileStream, CompressionLevel.SmallestSize)
                    originalFileStream.CopyTo(compressor)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub CompressFileDefalte(ByVal toCompress As String, ByVal FileSave As String)
        Using originalFileStream As FileStream = File.Open(toCompress, FileMode.Open)
            Using compressedFileStream As FileStream = File.Create(FileSave)
                Using compressor = New DeflateStream(compressedFileStream, CompressionLevel.SmallestSize)
                    originalFileStream.CopyTo(compressor)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub CompressFileBrotli(ByVal toCompress As String, ByVal FileSave As String)
        Using originalFileStream As FileStream = File.Open(toCompress, FileMode.Open)
            Using compressedFileStream As FileStream = File.Create(FileSave)
                Using compressor = New BrotliStream(compressedFileStream, CompressionLevel.SmallestSize)
                    originalFileStream.CopyTo(compressor)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub CompressFileLZip(ByVal toCompress As String, ByVal FileSave As String)
        Using originalFileStream As FileStream = File.Open(toCompress, FileMode.Open)
            Using compressedFileStream As FileStream = File.Create(FileSave)
                Using compressor = New Compressors.LZMA.LZipStream(compressedFileStream, Compressors.CompressionMode.Compress)
                    originalFileStream.CopyTo(compressor)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub CompressFileGzip(ByVal toCompress As String, ByVal FileSave As String)
        Using originalFileStream As FileStream = File.Open(toCompress, FileMode.Open)
            Using compressedFileStream As FileStream = File.Create(FileSave)
                Using compressor = New GZipStream(compressedFileStream, CompressionLevel.SmallestSize)
                    originalFileStream.CopyTo(compressor)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub CompressFileZLib(ByVal toCompress As String, ByVal FileSave As String)
        Using originalFileStream As FileStream = File.Open(toCompress, FileMode.Open)
            Using compressedFileStream As FileStream = File.Create(FileSave)
                Using compressor = New Compressors.Deflate.ZlibStream(compressedFileStream, Compressors.CompressionMode.Compress)
                    originalFileStream.CopyTo(compressor)
                End Using
            End Using
        End Using
    End Sub
End Class
