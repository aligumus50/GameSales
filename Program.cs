using System;
using GameSalesDemo.Adapters;
using GameSalesDemo.Concrete;
using GameSalesDemo.Entities;

namespace GameSalesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Member member1 = new Member
            {
                //Doğrulama için bilgilerinizi giriniz...

                Id = 1,
                //UserName = "UserName",
                //FirstName = "FirstName",
                //LastName = "LastName",
                //Email = "Email",
                //DateOfBirth = new DateTime(YYYY, MM, DD),
                //NationaalityId = "NationaalityId"

            };

            Game game1 = new Game
            {
                Id = 1,
                GameName = "GAME1",
                GameType = "SPORT",
                Price = 1500

            };

            Campaign campaign1 = new Campaign
            {
                Id = 1,
                CampaignName = "Bahar Kampanyası",
                CampaignDiscount = 100
            };
            

            MemberManager memberManager = new MemberManager(new MernisServiceAdapter());
            memberManager.Add(member1);

            GameManager gameManager = new GameManager();
            gameManager.Add(game1);

            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign1);

            SaleManager saleManager1 = new SaleManager();
            saleManager1.WithoutCampaignBuy(game1,member1);

            SaleManager saleManager2 = new SaleManager();
            saleManager2.WithCampaignBuy(game1,member1,campaign1);


            
        }
    }
}
