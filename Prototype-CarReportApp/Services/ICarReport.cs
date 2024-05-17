namespace Prototype_CarReportApp.Services
{
    public interface ICarReport<T>
    {
        Task<IEnumerable<T>> GetAll();
        Task<T> GetSpecificInt(int id);
        Task<T> GetSpecificString(string id);
        Task<T> Add(T newEntity, string firstString, string secondString);
    }
}
