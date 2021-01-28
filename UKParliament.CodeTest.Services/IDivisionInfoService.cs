using System.Threading.Tasks;

namespace UKParliament.CodeTest.Services
{
    public interface IDivisionInfoService
    {
        Task<DivisionInformation> GetDivisionPage(int skip, int take);

        void SaveNotesForDivision(int divisionId, string notes);

        bool NotesForDivisionExist(int divisionId);

        string GetNotesForDivision(int divisionId);
    }
}