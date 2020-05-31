using OpenTK;

namespace MIVAT.Layers
{
    public abstract class Layer
    {
        public BoundingBox BBX { get; protected set; }
        public string Name { get; protected set; }

        public abstract void Display();
    }
}
