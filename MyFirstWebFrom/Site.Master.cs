using MyFirstWebForm.Models;
using System;
using System.Linq;
using System.Web.UI;

namespace MyFirstWebForm
{
    public partial class SiteMaster : MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Category> GetCategories()
        {
            var _db = new MyFirstWebForm.Models.ProductContext();
            IQueryable<Category> query = _db.Categories;
            return query;
        }

    }
}