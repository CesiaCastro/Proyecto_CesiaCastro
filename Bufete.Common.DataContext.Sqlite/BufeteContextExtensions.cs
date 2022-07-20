using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Packt.Shared
{
    public static class BufeteContextExtensions
    {
        public static IServiceCollection AddBufeteContext(this IServiceCollection servicies,
           string relativePath = "..\\Bufete.Common.DataContex.Sqlite\\bin\\Debug\\net6.0")
        {
            string databasePath = Path.Combine(relativePath, "Bufete.db");
            servicies.AddDbContext<BufeteContext>(options => 
            options.UseSqlite($"Data Source={databasePath}"));

            return servicies;
        }
    }
}
