using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVC_Application_1.Models
{
    public class Info
    {
        [Key]
        [Column(Order = 1)]
        public int PersonID { get; set; }
        [Key]
        [Column(Order = 2)]
        public int TelNo { get; set; }
        [Key]
        [Column(Order = 3)]
        public int CellNo { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        public int AddressCode { get; set; }
        public string PostalAddress1 { get; set; }
        public string PostalAddress2 { get; set; }
        public int PostalCode { get; set; }
    }
}
