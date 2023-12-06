using PITCupCake.WebAPI.DAO;
using PITCupCake.WebAPI.Model;

namespace PITCupCake.WebAPI.Services
{
   public class CupCakesServices
   {
      #region *----------- Singleton ------------*

      private static CupCakesServices? _instance;

      private CupCakesServices()
      {

      }

      public static CupCakesServices GetInstance()
      {
         return _instance ?? (_instance = new CupCakesServices());
      }

      #endregion

      public List<Model.CupCake> Listar()
      {
         return new CupCakeContext().CupCake.ToList().ConvertAll(x => new Model.CupCake
         {
            Id = x.Id,
            Description = x.Description,
            ImageAlt = x.ImageAlt,
            ImageCredit = x.ImageCredit,
            ImageURL = x.ImageURL,
            Name = x.Name,
            Price = x.Price
         });
      }
   }
}