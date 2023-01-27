namespace WorldGenerator;


    public class OceanWorldBuilderBuilder : IWorldBuilder {
        public WorldBuilder getWorld(){
            return new WorldBuilder(200, 70, 10, 100, 100);
        }
    }
