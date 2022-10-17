Imports System.IO
Imports System.IO.Compression
Imports SharpCompress
Imports Brotli
Imports XZ.NET

Public Class Decompress
    Shared Sub DecompressFileGzip(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New GZipStream(compressedFileStream, CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub DecompressFileZlib(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New Compressors.Deflate.ZlibStream(compressedFileStream, Compressors.CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub DecompressFileDeflate(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New DeflateStream(compressedFileStream, CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub DecompressFileBrotli(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New BrotliStream(compressedFileStream, CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub DecompressFileZstdNet(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New ZstdNet.DecompressionStream(compressedFileStream, CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub DecompressFileXZ(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New XZInputStream(compressedFileStream, CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub DecompressFileLZip(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New Compressors.LZMA.LZipStream(compressedFileStream, Compressors.CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub

    Shared Sub DecompressFileADC(ByVal toDecompress As String, ByVal FileSave As String)
        Using compressedFileStream As FileStream = File.Open(toDecompress, FileMode.Open)
            Using outputFileStream As FileStream = File.Create(FileSave)
                Using decompressor = New Compressors.ADC.ADCStream(compressedFileStream, Compressors.CompressionMode.Decompress)
                    decompressor.CopyTo(outputFileStream)
                End Using
            End Using
        End Using
    End Sub
End Class
