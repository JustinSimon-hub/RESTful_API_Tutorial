using System;
namespace REST_API_Tutorial2nd.Models
{
	//this folder stores the data that going to be added to the database
	//so we know which customer is checked in a current room
	
	public class HotelBooking
	{
		public int Id { get; set; }
		public int RoomNumber { get; set; }
		public string? ClientName { get; set; }

		
	}
}

