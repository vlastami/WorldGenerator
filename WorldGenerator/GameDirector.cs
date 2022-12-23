using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorldGenerator
{
    public class GameDirector
    {
        private readonly World.Builder worldBuilder = new World.Builder();
        private World? createdWorld; //v c# jsou všechny datové typy non-nullable defaultně, otazník z toho udělá nullable

        // pokud bychom chtěli mít non-nullable proměnnou, museli bychom vytvořit konstruktor a vytvářet světy v konstruktoru podle enumu, který přijde v parametru

        public void createDesertWorld()
        {
            createdWorld = worldBuilder
                .Soil(World.Soil.SAND)
                .TreesFrequency(11)
                .WaterBodiesFrequency(21)
                .Area(100000)
                .HasDeserts(true)
                .Climate(World.Climate.TROPICAL)
                .Population(1000)
                .HasOceans(false)
                .AverageTemperature(50)
                .Build();
        }

        public void createCrowdedWorld()
        {
            createdWorld = worldBuilder
                .Soil(World.Soil.DIRT)
                .TreesFrequency(240)
                .WaterBodiesFrequency(200)
                .Climate(World.Climate.TEMPERATE)
                .Population(1000000000)
                .HasOceans(true)
                .AverageTemperature(25)
                .Language("Esperanto")
                .DominantReligion("Christianity")
                .MajorCities(new List<string>{ "New York", "Hongkong", "LA" })
                .Build();
        }

        public void createTinyWorld()
        {
            createdWorld = worldBuilder
                .Area(1000)
                .Build();
        }

        public string getWorldInfo()
        {
            return createdWorld.ToString();

        }
    }
}
