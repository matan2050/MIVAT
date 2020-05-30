using OpenTK;

namespace MIVAT.Layers
{
    public class BoundingBox
    {
        public Vector3 Min { get; private set; }
        public Vector3 Max { get; private set; }

        public BoundingBox(float minX, float minY, float minZ, float maxX, float maxY, float maxZ)
        {
            Min = new Vector3(minX, minY, minZ);
            Max = new Vector3(maxX, maxY, maxZ);
        }
    }
}
