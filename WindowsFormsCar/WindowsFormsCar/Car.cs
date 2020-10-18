using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsCar
{
    public class Car : Vehicle
    {
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        private readonly int carWidth = 120;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int carHeight = 80;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Car(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструкторс изменением размеров машины
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="carWidth">Ширина отрисовки автомобиля</param>
        /// <param name="carHeight">Высота отрисовки автомобиля</param>
        protected Car(int maxSpeed, float weight, Color mainColor, int carWidth, int
       carHeight)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            this.carWidth = carWidth;
            this.carHeight = carHeight;
        }
        public override void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - carWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }         
                    break;
                //вверх
                case Direction.Up:
                     if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - carHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }
        public override void DrawTransport(Graphics g)
        {
            // теперь отрисуем основной кузов автомобиля
            //границы автомобиля
            Pen pen = new Pen(Color.Black);
            Brush blackBrush = new SolidBrush(Color.Black);
            Brush mainer = new SolidBrush(MainColor);

            g.FillEllipse(blackBrush, _startPosX + 40, _startPosY + 40, 80, 30);

            g.FillRectangle(mainer, _startPosX + 40, _startPosY + 25, 90, 15);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 25, 90, 15);

            g.FillRectangle(mainer, _startPosX + 55, _startPosY + 10, 40, 15);
            g.DrawRectangle(pen, _startPosX + 55, _startPosY + 10, 40, 15);

        }
    }
}
