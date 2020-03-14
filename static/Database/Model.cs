using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TimeStac
{
    public class StacContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Stack> Stacks { get; set; }
        public DbSet<Timer> Timers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=TimeStac;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
    }

    public class User
    {
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

    }

    public class Stack
    {
        public int StackId { get; set; }
        public string Stackname { get; set; }
        public User User { get; set; }
    }

    public class Timer
    {
        public int TimerId { get; set; }
        public string Timername { get; set; }
        public float Timeset { get; set; }
        public Stack Stack { get; set; }
    }
}