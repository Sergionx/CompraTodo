using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompraTodo.Data
{
    public class CompraTodoDbContext: DbContext
    {
        public CompraTodoDbContext(DbContextOptions<CompraTodoDbContext> options)
            :base(options)
        {

        }

    }
}
