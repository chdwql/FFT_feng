''' <summary>
''' ��������FFT
''' </summary>
''' <param name="data">ԭʼ����</param>
''' <param name="ReVal">���</param>
''' <param name="beginPoint">��ʼ����</param>
''' <param name="endPoint">��������</param>
''' <returns>True�任�ɹ�</returns>
Public Shared Function FFTFeng(ByVal data() As Double, ByRef ReVal As Complex, ByVal beginPoint As Integer, ByVal endPoint As Integer) As Boolean
    Try
        Dim erpin, mm As Double
        Dim L As Integer = data.Length
        For i = beginPoint To endPoint          'iΪ���ڣ�jΪʱ��, wt=2.pi/i
            erpin = 2 * PI / i
            ReVal(i) = New Complex(0, 0)
            For j = 0 To L - 1
                mm = erpin * j
                ReVal(i).Real = ReVal(i).Real + data(j) * Math.Cos(mm)
                ReVal(i).Imag = ReVal(i).Imag + data(j) * Math.Sin(mm)
            Next j
            ReVal(i).Real = 2 * ReVal(i).Real / L
            ReVal(i).Imag = 2 * ReVal(i).Imag / L
        Next i
        Return True
    Catch ex As Exception
        Return False : Exit Function
    End Try
End Function
