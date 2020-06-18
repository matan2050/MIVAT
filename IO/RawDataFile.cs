namespace IO
{
    public class RawDataFile
    {
        public string Path { get; private set; }
        public int HeaderShift { get; private set; }
        public int FooterShift { get; private set; }
        public int DimX { get; private set; }
        public int DimY { get; private set; }
        public int DimZ { get; private set; }
    }

    /// <summary>
    /// DataFormat represents parsing method of pixel data
    /// from raw data file
    /// </summary>
    public enum DataFormat
    {
        FloatLittleEndian,
        FloatBigEndian,
        Int64,
        Int32,
        UnsignedInt32,
        UnsignedInt64
    }
}
