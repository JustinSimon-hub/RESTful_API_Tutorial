using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using REST_API_Tutorial2nd.Models;
using REST_API_Tutorial2nd.Data;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace REST_API_Tutorial2nd.Controllers
{
    [Route("api/[controller]")]
    public class HotelBookingController : Controller
    {
        //database context provided by the db injection 
        private readonly APIcontext _context;
        public HotelBookingController(APIcontext context)
        {
            _context = context;
        }
        //endpoint for creating and updating hotel bookings
        //create/edit
        [HttpPost]
        public JsonResult CreateEdit(HotelBooking booking)
        {
            if(booking.Id == 0)
            {
                _context.Bookings.Add(booking);
            }
            else
            {
                var bookingInDb = _context.Bookings.Find(booking.Id);
                if(bookingInDb == null)
                {
                    return new JsonResult(NotFound());
                    bookingInDb = booking;
                }
            }

            _context.SaveChanges();
            return new JsonResult(Ok(booking));
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

