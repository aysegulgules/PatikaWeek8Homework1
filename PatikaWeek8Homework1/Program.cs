using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Formats.Tar;
using System.Reflection;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews(); //MVC Servis

var app=builder.Build();


app.UseStaticFiles();   //wwwroot klas�r�nde bulunan statik dosyalar�n kullan�lmas�n� sa�layacak konfig�rasyon

app.UseRouting();        //Routing Konfig�rasyonu

app.MapControllerRoute(name :"default",pattern:"{controller=Home}/{action=Index}/{Id?}"); // bir varsay�lan routing yap�land�rmas�

app.Run();


//Controller: Controller s�n�flar� HTTP isteklerini i�ler ve Model ile View aras�ndaki ileti�imi sa�lar.

//Action:Controller i�indeki public metotlard�r.Bir Action, bir HTTP iste�ine yan�t olarak �al���r ve sonucu View�e iletir.

//Model: MVC mimarisi i�inde verilerin tutuldu�u, veri taban�na eri�imin sa�land���, t�m data i�lemlerinin ger�ekle�ti�i yerdir. 

//View: View, Model katman�n�n g�rselle�tirilmi�, kullan�c�n�n uygulamay� g�rd��� halidir.

//Razor:ASP.NET Core�un View motorudur. HTML i�ine C# kodu eklememizi sa�lar.

//Razor View:Razor syntax ile yaz�lm�� View dosyalar�d�r.HTML ve C# kodunu bir araya getirir.

//wwwroot:Statik dosyalar�n(CSS, JavaScript, resimler vb.) sakland��� klas�rd�r. Taray�c� taraf�ndan do�rudan eri�ilebilir.

//builder.Build():ASP.NET Core uygulamas�n�n yap�land�rmas�n� olu�turan metottur. WebHostBuilder veya HostBuilder ile kullan�l�r.

//app.Run(): Middleware�leri �al��t�ran metottur. HTTP iste�ini i�ler ve sonucu HTTP yan�t�na d�n��t�r�r.

