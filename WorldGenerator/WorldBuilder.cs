namespace WorldGenerator;
public class WorldBuilder : IWorldBuilder
{
    public readonly int Size;
    public readonly int WaterPercent;
    public readonly int TreeCount;
        
    public WorldBuilder(int size, int waterPercent, int treeCount){
        this.Size = size;
        this.WaterPercent = waterPercent;
        this.TreeCount = treeCount;
    }
    public WorldBuilder GetWorld(){
        return this;
    }
}


