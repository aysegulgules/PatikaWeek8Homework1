using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Tar;
using System.Reflection;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC Servis

var app=builder.Build();


app.UseStaticFiles();   //wwwroot klasöründe bulunan statik dosyalarýn kullanýlmasýný saðlayacak konfigürasyon

app.UseRouting();        //Routing Konfigürasyonu

app.MapControllerRoute(name :"default",pattern:"{controller=Home}/{action=Index}/{Id?}"); // bir varsayýlan routing yapýlandýrmasý

app.Run();


//Controller: Controller sýnýflarý HTTP isteklerini iþler ve Model ile View arasýndaki iletiþimi saðlar.

//Action:Controller içindeki public metotlardýr.Bir Action, bir HTTP isteðine yanýt olarak çalýþýr ve sonucu View’e iletir.

//Model: MVC mimarisi içinde verilerin tutulduðu, veri tabanýna eriþimin saðlandýðý, tüm data iþlemlerinin gerçekleþtiði yerdir. 

//View: View, Model katmanýnýn görselleþtirilmiþ, kullanýcýnýn uygulamayý gördüðü halidir.

//Razor:ASP.NET Core’un View motorudur. HTML içine C# kodu eklememizi saðlar.

//Razor View:Razor syntax ile yazýlmýþ View dosyalarýdýr.HTML ve C# kodunu bir araya getirir.

//wwwroot:Statik dosyalarýn(CSS, JavaScript, resimler vb.) saklandýðý klasördür. Tarayýcý tarafýndan doðrudan eriþilebilir.

//builder.Build():ASP.NET Core uygulamasýnýn yapýlandýrmasýný oluþturan metottur. WebHostBuilder veya HostBuilder ile kullanýlýr.

//app.Run(): Middleware’leri çalýþtýran metottur. HTTP isteðini iþler ve sonucu HTTP yanýtýna dönüþtürür.

