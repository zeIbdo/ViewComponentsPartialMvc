namespace ViewComponentsPartialMvc.DataAccessLayer.Entities
{
    public class Header:BaseEntity
    {
        public string LogoUrl { get; set; }
        public string CompanyName { 
        get; set;}
        public string Description
        {

        get; set;}
        public string MascotFurnitureImgUrl {  get; set;}
    }
}
