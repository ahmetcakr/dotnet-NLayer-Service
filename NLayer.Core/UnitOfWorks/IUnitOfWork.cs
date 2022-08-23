
namespace NLayer.Core.UnitOfWorks
{
    public interface IUnitOfWork
    {
        Task CommitAsync();   // SaveChangeAsync
        void Commit();        // SaveChange
    }
}
