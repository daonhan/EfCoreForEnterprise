using Microsoft.EntityFrameworkCore;
using Store.Core.EntityLayer.Sales;

namespace Store.Core.DataLayer.Mapping.Sales
{
    public class OrderSummaryMap : IEntityMap
	{
		public void Map(ModelBuilder modelBuilder)
		{
			var entity = modelBuilder.Entity<OrderSummary>();
			
			entity.ToTable("OrderSummary", "Sales");

            entity.HasKey(p => p.OrderID);
		}
	}
}
