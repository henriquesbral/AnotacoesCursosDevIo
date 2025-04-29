using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Curso.Data
{
    public class ApplicationContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=LENOVOHENRIQUE\\SQLEXPRESS;Database=DesenvolvedorIO;User Id=DevCursoIO;Password=Aps@2025140612#1;");
        }
    }
}
