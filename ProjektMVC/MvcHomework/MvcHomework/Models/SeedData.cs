using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic;
using MvcHomework.Data;
using System;
using System.Linq;

namespace MvcHomework.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcHomeworkContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcHomeworkContext>>()))
        {
            // Look for any Homework.
            if (context.Homework.Any())
            {
                return;   // DB has been seeded
            }
            context.Homework.AddRange(
                new Homework
                {
                    Name = "Matematyka Dyskretna",
                    Description = "Rozwiązać zadania ze stron 50-55.",
                    DueDate = DateTime.Parse("2025-6-11"),
                    Status = "Nie rozpoczęte",
                },
                new Homework
                {
                    Name = "Fizyka",
                    Description = "Rozwiązać i odesłać arkusz zadań.",
                    DueDate = DateTime.Parse("2025-6-9"),
                    Status = "W Trakcie",
                },
                new Homework
                {
                    Name = "Podstawy Programowania",
                    Description = "Napisać prosty program na zajęcia.",
                    DueDate = DateTime.Parse("2025-6-13"),
                    Status = "Nie rozpoczęte",
                },
                new Homework
                {
                    Name = "Grafika Komputerowa",
                    Description = "Zrobić projekt w grafice wektorowej.",
                    DueDate = DateTime.Parse("2025-6-8"),
                    Status = "Ukończone",
                },
                new Homework
                {
                    Name = "Wzorzec MVC w tworzeniu aplikacji internetowych",
                    Description = "Ukończyć i odesłać projekt aplikacji MVC.",
                    DueDate = DateTime.Parse("2025-6-12"),
                    Status = "Ukończone",
                }

            );
            context.SaveChanges();
        }
    }
}