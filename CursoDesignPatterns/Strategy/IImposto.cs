using System;

namespace Strategy
{
    public interface IImposto
    {
        decimal Calcular(Orcamento pOrcamento);
    }
}
