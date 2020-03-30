namespace goose2s
{
 using Microsoft.Extensions.Configuration;
 public class AppSettings
 {
     public string StorageConnectionString { get; set; }
     public string CallbackUri {get;set;}
     public static AppSettings LoadAppSettings()
     {
         IConfigurationRoot configRoot = new ConfigurationBuilder()
             .AddJsonFile("Settings.json")
             .Build();
         AppSettings appSettings = configRoot.Get<AppSettings>();
         return appSettings;
     }
 }
}