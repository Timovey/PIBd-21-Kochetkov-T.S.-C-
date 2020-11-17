using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCar
{

    /// <summary>
    /// Класс отрисовки автомобиля
    /// </summary>
    public class CrawlerCar: Car
    {

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего ковша
        /// </summary>
        public bool FrontLadle { private set; get; }
        /// <summary>
        /// Признак наличия задней антенны
        /// </summary>
        public bool BackAntenna { private set; get; }
        /// <summary>
        /// Признак наличия мигалки
        /// </summary>
        public bool Stand { private set; get; }
      

        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontLadle">Признак наличия переднего ковша</param>
        /// <param name="backAntenna">Признак наличия задней антенны</param>
        /// <param name="stand">Признак наличия задней подставки</param>

        public CrawlerCar(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool frontLadle, bool backAntenna, bool stand) :
        base(maxSpeed, weight, mainColor, 130, 80)

        {

            DopColor = dopColor;
            FrontLadle = frontLadle;
            BackAntenna = backAntenna;
            Stand = stand;
        }
        
       
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush blackBrush = new SolidBrush(Color.Black);

            Brush dop = new SolidBrush(DopColor);

            Brush mainer = new SolidBrush(MainColor);

            // рисуем передний ковш
            if (FrontLadle)
            {

                g.FillRectangle(dop, _startPosX + 10, _startPosY, 30, 10);
                g.DrawRectangle(pen, _startPosX + 10, _startPosY, 30, 10);

                g.FillRectangle(dop,
                _startPosX + 40, _startPosY, 10, 40);
                g.DrawRectangle(pen, _startPosX + 40, _startPosY, 10, 40);

                g.FillRectangle(blackBrush, _startPosX, _startPosY, 20, 20);
             
            }
            // рисуем антенну
            if (BackAntenna)
            {
                g.FillRectangle(blackBrush, _startPosX + 125, _startPosY + 40, 5, 30);
             
            }
            // отрисуем основной кузов автомобиля
            base.DrawTransport(g);
           
            // рисуем заднюю подставку
            if (Stand)
            {
                g.FillEllipse(dop, _startPosX + 60, _startPosY, 15, 10);
                g.DrawEllipse(pen, _startPosX + 60, _startPosY, 15, 10);
   
            }
        }
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }

    }
}
