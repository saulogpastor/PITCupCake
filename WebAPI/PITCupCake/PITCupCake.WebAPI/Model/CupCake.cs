using System.Text.Json.Serialization;

using Newtonsoft.Json;

namespace PITCupCake.WebAPI.Model
{  
   public class CupCake
   {
      [JsonProperty("id")]
      public long Id { get; set; }

      [JsonProperty("name")]
      public string Name { get; set; }

      [JsonProperty("price")]
      public decimal Price { get; set; }

      [JsonProperty("description")]
      public string Description { get; set; }

      [JsonProperty("imageURL")]
      public string ImageURL { get; set; }

      [JsonProperty("imageAlt")]
      public string ImageAlt { get; set; }

      [JsonProperty("imageCredit")]
      public string ImageCredit { get; set; }
   }
}