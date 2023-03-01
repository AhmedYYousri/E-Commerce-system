using OnlineShopping.DAL;
using OnlineShopping.Repository;
using System;
using System.IO;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;
using iTextSharp.text;

namespace OnlineShopping.Models.Home
{
    public class HomeIndexViewModel
    {
        public GenericUnitOfWork _uniteOfWork = new GenericUnitOfWork();
        readonly dbMyOnilineShoppingEntities1 context = new dbMyOnilineShoppingEntities1();
        public IPagedList<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search, int pageSize, int? page)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@search",search??(object)DBNull.Value)
            };
            IPagedList<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch @search", param).ToList().ToPagedList(page ?? 1, pageSize);
            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }

    }
}