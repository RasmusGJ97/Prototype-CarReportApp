using Prototype_CarReportApp_Models;

namespace Prototype_CarReportApp.Services
{
    public class CarReportRepository : ICarReport<Car>
    {

        private List<Car> _cars;

        public CarReportRepository()
        {
            // Creating test data
            _cars = new List<Car>
            {
                new Car { CarId = 1, CarRegNr = "ABC123", CarBrand = "Toyota", CarModel = "Prius", CarYear = 2020, 
                    Reports = new List<Report>
                    {
                        new Report
                        {
                            ReportId = 1,
                            ReportTitle = "Service",
                            ReportDescription = "Dags för service på bilen.",
                            DateOfReport = new DateTime(2024,01,20),
                            CarId = 1
                        },
                        new Report {
                            ReportId = 2,
                            ReportTitle = "Läcker olja",
                            ReportDescription = "Verkar som bilen börjat läcka olja.",
                            DateOfReport = new DateTime(2024,05,13),
                            CarId = 1
                        }
                    }
                },
                new Car { CarId = 2, CarRegNr = "DEF456", CarBrand = "Seat", CarModel = "Leon", CarYear = 2021,
                    Reports = new List<Report>
                    {
                        new Report
                        {
                            ReportId = 1,
                            ReportTitle = "Punktering",
                            ReportDescription = "Fick punktering på vänster fram.",
                            DateOfReport = new DateTime(2024,02,02),
                            CarId = 2
                        },
                        new Report {
                            ReportId = 2,
                            ReportTitle = "Service",
                            ReportDescription = "Dags för service på bilen.",
                            DateOfReport = new DateTime(2024,04,20),
                            CarId = 2
                        }
                    }
                },
                new Car { CarId = 3, CarRegNr = "GHI789", CarBrand = "Volkswagen", CarModel = "Golf", CarYear = 2022, 
                    Reports = new List<Report>
                    {
                        new Report {
                            ReportId = 1,
                           ReportTitle = "Motorlampa lyser",
                            ReportDescription = "Motorlampan började lysa.",
                            DateOfReport = new DateTime(2024,03,10),
                            CarId = 3
                        }
                    }

                }
            };
        }

        public Task<Car> Add(Car specificCar, string title, string description)
        {
            var newReport = new Report
            {
                ReportId = specificCar.Reports.Count + 1,
                ReportTitle = title,
                ReportDescription = description,
                DateOfReport = DateTime.Now,
                CarId = specificCar.CarId
            };

            specificCar.Reports.Add(newReport);

            return Task.FromResult(specificCar);
        }

        public Task<IEnumerable<Car>> GetAll()
        {
            return Task.FromResult<IEnumerable<Car>>(_cars);
        }

        public Task<Car> GetSpecificInt(int id)
        {
            var car = _cars.FirstOrDefault(c => c.CarId == id);
            return Task.FromResult(car);
        }

        public Task<Car> GetSpecificString(string id)
        {
            var car = _cars.FirstOrDefault(c => c.CarRegNr == id);
            return Task.FromResult(car);
        }
    }
}
