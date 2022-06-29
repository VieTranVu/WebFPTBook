using WebFPTBook.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebFPTBook.Data
{
    public class ApplicationDbContext : IdentityDbContext <User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Order> Orders { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            SeedBook(builder);
            SeedCategory(builder);
            SeedUser(builder);
            SeedRole(builder);
            SeedOrder(builder);
        }

        private void SeedUser(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User { Name = "Admin", Image = "", Email = "admin@gmail.com", PhoneNumber = "0123456789", Roles = "Admin" },
                new User { Name = "Customer", Image = "", Email = "customer@gmail.com", PhoneNumber = "0987654321", Roles = "Customer" }
            ); ;
        }
        public void SeedOrder(ModelBuilder builder)
        {
            builder.Entity<Order>().HasData(
                new Order { Id = 1, BookId = 1, Order_Date = DateTime.Parse("2021-10-12"), Quantity = 2},
                new Order { Id = 2, BookId = 2, Order_Date = DateTime.Parse("2022-01-02"), Quantity = 3},
                new Order { Id = 3, BookId = 3, Order_Date = DateTime.Parse("2022-03-05"), Quantity = 4}
                );
        }
        private void SeedRole(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IdentityRole>().HasData(
                new IdentityRole { Id = "1", Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Id = "2", Name = "Store Owner", NormalizedName = "STORE OWNER" },
                new IdentityRole { Id = "3", Name = "Customer", NormalizedName = "CUSTOMER" }
            );
        }
        public void SeedCategory(ModelBuilder builder)
        {
            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "Horror", Image = "https://prod-ripcut-delivery.disney-plus.net/v1/variant/disney/81BA14190C0DB4241EB4AD72ECC0CE70A13F58A52431057CB53AEB551BF86386/scale?width=1200&aspectRatio=1.78&format=jpeg" },
                new Category { Id = 2, Name = "Science", Image = "http://findingada.com/wp-content/uploads/2013/10/A-Passion-for-Science-cover.jpeg" },
                new Category { Id = 3, Name = "Novel", Image = "https://d28hgpri8am2if.cloudfront.net/book_images/onix/cvr9781628724431/masterpieces-of-the-english-short-novel-9781628724431_hr.jpg" },
                new Category { Id = 4, Name = "Comic", Image = "https://www.davibooks.vn/stores/uploads/h/300__49926_big.jpg" },
                new Category { Id = 5, Name = "Romance", Image = "https://m.media-amazon.com/images/I/51MicQZzKEL.jpg" }
                );
        }
        public void SeedBook(ModelBuilder builder)
        {
            builder.Entity<Book>().HasData(
                new Book { Id = 1, Name = "Harvest Home", Image = "https://images-na.ssl-images-amazon.com/images/I/5147HWXW8OL._SX326_BO1,204,203,200_.jpg", Price = 15, Description = "A family flees the crime-ridden city—and finds something worse—in “a brilliantly imagined horror story” by the New York Times–bestselling author (The Boston Globe).", CategoryId = 1},
                new Book { Id = 2, Name = "Signet Classics", Image = "https://salt.tikicdn.com/cache/400x400/ts/product/13/1e/20/77b87c3248a57a6d01c6b5bcce310cbc.jpg.webp", Price = 5, Description = "Charles Darwin’s classic that exploded into public controversy, revolutionized the course of science, and continues to transform our views of the world.", CategoryId = 2},
                new Book { Id = 3, Name = "Jane Eyre", Image = "https://cdn0.fahasa.com/media/catalog/product/8/9/8935095621453.jpg", Price = 6, Description = "I am not a bird, no cage can trap me. I am a free man, with an independent will", CategoryId = 3},
                new Book { Id = 4, Name = "DORAEMON", Image = "https://m.media-amazon.com/images/I/81nDqEEt-gL._CLa%7C2328,2048%7C81VQH+klyLL.jpg,810kEFirnWL.jpg%7C0,0,1536,2048+1576,0,752,1003+1576,1043,752,1003_._SY300_.jpg", Price = 10, Description = "Doraemon, a cat robot, traveled back in time from the 22nd century to watch over Noby who’s a good kid but terrible at sports, never studies, and has an incredible capacity for slacking off. Doraemon tries to help Noby with nice but often unpredictable gadgets from his 4th dimensional pocket as Noby’s clumsy and always getting into trouble. Can Doraemon solve the problems and change Noby’s fortune for the better?", CategoryId = 4},
                new Book { Id = 5, Name = "Night to Remember", Image = "https://images-na.ssl-images-amazon.com/images/I/51FCgfUVCqL._SY291_BO1,204,203,200_QL40_FMwebp_.jpg", Price = 26, Description = "The classic minute-by-minute account of the sinking of the Titanic, in a 50th anniversary edition with a new introduction by Nathaniel Philbrick", CategoryId = 5}

                );
        }
    }
}
