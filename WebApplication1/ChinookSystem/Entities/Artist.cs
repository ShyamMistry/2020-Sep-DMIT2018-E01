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
    //Annotate your entity to link to the sql table
    // indicate primary key type
    // include validate on fields

    [Table("Artists")]
    internal class Artist
    {
        //private data members
        private string _Name;

        //properties
        //each sql table attribute will be mapped within this entitiy defination
        //Annotation is required
        //[Key] primary key
        //an additional option within this annotaiton is DatabaseGenerated()
        //by default is no DatabaseGenerate option is given, the primary key is assumed to be an Identity sql primary key
        // Identity pkey:[key] or
        // [key, DatabaseGenerated(DatabaseGeneratedOption.none)]
        //public string ISBN { get; set; }


        //there is a third option for DatabaseGenerated() and that is .computed

        //Compound primary keys
        //the order of declared your primary compound key field as properties Must be in the order they exist
        //[key, Column(Order=n)]
        //property
        //[Key, Column(Order=n+1)]
        //property
        //[Key, Column(Order=n+2)]

        [Key]
        public int ArtistId { get; set; }

        //[Required(ErrorMessage = "Name is required")]
        //[StringLength(120, ErrorMessage = "Name is limited to 120 char")]
        public string Name
        {
            get { return _Name; }
            set {
                _Name = string.IsNullOrEmpty(value) ? null : value;
            }   
        }
        //constructors

        //behaviours

        public virtual ICollection<Album> Album { get; set; }
    }
}
