using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementDAO
{
    public class CarInformationDAO
    {
        private readonly CarManagementContext _db = null;
        protected static CarInformationDAO instance = null;
        public static CarInformationDAO Instance
        {
            get
            {
                //if (instance == null)
                //{
                    instance = new CarInformationDAO();
                //}
                return instance;
            }
        }
        public CarInformationDAO()
        {
            _db = new CarManagementContext();
        }
        public List<CarInformation> GetCars()
        {
            return _db.CarInformations.ToList();
        }
        public List<CarInformation> GetCarsByOwnerId(int id, string? key)
        {
            if (key == null)
            {
                return _db.CarInformations.Where(x => x.OwnerId == id).ToList();
            }
            else
            {
                return _db.CarInformations.Where(x => x.OwnerId == id && x.CarDescription.Contains(key)).ToList();
            }
        }
        public List<CarInformation> GetCarsByStatus()
        {
            return _db.CarInformations.Where(x => x.CarStatus != 1).ToList();
        }
        public CarInformation GetCarById(int code)
        {
            return _db.CarInformations.Where(x => x.Id.Equals(code)).FirstOrDefault();
        }
        public bool UpdateCar(CarInformation carInformation)
        {
            bool result = false;
            try
            {
                var dbContext = new CarManagementContext();
                dbContext.CarInformations.Update(carInformation);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
        public bool AddCar(CarInformation carInformation)
        {
            bool result = false;
            try
            {
                var dbContext = new CarManagementContext();
                dbContext.CarInformations.Add(carInformation);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
        public bool DeleteCar(int code)
        {
            bool result = false;
            try
            {
                var carInformation = GetCarById(code);
                var dbContext = new CarManagementContext();
                dbContext.CarInformations.Remove(carInformation);
                dbContext.SaveChanges();
                result = true;
            }
            catch (Exception ex)
            {
                return result;
            }
            return result;
        }
    }
}
