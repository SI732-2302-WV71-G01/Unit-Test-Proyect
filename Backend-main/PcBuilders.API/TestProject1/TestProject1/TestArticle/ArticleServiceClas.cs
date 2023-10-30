using System;
namespace TestProject1.TestArticle
{
    
        public class ArticleServiceClas
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

            private string _user;
            public string User
            {
                get { return _user; }
                set
                {
                    if (string.IsNullOrEmpty(value))
                    {
                        throw new ArgumentException("User cannot be null or empty");
                    }
                    _user = value;
                }
            }
        }
    }
    
