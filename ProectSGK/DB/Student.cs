using System.ComponentModel.DataAnnotations;

namespace ProectSGK.DB
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string Name { get; set; }


        public int GroupId { get; set; }
        public Group Group { get; set; } // навигационное  свойство
        // тоесть  ссылка  на группу 

    }
}