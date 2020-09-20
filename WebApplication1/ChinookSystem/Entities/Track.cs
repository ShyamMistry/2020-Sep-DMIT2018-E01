using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#region Additional Namespaces
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
#endregion

namespace ChinookSystem.Entities
{
    [Table("Tracks")]
    internal class Track
    {
        public string _Composer;
        [Key]
        public int TrackId {get; set;}

        [Required(ErrorMessage = "Track Name is a required field")]
        [StringLength(200, ErrorMessage = "Track Name is limit to 200 char")]
        public string Name { get; set; }

        //AlbumId can be null that is why we are using int?
        public int? AlbumId { get; set; }

        public int MediaTypeId { get; set; }

        public int? GenreId { get; set; }

        [Required(ErrorMessage = "Composer Name is a required field")]
        [StringLength(200, ErrorMessage = "Composer Name is limit to 200 char")]
        public string Composer 
        { get { return _Composer; }
          set { _Composer = string.IsNullOrEmpty(value) ? null : value; }
        }

        public int? Milliseconds { get; set; }

        public int Bytes { get; set; }

        public decimal UnitPrice { get; set; }

        //Navitational properties
        //Map relationship of Table A to Table B
        //Track has an Albums
        public virtual Album Album { get; set; }
    }
}
