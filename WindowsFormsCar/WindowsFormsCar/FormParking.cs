﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NLog; 

namespace WindowsFormsCar
{
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly ParkingCollection parkingCollection;

        /// <summary>
        /// Логгер
        /// </summary>
        private readonly Logger logger;


        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width,
            pictureBoxParking.Height);
            logger = LogManager.GetCurrentClassLogger();
        }
        /// <summary>         
        /// Заполнение listBoxLevels         
        /// </summary>         
        private void ReloadLevels()         {             
            int index = listBoxParkings.SelectedIndex;

        listBoxParkings.Items.Clear();
            for (int i = 0; i < parkingCollection.Keys.Count; i++)             
            {                 
                listBoxParkings.Items.Add(parkingCollection.Keys[i]);             
            } 
 
            if(listBoxParkings.Items.Count > 0 && (index == -1 || index >= listBoxParkings.Items.Count))             
            { 
                listBoxParkings.SelectedIndex = 0;             
            }             

            else if (listBoxParkings.Items.Count > 0 && index > -1 && index<listBoxParkings.Items.Count)             {                 
                listBoxParkings.SelectedIndex = index;         
            }
        } 
 
 

        /// <summary>
        /// Метод отрисовки парковки
        /// </summary>
        private void Draw()
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                Bitmap bmp = new Bitmap(pictureBoxParking.Width, pictureBoxParking.Height);
                Graphics gr = Graphics.FromImage(bmp);
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Draw(gr);
                pictureBoxParking.Image = bmp;
            }
        }

        /// <summary>   
        /// Обработка нажатия кнопки "Добавить парковку"         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void buttonAddParking_Click(object sender, EventArgs e)         {             
            if(string.IsNullOrEmpty(textBoxNewLevelName.Text))             
            {
                MessageBox.Show("Введите название парковки", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);                 
                return;             
            }
            logger.Info($"Добавили парковку {textBoxNewLevelName.Text}");
            parkingCollection.AddParking(textBoxNewLevelName.Text);
            ReloadLevels();
        }

        /// <summary>         
        /// Обработка нажатия кнопки "Удалить парковку"          
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void buttonDelParking_Click(object sender, EventArgs e)         
        {             
            if (listBoxParkings.SelectedIndex > -1)             
            {                 
                if(MessageBox.Show($"Удалить парковку {listBoxParkings.SelectedItem.ToString()}?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    logger.Info($"Удалили парковку{ listBoxParkings.SelectedItem.ToString()}");
                    parkingCollection.DelParking(textBoxNewLevelName.Text);
                    ReloadLevels();

                }
            }         
        }

        /// <summary>
        /// Обработка нажатия кнопки "Забрать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonTakeCar_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1 && maskedTextBox.Text != "")
            {
                try
                {
                    var car =
                   parkingCollection[listBoxParkings.SelectedItem.ToString()] -
                   Convert.ToInt32(maskedTextBox.Text);
                    if (car != null)
                    {
                        FormCar form = new FormCar();
                        form.SetCar(car);
                        form.ShowDialog();
                        logger.Info($"Изъят автомобиль {car} с места {maskedTextBox.Text}");
                    Draw();
                    }
                }
                catch (ParkingNotFoundException ex)
                {
                    logger.Warn("Автомобиль не найден");
                    MessageBox.Show(ex.Message, "Не найдено", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>    
        /// Метод обработки выбора элемента на listBoxLevels         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e) {
            logger.Info($"Перешли на парковку {listBoxParkings.SelectedItem.ToString()}");
            Draw();        
        }
        /// <summary>
        /// Обработка нажатия кнопки "Добавить автомобиль"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSetCar_Click(object sender, EventArgs e)
        {
            var formCarConfig = new FormCarConfig();
            formCarConfig.AddEvent(AddCar);
            formCarConfig.Show();
  
        }
        /// <summary>
        /// Метод добавления машины
        /// </summary>
        /// <param name="car"></param>
        private void AddCar(Vehicle car)
        {
            if (car != null && listBoxParkings.SelectedIndex > -1)
            {
                try
                {
                    if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) +
                   car)
                    {
                        Draw();
                        logger.Info($"Добавлен автомобиль {car}");
                    }
                    else
                    {
                        MessageBox.Show("Машину не удалось поставить");
                    }
                    Draw();
                }
                catch (ParkingOverflowException ex)
                {
                    logger.Warn("Переполнение парковки");
                    MessageBox.Show(ex.Message, "Переполнение", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
                catch (ParkingAlreadyHaveException ex)
                {
                    logger.Warn("Дублирование автомобиля");
                    MessageBox.Show(ex.Message, "Дублирование", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при добавлении на парковку");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработка нажатия пункта меню "Сохранить"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.SaveData(saveFileDialog.FileName);
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info("Сохранено в файл " + saveFileDialog.FileName);
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при сохранении");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при сохранении",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Обработка нажатия пункта меню "Загрузить"
        /// </summary>
        /// /// <param name="sender"></param>
        /// <param name="e"></param>
        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    parkingCollection.LoadData(openFileDialog.FileName);
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                    logger.Info("Загружено из файла " + openFileDialog.FileName);
                    ReloadLevels();
                    Draw();
                }
                catch (Exception ex)
                {
                    logger.Warn("Неизвестная ошибка при загрузке");
                    MessageBox.Show(ex.Message, "Неизвестная ошибка при загрузке",
                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Обработка нажатия кнопки "Сортировка"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (listBoxParkings.SelectedIndex > -1)
            {
                parkingCollection[listBoxParkings.SelectedItem.ToString()].Sort();
                Draw();
                logger.Info("Сортировка уровней");
            }
        }

    }
}
