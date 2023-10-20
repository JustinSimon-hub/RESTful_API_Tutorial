using System;
using Microsoft.EntityFrameworkCore;
using REST_API_Tutorial2nd.Models;

namespace REST_API_Tutorial2nd.Data
{
	//database context is a simple class that contains dbset prop of the type tht we want to store in the database
	//can use dbcontext to create update and read data from database
	public class APIcontext : DbContext
	{
		public DbSet<HotelBooking> Bookings { get; set; }


		public APIcontext(DbContextOptions<APIcontext> options)
			:base(options)

		{
			
		}
	}
}

