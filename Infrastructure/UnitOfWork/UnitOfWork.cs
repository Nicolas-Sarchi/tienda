
using Core.Interfaces;
using Infrastructure.Data;
using Infrastructure.Repository;



namespace Infrastructure.UnitOfWork;

public class UnitOfWork : IUnitOfWork
{
    private readonly TiendaContext context;
    private PaisRepository _paises;
    private EstadoRepository _estados;


    public UnitOfWork(TiendaContext _context)
    {
        context = _context;
    }

    public IPais Paises
    {
        get{
            if (_paises == null)
            {
                _paises = new PaisRepository(context);
            }
            return _paises;
        }

    }

    public IEstado Estados
    {
        get
        {
            if (_estados == null)
            {
                _estados = new EstadoRepository(context);
            }
            return _estados;
        }

    }


    public void Dispose()
    {
        context.Dispose();
    }

    public async Task<int> SaveAsync()
    {
        return await context.SaveChangesAsync();
    }
}
