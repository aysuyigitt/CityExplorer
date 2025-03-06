using AutoMapper;
using CityExplorer.BusinessLayer.Service;
using CityExplorer.DataAccessLayer.Concrete;
using CityExplorer.DtoLayer.EventMapper;
using CityExplorer.DtoLayer.TicketMapper;
using CityExplorer.EntitiesLayer.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace CityExplorerApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowLocalhost")]
    public class TicketsController : ControllerBase
    {
        private readonly ITicketService _ticketService;
        private readonly CityExplorerContext _context;
        private readonly IMapper _mapper;


        public TicketsController(ITicketService ticketService, CityExplorerContext context, IMapper mapper)
        {
            _ticketService = ticketService;
            _context = context;
            _mapper = mapper;
        }

        //[HttpPost]
        //public async Task<IActionResult> BuyTicket([FromBody] Ticket model)
        //{
        //    if (model == null)
        //    {
        //        return BadRequest("Geçersiz veri");
        //    }

        //    var eventToBook = await _context.Events.FindAsync(model.EventID);
        //    if (eventToBook == null)
        //    {
        //        return NotFound("Etkinlik bulunamadı");
        //    }
        //    var ticket = new Ticket
        //    {
        //        EventID = model.EventID,
        //        EventName = model.EventName,   
        //        PurchaseDate = model.PurchaseDate,  
        //        TicketID = model.TicketID, 

        //    };

        //    _context.Tickets.Add(ticket);
        //    await _context.SaveChangesAsync();

        //    return Ok(new { success = true });
        
        [HttpPost]
        public async Task<IActionResult> CreateTicket(CreateTicketDto createTicketDto)
        {
            var value = _mapper.Map<Ticket>(createTicketDto);
            await _ticketService.TCreateAsync(value);
            return Ok("Bilet alanı eklendi");
        }

    }
}
    



