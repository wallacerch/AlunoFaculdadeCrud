using Microsoft.EntityFrameworkCore;

namespace AlunoFaculdadeCrud.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
    }
}
