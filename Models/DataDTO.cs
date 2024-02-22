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


    //ProductIndexModel product1 = new()
    //{
    //    Id = 1,
    //    Name = "Pégasus",
    //    Sufix = "Estrela Negra",
    //    Description = "Pégasus é um potro preto majestoso, com uma crina espessa e sedosa que reluz ao sol. Sua postura é elegante e seus movimentos são ágeis e graciosos, característicos da nobre linhagem de cavalos de raça.",
    //    ActualPrice = 100.50f,
    //    Bids = new List<BidModel>
    //    {
    //        new BidModel { Id = 1, Name = "Arthur", Location = "Curitiba, PR", value = 150.75f },
    //        new BidModel { Id = 2, Name = "Guinevere", Location = "Porto Alegre, RS", value = 160.25f }
    //    }
    //};

    //ProductIndexModel product2 = new()
    //{
    //    Id = 1,
    //    Name = "Shadowfax",
    //    Sufix = "Estrela Negra",
    //    Description = "Shadowfax é um potro preto imponente, com uma musculatura poderosa e um porte altivo. Seus olhos brilham com inteligência e sua lealdade é inquestionável, fazendo dele um companheiro fiel e corajoso.",
    //    ActualPrice = 200.75f,
    //    Bids = new List<BidModel>
    //    {
    //        new BidModel { Id = 1, Name = "Legolas", Location = "Salvador, BA", value = 210.25f },
    //        new BidModel { Id = 2, Name = "Gimli", Location = "Florianópolis, SC", value = 220.50f }
    //    }
    //};

    //ProductIndexModel product3 = new()
    //{
    //    Id = 1,
    //    Name = "Bucephalus",
    //    Sufix = "Estrela Negra",
    //    Description = "Bucephalus é um potro preto lendário, com uma história que remonta à antiguidade. Sua força e coragem são conhecidas em todo o mundo, tornando-o um símbolo de bravura e nobreza.",
    //    ActualPrice = 300.25f,
    //    Bids = new List<BidModel>
    //    {
    //        new BidModel { Id = 1, Name = "Alexander", Location = "Manaus, AM", value = 310.75f },
    //        new BidModel { Id = 2, Name = "Hephaestion", Location = "Campo Grande, MS", value = 320.00f }
    //    }
    //};
}