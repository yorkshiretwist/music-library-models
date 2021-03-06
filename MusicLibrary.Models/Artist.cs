﻿using System.Collections.Generic;

namespace MusicLibrary.Models
{
    /// <summary>
    /// Represents an artist
    /// </summary>
    public class Artist
    {
        public string Name { get; set; }

        public List<Album> Albums { get; set; } = new List<Album>();
    }
}
