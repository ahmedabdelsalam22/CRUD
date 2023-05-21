using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRUD.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1,100,ErrorMessage = "Display Order nust be between 1 and 100") ]
        public int DisplayOrder { get; set; }
        [DisplayName("Created DateTime")] 
        public DateTime CreatedDateTime { get; set; } = DateTime.Now;

    }
}
