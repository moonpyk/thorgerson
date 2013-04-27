using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Thorgerson.Models
{
    public class Category
    {
        private ICollection<Post> _posts;

        public Category()
        {
            _posts = new HashSet<Post>();
        }

        public int Id
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }

        public virtual ICollection<Post> Posts
        {
            get { return _posts; }
            set { _posts = value; }
        }
    }
}
