namespace ViewComponentsPartialMvc.DataAccessLayer.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; } = null!;
        public double Price { get; set; }
        public string ImageUrl { get; set; } = null!;
    }
}
