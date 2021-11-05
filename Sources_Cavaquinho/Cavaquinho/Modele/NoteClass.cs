using System.Runtime.Serialization;

namespace Cavaquinho.Modele
{
    [DataContractAttribute]
    public class NoteClass
    {
        private eNoteNaturelle notenaturelle;
        private eAlteration alteration;
           
        public NoteClass(eNoteNaturelle _note, eAlteration _alteration)
        {
            this.notenaturelle = _note;
            this.alteration = _alteration;
        }

        public NoteClass(eNoteNaturelle _note)
        {
            this.notenaturelle = _note;
            this.alteration = eAlteration.Aucun;
            //return this.NoteClass(_note, aAucun);
        }

        public NoteClass()
        {
            this.notenaturelle = eNoteNaturelle.C;
            this.alteration = eAlteration.Aucun;
            //return this.NoteClass(_nDo, aAucun);
        }
        
        [DataMember]
        public eNoteNaturelle NoteNaturelle
        {
            get { return notenaturelle; }
            set { notenaturelle = value; }
        }
        
        [DataMember]
        public eAlteration Alteration
        {
            get { return alteration; }
            set { alteration = value; }
        }
        
        public string NoteToString()
        {
            return NoteNaturelleClass.NoteNaturelleToString(NoteNaturelle) + AlterationClass.AlterationToString(Alteration);
        }
    }

}
