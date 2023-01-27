namespace WorldGenerator;
public class OceanWorldBuilder : IWorldBuilder {
        public WorldBuilder GetWorld(){
            return new WorldBuilder(200, 70, 10);
        }
    }
