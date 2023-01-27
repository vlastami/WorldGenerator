namespace WorldGenerator;

    public class DesertWorldBuilderBuilder : IWorldBuilder {
        public WorldBuilder getWorld(){
            return new WorldBuilder(100, 10, 5, 100, 100);
        }
    }
