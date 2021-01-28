using System.Collections.Generic;

namespace UKParliament.CodeTest.Services
{
    public interface IDivisionInfoStorage
    {
        Dictionary<int, string> GetNotesStorage();
    }
}