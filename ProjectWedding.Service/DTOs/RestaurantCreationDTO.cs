﻿using ProjectWedding.Domain.Entities;
using ProjectWedding.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWedding.Service.DTOs
{
    public class RestaurantCreationDTO
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Location { get; set; }
        public int Price { get; set; }
        public RestaurantQualitys Quality { get; set; }
        public List<int> availableDays { get; set; }
        public string Email { get; set; }
        public string Capacity { get; set; }
        public List<Product> Products { get; set; }
    }
}
