using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HoangDinhDu355.Models
{
    
    public class HDD0355
    {
        [Key]
        [StringLength(20)]
        public String HDDId { get; set; }
        [StringLength(50)]
        [Required]
        public string HDDname { get; set; }
         public string HDDGender { get; set; }
         
        
        
         


        
    }
}