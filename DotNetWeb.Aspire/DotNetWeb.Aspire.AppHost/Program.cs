var builder = DistributedApplication.CreateBuilder(args);

var api = builder.AddProject<Projects.DotNetWeb_Api>("api");

builder.AddProject<Projects.DotNetWeb_Blazor>("blazor")
    .WithReference(api);

builder.Build().Run();

