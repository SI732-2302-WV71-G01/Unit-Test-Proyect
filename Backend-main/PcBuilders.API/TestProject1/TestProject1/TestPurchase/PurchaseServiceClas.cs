using System;
namespace TestProject1.TestPurchase
{
    public class PurchaseServiceClas
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

        private int _userId;
        public int UserId
        {
            get { return _userId; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("UserId cannot be negative");
                }
                _userId = value;
            }
        }

       
    }
}
