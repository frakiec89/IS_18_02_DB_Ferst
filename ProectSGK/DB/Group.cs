using System.ComponentModel.DataAnnotations;

namespace ProectSGK.DB
{
    public class Group
    {
        [Key]
        public int GroupId { get; set; }

        public string Name { get; set; }

        public override string ToString()
        {
            return $"{GroupId}. {Name}";
        }

    }
}
