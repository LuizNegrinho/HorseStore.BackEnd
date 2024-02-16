namespace HorseStore.BackEnd.Models
{
    public class ProductIndexModel
    {

      
        public string ImageUrl { get; set; }   
        public string BirthDate { get; set; }
        public int SellPrice { get; set; }
        public int MinPrice { get; set; }       
        public string Mother { get; set; }
        public string Father { get; set; }
        public string MaxBid { get; set; }
        public int MaxBidUserId { get; set; }



        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Sufix { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float ActualPrice { get; set; } = float.MinValue;
        public List<BidModel> Bids { get; set; } = new List<BidModel>();
    }

    public class BidModel
    {
        public int Id { get; set; } = int.MinValue;
        public string Name { get; set; } = string.Empty;
        public string Location { get; set; } = string.Empty;
        public float value { get; set;} = float.MinValue;
    }

}