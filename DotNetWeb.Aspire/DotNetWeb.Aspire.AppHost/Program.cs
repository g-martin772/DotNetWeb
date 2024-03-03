var builder = DistributedApplication.CreateBuilder(args);

builder.AddProject<Projects.DotNetWeb_Blazor>("blazor");

builder.Build().Run();

