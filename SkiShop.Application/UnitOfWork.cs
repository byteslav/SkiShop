using SkiShop.Domain;
using SkiShop.Domain.Entities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkiShop.Application
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ShopContext _context;

        public UnitOfWork(ShopContext context)
        {
            _context = context;
        }
        public void Dispose()
        {
            _context.Dispose();
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }
    }
}
