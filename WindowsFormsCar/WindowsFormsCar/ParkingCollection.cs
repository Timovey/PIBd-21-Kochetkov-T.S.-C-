using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsCar
{
	///<summary>
	///Класс-коллекция парковок
	///</summary>
	class ParkingCollection
	{
		/// <summary>  
		/// Словарь (хранилище) с парковками         
		/// </summary>         
		readonly Dictionary<string, Parking<Vehicle>> parkingStages;

		/// <summary>         
		/// Возвращение списка названий праковок         
		/// </summary>         
		public List<string> Keys => parkingStages.Keys.ToList();

		/// <summary>   
		/// Ширина окна отрисовки         
		/// </summary>
		private readonly int pictureWidth;

		/// <summary>     
		/// Высота окна отрисовки         
		/// </summary>         
		private readonly int pictureHeight;

        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>         
        /// Конструктор         
        /// </summary>         
        /// <param name="pictureWidth"></param>         
        /// <param name="pictureHeight"></param>         
        public ParkingCollection(int pictureWidth, int pictureHeight) {
			parkingStages = new Dictionary<string, Parking<Vehicle>>();
			this.pictureWidth = pictureWidth;
			this.pictureHeight = pictureHeight;
		}

		/// <summary>         
		/// Добавление парковки         
		/// </summary>         
		/// <param name="name">Название парковки</param>         
		public void AddParking(string name) {
			if (parkingStages.ContainsKey(name))
			{
				return;
			}

			parkingStages.Add(name, new Parking<Vehicle>(pictureWidth, pictureHeight)); }

		/// <summary>         
		/// Удаление парковки         
		/// </summary>         
		/// <param name="name">Название парковки</param>         
		public void DelParking(string name) {
			if (parkingStages.ContainsKey(name))
			{
				parkingStages.Remove(name);
			}
		}

		/// <summary>         
		/// Доступ к парковке         
		/// </summary>         
		/// <param name="ind"></param>         
		/// <returns></returns>         
		public Parking<Vehicle> this[string ind] {
			get
			{
				if (parkingStages.ContainsKey(ind))
				{
					return parkingStages[ind];
				}
                return null;
			}

		}

        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.WriteLine($"ParkingCollection");
                foreach (var level in parkingStages)
                {
                    sw.WriteLine($"Parking{separator}{level.Key}");
                    ITransport car = null;
                    for (int i = 0; (car = level.Value.GetNext(i)) != null; i++)
                    {
                        if (car != null)
                        {
                            if (car.GetType().Name == "Car")
                            {
                                sw.Write($"Car{separator}");
                            }
                            if (car.GetType().Name == "CrawlerCar")
                            {
                                sw.Write($"CrawlerCar{separator}");
                            }
                            //Записываемые параметры
                            sw.WriteLine(car);
                        }
                    }

                }
            }
            return true;
        }


        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                bool head = true;
                string line;
                Vehicle car = null;
                string key = string.Empty;
                while ((line = sr.ReadLine()) != null)
                {
                    line = line.Replace("\r", "");
                    if (head)
                    {
                        if (line.Contains("ParkingCollection"))
                        {
                            //очищаем записи
                            parkingStages.Clear();
                            head = false;
                        }
                        else
                        {
                            //если нет такой записи, то это не те данные
                            return false;
                        }
                    }
                    else
                    {
                        //идем по считанным записям
                        if (line.Contains("Parking"))
                        {//начинаем новую парковку
                            key = line.Split(separator)[1];
                            parkingStages.Add(key, new Parking<Vehicle>(pictureWidth, pictureHeight));
                            continue;
                        }
                        if (string.IsNullOrEmpty(line))
                        {
                            continue;
                        }
                        if (line.Split(separator)[0] == "Car")
                        {
                            car = new Car(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "CrawlerCar")
                        {
                            car = new CrawlerCar(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + car;
                        if (!result)
                        {
                            return false;
                        }
                    }
                }
            }
            return true;
        }

    }
}
