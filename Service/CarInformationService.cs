using BO.Models;
using CarManagementRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarManagementService
{
    public class CarInformationService : ICarInformationService
    {
        private readonly ICarInformationRepository _carInformationRepository = null;
        public CarInformationService()
        {
            _carInformationRepository = new CarInformationRepository();
        }

        public bool AddCar(CarInformation car)
        {
            return _carInformationRepository.AddCar(car);
        }

        public bool DeleteCar(int code)
        {
            return _carInformationRepository.DeleteCar(code);
        }

        public List<Brand> GetBrands()
        {
            return _carInformationRepository.GetBrands();
        }

        public CarInformation GetCarById(int code)
        {
            return _carInformationRepository.GetCarById(code);
        }

        public List<CarInformation> GetCars()
        {
            return _carInformationRepository.GetCars();
        }

        public List<CarClass> GetClasses()
        {
            return _carInformationRepository.GetClasses();
        }

        public bool UpdateCar(CarInformation car)
        {
            return _carInformationRepository.UpdateCar(car);
        }
    }
}
