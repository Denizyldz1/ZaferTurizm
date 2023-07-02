using MigraDoc.DocumentObjectModel;
using MigraDoc.DocumentObjectModel.Tables;
using MigraDoc.Rendering;
using ZaferTurizm.Dtos;

public class TicketPrinter
{
    public void PrintTicket(TicketDto ticketDto)
    {
        Document document = CreateTicket(ticketDto);

        PdfDocumentRenderer renderer = new PdfDocumentRenderer();
        renderer.Document = document;
        renderer.RenderDocument();

        string fileName = ticketDto.PassengerFirstName + "."+ ticketDto.PassengerLastName+"." + ticketDto.Id+"." +"ticket.pdf";

        string fullFileName = $@"C:\Users\ASUS\Desktop\Emre Hoca Wissen\ZaferTurizm\Biletler\{fileName}";

        renderer.PdfDocument.Save(fullFileName);


        // PDF'yi yazdırma işlemi için uygun bir yöntem kullanabilirsiniz.
        // Örneğin:
        // Process.Start(fileName);
    }

    private Document CreateTicket(TicketDto ticketDto)
    {
        Document document = new Document();
        Section section = document.AddSection();
        Table table = section.AddTable();
        table.AddColumn(Unit.FromCentimeter(5));
        table.AddColumn(Unit.FromCentimeter(5));

        Row row = table.AddRow();
        row.Cells[0].AddParagraph("Sefer Bilgisi");
        row.Cells[1].AddParagraph("Müşteri Bilgileri");

        Row dataRow = table.AddRow();
        dataRow.Cells[0].AddParagraph(ticketDto.BusTripName);
        dataRow.Cells[1].AddParagraph($" Müşteri Adı : {ticketDto.PassengerFirstName + ticketDto.PassengerLastName} " +
                                      $"TC Kimlik Numarası{ticketDto.PassengerIdentityNumber} " +
                                      $"Koltuk Numarası : {ticketDto.SeatNumber}" +
                                      $"Ücret: {ticketDto.Price}");


        return document;
    }
}


