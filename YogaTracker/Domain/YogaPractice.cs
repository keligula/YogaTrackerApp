using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KellyProject.Domain
{
    public class YogaPractice

    {
        public int PracticeId { get; set; }

        public int YogiId { get; set; }

        public DateTime PracticeDate { get; set; }

        public string InstructorName { get; set; }

    }
}
