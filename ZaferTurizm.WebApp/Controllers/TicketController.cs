using Microsoft.AspNetCore.Mvc;
using ZaferTurizm.Business.Services;
using ZaferTurizm.Dtos;

namespace ZaferTurizm.WebApp.Controllers
{
    public class TicketController : Controller
    {
        private readonly IBusTripService _busTripService;
        private readonly ITicketService _ticketService;

        public TicketController(IBusTripService busTripService, ITicketService ticketService)
        {
            _busTripService = busTripService;
            _ticketService = ticketService;
        }

        public IActionResult TicketsOfBusTrip(int busTripId)
        {
            var busTripDetails = _busTripService.GetBusTripDetails(busTripId);

            if (busTripDetails == null)
            {
                TempData["ErrorMessage"] = "Seyahat bulunamadı";
                return RedirectToAction("Index", "BusTrip");
            }

            return View(busTripDetails);
        }

        [HttpPost]
        public IActionResult Create(TicketDto ticket)
        {
            // Price hatası kaçamak çözümü
            var newPrice = ticket.Price.ToString();
            char sondanIkinci = newPrice[newPrice.Length - 2];
            string yeniString = newPrice.Substring(0, newPrice.Length - 2) + "," + sondanIkinci + newPrice[newPrice.Length - 1];
            ticket.Price = Decimal.Parse(yeniString);

            var result = _ticketService.Create(ticket);

            return Json(result);
        }
        public IActionResult Index()
        {
            var values = _ticketService.GetAll();
            return View(values);
        }
        [HttpGet]
        public IActionResult TicketForSeatNumber(int busTripId)
        {
            var values = _ticketService.GetAll().Where(p=>p.BusTripId == busTripId);
            return Json(values);
        }
        public IActionResult TicketPrint(int id)
        {
           var ticket = _ticketService.GetById(id);
            if(ticket == null)
            {
                return View();
            }
            TicketPrinter printer = new TicketPrinter();
            printer.PrintTicket(ticket);

            string fileName = ticket.PassengerFirstName + "." + ticket.PassengerLastName + "." + ticket.Id + "." + "ticket.pdf";
            string fullFileName = $@"C:\Users\ASUS\Desktop\Emre Hoca Wissen\ZaferTurizm\Biletler\{fileName}";
            byte[] fileBytes = System.IO.File.ReadAllBytes(fullFileName);
            string contentType = "application/pdf";

            Response.Headers.Add("Content-Disposition", "inline; filename=" + fileName);
            return File(fileBytes, contentType);


        }
    }
}
