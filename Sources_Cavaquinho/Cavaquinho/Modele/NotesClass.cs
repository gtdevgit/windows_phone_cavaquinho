using System;
using System.Runtime.Serialization;

namespace Cavaquinho.Modele
{
    // Liste des notes d'un accord
    [DataContractAttribute]
    public class NotesClass
    {
        private NoteClass n1, n2, n3, n4;

        public NotesClass(NoteClass _n1, NoteClass _n2, NoteClass _n3, NoteClass _n4)
        {
            n1 = _n1;
            n2 = _n2;
            n3 = _n3;
            n4 = _n4;
        }
        
        [DataMember]
        public NoteClass N1
        {
            get { return n1; }
            set { n1 = value; }
        }
        
        [DataMember]
        public NoteClass N2
        {
            get { return n2; }
            set { n2 = value; }
        }
        
        [DataMember]
        public NoteClass N3
        {
            get { return n3; }
            set { n3 = value; }
        }
        
        [DataMember]
        public NoteClass N4
        {
            get { return n4; }
            set { n4 = value; }
        }

        public string NotesToString()
        {
            return String.Format("{0} {1} {2} {3}", N1.NoteToString(), N2.NoteToString(), N3.NoteToString(), N4.NoteToString());
        }
    }

}
