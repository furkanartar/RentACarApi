using Core.Entities;

namespace Entities.Dtos
{
    public class RentalDetailDto : IDto
    {
        public string BrandName { get; set; }
        public string FullName { get; set; }
    }
}