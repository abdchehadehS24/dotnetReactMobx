using Persistence;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using Domain;

namespace API.Controllers
{
    public class ItemsController : BaseApiController
    {
        private readonly DataContext _context;
        public ItemsController(DataContext context)
        {
            this._context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Item>>> GetItems(){
            return await this._context.Items.ToListAsync();
        }        
        
        [HttpGet("{id}")]  // --> get Item by ID
        public async Task<ActionResult<Item>> GetItem(Guid id){
            return await this._context.Items.FindAsync(id);
        }

    }

}