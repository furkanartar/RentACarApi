using Core.Entities;

namespace Entities
{
    public class Findeks : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public short Score { get; set; }
    }
}