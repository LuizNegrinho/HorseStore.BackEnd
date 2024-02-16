using System.Collections.Generic;


namespace HorseStore.BackEnd.Repositories
{
    public class DataDTO
    {
        public List<User> Users { get; set; }
        public List<Bid> Bids { get; set; }
        public List<Lot> Lots { get; set; }
    }
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
    }

    public class Bid
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int LotId { get; set; }
        public string Username { get; set; }
        public string Location { get; set; }
        public string Date { get; set; }
        public int Value { get; set; }
    }

    public class Lot
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Name { get; set; }
        public string Sufix { get; set; }
        public string BirthDate { get; set; }
        public int SellPrice { get; set; }
        public int MinPrice { get; set; }
        public List<int> Bids { get; set; }
        public string Mother { get; set; }
        public string Father { get; set; }
        public string MaxBid { get; set; }
        public int MaxBidUserId { get; set; }
    }
}