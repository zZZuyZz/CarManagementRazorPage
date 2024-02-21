using BO.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementRepo
{
    public interface ICarInformationRepository
    {
        public List<CarInformation> GetCars();
        public List<CarInformation> GetCarsByOwner(int id, string? key);
        public List<CarInformation> GetCarsByStatus();
        public List<Brand> GetBrands();
        public List<CarClass> GetClasses();
        public CarInformation GetCarById(int code);
        public bool AddCar(CarInformation account);
        public bool UpdateCar(CarInformation account);
        public bool DeleteCar(int code);

    }
}
