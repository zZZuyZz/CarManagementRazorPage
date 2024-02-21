using BO.Models;
using CarManagementDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementRepo
{
    public class CarInformationRepository : ICarInformationRepository
    {
        public bool AddCar(CarInformation account) => CarInformationDAO.Instance.AddCar(account);

        public bool DeleteCar(int code) => CarInformationDAO.Instance.DeleteCar(code);

        public List<Brand> GetBrands() => BrandDAO.Instance.GetBrands();

        public List<CarClass> GetClasses() => ClassDAO.Instance.GetCarClasses();

        public CarInformation GetCarById(int code) => CarInformationDAO.Instance.GetCarById(code);

        public List<CarInformation> GetCars() => CarInformationDAO.Instance.GetCars();

        public bool UpdateCar(CarInformation account) => CarInformationDAO.Instance.UpdateCar(account);
    }
}
