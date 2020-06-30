using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.Extensions.Logging;
using Switch.Domain.Entities;
using Switch.Domain.Enums;
using Switch.Infra.CrossCutting.Logging;
using Switch.Infra.Data.Context;
using System;

namespace SwitchAPP
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario1;
            Usuario usuario2;
            Usuario usuario3;
            Usuario usuario4;
            Usuario usuario5;
            Usuario usuario6;

            Usuario CriaUsuario(string Nome) 
            {
                return new Usuario()
                {
                    Nome = Nome,
                    SobreNome = "Usuario",
                    Email = "Teste@teste.com",
                    Senha = "Senha",
                    Sexo = SexoEnum.Maculino,
                    DataNascimento = DateTime.Parse("17/10/1986"),
                    UrlFoto = "saass"
                };

            }

             usuario1 = CriaUsuario("usuario1");
             usuario2 = CriaUsuario("usuario2");
             usuario3 = CriaUsuario("usuario3");
             usuario4 = CriaUsuario("usuario4");
             usuario5 = CriaUsuario("usuario5");
             usuario6 = CriaUsuario("usuario6");

            var optionsBulder = new DbContextOptionsBuilder<SwitchContext>();
            
            optionsBulder.UseLazyLoadingProxies();
            optionsBulder.EnableSensitiveDataLogging();
            optionsBulder.UseNpgsql("Server=localhost; userid=postgres; password=discovoador;database=SwitchDB;", m => m.MigrationsAssembly("Switch.Infra.Data").MaxBatchSize(1000)
            );

            try
            {
                using (var dbcontext = new SwitchContext(optionsBulder.Options))
                {
                    dbcontext.GetService<ILoggerFactory>().AddProvider(new Logger());
                    
                    

                }
            }
            catch (Exception erro)
            {

                Console.WriteLine(erro.Message);
                Console.ReadKey();
            }
           
        }
    }
}
