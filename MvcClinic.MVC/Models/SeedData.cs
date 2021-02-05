using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcClinic.MVC.Data;
using System;
using System.Linq;

namespace MvcClinic.MVC.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcClinicContext(serviceProvider.GetRequiredService<DbContextOptions<MvcClinicContext>>()))
            {
                if (context.Clients.Any())
                {
                    return;
                }

                context.Clients.AddRange(
                    new Client
                    {
                        Name = "Wagner Albuquerque",
                        CPF = "8987889657",
                        DateBirth = "10/06/2000",
                        CellPhone = "79 98869-8989",
                        Email = "wagner@gmail.com",
                        Address = "Rua Maria da Penha",
                        RegDate = new DateTime(2021, 1, 22),
                        MaritalStatus = "Casado"
                    },
                    new Client
                    {
                        Name = "Mauro Galvão",
                        CPF = "98523569887",
                        DateBirth = "25/06/1996",
                        CellPhone = "79 98869-8989",
                        Email = "maurogalvao@gmail.com",
                        Address = "Rua Chica Chaves, 78",
                        RegDate = new DateTime(2021, 1, 22),
                        MaritalStatus = "Casado"
                    },
                    new Client
                    {
                        Name = "Alziva Evas",
                        CPF = "8987889657",
                        DateBirth = "30/06/2000",
                        CellPhone = "79 98869-8989",
                        Email = "alzira@gmail.com",
                        Address = "Rua bromélias, 1256",
                        RegDate = new DateTime(2021, 1, 22),
                        MaritalStatus = "Solteira"
                    },
                    new Client
                    {
                        Name = "Marcones Terevel",
                        CPF = "897523577",
                        DateBirth = "30/04/1978",
                        CellPhone = "79 9566-8989",
                        Email = "marcones@gmail.com",
                        Address = "Rua Felícia SAntos, 1256",
                        RegDate = new DateTime(2021, 1, 22),
                        MaritalStatus = "Casado"
                    }

                    );

                context.SaveChanges();
            }
        }
    }
}
