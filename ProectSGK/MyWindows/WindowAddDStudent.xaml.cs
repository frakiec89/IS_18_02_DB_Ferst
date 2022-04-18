using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ProectSGK.MyWindows
{
    /// <summary>
    /// Логика взаимодействия для WindowAddDStudent.xaml
    /// </summary>
    public partial class WindowAddDStudent : Window
    {
        public WindowAddDStudent()
        {
            InitializeComponent();
            this.Loaded += WindowAddDStudent_Loaded;
        }

        /// <summary>
        /// событие  после загрузки 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <exception cref="NotImplementedException"></exception>
        private void WindowAddDStudent_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                DB.MyContext myContext = new DB.MyContext();
                var gr = myContext.Groups.ToList();
                cbGroups.ItemsSource = gr;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btAddStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var gr = cbGroups.SelectedItem as DB.Group; // нашли объект  из комбобокса 
                if( string.IsNullOrEmpty(tbName.Text) ) // валидация 
                {
                    MessageBox.Show("Укажите Имя студента");
                    return;
                }
                if (gr != null)
                {
                    var  student = new  DB.Student(); // новый  студент 
                    student.Name = tbName.Text; // его имя 
                    student.GroupId = gr.GroupId; // его группа 

                    DB.MyContext myContext = new DB.MyContext(); // к бд 
                    myContext.Students.Add(student);  // добавили в бд
                    myContext.SaveChanges(); // сохранили  в  бд
                    MessageBox.Show("Студент добавлен"); // вывели  сообщение 
                }    
                else
                {
                    MessageBox.Show("Выберите  группу");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDellStudent_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(tbIdStudent.Text);
                DB.MyContext myContext = new DB.MyContext(); // к бд 
                myContext.Students.Remove( myContext.Students.Find(id));
                myContext.SaveChanges();
                MessageBox.Show("Студент  удален из бд");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
