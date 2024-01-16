var builder = WebApplication.CreateBuilder(args);
builder.Services.AddSignalR().AddAzureSignalR("Endpoint=https://warmupb.service.signalr.net;AccessKey=c7iumCvC6nEqCeM0DPApJKLKezilnMlrwO/5z0JLNN4=;Version=1.0;");
var app = builder.Build();

// Application will serve the HTML pages in the wwwroot folder.
app.UseDefaultFiles();
app.UseStaticFiles();
app.UseRouting();

app.UseRouting();
app.MapHub<ChatSampleHub>("/chat");
app.Run();
/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

builder.Services.AddMvc();
builder.Services.AddSignalR();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

// Code for using SignalR

app.UseStaticFiles();
// app.UseMvc();

app.UseHttpsRedirection();

app.MapControllers();

//app.MapGet("/shirts", () => {
//    return "all the shirts.";
//});


app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();

*/