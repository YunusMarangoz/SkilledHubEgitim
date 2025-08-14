namespace MVCEgitimi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();//Uygulamada MVC Controller view yapýsýný kullancaðýz

            var app = builder.Build();//builder nesnesi üzerinden eklenen servislerle beraber  app nesnesi oluþturulur

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())//uygulama development yani lokaldeki geliþtirme ortamýnda deðilse
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();//httpden httpe ye  otomatik yönlendirme yapar
            app.UseRouting();//Uygulamada routing mekanýzmasýný aktif et

            app.UseAuthorization();//Uygulamada yetkilendirme kullanýmýný aktif et

            app.MapStaticAssets();//wwwroot klasöründeki statik dosyalarý haritala
            app.MapControllerRoute(//route yapýsýný aþaðýdakiayarlarla kullan
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}")//adres çubuðunda beklediðimiz url yapýsý
                .WithStaticAssets();

            app.Run();//uyrlamayý yukarýdaki yapýlandýrmalarla çalýþtýr
        }
    }
}
