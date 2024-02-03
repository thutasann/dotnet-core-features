using practical_signalR_mvc.Hubs;

var builder = WebApplication.CreateBuilder(args);

// TODO: Remove For now
// builder.Services.AddAuthentication(options =>
// {
//     options.DefaultAuthenticateScheme = "Bearer";
//     options.DefaultChallengeScheme = "Bearer";
// }).AddJwtBearer("Bearer", o =>
// {
//     o.TokenValidationParameters = new TokenValidationParameters()
//     {
//         IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("4y7XS2AHicSOs2uUJCxwlHWqTJNExW3UDUjMeXi96uLEso1YV4RazqQubpFBdx0zZGtdxBelKURhh0WXxPR0mEJQHk_0U9HeYtqcMManhoP3X2Ge8jgxh6k4C_Gd4UPTc6lkx0Ca5eRE16ciFQ6wmYDnaXC8NbngGqartHccAxE")),
//         ValidIssuer = "http://localhost:5158/",
//         ValidAudience = "http://localhost:5158/",
//         ValidateIssuerSigningKey = true,
//         ValidateIssuer = true,
//         ValidateAudience = true,
//         ClockSkew = TimeSpan.Zero
//     };
//     o.Events = new JwtBearerEvents
//     {
//         OnMessageReceived = context =>
//         {
//             var accessToken = context.Request.Query["access_token"];
//             if (string.IsNullOrEmpty(accessToken) == false)
//             {
//                 context.Token = accessToken;
//             }
//             return Task.CompletedTask;
//         }
//     };
// });
builder.Services.AddControllersWithViews();
builder.Services.AddSignalR().AddRedis(options =>
{
    options.Configuration.ClientName = "SignalR";
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.MapHub<MessageHub>("messages");

app.Run();
