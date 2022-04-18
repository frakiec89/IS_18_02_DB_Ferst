using ProectSGK.DB;
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
    /// Логика взаимодействия для WindowAddGroup.xaml
    /// </summary>
    public partial class WindowAddGroup : Window
    {
        public WindowAddGroup()
        {
            InitializeComponent();
        }

        private void btAddGroup_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrEmpty(tbName.Text)) // валидация
            {
                MessageBox.Show("введите название для  новой группы ");
                return ;
            }

            try
            {
                Group groupNow = new Group();  //создали новый  объект
                groupNow.Name = tbName.Text; // задали его  свойство  имя 
                MyContext context = new MyContext(); // создали доступ для бд
                context.Groups.Add(groupNow); // добавить  в бд
                context.SaveChanges(); // сохранить  в бд 

                MessageBox.Show("Ура  - группа  добавлена в БД");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
