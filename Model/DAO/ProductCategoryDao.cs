using Model.EF;
using System.Collections.Generic;
using System.Linq;

namespace Model.DAO
{
    public class ProductCategoryDao
    {
        private OnlineShopDBContext db = null;

        public ProductCategoryDao()
        {
            db = new OnlineShopDBContext();
        }

        public List<ProductCategory> ListAll()
        {
            return db.ProductCategories.Where(x => x.Status == true).OrderBy(x => x.DisplayOrder).ToList();
        }

        public ProductCategory ViewDetail(long id)
        {
            return db.ProductCategories.Find(id);
        }
    }
}