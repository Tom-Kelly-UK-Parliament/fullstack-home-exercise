using System.Collections.Generic;

namespace UKParliament.CodeTest.Services
{
    public class DivisionInfoStorage : IDivisionInfoStorage
    {
        private static Dictionary<int, string> NotesStorage = new Dictionary<int, string>();

        public Dictionary<int, string> GetNotesStorage()
        {
            return NotesStorage;
        }
    }
}