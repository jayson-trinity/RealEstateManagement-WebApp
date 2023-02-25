using Microsoft.EntityFrameworkCore;
using System.Xml;

namespace TRINTY_ESTATES.Models
{
    public class RentListingModel
    {
        public int Id { get; set; }
        public List<byte[]> Images { get; set; } 
        public string Description { get; set; }
    }

 
}
