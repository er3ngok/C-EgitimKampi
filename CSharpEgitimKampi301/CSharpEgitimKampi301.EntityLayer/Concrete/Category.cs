using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.EntityLayer.Concrete
{
    public class Category
    {

        public int CategoryID { get; set; } // --> Primary KEY olduğunu belirtmek için class İSMİ VE ID kullanılmalıdır.
        public string CategoryName { get; set; }

        public bool CategoryStatus { get; set; }

        public List<Product> Products { get; set; }
    }
}

/*

Field --> int x; --> class'ın içinde direkt olarak tanımlanır

Property --> public int y { get; set;} --> get set varsa

Variable --> void test() {int z} --> methodun içinde tanımlanır


 */
