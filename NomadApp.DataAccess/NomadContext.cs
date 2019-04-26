namespace NomadApp.DataAccess
{
    using NomadApp.Models;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class NomadContext : DbContext
    {
        // Контекст настроен для использования строки подключения "NomadContext" из файла конфигурации  
        // приложения (App.config или Web.config). По умолчанию эта строка подключения указывает на базу данных 
        // "NomadApp.DataAccess.NomadContext" в экземпляре LocalDb. 
        // 
        // Если требуется выбрать другую базу данных или поставщик базы данных, измените строку подключения "NomadContext" 
        // в файле конфигурации приложения.
        public NomadContext()
            : base("name=NomadContext")
        {
            Database.SetInitializer(new DataInitializer());
        }

        public DbSet<User> Users { get; set; }
        public DbSet<SubscriptionLog> SubscriptionLogs { get; set; }
        public DbSet<Delivery> Deliveries { get; set; }
        // Добавьте DbSet для каждого типа сущности, который требуется включить в модель. Дополнительные сведения 
        // о настройке и использовании модели Code First см. в статье http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}