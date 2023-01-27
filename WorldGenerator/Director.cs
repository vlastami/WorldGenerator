namespace WorldGenerator;

public class Director {
    public WorldBuilder constructWorld(IWorldBuilder worldBuilderBuilder) {
        return worldBuilderBuilder.getWorld();
    }
}