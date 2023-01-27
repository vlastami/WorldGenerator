namespace WorldGenerator;

public class WorldBuilder : IWorldBuilder
{
    
        public int size;
        public int waterPercent;
        public int treeCount;
        public int width;
        public int height;
        public WorldBuilder(int size, int waterPercent, int treeCount, int width, int height){
            this.size = size;
            this.waterPercent = waterPercent;
            this.treeCount = treeCount;
            this.height = height;
            this.width = width;
        }
        public WorldBuilder getWorld(){
            return this;
        }
    }


