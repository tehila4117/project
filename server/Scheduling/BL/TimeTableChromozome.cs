using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accord.Genetic;
using DAL;
using DTO;
namespace BL
{
    struct TimeSlotChromozome
    {
        DTO.StudentsDTO StudentCode;
      
    }
    class TimeTableChromozome : ChromosomeBase
    {
        //חיבור למסד נתונים
        private readonly DBConection dBConection;


        static Random Random = new Random();

        //מס' מזהה של המוסד
        public int SchoolCode { get; set; }


        /// <summary>
        /// פעולה בונה מאתחלת נתונים
        /// </summary>
        /// <param name="db">חיבור לDB</param>
        /// <param name="schoolCode">מזהה של המוסד</param>
        public TimeTableChromozome(DBConection db, int schoolCode)
        {
            dBConection = db;
            SchoolCode = schoolCode;
            Generate();
        }
       
       
        //יצירת מערכת ראשונית בודדת
        public override void Generate()
        {


        }
    }
}
