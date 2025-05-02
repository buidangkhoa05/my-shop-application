var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.MyShop_Product>("product-api-service");

builder.Build().Run();
