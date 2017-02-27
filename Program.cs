using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




using System.ComponentModel.DataAnnotations;namespace ClMvcD13.Model
{
    public class Program
    {
        [Key]
        public int ProgramID { get; set; }
        [MaxLength(15)]
        public string ProgramName { get; set; }
        public int JurusanID { get; set; }
        public Jurusan Jurusan {get;set; }
        public ICollection<Siswa> Siswas { get; set; }
    }
}
