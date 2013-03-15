using System.Collections.Generic;
namespace RestService
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }

    public class RestServiceImpl : IRestServiceImpl
    {
        #region IRestServiceImpl Members

        public string XMLData(string id)
        {
            List<Product> lp = new List<Product>();
            lp.Add(new Product { Id = 1, Desc = "ff", Name = "nn" });
            lp.Add(new Product { Id = 2, Desc = "ff2", Name = "nn" });
            lp.Add(new Product { Id = 3, Desc = "ff3", Name = "nn" });
            return "You requested product " + id;
        }

        public List<Product> XMLProduct(string id)
        {
            List<Product> lp = new List<Product>();
            lp.Add(new Product { Id = 1, Desc = "ff", Name = "nn" });
            lp.Add(new Product { Id = 2, Desc = "ff2", Name = "nn" });
            lp.Add(new Product { Id = 3, Desc = "ff3", Name = "nn" });
            return lp;
        }

        public List<Product> JSONProduct(string id)
        {
            return XMLProduct(id);
        }

        public string JSONData(string id)
        {
            return "You requested product " + id;
        }

        #endregion
    }
}