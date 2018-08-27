using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTest
{
   public class AddressData
    {
        string fileType;
        string name;
        string age;
        string address;
        string bday;
        string level;

        [FixedLengthDelimeter(0, 2)]
        public string FileType { get { return this.fileType; } set { this.fileType = value; } }

        [FixedLengthDelimeter(1, 20)]
        public string Name { get { return this.name; } set { this.name = value; } }

        [FixedLengthDelimeter(2, 3)]
        public string Age { get { return this.age; } set { this.age = value; } }

        [FixedLengthDelimeter(3, 30)]
        public string Address { get { return this.address; } set { this.address = value; } }

        [FixedLengthDelimeter(4, 10)]
        public string BDay { get { return this.bday; } set { this.bday = value; } }

        [FixedLengthDelimeter(5, 3)]
        public string Level { get { return this.level; } set { this.level = value; } }

    }
}
