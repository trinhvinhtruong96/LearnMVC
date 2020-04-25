using WebApp.Infrastructure.Interfaces;

namespace WebApp.Data.EF
{
    public class EFUnitOfWork : IUnitOfWork
    {
        private AppDbContext _context;
        public EFUnitOfWork(AppDbContext context)
        {
            this._context = context;
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}