using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace managementSystem.Models
{
    public class UserModel
    {
        [Key]
        public int id { get; set; }
        [Required, Column(TypeName = "nvarchar(50)")]
        public string name { get; set; }

        [Required ,Column (TypeName = "nvarchar(50)")]
        public string surName { get; set; }
        
        [Required, Column (TypeName = "nvarchar(13)")]
        public string idCard { get; set; }

        [Column (TypeName ="nvarchar(6)")]
        public string sex { get; set; }

        [Required, Column (TypeName ="nvarchar(20)")]
        public string department { get; set; }

        [Required, Column (TypeName = "nvarchar(10)")]
        public string tel { get; set; }
    }
}
