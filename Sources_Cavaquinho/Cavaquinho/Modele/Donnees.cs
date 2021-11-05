
namespace Cavaquinho.Modele
{
    public static class Donnees
    {
#region TAB_ACCORD, la base de données des accords...
        // La base de données des accords
        private static Accord[] _TAB_ACCORDS = {
        #region C            
            // "C", "maj", "E G C E", "2 0 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,0,1,2)),
            // "C", "maj", "G C E G", "5 5 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,5,5,5)),
            // "C", "maj", "C E G C", "10 9 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,9,8,10)),
            // "C", "7M", "E G B E", "2 0 0 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,0,0,2)),
            // "C", "7M", "G B E G", "5 4 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,5,5)),
            // "C", "7M", "G C E B", "5 5 5 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(5,5,5,9)),
            // "C", "7M", "C E G B", "10 9 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(10,9,8,9)),
            // "C", "7", "E Bb C E", "2 3 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,3,1,2)),
            // "C", "7", "G Bb E G", "5 3 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,3,5,5)),
            // "C", "7", "Bb C E Bb", "8 5 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,5,5,8)),
            // "C", "7", "C E G Bb", "10 9 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(10,9,8,8)),
            // "C", "7", "Bb E G C", "8 9 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,9,8,10)),
            // "C", "7", "C E Bb C", "10 9 11 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,9,11,10)),
            // "C", "7/9", "D Bb C E", "0 3 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(0,3,1,2)),
            // "C", "7/9", "E Bb D G", "2 3 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,3,3,5)),
            // "C", "min", "Eb G C Eb", "1 0 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,0,1,1)),
            // "C", "min", "G C Eb G", "5 5 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,5,4,5)),
            // "C", "min", "C Eb G C", "10 8 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,8,8,10)),
            // "C", "min7", "G Bb Eb G", "5 3 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,3,4,5)),
            // "C", "min7", "C Eb G Bb", "10 8 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(10,8,8,8)),
            // "C", "m7/5b", "Gb Bb C Eb", "4 3 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(4,3,1,1)),
            // "C", "m7/5b", "C Eb Gb Bb", "10 8 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(10,8,7,8)),
            // "C", "min6", "A C Eb G", "7 5 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(7,5,4,5)),
            // "C", "min6", "C Eb G A", "10 8 8 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(10,8,8,7)),
            // "C", "m9", "Eb G C D", "1 0 1 0"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(1,0,1,0)),
            // "C", "m7/9", "Eb Bb C D", "1 3 1 0"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(1,3,1,0)),
            // "C", "m7/5+", "G B Eb G", "5 4 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,4,5)),
            // "C", "m7/5+", "C Eb G B", "10 8 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(10,8,8,9)),
            // "C", "dim", "Gb C Eb Gb", "4 5 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,5,4,4)),
            // "C", "dim", "C Eb Gb A", "10 8 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(10,8,7,7)),
            // "C", "4", "F G C F", "3 0 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,0,1,3)),
            // "C", "4", "C F G C", "10 10 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,10,8,10)),
            // "C", "5+", "E Ab C E", "2 1 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,1,2)),
            // "C", "5+", "Ab C E Ab", "6 5 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,5,5,6)),
            // "C", "6", "G C E A", "5 5 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,5,5,7)),
            // "C", "6", "C E G A", "10 9 8 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(10,9,8,7)),
            // "C", "6/9", "E A D G", "2 2 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,2,3,5)),
            // "C", "7/9-", "E Bb Db E", "2 3 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,3,2,2)),
            // "C", "7/9-", "G Db E Bb", "5 6 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(5,6,5,8)),
            // "C", "7/9-", "C E Bb Db", "10 9 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(10,9,11,11)),
            // "C", "7/9+", "E Bb Eb E", "2 3 4 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,3,4,2)),
            // "C", "7/9+", "G Eb E Bb", "5 8 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(5,8,5,8)),
            // "C", "7/13", "G Bb E A", "5 3 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,3,5,7)),
            // "C", "7/13", "Bb E A C", "8 9 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,9,10,10)),
            // "C", "7/13-", "G Bb E Ab", "5 3 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(5,3,5,6)),
            // "C", "7/13-", "Bb E Ab C", "8 9 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,9,9,10)),
            // "C", "9", "E G C D", "2 0 1 0"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(2,0,1,0)),
            // "C", "9", "E G D E", "2 0 3 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,0,3,2)),
            // "C", "9", "G D E G", "5 7 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,7,5,5)),
#endregion
#region C#
            // "C#", "maj", "E# G# C# E#", "3 1 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,1,2,3)),
            // "C#", "maj", "G# C# E# G#", "6 6 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,6,6,6)),
            // "C#", "maj", "C# E# G# C#", "11 10 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,10,9,11)),
            // "C#", "7M", "E# G# B# E#", "3 1 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,1,1,3)),
            // "C#", "7M", "G# B# E# G#", "6 5 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,5,6,6)),
            // "C#", "7M", "G# C# E# B#", "6 6 6 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Diese)),
                new CasesClass(6,6,6,10)),
            // "C#", "7M", "C# E# G# B#", "11 10 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Diese)),
                new CasesClass(11,10,9,10)),
            // "C#", "7", "E# G# B E#", "3 1 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,1,0,3)),
            // "C#", "7", "E# B C# E#", "3 4 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,4,2,3)),
            // "C#", "7", "G# B E# G#", "6 4 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,4,6,6)),
            // "C#", "7", "B C# E# B", "9 6 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,6,6,9)),
            // "C#", "7", "C# E# G# B", "11 10 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,10,9,9)),
            // "C#", "7", "B E# G# C#", "9 10 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,10,9,11)),
            // "C#", "7/9", "D# B C# E#", "1 4 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(1,4,2,3)),
            // "C#", "7/9", "E# B D# G#", "3 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(3,4,4,6)),
            // "C#", "min", "E G# C# E", "2 1 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,2,2)),
            // "C#", "min", "G# C# E G#", "6 6 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,6,5,6)),
            // "C#", "min", "C# E G# C#", "11 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,9,9,11)),
            // "C#", "min7", "G# B E G#", "6 4 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,4,5,6)),
            // "C#", "min7", "C# E G# B", "11 9 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,9,9,9)),
            // "C#", "m7/5b", "G B C# E", "5 4 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(5,4,2,2)),
            // "C#", "m7/5b", "C# E G B", "11 9 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,9,8,9)),
            // "C#", "min6", "A# C# E G#", "8 6 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(8,6,5,6)),
            // "C#", "min6", "C# E G# A#", "11 9 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(11,9,9,8)),
            // "C#", "m9", "E G# C# D#", "2 1 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(2,1,2,1)),
            // "C#", "m7/9", "E B C# D#", "2 4 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(2,4,2,1)),
            // "C#", "m7/5+", "G# B# E G#", "6 5 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,5,5,6)),
            // "C#", "m7/5+", "C# E G# B#", "11 9 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Diese)),
                new CasesClass(11,9,9,10)),
            // "C#", "dim", "G C# E G", "5 6 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,6,5,5)),
            // "C#", "dim", "C# E G A#", "11 9 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(11,9,8,8)),
            // "C#", "4", "F# G# C# F#", "4 1 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,1,2,4)),
            // "C#", "4", "C# F# G# C#", "11 11 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,11,9,11)),
            // "C#", "5+", "E# A C# E#", "3 2 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,2,2,3)),
            // "C#", "5+", "A C# E# A", "7 6 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,6,7)),
            // "C#", "6", "G# C# E# A#", "6 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(6,6,6,8)),
            // "C#", "6", "C# E# G# A#", "11 10 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(11,10,9,8)),
            // "C#", "6/9", "E# A# D# G#", "3 3 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(3,3,4,6)),
            // "C#", "7/9-", "E# B D E#", "3 4 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,4,3,3)),
            // "C#", "7/9-", "G# D E# B", "6 7 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,7,6,9)),
            // "C#", "7/9+", "E# B E E#", "3 4 5 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,4,5,3)),
            // "C#", "7/9+", "G# E E# B", "6 9 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,9,6,9)),
            // "C#", "7/13", "E# A# B E#", "3 3 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,3,0,3)),
            // "C#", "7/13", "G# B E# A#", "6 4 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(6,4,6,8)),
            // "C#", "7/13", "B E# A# C#", "9 10 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,10,11,11)),
            // "C#", "7/13-", "G# B E# A", "6 4 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(6,4,6,7)),
            // "C#", "7/13-", "B E# A C#", "9 10 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,10,10,11)),
            // "C#", "9", "E# G# C# D#", "3 1 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(3,1,2,1)),
            // "C#", "9", "E# G# D# E#", "3 1 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese)),
                new CasesClass(3,1,4,3)),
            // "C#", "9", "G# D# E# G#", "6 8 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,8,6,6)),
#endregion
#region Db            
            // "Db", "maj", "F Ab Db F", "3 1 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,1,2,3)),
            // "Db", "maj", "Ab Db F Ab", "6 6 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,6,6,6)),
            // "Db", "maj", "Db F Ab Db", "11 10 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,10,9,11)),
            // "Db", "7M", "F Ab C F", "3 1 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,1,1,3)),
            // "Db", "7M", "Ab C F Ab", "6 5 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,5,6,6)),
            // "Db", "7M", "Ab Db F C", "6 6 6 10"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(6,6,6,10)),
            // "Db", "7M", "Db F Ab C", "11 10 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(11,10,9,10)),
            // "Db", "7", "F Ab B F", "3 1 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,1,0,3)),
            // "Db", "7", "F B Db F", "3 4 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,4,2,3)),
            // "Db", "7", "Ab B F Ab", "6 4 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,4,6,6)),
            // "Db", "7", "B Db F B", "9 6 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,6,6,9)),
            // "Db", "7", "Db F Ab B", "11 10 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,10,9,9)),
            // "Db", "7", "B F Ab Db", "9 10 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,10,9,11)),
            // "Db", "7/9", "Eb B Db F", "1 4 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(1,4,2,3)),
            // "Db", "7/9", "F B Eb Ab", "3 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,4,4,6)),
            // "Db", "min", "E Ab Db E", "2 1 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,2,2)),
            // "Db", "min", "Ab Db E Ab", "6 6 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,6,5,6)),
            // "Db", "min", "Db E Ab Db", "11 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,9,9,11)),
            // "Db", "min7", "Ab B E Ab", "6 4 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,4,5,6)),
            // "Db", "min7", "Db E Ab B", "11 9 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,9,9,9)),
            // "Db", "m7/5b", "G B Db E", "5 4 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(5,4,2,2)),
            // "Db", "m7/5b", "Db E G B", "11 9 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,9,8,9)),
            // "Db", "min6", "Bb Db E Ab", "8 6 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(8,6,5,6)),
            // "Db", "min6", "Db E Ab Bb", "11 9 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(11,9,9,8)),
            // "Db", "m9", "E Ab Db Eb", "2 1 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(2,1,2,1)),
            // "Db", "m7/9", "E B Db Eb", "2 4 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(2,4,2,1)),
            // "Db", "m7/5+", "Ab C E Ab", "6 5 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,5,5,6)),
            // "Db", "m7/5+", "Db E Ab C", "11 9 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(11,9,9,10)),
            // "Db", "dim", "G Db E G", "5 6 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,6,5,5)),
            // "Db", "dim", "Db E G Bb", "11 9 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(11,9,8,8)),
            // "Db", "4", "Gb Ab Db Gb", "4 1 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,1,2,4)),
            // "Db", "4", "Db Gb Ab Db", "11 11 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,11,9,11)),
            // "Db", "5+", "F A Db F", "3 2 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,2,2,3)),
            // "Db", "5+", "A Db F A", "7 6 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,6,7)),
            // "Db", "6", "Ab Db F Bb", "6 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,6,6,8)),
            // "Db", "6", "Db F Ab Bb", "11 10 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(11,10,9,8)),
            // "Db", "6/9", "F Bb Eb Ab", "3 3 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,3,4,6)),
            // "Db", "7/9-", "F B D F", "3 4 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,4,3,3)),
            // "Db", "7/9-", "Ab D F B", "6 7 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,7,6,9)),
            // "Db", "7/9+", "F B E F", "3 4 5 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,4,5,3)),
            // "Db", "7/9+", "Ab E F B", "6 9 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,9,6,9)),
            // "Db", "7/13", "F Bb B F", "3 3 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,3,0,3)),
            // "Db", "7/13", "Ab B F Bb", "6 4 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,4,6,8)),
            // "Db", "7/13", "B F Bb Db", "9 10 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,10,11,11)),
            // "Db", "7/13-", "Ab B F A", "6 4 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(6,4,6,7)),
            // "Db", "7/13-", "B F A Db", "9 10 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,10,10,11)),
            // "Db", "9", "F Ab Db Eb", "3 1 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(3,1,2,1)),
            // "Db", "9", "F Ab Eb F", "3 1 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,1,4,3)),
            // "Db", "9", "Ab Eb F Ab", "6 8 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,8,6,6)),
#endregion
#region D            
            // "D", "maj", "F# A D F#", "4 2 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,2,3,4)),
            // "D", "maj", "A D F# A", "7 7 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,7,7,7)),
            // "D", "7M", "D A C# F#", "0 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(0,2,2,4)),
            // "D", "7M", "F# A C# F#", "4 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,2,2,4)),
            // "D", "7M", "A C# F# A", "7 6 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,7,7)),
            // "D", "7M", "A D F# C#", "7 7 7 11"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(7,7,7,11)),
            // "D", "7", "F# A C F#", "4 2 1 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,2,1,4)),
            // "D", "7", "F# C D F#", "4 5 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,5,3,4)),
            // "D", "7", "A C F# A", "7 5 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,5,7,7)),
            // "D", "7", "C D F# C", "10 7 7 10"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,7,7,10)),
            // "D", "7/9", "E C D F#", "2 5 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,5,3,4)),
            // "D", "7/9", "F# C E A", "4 5 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,5,7)),
            // "D", "min", "F A D F", "3 2 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,2,3,3)),
            // "D", "min", "A D F A", "7 7 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,7,6,7)),
            // "D", "min7", "D A C F", "0 2 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,2,1,3)),
            // "D", "min7", "A C F A", "7 5 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,5,6,7)),
            // "D", "m7/5b", "D G# C F", "0 1 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,1,1,3)),
            // "D", "m7/5b", "G# C D F", "6 5 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(6,5,3,3)),
            // "D", "min6", "D A B F", "0 2 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,2,0,3)),
            // "D", "min6", "B D F A", "9 7 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,7,6,7)),
            // "D", "m9", "F A D E", "3 2 3 2"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(3,2,3,2)),
            // "D", "m7/9", "F C D E", "3 5 3 2"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(3,5,3,2)),
            // "D", "m7/5+", "A C# F A", "7 6 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,6,7)),
            // "D", "dim", "D G# B F", "0 1 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,1,0,3)),
            // "D", "dim", "D G# D F", "0 1 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,1,3,3)),
            // "D", "dim", "G# D F G#", "6 7 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,7,6,6)),
            // "D", "4", "G A D G", "5 2 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,2,3,5)),
            // "D", "5+", "F# A# D F#", "4 3 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,3,3,4)),
            // "D", "5+", "A# D F# A#", "8 7 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,7,7,8)),
            // "D", "6", "A D F# B", "7 7 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,7,7,9)),
            // "D", "6/9", "F# B E A", "4 4 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,4,5,7)),
            // "D", "7/9-", "F# C D# F#", "4 5 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,5,4,4)),
            // "D", "7/9-", "A D# F# C", "7 8 7 10"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,8,7,10)),
            // "D", "7/9+", "F# C F F#", "4 5 6 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,5,6,4)),
            // "D", "7/9+", "A F F# C", "7 10 7 10"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,10,7,10)),
            // "D", "7/13", "F# B C F#", "4 4 1 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,4,1,4)),
            // "D", "7/13", "A C F# B", "7 5 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,5,7,9)),
            // "D", "7/13-", "A C F# A#", "7 5 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(7,5,7,8)),
            // "D", "9", "F# A D E", "4 2 3 2"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,2,3,2)),
            // "D", "9", "F# A E F#", "4 2 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,2,5,4)),
            // "D", "9", "A E F# A", "7 9 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,9,7,7)),
#endregion
#region Eb
            // "Eb", "maj", "G Bb Eb G", "5 3 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,3,4,5)),
            // "Eb", "maj", "Bb Eb G Bb", "8 8 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,8,8,8)),
            // "Eb", "7M", "Eb Bb D G", "1 3 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(1,3,3,5)),
            // "Eb", "7M", "G Bb D G", "5 3 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,3,3,5)),
            // "Eb", "7M", "Bb D G Bb", "8 7 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,7,8,8)),
            // "Eb", "7", "Eb G Db Eb", "1 0 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,0,2,1)),
            // "Eb", "7", "G Bb Db G", "5 3 2 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,3,2,5)),
            // "Eb", "7", "G Db Eb G", "5 6 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,6,4,5)),
            // "Eb", "7", "Bb Db G Bb", "8 6 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,6,8,8)),
            // "Eb", "7", "Db Eb G Db", "11 8 8 11"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,8,8,11)),
            // "Eb", "7/9", "Eb G Db F", "1 0 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(1,0,2,3)),
            // "Eb", "7/9", "F Db Eb G", "3 6 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,6,4,5)),
            // "Eb", "7/9", "G Db F Bb", "5 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(5,6,6,8)),
            // "Eb", "min", "Gb Bb Eb Gb", "4 3 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,3,4,4)),
            // "Eb", "min", "Bb Eb Gb Bb", "8 8 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,8,7,8)),
            // "Eb", "min7", "Eb Bb Db Gb", "1 3 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,3,2,4)),
            // "Eb", "min7", "Bb Db Gb Bb", "8 6 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,6,7,8)),
            // "Eb", "m7/5b", "Eb A Db Gb", "1 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,2,2,4)),
            // "Eb", "m7/5b", "A Db Eb Gb", "7 6 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(7,6,4,4)),
            // "Eb", "min6", "Eb Bb C Gb", "1 3 1 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,3,1,4)),
            // "Eb", "min6", "C Eb Gb Bb", "10 8 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(10,8,7,8)),
            // "Eb", "m9", "Gb Bb Eb F", "4 3 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(4,3,4,3)),
            // "Eb", "m7/9", "Gb Db Eb F", "4 6 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(4,6,4,3)),
            // "Eb", "m7/5+", "Bb D Gb Bb", "8 7 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,7,7,8)),
            // "Eb", "dim", "Eb A C Gb", "1 2 1 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,2,1,4)),
            // "Eb", "dim", "Eb A Eb Gb", "1 2 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,2,4,4)),
            // "Eb", "dim", "A Eb Gb A", "7 8 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,8,7,7)),
            // "Eb", "4", "Ab Bb Eb Ab", "6 3 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,3,4,6)),
            // "Eb", "5+", "G B Eb G", "5 4 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,4,5)),
            // "Eb", "5+", "B Eb G B", "9 8 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,8,8,9)),
            // "Eb", "6", "Bb Eb G C", "8 8 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,8,8,10)),
            // "Eb", "6/9", "Eb G C F", "1 0 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(1,0,1,3)),
            // "Eb", "6/9", "G C F Bb", "5 5 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(5,5,6,8)),
            // "Eb", "7/9-", "Eb G Db E", "1 0 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(1,0,2,2)),
            // "Eb", "7/9-", "G Db E G", "5 6 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,6,5,5)),
            // "Eb", "7/9-", "Bb E G Db", "8 9 8 11"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,9,8,11)),
            // "Eb", "7/9+", "Eb G Db Gb", "1 0 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,0,2,4)),
            // "Eb", "7/9+", "G Db Gb G", "5 6 7 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,6,7,5)),
            // "Eb", "7/9+", "Bb Gb G Db", "8 11 8 11"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,11,8,11)),
            // "Eb", "7/13", "G C Db G", "5 5 2 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,5,2,5)),
            // "Eb", "7/13", "Bb Db G C", "8 6 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,6,8,10)),
            // "Eb", "7/13-", "Bb Db G B", "8 6 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(8,6,8,9)),
            // "Eb", "9", "G Bb Eb F", "5 3 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(5,3,4,3)),
            // "Eb", "9", "G Bb F G", "5 3 6 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,3,6,5)),
            // "Eb", "9", "Bb F G Bb", "8 10 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,10,8,8)),
#endregion
#region E
                // "E", "maj", "E G# B E", "2 1 0 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,0,2)),
            // "E", "maj", "G# B E G#", "6 4 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,4,5,6)),
            // "E", "maj", "B E G# B", "9 9 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,9,9,9)),
            // "E", "7M", "E G# B D#", "2 1 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(2,1,0,1)),
            // "E", "7M", "E B D# G#", "2 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(2,4,4,6)),
            // "E", "7M", "G# B D# G#", "6 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,4,4,6)),
            // "E", "7M", "B D# G# B", "9 8 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,8,9,9)),
            // "E", "7", "E G# B D", "2 1 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(2,1,0,0)),
            // "E", "7", "D G# B E", "0 1 0 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(0,1,0,2)),
            // "E", "7", "E G# D E", "2 1 3 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,3,2)),
            // "E", "7", "G# B D G#", "6 4 3 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,4,3,6)),
            // "E", "7", "G# D E G#", "6 7 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,7,5,6)),
            // "E", "7", "B D G# B", "9 7 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,7,9,9)),
            // "E", "7/9", "E G# D F#", "2 1 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,1,3,4)),
            // "E", "7/9", "F# D E G#", "4 7 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,7,5,6)),
            // "E", "7/9", "G# D F# B", "6 7 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,7,7,9)),
            // "E", "min", "E G B E", "2 0 0 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,0,0,2)),
            // "E", "min", "G B E G", "5 4 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,5,5)),
            // "E", "min", "B E G B", "9 9 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,9,8,9)),
            // "E", "min7", "E G B D", "2 0 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(2,0,0,0)),
            // "E", "min7", "E B D G", "2 4 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,4,3,5)),
            // "E", "min7", "B D G B", "9 7 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,7,8,9)),
            // "E", "m7/5b", "E A# D G", "2 3 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,3,3,5)),
            // "E", "m7/5b", "A# D E G", "8 7 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(8,7,5,5)),
            // "E", "min6", "E B C# G", "2 4 2 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,4,2,5)),
            // "E", "min6", "C# E G B", "11 9 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,9,8,9)),
            // "E", "m9", "E G B F#", "2 0 0 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,0,0,4)),
            // "E", "m9", "G B E F#", "5 4 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(5,4,5,4)),
            // "E", "m7/9", "E G D F#", "2 0 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,0,3,4)),
            // "E", "m7/9", "G D E F#", "5 7 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(5,7,5,4)),
            // "E", "m7/5+", "E G B D#", "2 0 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(2,0,0,1)),
            // "E", "m7/5+", "B D# G B", "9 8 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,8,8,9)),
            // "E", "dim", "E A# C# G", "2 3 2 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,3,2,5)),
            // "E", "dim", "E A# E G", "2 3 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,3,5,5)),
            // "E", "dim", "A# E G A#", "8 9 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,9,8,8)),
            // "E", "4", "E A B E", "2 2 0 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,2,0,2)),
            // "E", "4", "A B E A", "7 4 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,4,5,7)),
            // "E", "5+", "G# C E G#", "6 5 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,5,5,6)),
            // "E", "5+", "C E G# C", "10 9 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,9,9,10)),
            // "E", "6", "B E G# C#", "9 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,9,9,11)),
            // "E", "6/9", "E G# C# F#", "2 1 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,1,2,4)),
            // "E", "6/9", "G# C# F# B", "6 6 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,6,7,9)),
            // "E", "7/9-", "E G# D F", "2 1 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(2,1,3,3)),
            // "E", "7/9-", "G# D F G#", "6 7 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,7,6,6)),
            // "E", "7/9+", "E G# D G", "2 1 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,1,3,5)),
            // "E", "7/9+", "G# D G G#", "6 7 8 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,7,8,6)),
            // "E", "7/13", "D G# C# E", "0 1 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(0,1,2,2)),
            // "E", "7/13", "G# C# D G#", "6 6 3 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,6,3,6)),
            // "E", "7/13", "B D G# C#", "9 7 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,7,9,11)),
            // "E", "7/13-", "D G# C E", "0 1 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(0,1,1,2)),
            // "E", "7/13-", "B D G# C", "9 7 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(9,7,9,10)),
            // "E", "9", "E G# B F#", "2 1 0 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,1,0,4)),
            // "E", "9", "G# B E F#", "6 4 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(6,4,5,4)),
            // "E", "9", "G# B F# G#", "6 4 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(6,4,7,6)),
            // "E", "9", "B F# G# B", "9 11 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,11,9,9)),
#endregion
#region F
            // "F", "maj", "F A C F", "3 2 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,2,1,3)),
            // "F", "maj", "A C F A", "7 5 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,5,6,7)),
            // "F", "maj", "C F A C", "10 10 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,10,10,10)),
            // "F", "7M", "F A C E", "3 2 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(3,2,1,2)),
            // "F", "7M", "F C E A", "3 5 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(3,5,5,7)),
            // "F", "7M", "A C E A", "7 5 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,5,5,7)),
            // "F", "7M", "C E A C", "10 9 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,9,10,10)),
            // "F", "7", "F A C Eb", "3 2 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(3,2,1,1)),
            // "F", "7", "Eb A C F", "1 2 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(1,2,1,3)),
            // "F", "7", "F A Eb F", "3 2 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,2,4,3)),
            // "F", "7", "A C Eb A", "7 5 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,5,4,7)),
            // "F", "7", "A Eb F A", "7 8 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,8,6,7)),
            // "F", "7", "C Eb A C", "10 8 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,8,10,10)),
            // "F", "7/9", "F A Eb G", "3 2 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,2,4,5)),
            // "F", "7/9", "G Eb F A", "5 8 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,8,6,7)),
            // "F", "7/9", "A Eb G C", "7 8 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,8,8,10)),
            // "F", "min", "F Ab C F", "3 1 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,1,1,3)),
            // "F", "min", "Ab C F Ab", "6 5 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,5,6,6)),
            // "F", "min", "C F Ab C", "10 10 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,10,9,10)),
            // "F", "min7", "F Ab C Eb", "3 1 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(3,1,1,1)),
            // "F", "min7", "F C Eb Ab", "3 5 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,5,4,6)),
            // "F", "min7", "C Eb Ab C", "10 8 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,8,9,10)),
            // "F", "m7/5b", "F Ab B Eb", "3 1 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(3,1,0,1)),
            // "F", "m7/5b", "F B Eb Ab", "3 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,4,4,6)),
            // "F", "m7/5b", "B Eb F Ab", "9 8 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(9,8,6,6)),
            // "F", "min6", "F Ab C D", "3 1 1 0"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(3,1,1,0)),
            // "F", "min6", "F C D Ab", "3 5 3 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,5,3,6)),
            // "F", "m9", "F Ab C G", "3 1 1 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,1,1,5)),
            // "F", "m9", "Ab C F G", "6 5 6 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(6,5,6,5)),
            // "F", "m7/9", "F Ab Eb G", "3 1 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,1,4,5)),
            // "F", "m7/9", "Ab Eb F G", "6 8 6 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(6,8,6,5)),
            // "F", "m7/5+", "F Ab C E", "3 1 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(3,1,1,2)),
            // "F", "m7/5+", "C E Ab C", "10 9 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,9,9,10)),
            // "F", "dim", "F Ab B D", "3 1 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(3,1,0,0)),
            // "F", "dim", "F B D Ab", "3 4 3 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,4,3,6)),
            // "F", "dim", "F B F Ab", "3 4 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,4,6,6)),
            // "F", "dim", "B F Ab B", "9 10 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,10,9,9)),
            // "F", "4", "F Bb C F", "3 3 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,3,1,3)),
            // "F", "4", "Bb C F Bb", "8 5 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,5,6,8)),
            // "F", "5+", "A Db F A", "7 6 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,6,7)),
            // "F", "5+", "Db F A Db", "11 10 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,10,10,11)),
            // "F", "6", "F A C D", "3 2 1 0"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(3,2,1,0)),
            // "F", "6/9", "F A D G", "3 2 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,2,3,5)),
            // "F", "6/9", "A D G C", "7 7 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,7,8,10)),
            // "F", "7/9-", "F A Eb Gb", "3 2 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(3,2,4,4)),
            // "F", "7/9-", "A Eb Gb A", "7 8 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,8,7,7)),
            // "F", "7/9+", "F A Eb Ab", "3 2 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,2,4,6)),
            // "F", "7/9+", "A Eb Ab A", "7 8 9 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,8,9,7)),
            // "F", "7/13", "Eb A D F", "1 2 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(1,2,3,3)),
            // "F", "7/13", "A D Eb A", "7 7 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,7,4,7)),
            // "F", "7/13-", "Eb A Db F", "1 2 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(1,2,2,3)),
            // "F", "7/13-", "C Eb A Db", "10 8 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(10,8,10,11)),
            // "F", "9", "F A C G", "3 2 1 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,2,1,5)),
            // "F", "9", "A C F G", "7 5 6 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(7,5,6,5)),
            // "F", "9", "A C G A", "7 5 8 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,5,8,7)),
#endregion
#region F#
            // "F#", "maj", "F# A# C# F#", "4 3 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,3,2,4)),
            // "F#", "maj", "A# C# F# A#", "8 6 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,6,7,8)),
            // "F#", "maj", "C# F# A# C#", "11 11 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,11,11,11)),
            // "F#", "7M", "F# A# C# F", "4 3 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(4,3,2,3)),
            // "F#", "7M", "F# C# F A#", "4 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(4,6,6,8)),
            // "F#", "7M", "A# C# F A#", "8 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,6,6,8)),
            // "F#", "7M", "C# F A# C#", "11 10 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,10,11,11)),
            // "F#", "7", "F# A# C# E", "4 3 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,3,2,2)),
            // "F#", "7", "E A# C# F#", "2 3 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,3,2,4)),
            // "F#", "7", "F# A# E F#", "4 3 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,3,5,4)),
            // "F#", "7", "A# C# E A#", "8 6 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,6,5,8)),
            // "F#", "7", "A# E F# A#", "8 9 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,9,7,8)),
            // "F#", "7", "C# E A# C#", "11 9 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,9,11,11)),
            // "F#", "7/9", "F# A# E G#", "4 3 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,3,5,6)),
            // "F#", "7/9", "G# E F# A#", "6 9 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(6,9,7,8)),
            // "F#", "7/9", "A# E G# C#", "8 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(8,9,9,11)),
            // "F#", "min", "F# A C# F#", "4 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,2,2,4)),
            // "F#", "min", "A C# F# A", "7 6 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,7,7)),
            // "F#", "min", "C# F# A C#", "11 11 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,11,10,11)),
            // "F#", "min7", "F# A C# E", "4 2 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,2,2,2)),
            // "F#", "min7", "F# C# E A", "4 6 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,6,5,7)),
            // "F#", "min7", "C# E A C#", "11 9 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,9,10,11)),
            // "F#", "m7/5b", "F# A C E", "4 2 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,2,1,2)),
            // "F#", "m7/5b", "F# C E A", "4 5 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,5,7)),
            // "F#", "m7/5b", "C E F# A", "10 9 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(10,9,7,7)),
            // "F#", "min6", "F# A C# D#", "4 2 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(4,2,2,1)),
            // "F#", "min6", "F# C# D# A", "4 6 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,6,4,7)),
            // "F#", "m9", "F# A C# G#", "4 2 2 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,2,2,6)),
            // "F#", "m9", "A C# F# G#", "7 6 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(7,6,7,6)),
            // "F#", "m7/9", "F# A E G#", "4 2 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,2,5,6)),
            // "F#", "m7/9", "A E F# G#", "7 9 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(7,9,7,6)),
            // "F#", "m7/5+", "F# A C# F", "4 2 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(4,2,2,3)),
            // "F#", "m7/5+", "C# F A C#", "11 10 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,10,10,11)),
            // "F#", "dim", "F# A C D#", "4 2 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(4,2,1,1)),
            // "F#", "dim", "F# C D# A", "4 5 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,4,7)),
            // "F#", "dim", "F# C F# A", "4 5 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,7,7)),
            // "F#", "dim", "C F# A C", "10 11 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,11,10,10)),
            // "F#", "4", "F# B C# F#", "4 4 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,4,2,4)),
            // "F#", "4", "B C# F# B", "9 6 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,6,7,9)),
            // "F#", "5+", "A# D F# A#", "8 7 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,7,7,8)),
            // "F#", "6", "F# A# C# D#", "4 3 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(4,3,2,1)),
            // "F#", "6/9", "F# A# D# G#", "4 3 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,3,4,6)),
            // "F#", "6/9", "A# D# G# C#", "8 8 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(8,8,9,11)),
            // "F#", "7/9-", "F# A# E G", "4 3 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(4,3,5,5)),
            // "F#", "7/9-", "A# E G A#", "8 9 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,9,8,8)),
            // "F#", "7/9+", "F# A# E A", "4 3 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,3,5,7)),
            // "F#", "7/9+", "A# E A A#", "8 9 10 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,9,10,8)),
            // "F#", "7/13", "E A# D# F#", "2 3 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,3,4,4)),
            // "F#", "7/13", "A# D# E A#", "8 8 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,8,5,8)),
            // "F#", "7/13-", "E A# D F#", "2 3 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,3,3,4)),
            // "F#", "9", "F# A# C# G#", "4 3 2 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,3,2,6)),
            // "F#", "9", "A# C# F# G#", "8 6 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(8,6,7,6)),
            // "F#", "9", "A# C# G# A#", "8 6 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,6,9,8)),
#endregion
#region Gb
            // "Gb", "maj", "Gb Bb Db Gb", "4 3 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,3,2,4)),
            // "Gb", "maj", "Bb Db Gb Bb", "8 6 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,6,7,8)),
            // "Gb", "maj", "Db Gb Bb Db", "11 11 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,11,11,11)),
            // "Gb", "7M", "Gb Bb Db F", "4 3 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(4,3,2,3)),
            // "Gb", "7M", "Gb Db F Bb", "4 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(4,6,6,8)),
            // "Gb", "7M", "Bb Db F Bb", "8 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,6,6,8)),
            // "Gb", "7M", "Db F Bb Db", "11 10 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,10,11,11)),
            // "Gb", "7", "Gb Bb Db E", "4 3 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,3,2,2)),
            // "Gb", "7", "E Bb Db Gb", "2 3 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(2,3,2,4)),
            // "Gb", "7", "Gb Bb E Gb", "4 3 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,3,5,4)),
            // "Gb", "7", "Bb Db E Bb", "8 6 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,6,5,8)),
            // "Gb", "7", "Bb E Gb Bb", "8 9 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,9,7,8)),
            // "Gb", "7", "Db E Bb Db", "11 9 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,9,11,11)),
            // "Gb", "7/9", "Gb Bb E Ab", "4 3 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,3,5,6)),
            // "Gb", "7/9", "Ab E Gb Bb", "6 9 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,9,7,8)),
            // "Gb", "7/9", "Bb E Ab Db", "8 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,9,9,11)),
            // "Gb", "min", "Gb A Db Gb", "4 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,2,2,4)),
            // "Gb", "min", "A Db Gb A", "7 6 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,7,7)),
            // "Gb", "min", "Db Gb A Db", "11 11 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,11,10,11)),
            // "Gb", "min7", "Gb A Db E", "4 2 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,2,2,2)),
            // "Gb", "min7", "Gb Db E A", "4 6 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,6,5,7)),
            // "Gb", "min7", "Db E A Db", "11 9 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,9,10,11)),
            // "Gb", "m7/5b", "Gb A C E", "4 2 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,2,1,2)),
            // "Gb", "m7/5b", "Gb C E A", "4 5 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,5,7)),
            // "Gb", "m7/5b", "C E Gb A", "10 9 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(10,9,7,7)),
            // "Gb", "min6", "Gb A Db Eb", "4 2 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(4,2,2,1)),
            // "Gb", "min6", "Gb Db Eb A", "4 6 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,6,4,7)),
            // "Gb", "m9", "Gb A Db Ab", "4 2 2 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,2,2,6)),
            // "Gb", "m9", "A Db Gb Ab", "7 6 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(7,6,7,6)),
            // "Gb", "m7/9", "Gb A E Ab", "4 2 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,2,5,6)),
            // "Gb", "m7/9", "A E Gb Ab", "7 9 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(7,9,7,6)),
            // "Gb", "m7/5+", "Gb A Db F", "4 2 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(4,2,2,3)),
            // "Gb", "m7/5+", "Db F A Db", "11 10 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,10,10,11)),
            // "Gb", "dim", "Gb A C Eb", "4 2 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(4,2,1,1)),
            // "Gb", "dim", "Gb C Eb A", "4 5 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,4,7)),
            // "Gb", "dim", "Gb C Gb A", "4 5 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,7,7)),
            // "Gb", "dim", "C Gb A C", "10 11 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,11,10,10)),
            // "Gb", "4", "Gb B Db Gb", "4 4 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,4,2,4)),
            // "Gb", "4", "B Db Gb B", "9 6 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,6,7,9)),
            // "Gb", "5+", "Bb D Gb Bb", "8 7 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,7,7,8)),
            // "Gb", "6", "Gb Bb Db Eb", "4 3 2 1"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(4,3,2,1)),
            // "Gb", "6/9", "Gb Bb Eb Ab", "4 3 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,3,4,6)),
            // "Gb", "6/9", "Bb Eb Ab Db", "8 8 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,8,9,11)),
            // "Gb", "7/9-", "Gb Bb E G", "4 3 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(4,3,5,5)),
            // "Gb", "7/9-", "Bb E G Bb", "8 9 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,9,8,8)),
            // "Gb", "7/9+", "Gb Bb E A", "4 3 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,3,5,7)),
            // "Gb", "7/9+", "Bb E A Bb", "8 9 10 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,9,10,8)),
            // "Gb", "7/13", "E Bb Eb Gb", "2 3 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(2,3,4,4)),
            // "Gb", "7/13", "Bb Eb E Bb", "8 8 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,8,5,8)),
            // "Gb", "7/13-", "E Bb D Gb", "2 3 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(2,3,3,4)),
            // "Gb", "9", "Gb Bb Db Ab", "4 3 2 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,3,2,6)),
            // "Gb", "9", "Bb Db Gb Ab", "8 6 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(8,6,7,6)),
            // "Gb", "9", "Bb Db Ab Bb", "8 6 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,6,9,8)),
#endregion
#region G
            // "G", "maj", "D G B D", "0 0 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(0,0,0,0)),
            // "G", "maj", "G B D G", "5 4 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,3,5)),
            // "G", "maj", "B D G B", "9 7 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,7,8,9)),
            // "G", "7M", "D G B F#", "0 0 0 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(0,0,0,4)),
            // "G", "7M", "G B D F#", "5 4 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(5,4,3,4)),
            // "G", "7M", "G D F# B", "5 7 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(5,7,7,9)),
            // "G", "7M", "B D F# B", "9 7 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,7,7,9)),
            // "G", "7", "F G B F", "3 0 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,0,0,3)),
            // "G", "7", "G B D F", "5 4 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(5,4,3,3)),
            // "G", "7", "F B D G", "3 4 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,4,3,5)),
            // "G", "7", "G B F G", "5 4 6 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,6,5)),
            // "G", "7", "B D F B", "9 7 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,7,6,9)),
            // "G", "7", "B F G B", "9 10 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,10,8,9)),
            // "G", "7/9", "G B F A", "5 4 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,4,6,7)),
            // "G", "7/9", "A F G B", "7 10 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,10,8,9)),
            // "G", "min", "G A# D G", "5 3 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,3,3,5)),
            // "G", "min", "A# D G A#", "8 7 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(8,7,8,8)),
            // "G", "min7", "G A# D F", "5 3 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(5,3,3,3)),
            // "G", "min7", "G D F A#", "5 7 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(5,7,6,8)),
            // "G", "m7/5b", "G A# C# F", "5 3 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(5,3,2,3)),
            // "G", "m7/5b", "G C# F A#", "5 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(5,6,6,8)),
            // "G", "m7/5b", "C# F G A#", "11 10 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(11,10,8,8)),
            // "G", "min6", "G A# D E", "5 3 3 2"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(5,3,3,2)),
            // "G", "min6", "G D E A#", "5 7 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(5,7,5,8)),
            // "G", "m9", "G A# D A", "5 3 3 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,3,3,7)),
            // "G", "m9", "A# D G A", "8 7 8 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(8,7,8,7)),
            // "G", "m7/9", "G A# F A", "5 3 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,3,6,7)),
            // "G", "m7/9", "A# F G A", "8 10 8 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(8,10,8,7)),
            // "G", "m7/5+", "G A# D F#", "5 3 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(5,3,3,4)),
            // "G", "dim", "G A# C# E", "5 3 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(5,3,2,2)),
            // "G", "dim", "G C# E A#", "5 6 5 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(5,6,5,8)),
            // "G", "dim", "G C# G A#", "5 6 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(5,6,8,8)),
            // "G", "4", "G C D G", "5 5 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,5,3,5)),
            // "G", "4", "C D G C", "10 7 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,7,8,10)),
            // "G", "5+", "D# G B D#", "1 0 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(1,0,0,1)),
            // "G", "5+", "B D# G B", "9 8 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,8,8,9)),
            // "G", "6", "D G B E", "0 0 0 2"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(0,0,0,2)),
            // "G", "6", "G B D E", "5 4 3 2"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(5,4,3,2)),
            // "G", "6/9", "G B E A", "5 4 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,4,5,7)),
            // "G", "7/9-", "D G# B F", "0 1 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,1,0,3)),
            // "G", "7/9-", "G B F G#", "5 4 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(5,4,6,6)),
            // "G", "7/9-", "B F G# B", "9 10 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,10,9,9)),
            // "G", "7/9+", "D A# B F", "0 3 0 3"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,3,0,3)),
            // "G", "7/9+", "G B F A#", "5 4 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(5,4,6,8)),
            // "G", "7/9+", "B F A# B", "9 10 11 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,10,11,9)),
            // "G", "7/13", "F B E G", "3 4 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,4,5,5)),
            // "G", "7/13", "B E F B", "9 9 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,9,6,9)),
            // "G", "7/13-", "F B D# G", "3 4 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,4,4,5)),
            // "G", "9", "D A B D", "0 2 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(0,2,0,0)),
            // "G", "9", "G B D A", "5 4 3 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,4,3,7)),
            // "G", "9", "B D G A", "9 7 8 7"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,7,8,7)),
            // "G", "9", "B D A B", "9 7 10 9"
            new Accord(
                new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,7,10,9)),
#endregion
#region Ab
            // "Ab", "maj", "Eb Ab C Eb", "1 1 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,1,1,1)),
            // "Ab", "maj", "Ab C Eb Ab", "6 5 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,5,4,6)),
            // "Ab", "maj", "C Eb Ab C", "10 8 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,8,9,10)),
            // "Ab", "7M", "Eb G C Eb", "1 0 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,0,1,1)),
            // "Ab", "7M", "Eb Ab C G", "1 1 1 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(1,1,1,5)),
            // "Ab", "7M", "Ab C Eb G", "6 5 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(6,5,4,5)),
            // "Ab", "7M", "Ab Eb G C", "6 8 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(6,8,8,10)),
            // "Ab", "7M", "C Eb G C", "10 8 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,8,8,10)),
            // "Ab", "7", "Gb Ab C Gb", "4 1 1 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,1,1,4)),
            // "Ab", "7", "Ab C Eb Gb", "6 5 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(6,5,4,4)),
            // "Ab", "7", "Gb C Eb Ab", "4 5 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,5,4,6)),
            // "Ab", "7", "Ab C Gb Ab", "6 5 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,5,7,6)),
            // "Ab", "7", "C Eb Gb C", "10 8 7 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,8,7,10)),
            // "Ab", "7", "C Gb Ab C", "10 11 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,11,9,10)),
            // "Ab", "7/9", "Ab C Gb Bb", "6 5 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,5,7,8)),
            // "Ab", "7/9", "Bb Gb Ab C", "8 11 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,11,9,10)),
            // "Ab", "min", "Eb Ab B Eb", "1 1 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,1,0,1)),
            // "Ab", "min", "Ab B Eb Ab", "6 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,4,4,6)),
            // "Ab", "min", "B Eb Ab B", "9 8 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,8,9,9)),
            // "Ab", "min7", "Ab B Eb Gb", "6 4 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(6,4,4,4)),
            // "Ab", "min7", "Ab Eb Gb B", "6 8 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,8,7,9)),
            // "Ab", "m7/5b", "Ab B D Gb", "6 4 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(6,4,3,4)),
            // "Ab", "m7/5b", "Ab D Gb B", "6 7 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,7,7,9)),
            // "Ab", "min6", "F Ab B Eb", "3 1 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(3,1,0,1)),
            // "Ab", "min6", "Ab B Eb F", "6 4 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(6,4,4,3)),
            // "Ab", "min6", "Ab Eb F B", "6 8 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,8,6,9)),
            // "Ab", "m9", "Ab B Eb Bb", "6 4 4 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,4,4,8)),
            // "Ab", "m9", "B Eb Ab Bb", "9 8 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(9,8,9,8)),
            // "Ab", "m7/9", "Ab B Gb Bb", "6 4 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,4,7,8)),
            // "Ab", "m7/9", "B Gb Ab Bb", "9 11 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(9,11,9,8)),
            // "Ab", "m7/5+", "Eb G B Eb", "1 0 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,0,0,1)),
            // "Ab", "m7/5+", "Ab B Eb G", "6 4 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(6,4,4,5)),
            // "Ab", "dim", "D Ab B D", "0 1 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(0,1,0,0)),
            // "Ab", "dim", "Ab B D F", "6 4 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(6,4,3,3)),
            // "Ab", "dim", "Ab D F B", "6 7 6 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,7,6,9)),
            // "Ab", "dim", "Ab D Ab B", "6 7 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,7,9,9)),
            // "Ab", "4", "Ab Db Eb Ab", "6 6 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,6,4,6)),
            // "Ab", "4", "Db Eb Ab Db", "11 8 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,8,9,11)),
            // "Ab", "5+", "E Ab C E", "2 1 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,1,2)),
            // "Ab", "5+", "C E Ab C", "10 9 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,9,9,10)),
            // "Ab", "6", "Eb Ab C F", "1 1 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(1,1,1,3)),
            // "Ab", "6", "Ab C Eb F", "6 5 4 3"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(6,5,4,3)),
            // "Ab", "6/9", "Ab C F Bb", "6 5 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,5,6,8)),
            // "Ab", "7/9-", "Eb A C Gb", "1 2 1 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,2,1,4)),
            // "Ab", "7/9-", "Ab C Gb A", "6 5 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(6,5,7,7)),
            // "Ab", "7/9-", "C Gb A C", "10 11 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,11,10,10)),
            // "Ab", "7/9+", "Eb B C Gb", "1 4 1 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,4,1,4)),
            // "Ab", "7/9+", "Ab C Gb B", "6 5 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(6,5,7,9)),
            // "Ab", "7/13", "Gb C F Ab", "4 5 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,5,6,6)),
            // "Ab", "7/13", "C F Gb C", "10 10 7 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,10,7,10)),
            // "Ab", "7/13-", "Gb C E Ab", "4 5 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,5,5,6)),
            // "Ab", "9", "Eb Bb C Eb", "1 3 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,3,1,1)),
            // "Ab", "9", "Ab C Eb Bb", "6 5 4 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,5,4,8)),
            // "Ab", "9", "C Eb Ab Bb", "10 8 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(10,8,9,8)),
            // "Ab", "9", "C Eb Bb C", "10 8 11 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,8,11,10)),
#endregion
#region A
            // "A", "maj", "E A C# E", "2 2 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,2,2,2)),
            // "A", "maj", "A C# E A", "7 6 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,5,7)),
            // "A", "maj", "C# E A C#", "11 9 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,9,10,11)),
            // "A", "7M", "E G# C# E", "2 1 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,2,2)),
            // "A", "7M", "E A C# G#", "2 2 2 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(2,2,2,6)),
            // "A", "7M", "A C# E G#", "7 6 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(7,6,5,6)),
            // "A", "7M", "A E G# C#", "7 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(7,9,9,11)),
            // "A", "7M", "C# E G# C#", "11 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,9,9,11)),
            // "A", "7", "E G C# E", "2 0 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,0,2,2)),
            // "A", "7", "G A C# G", "5 2 2 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,2,2,5)),
            // "A", "7", "A C# E G", "7 6 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(7,6,5,5)),
            // "A", "7", "G C# E A", "5 6 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,6,5,7)),
            // "A", "7", "A C# G A", "7 6 8 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,6,8,7)),
            // "A", "7", "C# E G C#", "11 9 8 11"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,9,8,11)),
            // "A", "7/9", "A C# G B", "7 6 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,6,8,9)),
            // "A", "min", "E A C E", "2 2 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,2,1,2)),
            // "A", "min", "A C E A", "7 5 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,5,5,7)),
            // "A", "min", "C E A C", "10 9 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(10,9,10,10)),
            // "A", "min7", "E G C E", "2 0 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,0,1,2)),
            // "A", "min7", "A C E G", "7 5 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(7,5,5,5)),
            // "A", "min7", "A E G C", "7 9 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,9,8,10)),
            // "A", "m7/5b", "A C D# G", "7 5 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(7,5,4,5)),
            // "A", "m7/5b", "A D# G C", "7 8 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,8,8,10)),
            // "A", "min6", "F# A C E", "4 2 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(4,2,1,2)),
            // "A", "min6", "A C E F#", "7 5 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(7,5,5,4)),
            // "A", "min6", "A E F# C", "7 9 7 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,9,7,10)),
            // "A", "m9", "A C E B", "7 5 5 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,5,5,9)),
            // "A", "m9", "C E A B", "10 9 10 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(10,9,10,9)),
            // "A", "m7/9", "A C G B", "7 5 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,5,8,9)),
            // "A", "m7/5+", "E G# C E", "2 1 1 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,1,1,2)),
            // "A", "m7/5+", "A C E G#", "7 5 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(7,5,5,6)),
            // "A", "dim", "D# A C D#", "1 2 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(1,2,1,1)),
            // "A", "dim", "A C D# F#", "7 5 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(7,5,4,4)),
            // "A", "dim", "A D# F# C", "7 8 7 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,8,7,10)),
            // "A", "dim", "A D# A C", "7 8 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,8,10,10)),
            // "A", "4", "A D E A", "7 7 5 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,7,5,7)),
            // "A", "5+", "F A C# F", "3 2 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,2,2,3)),
            // "A", "5+", "C# F A C#", "11 10 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,10,10,11)),
            // "A", "6", "E A C# F#", "2 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,2,2,4)),
            // "A", "6", "A C# E F#", "7 6 5 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(7,6,5,4)),
            // "A", "6/9", "A C# F# B", "7 6 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,6,7,9)),
            // "A", "7/9-", "E A# C# G", "2 3 2 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,3,2,5)),
            // "A", "7/9-", "A C# G A#", "7 6 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(7,6,8,8)),
            // "A", "7/9+", "E C C# G", "2 5 2 5"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(2,5,2,5)),
            // "A", "7/9+", "A C# G C", "7 6 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(7,6,8,10)),
            // "A", "7/13", "E G C# F#", "2 0 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(2,0,2,4)),
            // "A", "7/13", "G C# F# A", "5 6 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,6,7,7)),
            // "A", "7/13", "C# F# G C#", "11 11 8 11"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(11,11,8,11)),
            // "A", "7/13-", "E G C# F", "2 0 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(2,0,2,3)),
            // "A", "7/13-", "G C# F A", "5 6 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(5,6,6,7)),
            // "A", "9", "E B C# E", "2 4 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,4,2,2)),
            // "A", "9", "A C# E B", "7 6 5 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,6,5,9)),
            // "A", "9", "C# E A B", "11 9 10 9"
            new Accord(
                new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(11,9,10,9)),
#endregion
#region Bb
            // "Bb", "maj", "F Bb D F", "3 3 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,3,3,3)),
            // "Bb", "maj", "Bb D F Bb", "8 7 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,7,6,8)),
            // "Bb", "7M", "F A D F", "3 2 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,2,3,3)),
            // "Bb", "7M", "F Bb D A", "3 3 3 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(3,3,3,7)),
            // "Bb", "7M", "Bb D F A", "8 7 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(8,7,6,7)),
            // "Bb", "7", "F Ab D F", "3 1 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,1,3,3)),
            // "Bb", "7", "Ab Bb D Ab", "6 3 3 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(6,3,3,6)),
            // "Bb", "7", "Bb D F Ab", "8 7 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(8,7,6,6)),
            // "Bb", "7", "Ab D F Bb", "6 7 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,7,6,8)),
            // "Bb", "7", "Bb D Ab Bb", "8 7 9 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,7,9,8)),
            // "Bb", "7/9", "D Ab C F", "0 1 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,1,1,3)),
            // "Bb", "7/9", "Bb D Ab C", "8 7 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,7,9,10)),
            // "Bb", "min", "F Bb Db F", "3 3 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,3,2,3)),
            // "Bb", "min", "Bb Db F Bb", "8 6 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,6,6,8)),
            // "Bb", "min", "Db F Bb Db", "11 10 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(11,10,11,11)),
            // "Bb", "min7", "F Ab Db F", "3 1 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,1,2,3)),
            // "Bb", "min7", "Bb Db F Ab", "8 6 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(8,6,6,6)),
            // "Bb", "min7", "Bb F Ab Db", "8 10 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,10,9,11)),
            // "Bb", "m7/5b", "Bb Db E Ab", "8 6 5 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(8,6,5,6)),
            // "Bb", "m7/5b", "Bb E Ab Db", "8 9 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,9,9,11)),
            // "Bb", "min6", "G Bb Db F", "5 3 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(5,3,2,3)),
            // "Bb", "min6", "Bb Db F G", "8 6 6 5"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(8,6,6,5)),
            // "Bb", "min6", "Bb F G Db", "8 10 8 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,10,8,11)),
            // "Bb", "m9", "Bb Db F C", "8 6 6 10"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,6,6,10)),
            // "Bb", "m9", "Db F Bb C", "11 10 11 10"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(11,10,11,10)),
            // "Bb", "m7/9", "Bb Db Ab C", "8 6 9 10"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,6,9,10)),
            // "Bb", "m7/5+", "F A Db F", "3 2 2 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,2,2,3)),
            // "Bb", "m7/5+", "Bb Db F A", "8 6 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(8,6,6,7)),
            // "Bb", "dim", "E Bb Db E", "2 3 2 2"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun)),
                new CasesClass(2,3,2,2)),
            // "Bb", "dim", "Bb Db E G", "8 6 5 5"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(8,6,5,5)),
            // "Bb", "dim", "Bb E G Db", "8 9 8 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,9,8,11)),
            // "Bb", "dim", "Bb E Bb Db", "8 9 11 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,9,11,11)),
            // "Bb", "4", "Bb Eb F Bb", "8 8 6 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(8,8,6,8)),
            // "Bb", "5+", "Gb Bb D Gb", "4 3 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,3,3,4)),
            // "Bb", "6", "F Bb D G", "3 3 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,3,3,5)),
            // "Bb", "6", "Bb D F G", "8 7 6 5"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(8,7,6,5)),
            // "Bb", "6/9", "D G C F", "0 0 1 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(0,0,1,3)),
            // "Bb", "6/9", "Bb D G C", "8 7 8 10"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,7,8,10)),
            // "Bb", "7/9-", "D Ab B D", "0 1 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(0,1,0,0)),
            // "Bb", "7/9-", "F B D Ab", "3 4 3 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,4,3,6)),
            // "Bb", "7/9-", "Bb D Ab B", "8 7 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(8,7,9,9)),
            // "Bb", "7/9+", "D Ab Db D", "0 1 2 0"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(0,1,2,0)),
            // "Bb", "7/9+", "F Db D Ab", "3 6 3 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(3,6,3,6)),
            // "Bb", "7/9+", "Bb D Ab Db", "8 7 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(8,7,9,11)),
            // "Bb", "7/13", "F Ab D G", "3 1 3 5"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(3,1,3,5)),
            // "Bb", "7/13", "Ab D G Bb", "6 7 8 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,7,8,8)),
            // "Bb", "7/13-", "F Ab D Gb", "3 1 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(3,1,3,4)),
            // "Bb", "7/13-", "Ab D Gb Bb", "6 7 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(6,7,7,8)),
            // "Bb", "9", "F C D F", "3 5 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,5,3,3)),
            // "Bb", "9", "Bb D F C", "8 7 6 10"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(8,7,6,10)),
#endregion
#region B
            // "B", "maj", "F# B D# F#", "4 4 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,4,4,4)),
            // "B", "maj", "B D# F# B", "9 8 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,8,7,9)),
            // "B", "7M", "F# A# D# F#", "4 3 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,3,4,4)),
            // "B", "7M", "F# B D# A#", "4 4 4 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(4,4,4,8)),
            // "B", "7M", "B D# F# A#", "9 8 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(9,8,7,8)),
            // "B", "7", "D# A B D#", "1 2 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(1,2,0,1)),
            // "B", "7", "F# A D# F#", "4 2 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,2,4,4)),
            // "B", "7", "A B D# A", "7 4 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,4,4,7)),
            // "B", "7", "B D# F# A", "9 8 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,8,7,7)),
            // "B", "7", "A D# F# B", "7 8 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,8,7,9)),
            // "B", "7", "B D# A B", "9 8 10 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,8,10,9)),
            // "B", "7/9", "D# A C# F#", "1 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(1,2,2,4)),
            // "B", "7/9", "B D# A C#", "9 8 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,8,10,11)),
            // "B", "min", "F# B D F#", "4 4 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,4,3,4)),
            // "B", "min", "B D F# B", "9 7 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,7,7,9)),
            // "B", "min7", "F# A D F#", "4 2 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,2,3,4)),
            // "B", "min7", "B D F# A", "9 7 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,7,7,7)),
            // "B", "m7/5b", "F A B D", "3 2 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(3,2,0,0)),
            // "B", "m7/5b", "B D F A", "9 7 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,7,6,7)),
            // "B", "min6", "G# B D F#", "6 4 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(6,4,3,4)),
            // "B", "min6", "B D F# G#", "9 7 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(9,7,7,6)),
            // "B", "m9", "B D F# C#", "9 7 7 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,7,7,11)),
            // "B", "m7/9", "B D A C#", "9 7 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,7,10,11)),
            // "B", "m7/5+", "F# A# D F#", "4 3 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,3,3,4)),
            // "B", "m7/5+", "B D F# A#", "9 7 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Diese)),
                new CasesClass(9,7,7,8)),
            // "B", "dim", "F B D F", "3 4 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,4,3,3)),
            // "B", "dim", "B D F G#", "9 7 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(9,7,6,6)),
            // "B", "4", "B E F# B", "9 9 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(9,9,7,9)),
            // "B", "5+", "D# G B D#", "1 0 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(1,0,0,1)),
            // "B", "5+", "G B D# G", "5 4 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,4,5)),
            // "B", "6", "F# B D# G#", "4 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,4,4,6)),
            // "B", "6", "B D# F# G#", "9 8 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(9,8,7,6)),
            // "B", "6/9", "D# G# C# F#", "1 1 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(1,1,2,4)),
            // "B", "6/9", "B D# G# C#", "9 8 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,8,9,11)),
            // "B", "7/9-", "D# A C D#", "1 2 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(1,2,1,1)),
            // "B", "7/9-", "F# C D# A", "4 5 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,4,7)),
            // "B", "7/9-", "B D# A C", "9 8 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(9,8,10,10)),
            // "B", "7/9+", "D# A D D#", "1 2 3 1"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese)),
                new CasesClass(1,2,3,1)),
            // "B", "7/9+", "F# D D# A", "4 7 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,7,4,7)),
            // "B", "7/13", "F# A D# G#", "4 2 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese)),
                new CasesClass(4,2,4,6)),
            // "B", "7/13", "A D# G# B", "7 8 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,8,9,9)),
            // "B", "7/13-", "F# A D# G", "4 2 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(4,2,4,5)),
            // "B", "7/13-", "A D# G B", "7 8 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun)),
                new CasesClass(7,8,8,9)),
            // "B", "9", "F# C# D# F#", "4 6 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese)),
                new CasesClass(4,6,4,4)),
            // "B", "9", "B D# F# C#", "9 8 7 11"
            new Accord(
                new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.B, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Diese),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Diese)),
                new CasesClass(9,8,7,11)),
#endregion
#region Cb
            // "Cb", "maj", "Gb Cb Eb Gb", "4 4 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,4,4,4)),
            // "Cb", "maj", "Cb Eb Gb Cb", "9 8 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol)),
                new CasesClass(9,8,7,9)),
            // "Cb", "7M", "Gb Bb Eb Gb", "4 3 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,3,4,4)),
            // "Cb", "7M", "Gb Cb Eb Bb", "4 4 4 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(4,4,4,8)),
            // "Cb", "7M", "Cb Eb Gb Bb", "9 8 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_majeur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(9,8,7,8)),
            // "Cb", "7", "Eb A Cb Eb", "1 2 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,2,0,1)),
            // "Cb", "7", "Gb A Eb Gb", "4 2 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,2,4,4)),
            // "Cb", "7", "A Cb Eb A", "7 4 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(7,4,4,7)),
            // "Cb", "7", "Cb Eb Gb A", "9 8 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,8,7,7)),
            // "Cb", "7", "A Eb Gb Cb", "7 8 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol)),
                new CasesClass(7,8,7,9)),
            // "Cb", "7", "Cb Eb A Cb", "9 8 10 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol)),
                new CasesClass(9,8,10,9)),
            // "Cb", "7/9", "Eb A Db Gb", "1 2 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,2,2,4)),
            // "Cb", "7/9", "Cb Eb A Db", "9 8 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,8,10,11)),
            // "Cb", "min", "Gb Cb D Gb", "4 4 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,4,3,4)),
            // "Cb", "min", "Cb D Gb Cb", "9 7 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol)),
                new CasesClass(9,7,7,9)),
            // "Cb", "min7", "Gb A D Gb", "4 2 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,2,3,4)),
            // "Cb", "min7", "Cb D Gb A", "9 7 7 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,7,7,7)),
            // "Cb", "m7/5b", "F A Cb D", "3 2 0 0"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun)),
                new CasesClass(3,2,0,0)),
            // "Cb", "m7/5b", "Cb D F A", "9 7 6 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5b), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(9,7,6,7)),
            // "Cb", "min6", "Ab Cb D Gb", "6 4 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(6,4,3,4)),
            // "Cb", "min6", "Cb D Gb Ab", "9 7 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur6), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(9,7,7,6)),
            // "Cb", "m9", "Cb D Gb Db", "9 7 7 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,7,7,11)),
            // "Cb", "m7/9", "Cb D A Db", "9 7 10 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_9),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,7,10,11)),
            // "Cb", "m7/5+", "Gb Bb D Gb", "4 3 3 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,3,3,4)),
            // "Cb", "m7/5+", "Cb D Gb Bb", "9 7 7 8"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.mineur7_5plus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.B, eAlteration.Bemol)),
                new CasesClass(9,7,7,8)),
            // "Cb", "dim", "F Cb D F", "3 4 3 3"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun)),
                new CasesClass(3,4,3,3)),
            // "Cb", "dim", "Cb D F Ab", "9 7 6 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.diminue),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(9,7,6,6)),
            // "Cb", "4", "Cb Fb Gb Cb", "9 9 7 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.quarte),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.F, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol)),
                new CasesClass(9,9,7,9)),
            // "Cb", "5+", "Eb G Cb Eb", "1 0 0 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,0,0,1)),
            // "Cb", "5+", "G Cb Eb G", "5 4 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.quinteplus),
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(5,4,4,5)),
            // "Cb", "6", "Gb Cb Eb Ab", "4 4 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,4,4,6)),
            // "Cb", "6", "Cb Eb Gb Ab", "9 8 7 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.six), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(9,8,7,6)),
            // "Cb", "6/9", "Eb Ab Db Gb", "1 1 2 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(1,1,2,4)),
            // "Cb", "6/9", "Cb Eb Ab Db", "9 8 9 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.six9), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,8,9,11)),
            // "Cb", "7/9-", "Eb A C Eb", "1 2 1 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,2,1,1)),
            // "Cb", "7/9-", "Gb C Eb A", "4 5 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,5,4,7)),
            // "Cb", "7/9-", "Cb Eb A C", "9 8 10 10"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Aucun)),
                new CasesClass(9,8,10,10)),
            // "Cb", "7/9+", "Eb A D Eb", "1 2 3 1"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol)),
                new CasesClass(1,2,3,1)),
            // "Cb", "7/9+", "Gb D Eb A", "4 7 4 7"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_9plus), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun)),
                new CasesClass(4,7,4,7)),
            // "Cb", "7/13", "Gb A Eb Ab", "4 2 4 6"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol)),
                new CasesClass(4,2,4,6)),
            // "Cb", "7/13", "A Eb Ab Cb", "7 8 9 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol)),
                new CasesClass(7,8,9,9)),
            // "Cb", "7/13-", "Gb A Eb G", "4 2 4 5"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun)),
                new CasesClass(4,2,4,5)),
            // "Cb", "7/13-", "A Eb G Cb", "7 8 8 9"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.sept_13moins), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.A, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Aucun),
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol)),
                new CasesClass(7,8,8,9)),
            // "Cb", "9", "Gb Db Eb Gb", "4 6 4 4"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf), 
                new NotesClass(
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol)),
                new CasesClass(4,6,4,4)),
            // "Cb", "9", "Cb Eb Gb Db", "9 8 7 11"
            new Accord(
                new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                new CouleurClass(eCouleur.neuf),                 new NotesClass(
                    new NoteClass(eNoteNaturelle.C, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.E, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.G, eAlteration.Bemol),
                    new NoteClass(eNoteNaturelle.D, eAlteration.Bemol)),
                new CasesClass(9,8,7,11))
            };
#endregion
        public static Accord[] TAB_ACCORDS
        {
            get { return _TAB_ACCORDS; }
        }
    }
#endregion
}
