namespace MyFood.com.Entity
{
    public class Category
    {
        public int ID { get; set; }
        public string? Name { get; set; }
        public List<Menu>? Menus { get; set; }
    }
}
