using System;
namespace ProductClientHub.API.Entities
{
	public class Product
	{
        public Guid Id { get; set; } = Guid.NewGuid();

        public string Name { get; set; } = string.Empty;

        public string Brands { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public Guid ClientId { get; set; }
    }
}

