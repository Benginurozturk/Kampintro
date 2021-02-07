using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaignService
    {
        public void AddCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Eklendi" + campaign.CampaignName + campaign.CampaignDuration + campaign.CampaignDescription);
        }

        public void DeleteCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");

        }

        public void UpdateCampaign(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
