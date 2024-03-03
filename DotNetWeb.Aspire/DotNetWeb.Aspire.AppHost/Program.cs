var builder = DistributedApplication.CreateBuilder(args);

var cache = builder.AddRedis("cache");

var api = builder.AddProject<Projects.DotNetWeb_Api>("api");

builder.AddProject<Projects.DotNetWeb_Blazor>("blazor")
    .WithReference(api)
    .WithReference(cache);

builder.Build().Run();

