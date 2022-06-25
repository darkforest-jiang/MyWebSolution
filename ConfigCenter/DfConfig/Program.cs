using DfConfig.Model.Interfaces;
using ProtoBuf.Grpc.Server;
using ProtoBuf.Grpc.Reflection;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddCodeFirstGrpc();//添加Grpc服务
builder.Services.AddCodeFirstGrpcReflection();//添加Grpc反射

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapControllers();
app.UseEndpoints(endpoints => {
    endpoints.MapGrpcService<IAppKeyService>();//添加Grpc服务路由

    endpoints.MapCodeFirstGrpcReflectionService();//添加Grpc反射服务 使Grpc服务可被发现服务列表
});

app.Run();
