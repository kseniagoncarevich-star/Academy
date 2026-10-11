using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AcademyCW.Models
{
    public class Direction
    {
        [Key]
        public byte direction_id { get; set; }
        public string direction_name { get; set; }
    }
}
