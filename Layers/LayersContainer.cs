using System.Collections.Generic;

namespace MIVAT.Layers
{
    public class LayersContainer
    {
        public Dictionary<string, Layer> Container { get; private set; }

        public void AddLayerToContainer(Layer _layer)
        {
            if (!Container.TryGetValue(_layer.Name, out Layer layer))
            {
                Container.Add(layer.Name, layer);
            }
            else
            {
                throw new ArgumentException("layer already exists");
            }
        }

        public void RemoveLayerFromContainer(string name)
        {
            if (Container.TryGetValue(name, out Layer layer))
            {
                Container.Remove(name);
            }
            else
            {
                throw new ArgumentException("layer to remove does not exist");
            }
        }

        public List<string> GetContainerStatus()
        {
            List<string> layersName = new List<string>(Container.Count);
            foreach (var layerName in Container.Keys)
            {
                layersName.Add(layerName);
            }
            return layersName;
        }
    }
}
