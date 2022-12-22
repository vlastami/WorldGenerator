using System;

namespace WorldGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            World.Builder worldBuilder = new World.Builder();
            World myWorld = worldBuilder
                .Soil(World.Soil.SAND)
                .TreesFrequency(78)
                .WaterBodiesFrequency(43)
                .Area(100000)
                .HasDeserts(true)
                .Build();
            
        }
    }



}