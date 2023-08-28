
namespace Core.Interfaces;

public interface IUnitOfWork: IDisposable
{

 IPais Paises { get; }
Task<int> SaveAsync();

}
