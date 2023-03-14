using System.ComponentModel.DataAnnotations;

namespace DatabaseSync.Core.Entities
{
    public class Mt4User
    {
        [Key]
        public int Login { get; set; }

        public string? Group { get; set; }
    }
}
