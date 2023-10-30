using System;
namespace TestProject1.TestStore
{
    public class StoreServiceClas
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

        private string _description;
        public string Description
        {
            get { return _description; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Description cannot be null or empty");
                }
                _description = value;
            }
        }

        private string _address;
        public string Address
        {
            get { return _address; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Address cannot be null or empty");
                }
                _address = value;
            }
        }

        private string _encoded64LogoImage;
        public string Encoded64LogoImage
        {
            get { return _encoded64LogoImage; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Encoded64LogoImage cannot be null or empty");
                }
                _encoded64LogoImage = value;
            }
        }
    }
}
