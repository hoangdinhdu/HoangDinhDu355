using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangDinhDu355.Models
{
    [Table("CompanyHDD355")]
    public class CompanyHDD355
    {
        [Key]
        [StringLength(20)]
        public String CompanyId { get; set; }
        [StringLength(50)]
        public string CompanyName { get; set; }
         
        
        
         


        
    }
}