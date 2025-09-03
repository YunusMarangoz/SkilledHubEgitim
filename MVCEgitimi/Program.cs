using MVCEgitimi.Models;

namespace MVCEgitimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews(); // Uygulamada MVC controller view yap�s�n� kullanaca��z

            builder.Services.AddDbContext<UyeContext>(); // projede kullanaca��m�z dbcontext s�n�f�m�z� uygulamaya tan�t�yoruz.

            builder.Services.AddSession(); // bu uygulamada session kullan�m�n� aktif et

            var app = builder.Build(); // builder nesnesi �zerinden eklenen servislerle beraber app onesnesi olu�turuluyor

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment()) // uygulama develeopment yani lokaldeki geli�tirme ortam�nda de�ilse
            {
                app.UseExceptionHandler("/Home/Error"); // global hata yakalamay� kullan ve olu�an hatalarda kullan�c�y� burada yazan ekrana y�nlendir
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection(); // http den https ye otomatik y�nlendire yap
            app.UseRouting(); // Uygulamada Routing mekanizmas�n� aktif et

            app.UseAuthorization(); // Uygulamada yetkilendirme kullan�m�n� aktif et

            app.UseSession(); // uygulamada session kullan�labilsin

            app.MapStaticAssets(); // wwwroot klas�r�ndeki statik dosylara� haritala
            app.MapControllerRoute( // route yap�s�n� a�a��daki ayarlarla kullan
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}") // adres �ubu�unda bekledi�imiz url yap�s�
                .WithStaticAssets();

            app.Run(); // uygulamay� yukar�daki yap�land�rmalarla �al��t�r.
        }
    }
}