using InvoiceApplication.Models;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.Drawing;
using System.Reflection.Metadata;

namespace InvoiceApplication.Report
{
    public class PdfData
    {
        #region Declaration
        int _totalColumn = 3;
        Document _document;
        System.Drawing.Font _font;
        PdfPTable pdfPTable=new PdfPTable(3);
        PdfPCell PdfPCell;
        MemoryStream _stream=new MemoryStream();
        List<AddDetails> AddData = new List<AddDetails>();

        #endregion
        public byte[] PrepareReports(List<AddDetails> _AddData) {
            AddData = _AddData;
            #region
            _document=new Document(PageSize.A4,0f,0f,0f,0f);
            _document.SetPageSize(PageSize.A4);
            _document.SetMargins(20f,20f,20f,20f);
            pdfPTable.WidthPercentage = 100;
            pdfPTable.HorizontalAlignment = Element.ALIGN_LEFT;
            _font = FontFactory.GetFont("Tahoma",8f,1);
            PdfWriter.GetInstance(_document, _stream);
            _document.Open();
            pdfPTable.SetWidths(new float[] {20f,150f,100f});
            #endregion
            this.ReportHeader();
            this.ReportBody();
            pdfPTable.HeaderRows = 2;
            _document.Add();
            _document.Close();
            return _stream.ToArray();

        }
        private void ReportHeader()
        {
            _font = FontFactory.GetFont("Tahoma", 11f, 1);
            PdfPCell = new PdfPCell(new Phrase("My university"),_font);
            PdfPCell.Colspan = _totalColumn;
            PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell.Border = 0;
            PdfPCell.BackgroundColor = BaseColor.WHITE;
            PdfPCell.ExtraParagraphSpace=0;
            pdfPTable.AddCell(PdfPCell);
            pdfPTable.CompleteRow();

            _font = FontFactory.GetFont("Tahoma", 9f, 1);
            PdfPCell = new PdfPCell(new Phrase("My university"), _font);
            PdfPCell.Colspan = _totalColumn;
            PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell.Border = 0;
            PdfPCell.BackgroundColor = BaseColor.WHITE;
            PdfPCell.ExtraParagraphSpace = 0;
            pdfPTable.AddCell(PdfPCell);
            pdfPTable.CompleteRow();

        }
        private void ReportBody() {
            #region table  header
            _font = FontFactory.GetFont("Tahoma", 8f, 1);
            PdfPCell = new PdfPCell(new Phrase("serial No"), _font);
            PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            PdfPCell.BackgroundColor = BaseColor.GRAY;
            PdfPCell.ExtraParagraphSpace = 0;
            pdfPTable.AddCell(PdfPCell);

            PdfPCell = new PdfPCell(new Phrase("Name"), _font);
            PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            PdfPCell.BackgroundColor = BaseColor.GRAY;
            PdfPCell.ExtraParagraphSpace = 0;
            pdfPTable.AddCell(PdfPCell);

            PdfPCell = new PdfPCell(new Phrase("Roll"), _font);
            PdfPCell.HorizontalAlignment = Element.ALIGN_CENTER;
            PdfPCell.VerticalAlignment = Element.ALIGN_MIDDLE;
            PdfPCell.BackgroundColor = BaseColor.GRAY;
            PdfPCell.ExtraParagraphSpace = 0;
            pdfPTable.AddCell(PdfPCell);
            #endregion
        }
    }
}
