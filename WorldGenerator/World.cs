namespace WorldGenerator
{
    public class World
    {
        public enum Soil { SAND, ROCK, DIRT, CLAY} // může nabývat pouze těchto hodnot
        public enum Climate { TROPICAL, DRY, TEMPERATE, CONTINENTAL, POLAR }
        private readonly Soil soil;
        private readonly Climate climate;
        private readonly byte waterBodiesFrequency; // máme byte, abychom nemuseli nastavovat min a max
        private readonly byte treesFrequency;
        private readonly int area;
        private readonly int population;
        private readonly string dominantReligion;
        private readonly string language;
        private readonly bool hasOceans;
        private readonly double averageTemperature;
        private readonly bool hasDeserts;
        private readonly List<string> majorCities;

        private World(Soil soil, Climate climate, byte waterBodiesFrequency, byte treesFrequency, int area, int population, string dominantReligion, string language, bool hasOceans, double averageTemperature, bool hasDeserts, List<string> majorCities)
        {
            this.soil = soil;
            this.climate = climate;
            this.waterBodiesFrequency = waterBodiesFrequency;
            this.treesFrequency = treesFrequency;
            this.area = area;
            this.population = population;
            this.dominantReligion = dominantReligion;
            this.language = language;
            this.hasOceans = hasOceans;
            this.averageTemperature = averageTemperature;
            this.hasDeserts = hasDeserts;
            this.majorCities = majorCities;
        }

        public class Builder // static znamená, že nebudou vytvořené instance, není možné ani zavolat defaultní konstruktor
        {
            private Soil soil = World.Soil.DIRT; // musíme napsat classifier, aby si to nemyslelo, že myslím metodu na téhle třídě

            private byte waterBodiesFrequency = 128; 

            private byte treesFrequency = 128;

            private int area = 1000;
            private int population = 1000;
            private string dominantReligion = "Pastafarianism";
            private string language = "English";
            private Climate climate = World.Climate.CONTINENTAL;
            private bool hasOceans = true;
            private double averageTemperature = 17.5;
            private bool hasDeserts = false;
            private List<string> majorCities = new List<string>(){ "SaltCity", "SweetTown", "Las Pizzas" };

            public Builder Soil(Soil soil)
            {
                this.soil = soil;
                return this;
            }

            public Builder WaterBodiesFrequency(byte waterBodiesFrequency)
            {
                this.waterBodiesFrequency = waterBodiesFrequency;
                return this;
            }

            public Builder TreesFrequency(byte treesFrequency)
            {
                this.treesFrequency = treesFrequency;
                return this;
            }

            public Builder Climate(Climate climate)
            {
                this.climate = climate;
                return this;
            }
            public Builder Population(int population)
            {
                this.population = population;
                return this;
            }
            public Builder HasOceans(bool hasOceans)
            {
                this.hasOceans = hasOceans;
                return this;
            }
            public Builder AverageTemperature(double averageTemperature)
            {
                this.averageTemperature = averageTemperature;
                return this;
            }
            public Builder Language(string language)
            {
                this.language = language;
                return this;
            }

            public Builder HasDeserts(bool hasDeserts)
            {
                this.hasDeserts = hasDeserts;
                return this;
            }

            public Builder MajorCities(List<string> majorCities)
            {
                this.majorCities = majorCities;
                return this;
            }

            public Builder DominantReligion(string dominantReligion)
            {
                this.dominantReligion = dominantReligion;
                return this;
            }
            public Builder Area(int area)
            {
                this.area = area;
                return this;
            }

            public World Build()
            {
                return new World(soil, climate, waterBodiesFrequency, treesFrequency, area, population, dominantReligion, language, hasOceans, averageTemperature, hasDeserts, majorCities);
            }

        }


        public override string ToString()
        {
            return
                $"{nameof(soil)}: {soil}, {nameof(climate)}: {climate}, {nameof(waterBodiesFrequency)}: {waterBodiesFrequency}, {nameof(treesFrequency)}: {treesFrequency}, {nameof(area)}: {area}," +
                $" {nameof(population)}: {population}, {nameof(dominantReligion)}: {dominantReligion}, {nameof(language)}: {language}, {nameof(hasOceans)}: {hasOceans}," +
                $" {nameof(averageTemperature)}: {averageTemperature}, {nameof(hasDeserts)}: {hasDeserts}, {nameof(majorCities)}: {majorCities}";
        }
    }
}
