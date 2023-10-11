using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PortFolio.web.Models
{
    public class AdminProfile
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public String Title { get; set; }
        [DataType(DataType.EmailAddress)] 
        public string EmailAddress { get; set; }
        [Description("Professional Summary")]
        public string Summary { get; set; }
        public string FullName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string? Website { get; set; }
    }
}
