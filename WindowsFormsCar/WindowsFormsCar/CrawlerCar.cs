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
    public class CrawlerCar
    {
        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        private float _startPosX;
        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        private float _startPosY;
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private int _pictureWidth;
        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private int _pictureHeight;
        /// <summary>
        /// Ширина отрисовки автомобиля
        /// </summary>
        ///
        private readonly int carWidth = 120;
        /// <summary>
        /// Высота отрисовки автомобиля
        /// </summary>
        private readonly int carHeight = 80;
        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { private set; get; }
        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { private set; get; }
        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { private set; get; }
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }
        /// <summary>
        /// Признак наличия переднего спойлера
        /// </summary>
        public bool FrontLadle { private set; get; }
        /// <summary>
        /// Признак наличия переднего ковша
        /// </summary>
        public bool BackAntenna { private set; get; }
        /// <summary>
        /// Признак наличия задней антенны
        /// </summary>
        public bool Flasher { private set; get; }
        /// <summary>
        /// Признак наличия мигалки
        /// </summary>

        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontLadle">Признак наличия переднего спойлера</param>
        /// <param name="backAntenna">Признак наличия боковых спойлеров</param>
        /// <param name="flasher">Признак наличия заднего спойлера</param>

        public CrawlerCar(int maxSpeed, float weight, Color mainColor, Color dopColor,
        bool frontLadle, bool backAntenna, bool flasher)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;
            FrontLadle = frontLadle;
            BackAntenna = backAntenna;
            Flasher = flasher;
        }
        /// <summary>
        /// Установка позиции автомобиля
        /// </summary>
        /// <param name="x">Координата X</param>
        /// <param name="y">Координата Y</param>
        /// <param name="width">Ширина картинки</param>
        /// <param name="height">Высота картинки</param>
        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureWidth = width;
            _pictureHeight = height;
            // Продумать логику
        }
        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
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
        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush blackBrush = new SolidBrush(Color.Black);

            Brush dop = new SolidBrush(DopColor);

            Brush mainer = new SolidBrush(MainColor);


            if (FrontLadle)
            {

                g.FillRectangle(dop, _startPosX + 10, _startPosY, 30, 10);
                g.DrawRectangle(pen, _startPosX + 10, _startPosY, 30, 10);

                g.FillRectangle(dop,
                _startPosX + 40, _startPosY, 10, 40);
                g.DrawRectangle(pen, _startPosX + 40, _startPosY, 10, 40);


                g.FillRectangle(blackBrush, _startPosX, _startPosY, 20, 20);

                //g.DrawEllipse(pen, _startPosX + 80, _startPosY - 6, 20, 20);
                //g.DrawEllipse(pen, _startPosX + 80, _startPosY + 35, 20, 20);
                //g.DrawEllipse(pen, _startPosX - 5, _startPosY - 6, 20, 20);
                //g.DrawEllipse(pen, _startPosX - 5, _startPosY + 35, 20, 20);
                //g.DrawRectangle(pen, _startPosX + 80, _startPosY - 6, 15, 15);
                //g.DrawRectangle(pen, _startPosX + 80, _startPosY + 40, 15, 15);
                //g.DrawRectangle(pen, _startPosX, _startPosY - 6, 14, 15);
                //g.DrawRectangle(pen, _startPosX, _startPosY + 40, 14, 15);
                //Brush spoiler = new SolidBrush(DopColor);
                //g.FillEllipse(spoiler, _startPosX + 80, _startPosY - 5, 20, 20);
                //g.FillEllipse(spoiler, _startPosX + 80, _startPosY + 35, 20, 20);
                //g.FillRectangle(spoiler, _startPosX + 75, _startPosY, 25, 40);
                //g.FillRectangle(spoiler, _startPosX + 80, _startPosY - 5, 15, 15);
                //g.FillRectangle(spoiler, _startPosX + 80, _startPosY + 40, 15, 15);
                //g.FillEllipse(spoiler, _startPosX - 5, _startPosY - 5, 20, 20);
                //g.FillEllipse(spoiler, _startPosX - 5, _startPosY + 35, 20, 20);
                //g.FillRectangle(spoiler, _startPosX - 5, _startPosY, 25, 40);
                //g.FillRectangle(spoiler, _startPosX, _startPosY - 5, 15, 15);
                //g.FillRectangle(spoiler, _startPosX, _startPosY + 40, 15, 15);
            }

            if (BackAntenna)
            {

                g.FillRectangle(blackBrush, _startPosX + 125, _startPosY + 40, 5, 30);

                //g.DrawRectangle(pen, _startPosX + 25, _startPosY - 6, 39, 10);
                //g.DrawRectangle(pen, _startPosX + 25, _startPosY + 45, 39, 10);
                //Brush spoiler = new SolidBrush(DopColor);
                //g.FillRectangle(spoiler, _startPosX + 25, _startPosY - 5, 40, 10);
                //g.FillRectangle(spoiler, _startPosX + 25, _startPosY + 45, 40, 10);
            }
            // теперь отрисуем основной кузов автомобиля
            //границы автомобиля
            g.FillEllipse(blackBrush, _startPosX + 40, _startPosY + 40, 80, 30);

            g.FillRectangle(mainer, _startPosX + 40, _startPosY + 25, 90, 15);
            g.DrawRectangle(pen, _startPosX + 40, _startPosY + 25, 90, 15);

            g.FillRectangle(mainer, _startPosX + 55, _startPosY + 10, 40, 15);
            g.DrawRectangle(pen, _startPosX + 55, _startPosY + 10, 40, 15);

            // рисуем гоночные полоски
            if (Flasher)
            {
                g.FillEllipse(dop, _startPosX + 60, _startPosY, 15, 10);
                g.DrawEllipse(pen, _startPosX + 60, _startPosY, 15, 10);

                // br = new SolidBrush(DopColor);
                // g.FillRectangle(br, _startPosX + 65, _startPosY + 18, 25, 15);
                // g.FillRectangle(br, _startPosX + 25, _startPosY + 18, 35, 15);
                // g.FillRectangle(br, _startPosX, _startPosY + 18, 20, 15);
            }
        }
    }
}
