using OpenTK;

namespace MIVAT.Layers
{
    public abstract class Layer
    {
        public BoundingBox BBX { get; private set; }
        public string Name { get; private set; }

        public abstract void Display();
    }
}
