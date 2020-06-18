namespace DataTypes
{
    public class Volume
    {
        public int DimX { get; private set; }
        public int DimY { get; private set; }
        public int DimZ { get; private set; }
        public float VoxelSizeX { get; private set; }
        public float VoxelSizeY { get; private set; }
        public float VoxelSizeZ { get; private set; }
        public float[] PixelData { get; private set; }
    }
}
