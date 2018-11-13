using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constraints
{
    public class Video
    {
        public string Title { get; private set; }
        public Video(string title)
        {
            Title = title;
        }
    }
}
