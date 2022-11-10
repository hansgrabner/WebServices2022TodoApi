using System.ComponentModel.DataAnnotations;

namespace TodoApi.Models
{
    public class Lektor
    {
        public int LektorId { get; set; }

        [MinLength(2)]
        public string Vorname { get; set; }
        public string Nachname { get; set; }
    }
}
