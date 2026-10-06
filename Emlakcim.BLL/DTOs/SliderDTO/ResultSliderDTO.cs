using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Emlakcim.BLL.DTOs.SliderDTO
{
    public class ResultSliderDTO
    {
        public int Id { get; set; }
        
        [StringLength(100)] //Attribute
        public string Title { get; set; }

        [StringLength(200)]
        public string? Description { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }

        [StringLength(30)]
        public string Page { get; set; }
    }
}
