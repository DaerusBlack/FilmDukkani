using FilmDukkani.Models.Entities.Abstract;
using System;
using System.Collections.Generic;

namespace FilmDukkani.Models.Entities.Concrete
{
    public class Movie : BaseEntity
    {
        public string Name { get; set; }
        public string Director { get; set; }
        public string Summary { get; set; }
        public List<Category>  Category { get; set; }
        public  List<Actor> Actor { get; set; }
        public string TechnicalProps { get; set; }
        public string SoundProps { get; set; }
        public string Subtitles { get; set; }
        public string Trailer { get; set; }
        public string Prizes { get; set; }
        public string BarcodeNumber { get; set; }
        public string Supplier { get; set; }
        public string CoverImage { get; set; }
        public string WonPrizes { get; set; }

    }
}
