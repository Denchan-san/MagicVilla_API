using System.Text.Json.Serialization.Metadata;

namespace MagicVilla_VillaAPI.Models
{
    public class Pagination
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
