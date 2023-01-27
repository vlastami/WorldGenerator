namespace WorldGenerator;
public class DesertWorldBuilder : IWorldBuilder {
        public WorldBuilder GetWorld(){
            return new WorldBuilder(100, 10, 5);
        }
    }
