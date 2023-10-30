using System;
namespace TestProject1.TestProduct
{
     public class ProductServiceClas
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

        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Name cannot be null or empty");
                }
                _name = value;
            }
        }

        private int _rating;
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Rating cannot be negative");
                }
                _rating = value;
            }
        }

        private string _image;
        public string Image
        {
            get { return _image; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Image cannot be null or empty");
                }
                _image = value;
            }
        }

        private string _category;
        public string Category
        {
            get { return _category; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Category cannot be null or empty");
                }
                _category = value;
            }
        }

        private int _price;
        public int Price
        {
            get { return _price; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Price cannot be negative");
                }
                _price = value;
            }
        }

        private string _inventoryStatus;
        public string InventoryStatus
        {
            get { return _inventoryStatus; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("InventoryStatus cannot be null or empty");
                }
                _inventoryStatus = value;
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
