using System.ComponentModel.DataAnnotations;

namespace TiketApi.Models
{
    public class TiketModel
    {
        [Key]
        public long Id { get; set; }
        public DateTime WaktuSkrg { get; set; }
        public string NamaPenumpang { get; set; }
        public long NomorPenumpang { get; private set; }
        public string Dari { get; set; }
        public string Ke { get; set; }
        public int HargaTiket { get; set; }
        public DateTime WaktuBuat { get; set; }
        public DateTime WaktuUpdate { get; set; }
        public string Komentar { get; set; } = "Normal";


    }
}
