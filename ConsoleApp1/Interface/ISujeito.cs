using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Observador.Interface
{
    public interface ISujeito
    {
        void RegistrarObservador(IObservador o);
        void RemoverObservador(IObservador o);
        void NotificarObservadores();
    }
}
