﻿using Grpc.Core;

using GrpcService.GeneratedCode;

public class ProductServiceHandler : ProductService.ProductServiceBase
{
    public override Task<ProductResponse> GetProductDetails(ProductRequest request, ServerCallContext context)
    {
        return Task.FromResult(new ProductResponse
        {
            ProductDetails = $"Details for Product ID: {request.ProductId}"
        });
    }
}