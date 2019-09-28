Imports libacctng.myFunctions
Imports System.Windows.Forms
Imports DevExpress.Pdf

Public Class bir0619e
    Dim pdfPath As String = Application.StartupPath & "/templates/tmp/"
    Dim pdfFile As String = Application.StartupPath & "/templates/0619e.pdf"
    Private Sub bir0619e_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim documentProcessor As New PdfDocumentProcessor()
        'documentProcessor.LoadDocument(pdfFile)
        'Dim formData As PdfFormData = documentProcessor.GetFormData()
        'formData("txtMonth1").Value = "0"
        'formData("txtMonth2").Value = "7"
        'formData("txtYear1").Value = "2"
        'formData("txtYear2").Value = "0"
        'formData("txtYear3").Value = "1"
        'formData("txtYear4").Value = "9"
        'Dim tmpFile As String = pdfPath & GenerateRandomString() & ".pdf"
        'documentProcessor.SaveDocument(tmpFile)
        'mypdf.LoadDocument(tmpFile)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs)
        'Dim documentProcessor As New PdfDocumentProcessor()
        'documentProcessor.LoadDocument(pdfFile)
        'Dim txtMonth As New PdfAcroFormTextBoxField("txtMonth", 1, New PdfRectangle(46, 643, 74, 661))
        'Dim txtYear As New PdfAcroFormTextBoxField("txtYear", 1, New PdfRectangle(74, 643, 130, 661))

        '' Specify text box text, and appearance.
        'txtMonth.Text = "Month"
        'txtYear.Text = "Year"
        'txtYear.Appearance.BackgroundColor = New PdfRGBColor(0.8, 0.5, 0.3)
        'txtMonth.Appearance.FontSize = 12
        'txtYear.Appearance.FontSize = 12
        'documentProcessor.AddFormFields(txtMonth, txtYear)
        ''processor.AddFormFields(textBox, radioGroup)
        'Dim tmpFile As String = pdfPath & GenerateRandomString() & ".pdf"
        'documentProcessor.SaveDocument(tmpFile)
        'mypdf.LoadDocument(tmpFile)
    End Sub
End Class