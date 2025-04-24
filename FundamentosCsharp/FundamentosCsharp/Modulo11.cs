using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloDatas
{
    public class TrabalhandoComDatas
    {
        public void AulaDateTime()
        {
            var date1 = new DateTime(2025, 01, 23, 23, 34, 23);
            var date2 = DateTime.Parse("2022/12/23 19:25:25");
            var date3 = DateTime.Now;
            var date4 = DateTime.Today;

            Console.WriteLine(date1);
            Console.WriteLine(date2);
            Console.WriteLine(date3);
            Console.WriteLine(date4);

            Console.WriteLine("Data Formatada: " + date1.ToString("yyyy-dd-MM HH-mm-ss"));
            var dateOffste1 = new DateTimeOffset(DateTime.Now, new TimeSpan(-3,0,0)); //transformando a hora no padrao brasileiro
            Console.WriteLine(dateOffste1.LocalDateTime);
            Console.WriteLine(dateOffste1.UtcDateTime);
        }

        public void AulaSubtraindoDatas()
        {
            var date1 = DateTime.Now;
            var date2 = DateTime.Parse("2024-01-24");

            var diff = date1 - date2; // ou date1.Subtract(date2);

            Console.WriteLine("A diferença de dias é: " + diff.TotalDays);
            Console.WriteLine("A diferença de horas é: " + diff.TotalHours);
        }

        public void AulaAddDiasMesAno()
        {
            var date1 = DateTime.Now;

            Console.WriteLine("Adicionando dia na dataAtual - " + date1.AddDays(1));
            Console.WriteLine("Adicionando mês na dataAtual - " + date1.AddMonths(2));
            Console.WriteLine("Adicionando ano na dataAtual - " + date1.AddYears(1));
        }
        public void AulaAddHoraMinSeg()
        {
            var date1 = DateTime.Now;

            Console.WriteLine("Adicionando hora na dataAtual - " + date1.AddHours(1).ToString("HH:mm:ss"));
            Console.WriteLine("Adicionando minuto na dataAtual - " + date1.AddMinutes(50).ToString("HH:mm:ss"));
            Console.WriteLine("Adicionando segundos na dataAtual - " + date1.AddSeconds(10).ToString("HH:mm:ss"));
        }
        public void AulaRecDiaSemana()
        {
            var date1 = DateTime.Now;

            Console.WriteLine("" + date1.DayOfWeek); //Dia Da Semana
        }
        public void AulaDateOnly()
        {
            //var date1 = new DateOnly(2022,12,02); //Construtor
            var somenteData = DateOnly.Parse("2022-02-01");

            Console.WriteLine(somenteData); 
        }
        public void AulaTimeOnly()
        {
            //var date1 = new TimeOnly(00,12,02); //Construtor
            var somenteHora= TimeOnly.Parse("00:59:39");

            Console.WriteLine(somenteHora); 
        }

        private static void TrabalhandoComDatass()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaDateTime();
        }
        private static void TrabalhandoComDiffDeDatas()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaSubtraindoDatas();
        }
        private static void TrabalhandAddDeDatas()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaAddDiasMesAno();
        }
        private static void TrabalhandAddHorasMinSeg()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaAddHoraMinSeg();
        }
        private static void TrabalhandDiaSemana()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaRecDiaSemana();
        }
        private static void TrabalhandDateOnly()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaDateOnly();
        }
        private static void TrabalhandTimeOnly()
        {
            var dateT = new ModuloDatas.TrabalhandoComDatas();
            dateT.AulaTimeOnly();
        }
    }

}
