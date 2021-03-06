using System;
using System.Collections.ObjectModel;

namespace Store.Core.EntityLayer.Production
{
    public class Product : IEntity
    {
        public Product()
        {
        }

        public Int32? ProductID { get; set; }

        public String ProductName { get; set; }

        public Int32? ProductCategoryID { get; set; }

        public Decimal? UnitPrice { get; set; }

        public String Description { get; set; }

        public Boolean? Discontinued { get; set; }

        public virtual ProductCategory ProductCategoryFk { get; set; }

        public virtual Collection<ProductInventory> ProductInventories { get; set; }
    }
}
