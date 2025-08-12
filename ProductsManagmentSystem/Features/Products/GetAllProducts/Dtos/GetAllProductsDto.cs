﻿namespace ProductsMangementSystem.Features.Products.GetAllProducts.Dtos
{
    public record GetAllProductsDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public Guid CategoryId { get; set; }

    }
}
