using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Observador.Interface
{
    public interface IObservador
    {
        void Atualizar(ISujeito sujeito);
    }
}
