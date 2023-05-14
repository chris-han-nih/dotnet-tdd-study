namespace Orders.Controllers;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/orders")]
public sealed class OrdersController: ControllerBase
{
    [HttpGet]
    [Produces("application/json", Type = typeof(Order[]))]
    public async Task<IEnumerable<Order>> GetOrders(
        [FromQuery(Name = "user-id")] Guid? userId,
        [FromQuery(Name = "shop-id")] Guid? shopId,
        [FromServices] OrdersDbContext context)
    {
        return await context.Orders
                            .AsNoTracking()
                            .ToListAsync();
    }
}