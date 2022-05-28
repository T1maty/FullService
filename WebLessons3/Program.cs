using System.Text;

var builder = WebApplication.CreateBuilder();

var services = builder.Services;
var app = builder.Build();

app.Run(async context =>
{ 

    var sb = new StringBuilder();
    sb.Append("<h1> Full Service</h1>");
    sb.Append("<table>");
    sb.Append("<tr><th>���</th><th>Lifetime</th><th>����������</th></tr>");

    foreach (var svc in services)
    {
        sb.Append("<tr>");
        sb.Append($"<td>{svc.ServiceType.FullName}</td>");
        sb.Append($"<td>{svc.Lifetime}</td>");
        sb.Append($"<td>{svc.ImplementationType?.FullName}</td>");
        sb.Append("</tr>");
    }
    sb.Append("</table>");
    context.Response.ContentType = "text/html;charset=utf-8";
    await context.Response.WriteAsync(sb.ToString());


});

app.Run();