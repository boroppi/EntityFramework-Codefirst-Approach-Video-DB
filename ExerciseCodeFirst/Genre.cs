using System.Collections;
using System.Collections.Generic;

namespace ExerciseCodeFirst
{
    public class Genre
    {
        public byte Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Video> Videos { get; set; }
    }
}