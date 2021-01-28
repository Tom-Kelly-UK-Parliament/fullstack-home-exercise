using System.Threading.Tasks;

namespace UKParliament.CodeTest.Services
{
    public class DivisionInfoService : IDivisionInfoService
    {
        private readonly IDivisionInfoStorage _storage;

        public DivisionInfoService(IDivisionInfoStorage storage)
        {
            _storage = storage;
        }

        public Task<DivisionInformation> GetDivisionPage(int skip, int take)
        {
            throw new System.NotImplementedException();
        }

        public void SaveNotesForDivision(int divisionId, string notes)
        {
            if (NotesForDivisionExist(divisionId))
            {
                _storage.GetNotesStorage()[divisionId] = notes;
            }
            else
            {
                _storage.GetNotesStorage().Add(divisionId, notes);
            }
        }

        public bool NotesForDivisionExist(int divisionId)
        {
            return _storage.GetNotesStorage().ContainsKey(divisionId);
        }

        public string GetNotesForDivision(int divisionId)
        {
            if (!NotesForDivisionExist(divisionId))
            {
                return null;
            }

            return _storage.GetNotesStorage()[divisionId];
        }
    }
}
