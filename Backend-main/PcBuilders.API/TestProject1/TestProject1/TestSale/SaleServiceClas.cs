using System;
namespace TestProject1.TestSale
{
    public class SaleServiceClas
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

        private string _code;
        public string Code
        {
            get { return _code; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Code cannot be null or empty");
                }
                _code = value;
            }
        }

        private int _purchaserId;
        public int PurchaserId
        {
            get { return _purchaserId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("PurchaserId cannot be negative");
                }
                _purchaserId = value;
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
