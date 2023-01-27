namespace WorldGenerator;

public class Director {
    public WorldBuilder ConstructWorld(IWorldBuilder worldBuilderBuilder) {
        return worldBuilderBuilder.GetWorld();
    }
}