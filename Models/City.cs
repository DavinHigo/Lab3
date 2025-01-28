
namespace Lab3.Models

{

    public class City

    {

        public int CityId { get; set; }

        public string? CityName { get; set; }

        public int Population { get; set; }

        public string? ProvinceCode { get; set; }

        public Province? Province { get; set; } // Add this line

    }

}
