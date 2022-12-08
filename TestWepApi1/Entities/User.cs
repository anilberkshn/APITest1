using System.ComponentModel;

namespace TestWepApi1.Entities
{
    public class User
    {
        public int Id { get; set; }
        [DisplayName("Adi")]
        public string Name { get; set; }
        [DisplayName("Soyadi")]
        public string Surname { get; set; }
    }
}