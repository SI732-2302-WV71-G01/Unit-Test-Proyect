using System;
namespace TestProject1.TestStoreImage
{
    public class StoreImageServiceClas
    {
        private int _id;
        public int Id
        {
            get { return _id; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Id cannot be negative");
                }
                _id = value;
            }
        }

        private string _enconded64Image;
        public string Enconded64Image
        {
            get { return _enconded64Image; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Enconded64Image cannot be null or empty");
                }
                _enconded64Image = value;
            }
        }

        private int _storeId;
        public int StoreId
        {
            get { return _storeId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("StoreId cannot be negative");
                }
                _storeId = value;
            }
        }
        
    }
}
