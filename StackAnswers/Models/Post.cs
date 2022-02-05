using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace StackAnswers.Models
{
    public class Post
    {
        public int PostID { get; set; }

        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }
    }
}
