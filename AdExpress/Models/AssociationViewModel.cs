using System;

namespace AdExpress.Models
{
    public class AssociationViewModel
    {
        public int ID { get; set; }
        public DateTime StarDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
        public int AdId { get; set; }
        public string AdTitle { get; set; }
        public int NewspaperId { get; set; }
        public string NewspaperName { get; set; }
    }
}