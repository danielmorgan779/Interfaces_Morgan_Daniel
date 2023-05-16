using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces_Morgan_Daniel
{
    /// <summary>
    /// Made an interface called IGenre with automatic properties for esrb, genre, and title. Also a defined method called Describe
    /// </summary>
    interface IGenre
    {

        public string Esrb { get; set; }

        public string Genre { get; set; }

        public string Title { get; set; }

        public string Describe();

    }
}
