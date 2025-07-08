using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    public class Grade
    {
        public int Id { get; set; }
        public double Grades { get; set; }
        public int OgrenciId { get; set; }
        public string CourseId { get; set; }
        public Ogrenci Ogrenci { get; set; }

        public Course Course { get; set; }
    }


}
