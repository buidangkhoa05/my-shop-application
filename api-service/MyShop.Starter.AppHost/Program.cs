var builder = DistributedApplication.CreateBuilder(args);

 builder.AddProject<Projects.MyShop_Product>("my-shop-product-api");

builder.Build().Run();
