using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace KellyProject.Models.Requests
{
    public class YogaPracticeRequestModel
    {
        [Required]
        public int YogiId { get; set; }

        public string PracticeDate { get; set; }

        public string InstructorName { get; set; }

    }
}
