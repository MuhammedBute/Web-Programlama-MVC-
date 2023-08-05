using System.ComponentModel.DataAnnotations;

namespace MyWebApplicationMVC.Models.sınıflar
{
    public class Doktor
    {
        [Key]
        public int Id { get; set; }
        public string DoctorName { get; set; }
        public string DoctorBranch { get; set; }



    }
}
