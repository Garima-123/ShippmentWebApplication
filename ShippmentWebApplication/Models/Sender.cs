
namespace ShippmentWebApplication.Models
{
    using System;
    using System.Collections.Generic;
   
    public partial class Sender
    {
        //IEnumerable<Sender> Senders = Enumerable.Empty<Sender>();
        public int SenderId { get; set; }
        public string SenderName { get; set; }
        public string Description { get; set; }
        public string RecipientAddress { get; set; }
        public string Expedited { get; set; }
        public string Shipment { get; set; }
        public string Action { get; set; }

       
    }

   
}
