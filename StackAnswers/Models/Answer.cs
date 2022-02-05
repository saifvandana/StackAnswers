using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Threading.Tasks;

namespace StackAnswers.Models
{
    public class Answer
    {
        public int AnswerID { get; set; }

        public string Name { get; set; }

        [Column(TypeName = "ntext")]
        public string Body { get; set; }

        public int PostID { get; set; }
    }
}
