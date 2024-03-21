using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Crud_operation.Data;
using Crud_operation.Models;

namespace Crud_operation.Views.User
{
    public class IndexModel : PageModel
    {
        private readonly Crud_operation.Data.Crud_operationContext _context;

        public IndexModel(Crud_operation.Data.Crud_operationContext context)
        {
            _context = context;
        }

        public IList<User> User { get;set; } = default!;

        public async Task OnGetAsync()
        {
            User = await _context.User.ToListAsync();
        }
    }
}
