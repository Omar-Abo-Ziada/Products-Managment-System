namespace ProductsMangementSystem.Features.Products.DeleteProduct
{
    public sealed record DeleteProductEndpointRequest
    {
        public Guid ProductId { get; init; }
    }
}
