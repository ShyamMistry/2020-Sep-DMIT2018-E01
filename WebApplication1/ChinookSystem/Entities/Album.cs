﻿using System;
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
    [Table("Albums")]
    internal class Album
    {
        private string _ReleaseLabel;
        [Key]
        public int AlbumId { get; set; }

        [Required(ErrorMessage = "Album Title is a required field")]
        [StringLength(160, ErrorMessage = "Album Title is limit to 160 char")]
        public string Title { get; set; }

        //[ForeignKey] DO NOT USER ********************?????????????/
        public int ArtistId { get; set; }

        //[Range(1950, 3000)]
        public int ReleaseYear { get; set; }

        [StringLength(50, ErrorMessage = "Release label is limit to 50 char")]
        public string ReleaseLabel {
            get { return _ReleaseLabel; }
            set { _ReleaseLabel = string.IsNullOrEmpty(value) ? null : value; }
        }

        //Navitational propertis 
        //Track has an Albums
        public virtual ICollection<Track> Tracks { get; set; }
        public virtual Artist Artist { get; set; }
    }
}
