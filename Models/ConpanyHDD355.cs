using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HoangDinhDu355.Models;
{
     
}

namespace HoangDinhDu355.Models
{
    [Table("CompanyHDD355")]
    public class CompanyHDD355 : StringProcessHDD355
    {
        [Key]
        [StringLength(20)]
        public String CompanyId { get; set; }
        [StringLength(50)]
        [Required]
        public string CompanyName { get; set; }
         
        
        
         


        
    }
}