﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Amazon.Models.Enums;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace Amazon.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ApplicationDbContext context = app.ApplicationServices
            .GetRequiredService<ApplicationDbContext>();
            context.Database.Migrate();
            if (!context.Books.Any())
            {
                context.Books.AddRange(
                new Book
                {
                    ISBN = "12546895",
                    Title = "How to code in C#",
                    Author = "Giancarlo Gamarra",
                    Price = 550,
                    NroPages = 950,
                    LevelStock = LevelStock.InStock
                },
                new Book
                {
                    ISBN = "12546895",
                    Title = "How to code in Java",
                    Author = "Giancarlo Gamarra",
                    Price = 600,
                    NroPages = 1500,
                    LevelStock = LevelStock.InStock
                },
                 new Book
                 {
                     ISBN = "23456542",
                     Title = "How to code in ASP.net",
                     Author = "Giancarlo Gamarra",
                     Price = 263,
                     NroPages = 800,
                     LevelStock = LevelStock.InStock
                 },
                  new Book
                  {
                      ISBN = "42323112",
                      Title = "How to code in Angular",
                      Author = "Giancarlo Gamarra",
                      Price = 500,
                      NroPages = 562,
                      LevelStock = LevelStock.InStock
                  },
                  new Book
                  {
                      ISBN = "12231112",
                      Title = "How to code in Visual Basic",
                      Author = "Giancarlo Gamarra",
                      Price = 150,
                      NroPages = 250,
                      LevelStock = LevelStock.InStock
                  },
                  new Book
                  {
                      ISBN = "222132122",
                      Title = "How to code in C++",
                      Author = "Giancarlo Gamarra",
                      Price = 500,
                      NroPages = 300,
                      LevelStock = LevelStock.InStock
                  },
                  new Book
                  {
                      ISBN = "11111222",
                      Title = "How to code in PHP",
                      Author = "Giancarlo Gamarra",
                      Price = 100,
                      NroPages = 500,
                      LevelStock = LevelStock.InStock
                  },
                  new Book
                  {
                      ISBN = "556667777",
                      Title = "How to code in C#",
                      Author = "Giancarlo Gamarra",
                      Price = 300,
                      NroPages = 200,
                      LevelStock = LevelStock.InStock
                  }
                  );
                context.SaveChanges();
            }
        }
    }
}
