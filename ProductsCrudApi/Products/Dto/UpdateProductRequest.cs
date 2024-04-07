﻿namespace ProductsCrudApi.Products.Dto
{
    public class UpdateProductRequest
    {
        public int Id { get; set; }
        public int? Age { get; set; }
        public string? Name { get; set; }
        public string? Gender { get; set; }

        public DateTime? DateOfBirth { get; set; }
    }
}
