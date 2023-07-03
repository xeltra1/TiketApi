using System.ComponentModel.DataAnnotations;

namespace TiketApi.DataModels
{
    public class AllDataTiket
    {
        public long Id { get; set; }
        public DateTime WaktuSkrg { get; set; }
        public string NamaPenumpang { get; set; }
        public long NomorPenumpang { get; private set; }
        public string Dari { get; set; }
        public string Ke { get; set; }
        public int HargaTiket { get; set; }
        
    }
}
