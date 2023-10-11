using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace PortFolio.web.Models
{
    public class ProfileModel
    {
        public int Id { get; set; }
        [StringLength(20)]
        public String Title { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Description("Professional Summary")]
        public string  Summary { get; set; }
        [StringLength(100)]
        public string FullName { get; set; }
        [DataType(DataType.Date)]
        public DateTime DatrOfBiret { get; set; }
        public string? Website { get; set; }
    }
}
