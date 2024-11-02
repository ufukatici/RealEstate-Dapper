﻿namespace RealEstate_Dapper_UI.Dtos.PropertyDtos
{
    public class ResultLast3PropertyWithCategoryDto
    {
        public int PropertyID { get; set; }

        public string Title { get; set; }

        public decimal Price { get; set; }

        public string City { get; set; }

        public string District { get; set; }

        public string CoverImage { get; set; }

        public int PropertyCategory { get; set; }

        public string CategoryName { get; set; }

        public DateTime AdvertisementDate { get; set; }
    }
}
