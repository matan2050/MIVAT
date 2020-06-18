using OpenTK;

namespace MIVAT.Layers
{
    /// <summary>
    /// represents a displayable layer
    /// items may include ROI, volumes, etc
    /// </summary>
    public abstract class Layer
    {
        public BoundingBox BBX { get; protected set; }
        public string Name { get; protected set; }

        public abstract void Display();
    }
}
