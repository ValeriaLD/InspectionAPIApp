using System.ComponentModel.DataAnnotations;

namespace InspectionAPI
{
    public class Status
    {
        public int StatusId { get; set; }
        
        [StringLength(20)]
        public string StatusOption { get; set; } = string.Empty;
    }
}
