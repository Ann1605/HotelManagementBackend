namespace HotelManagement.Models
{
    public class Rooms
    {
        public int Id { get; set; }
        public int hostel_id { get; set; }
        public string? hostel_name { get; set; }
        public string? hostel_description { get; set; }
        public string? type_of_rooms { get; set; }
        public string? type_of_food { get; set; }
        public float rate { get; set; }
        public int heads_per_room { get; set; }
        public string? image { get; set; }  

        public string? hostel_address { get; set; }

    }
}
