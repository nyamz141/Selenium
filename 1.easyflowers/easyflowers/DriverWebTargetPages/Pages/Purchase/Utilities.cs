using System;
namespace DriverWebTargetPages.Pages.Purchase
{
	public class Utilities
	{
        public string returnOccasaionDroDownValue(int min, int max)
        {
            return new Random().Next(min, max + 1).ToString();
        }

        public string returnLocationDropValue()
        {
            string[] values = {
                "Residential","Business","Hospital","Funeral","School","Other"
            };
            return values[new Random().Next(0, values.Length - 1)];
        }

        public string recipientState()
        {
            string[] values = {
                "ACT","NSW","NT","QLD","SA","TAS","VIC","WA"
            };
            return values[new Random().Next(0, values.Length - 1)];
        }
    }
}

