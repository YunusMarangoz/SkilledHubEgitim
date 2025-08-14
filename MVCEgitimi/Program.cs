namespace MVCEgitimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();//Uygulamada MVC Controller view yap�s�n� kullanca��z

            var app = builder.Build();//builder nesnesi �zerinden eklenen servislerle beraber  app nesnesi olu�turulur

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())//uygulama development yani lokaldeki geli�tirme ortam�nda de�ilse
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();//httpden httpe ye  otomatik y�nlendirme yapar
            app.UseRouting();//Uygulamada routing mekan�zmas�n� aktif et

            app.UseAuthorization();//Uygulamada yetkilendirme kullan�m�n� aktif et

            app.MapStaticAssets();//wwwroot klas�r�ndeki statik dosyalar� haritala
            app.MapControllerRoute(//route yap�s�n� a�a��dakiayarlarla kullan
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")//adres �ubu�unda bekledi�imiz url yap�s�
                .WithStaticAssets();

            app.Run();//uyrlamay� yukar�daki yap�land�rmalarla �al��t�r
        }
    }
}
