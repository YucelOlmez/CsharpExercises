using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    class Urun
    {
        public int Id { get; set; }    //Buradaki Id urunun eşsiz bir numaralandırma ile tutulup karıştırılmaması için eklenmiştir. Bunu eklemeyi unutmamalıyız.
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int stokAdedi { get; set; }


    }
}
