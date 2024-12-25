using GrpcService.GeneratedCode;

var builder = WebApplication.CreateBuilder(args);

// Add gRPC services
builder.Services.AddGrpc();

var app = builder.Build();

// HTTPS redirection (optional)
app.UseHttpsRedirection();

// Routing is automatically set up by UseEndpoints or MapGrpcService
app.MapGrpcService<ProductServiceHandler>();

// Run the application
app.Run();
