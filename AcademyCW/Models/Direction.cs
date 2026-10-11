using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyCW.Models
{
    public class Direction
    {
        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Принудительное включение автоинкремента (IDENTITY SPECIFICATION)
        [Column("direction_id", TypeName = "TINYINT")]
        public int direction_id { get; set; }
        public string direction_name { get; set; }
    }
}
