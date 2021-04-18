using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork8.Pratybos
{
    class PointInTime
    {
        private DateTime TimePoint;
        private string Place;
        private string Comments;

        public PointInTime(DateTime time, string place = "Lithuania", string comments = "Sanny day")
        {
            TimePoint = time;
            Place = place;
            Comments = comments;
        }

        public void SetTimePoint(DateTime timepoint)
        {
            TimePoint = timepoint;
        }
        public DateTime GetTimePoint()
        {
            return TimePoint;
        }
        public void SetPlace(string place)
        {
            Place = place;
        }
        public string GetPlace()
        {
            return Place;
        }
        public void SetComments(string comments)
        {
            Comments = comments;
        }
        public string GetComments()
        {
            return Comments;
        }


    }
}
