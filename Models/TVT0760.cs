using System.ComponentModel.DataAnnotations;

namespace TranVanTuyen760.Models
{
    public class TVT0760
    {
        [Key, StringLength(20), Display(Name = "ID")]
        public string TVTId { get; set; }
        [Required, StringLength(50), Display(Name = "Họ và tên")]
        public string TVTName { get; set; }
        [Required, Display(Name = "Giới tính nam")]
        public bool TVTGender { get; set; }
    }
}