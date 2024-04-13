using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoviesDemoAPI.Entities
{
    [Table("tb_movies")]
    public class Movie
    {
        [Key]
        [Column("movie_id")]
        public int Id { get; set; }
        [Column("movie_name")]
        [StringLength(20)]
        public string Name { get; set; }
        [Column("movie_synopsis")]
        [StringLength(60)]
        public string Synopsis { get; set; }
    }
}
