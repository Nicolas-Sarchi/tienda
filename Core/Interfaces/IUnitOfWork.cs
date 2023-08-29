
namespace Core.Interfaces;

public interface IUnitOfWork: IDisposable
{

 IPais Paises { get; }
 IEstado Estados { get; }
Task<int> SaveAsync();

}
