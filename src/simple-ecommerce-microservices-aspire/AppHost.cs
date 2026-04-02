var builder = DistributedApplication.CreateBuilder(args);


builder.AddProject<Projects.CustomerService>("CustomerService");
builder.AddProject<Projects.EmailService>("EmailService");
builder.AddProject<Projects.OrderService>("OrderService");
builder.AddProject<Projects.PaymentService>("PaymentService");
builder.AddProject<Projects.ProductService>("ProductService");
builder.AddProject<Projects.TransactionService>("TransactionService");

builder.Build().Run();