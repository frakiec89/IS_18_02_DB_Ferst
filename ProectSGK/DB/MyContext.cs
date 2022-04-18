using Microsoft.EntityFrameworkCore;


namespace ProectSGK.DB
{
    public class MyContext : DbContext
    {

        //  4 библиотеки   + EF / tools / desin / Sql Server
        // наследоваться   от DbContext
        // Строка соединения 
        static string cs = "server=192.168.10.134; database=Ahtaymov_18_04; user id =stud; password=stud;";  // в  первый день  


        // переопределить  провайдер 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(cs);
        }

        // dbSet 

        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        // провести  миграцию 
        // > Add-Migration

        // Обновить БД 
        // update-database


    }
}
