using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class Country
    {
        public string Name { get; set; }
        public uint TotalPopulation
        {
            get
            {
                uint total = default;
                foreach (Settlement settlement in Settlements)
                {
                    total += settlement.Population;
                }
                return total;
            }
        }
        public List<Settlement> Settlements { get; set; }

        public Country()
        {
            Settlements = new List<Settlement>();
        }

        public List<Settlement> FindAllByPopulation(uint min, uint max)
        {
            List<Settlement> settlements = new List<Settlement>();
            foreach (Settlement settlement in Settlements)
            {
                if (settlement.Population >= min && settlement.Population <= max)
                {
                    settlements.Add(settlement);
                }
            }
            return settlements;
        }

        public void AddSettlement(Settlement settlement)
        {
            Settlements.Add(settlement);
        }

        public void ShowSettlementsInfos()
        {
            foreach (Settlement settlement in Settlements)
            {
                if(settlement is City city)
                {
                    Console.WriteLine($"{city.Name}, {city.Population}, {city.PoliceDepartment}");
                }
                else
                {
                    Console.WriteLine($"{settlement.Name}, {settlement.Population}, {((Village)settlement).Farm}");
                }
            }
        }
    }
}
