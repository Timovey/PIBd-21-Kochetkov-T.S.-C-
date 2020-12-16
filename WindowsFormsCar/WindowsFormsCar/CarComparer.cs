using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WindowsFormsCar
{
	public class CarComparer : IComparer<Vehicle>
	{
		public int Compare(Vehicle x, Vehicle y)
		{
			
			if (x is CrawlerCar VehCrawCarX && y is CrawlerCar VehCrawCarY)
			{
				return ComparerCrawlerCar(VehCrawCarX, VehCrawCarY);
			}
			if (!(x is CrawlerCar))
			{
				return 1;
			}
			if (!(y is CrawlerCar))
			{
				return -1;
			}
			if (x is Car VehCarX && y is Car VehCarY)
			{
				return ComparerCar(VehCarX, VehCarY);
			}

			return 0;
			
				
		}
		private int ComparerCar(Car x, Car y)
		{
			if (x.MaxSpeed != y.MaxSpeed)
			{
				return x.MaxSpeed.CompareTo(y.MaxSpeed);
			}
			if (x.Weight != y.Weight)
			{
				return x.Weight.CompareTo(y.Weight);
			}
			if (x.MainColor != y.MainColor)
			{
				return x.MainColor.Name.CompareTo(y.MainColor.Name);
			}
			return 0;
		}
		private int ComparerCrawlerCar(CrawlerCar x, CrawlerCar y)
		{
			var res = ComparerCar(x, y);
			if (res != 0)
			{
				return res;
			}
			if (x.DopColor != y.DopColor)
			{
				return x.DopColor.Name.CompareTo(y.DopColor.Name);
			}
			if (x.FrontLadle != y.FrontLadle)
			{
				return x.FrontLadle.CompareTo(y.FrontLadle);
			}
			if (x.BackAntenna != y.BackAntenna)
			{
				return x.BackAntenna.CompareTo(y.BackAntenna);
			}
			if (x.Stand!= y.Stand)
			{
				return x.Stand.CompareTo(y.Stand);
			}
			return 0;
		}
	}
}
