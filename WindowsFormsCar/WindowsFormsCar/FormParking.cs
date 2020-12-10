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
    public partial class FormParking : Form
    {
        /// <summary>
        /// Объект от класса-парковки
        /// </summary>
        private readonly ParkingCollection parkingCollection;
        public FormParking()
        {
            InitializeComponent();
            parkingCollection = new ParkingCollection(pictureBoxParking.Width,
            pictureBoxParking.Height);
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
            parkingCollection.AddParking(textBoxNewLevelName.Text); ReloadLevels();
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
                    parkingCollection.DelParking(listBoxParkings.SelectedItem.ToString());                     
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
                var car = parkingCollection[listBoxParkings.SelectedItem.ToString()] - Convert.ToInt32(maskedTextBox.Text);
                if (car != null)
                {
                    FormCar form = new FormCar();
                    form.SetCar(car);
                    form.ShowDialog();
                }
                Draw();
            }
        }

        /// <summary>    
        /// Метод обработки выбора элемента на listBoxLevels         
        /// </summary>         
        /// <param name="sender"></param>         
        /// <param name="e"></param>         
        private void listBoxParkings_SelectedIndexChanged(object sender, EventArgs e)         {
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
                if ((parkingCollection[listBoxParkings.SelectedItem.ToString()]) + car)
                {
                    Draw(); 
                }
                else
                {
                    MessageBox.Show("Машину не удалось поставить");
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
                if (parkingCollection.SaveData(saveFileDialog.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "Результат",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "Результат",
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
                if (parkingCollection.LoadData(openFileDialog.FileName))
                {
                    MessageBox.Show("Загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
                    ReloadLevels();
                    Draw();
                }
                else
                {
                    MessageBox.Show("Не загрузили", "Результат", MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                }
            }
        }

    }
}
