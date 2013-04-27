using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Thorgerson.Models
{
    public class Post
    {
        private ICollection<Category> _categories;

        public Post()
        {
            _categories = new HashSet<Category>();
        }

        public int Id
        {
            get;
            set;
        }

        public string Title
        {
            get;
            set;
        }

        public string Slug
        {
            get;
            set;
        }

        public string Layout
        {
            get;
            set;
        }

        [DataType(DataType.Html)]
        public string Content
        {
            get;
            set;
        }

        public DateTime Date
        {
            get;
            set;
        }

        public string Author
        {
            get;
            set;
        }

        public virtual ICollection<Category> Categories
        {
            get { return _categories; }
            set { _categories = value; }
        }
    }
}
