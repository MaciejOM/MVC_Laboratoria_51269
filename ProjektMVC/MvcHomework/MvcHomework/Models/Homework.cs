using System.ComponentModel.DataAnnotations;

namespace MvcHomework.Models;

    public enum HomeworkStatus
    {
        [Display(Name = "Nie rozpoczęte")]
        NieRozpoczete,

        [Display(Name = "W trakcie")]
        WTrakcie,

        [Display(Name = "Ukończone")]
        Ukonczone
}
    public class Homework
    {
     
        public int Id { get; set; }
        [Display(Name = "Przedmiot")]
        [StringLength(60, MinimumLength = 2)]
        [Required]
        public string? Name { get; set; }
        [Required]
        [Display(Name = "Opis Zadania")]
        public string? Description { get; set; }
        [Display(Name = "Termin Wykonania")]
        [DataType(DataType.Date)]
        public DateTime DueDate { get; set; }
        [Display(Name = "Status")]
        [Required]
        public string? Status { get; set; }
    }
