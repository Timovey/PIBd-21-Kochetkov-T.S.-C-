using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsCar
{
    public partial class FormCarConfig : Form
    {

        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        Vehicle car = null;
        /// <summary>
        /// Событие
        /// </summary>
        private event Action<Vehicle> eventAddCar;


        public FormCarConfig()
        {
            InitializeComponent();

            foreach (var elem in groupBoxColor.Controls)
            {
                if (elem is Panel)
                {
                    (elem as Panel).MouseDown += panelColor_MouseDown;
                }
            }

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }
        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawCar()
        {
            if (car != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxCar.Width, pictureBoxCar.Height);
                Graphics gr = Graphics.FromImage(bmp);
                car.SetPosition(5, 5, pictureBoxCar.Width, pictureBoxCar.Height);
                car.DrawTransport(gr);
                pictureBoxCar.Image = bmp;
            }
        }
        /// <summary>
        /// Добавление события
        /// </summary>
        /// /// <param name="ev"></param>
        public void AddEvent(Action<Vehicle> ev)
        {
            if (eventAddCar == null)
            {
                eventAddCar = new Action<Vehicle>(ev);
            }
            else
            {
                eventAddCar += ev;
            }
        }



        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelCar.DoDragDrop(labelCar.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelCrawlertCar_MouseDown(object sender, MouseEventArgs e)
        {
            labelCrawlerCar.DoDragDrop(labelCrawlerCar.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCar_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelCar_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {

                case "обычный гусенечный автомобиль":
                    car = new Car((int)numericUpDownMaxSpeed.Value,
                    (int)numericUpDownWeight.Value, Color.White);
                    break;
                case "экскаватор":
                    car = new CrawlerCar((int)numericUpDownMaxSpeed.Value,
                   (int)numericUpDownWeight.Value, Color.White, Color.Black,
                    checkBoxFrontLadle.Checked, checkBoxBackAntenna.Checked, checkBoxStand.Checked);
                    break;
            }
            DrawCar();
        }


        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            Color color = (sender as Panel).BackColor;
            (sender as Panel).DoDragDrop(color, DragDropEffects.Move |
             DragDropEffects.Copy);
        }
        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetData(typeof(Color)) != null)
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        /// <summary>
        /// Принимаем основной цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car is Car)
            {
                car.SetMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }
        /// <summary>
        /// Принимаем дополнительный цвет
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (car is CrawlerCar)
            {
                (car as CrawlerCar).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawCar();
            }
        }
        /// <summary>
        /// Добавление машины
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOk_Click(object sender, EventArgs e)
        {
           
            eventAddCar?.Invoke(car);
            Close();
        }

    }
}
