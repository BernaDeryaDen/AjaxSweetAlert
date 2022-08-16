using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AjaxSweetAlert.Models
{
    public class Sector
    {
        [Key]
        [DatabaseGenerated( DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Description")]
        [MaxLength(155)]
        public string Description { get; set; }

    }
}
