using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementDAO
{
    public class BrandDAO
    {
        private readonly CarManagementContext _db = null;
        protected static BrandDAO instance = null;
        public static BrandDAO Instance
        {
            get
            {
                //if (instance == null)
                //{
                        instance = new BrandDAO();
                    //}
                return instance;
            }
        }
        public BrandDAO()
        {
            _db = new CarManagementContext();
        }
        public List<Brand> GetBrands()
        {
            return _db.Brands.ToList();
        }
    }
}
