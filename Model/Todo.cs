using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SwaggerLab.Model
{
    public class Todo
    {
        [Newtonsoft.Json.JsonIgnore]
        public Guid ID { get; set; } = Guid.NewGuid();

        [Required]
        public User User { get; set; }

        [Required]
        public string Note { get; set; }

        public DateTimeOffset DeadLine { get; set; }

        public DateTimeOffset CreateDT { get; set; } = DateTime.Now;
    }
}
