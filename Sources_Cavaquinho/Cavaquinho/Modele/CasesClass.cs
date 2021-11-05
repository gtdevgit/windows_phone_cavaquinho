using System.Runtime.Serialization;

namespace Cavaquinho.Modele
{
    [DataContractAttribute]
    public class CasesClass
    {
        private int c1, c2, c3, c4;

        public CasesClass(int _c1, int _c2, int _c3, int _c4)
        {
            c1 = _c1;
            c2 = _c2;
            c3 = _c3;
            c4 = _c4;
        }

        [DataMember]
        public int C1
        {
            get { return c1; }
            set { c1 = value; }
        }

        [DataMember]
        public int C2
        {
            get { return c2; }
            set { c2 = value; }
        }

        [DataMember]
        public int C3
        {
            get { return c3; }
            set { c3 = value; }
        }

        [DataMember]
        public int C4
        {
            get { return c4; }
            set { c4 = value; }
        }
    }
}
