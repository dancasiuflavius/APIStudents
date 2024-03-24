namespace ProductsCrudApi.Products.Dto
{
    public class CreateProductRequest
    {
        public string Name { get; set; }
        public int Age { get; set; } 
        public string Gender { get; set; } 
        public DateTime DateOfBirth { get; set; } 
    }
}
