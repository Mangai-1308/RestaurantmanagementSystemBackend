using System.ComponentModel.DataAnnotations;

namespace RestaurantmanagementSystem.Modals
{
    public class Restaurant
    {
        
        public int Id { get; set; }
        public string? restaurant_name { get; set; }
        public string? description { get; set; }
        public string? type_of_food{ get; set; }
        public string? type_of_cusine { get; set; }
        public string? image { get; set; }
        public string? url { get; set; }
        public decimal rating  { get; set; }  
    }
}
