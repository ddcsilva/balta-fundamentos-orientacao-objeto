using System.Collections.Generic;

namespace Balta.ContentContext
{
    public class Carrer : Content
    {
        public Carrer()
        {
            Items = new List<CarrerItem>();
        }

        public IList<CarrerItem> Items { get; set; }
        public int TotalCourses => Items.Count; // Expression Body
    }
}