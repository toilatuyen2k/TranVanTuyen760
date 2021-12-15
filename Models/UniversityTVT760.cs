using System.ComponentModel.DataAnnotations;

namespace TranVanTuyen760.Models
{
    public class UniversityTVT760
    {
        [Key,StringLength(20),Display(Name ="ID")]
        public string UniversityId { get; set; }
        [StringLength(50),Display(Name ="Họ và tên")]
         public string UniversityName { get; set; }
    }
}