using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using mf_dev_backend_2024.Models;

namespace mf_dev_backend_2024.Data
{
    public class mf_dev_backend_2024Context : DbContext
    {
        public mf_dev_backend_2024Context (DbContextOptions<mf_dev_backend_2024Context> options)
            : base(options)
        {
        }

        public DbSet<mf_dev_backend_2024.Models.Veiculo> Veiculo { get; set; } = default!;
        
        public DbSet<mf_dev_backend_2024.Models.Consumo> Consumos { get; set; } = default!;
        
        public DbSet<mf_dev_backend_2024.Models.Usuario> Usuarios { get; set; } = default!;
   
    }
}
