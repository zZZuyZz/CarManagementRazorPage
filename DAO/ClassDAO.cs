using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementDAO
{
    public class ClassDAO
    {
        private readonly CarManagementContext _db = null;
        protected static ClassDAO instance = null;
        public static ClassDAO Instance
        {
            get
            {
                //if (instance == null)
                //{
                    instance = new ClassDAO();
                //}
                return instance;
            }
        }
        public ClassDAO()
        {
            _db = new CarManagementContext();
        }
        public List<CarClass> GetCarClasses()
        {
            return _db.CarClasses.ToList();
        }
    }
}
