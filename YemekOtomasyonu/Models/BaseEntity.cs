using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YemekOtomasyonu.Models
{
    public class BaseEntity
    {
        public String Ad { get; set; }

        public override string ToString()
        {
            return Ad.ToString();
        }
    }
}
