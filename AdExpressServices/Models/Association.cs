using System;

namespace AdExpressServices.Models
{
    public class Association
    {
        public int ID { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int AdId { get; set; }
        public int NewspaperId { get; set; }

        public virtual Ad Ad { get; set; }
        public virtual Newspaper Newspaper { get; set; }

    }


}