using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace Entities
{
	public class Country
	{
		[Key]
		public Guid CountryId { get; set; }

		[StringLength(50)]
		public string? CountryName { get; set; }
	}
}
