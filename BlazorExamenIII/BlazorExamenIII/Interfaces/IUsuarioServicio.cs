using Modelos;

namespace BlazorExamenIII.Interfaces;

public interface IUsuarioServicio
{
    Task<Usuario> GetPorCodigo(string codigo);
}
