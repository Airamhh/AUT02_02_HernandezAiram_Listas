using System.ComponentModel.DataAnnotations;

namespace AUT02_02_HernandezAiram_Listas.Models
{
    public class Personaje
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Family { get; set; }
        public int NChildren { get; set; }

    }
}
