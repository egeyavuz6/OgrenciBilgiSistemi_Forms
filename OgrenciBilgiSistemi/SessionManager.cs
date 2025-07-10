using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciBilgiSistemi
{
    static class SessionManager
    {
        public static string StudentID { get; set; }

        public static string StudentNameSurname { get; set; }

        public static int ogrenciId { get; set; } // This is used to store the student ID for the current session
    }
}
