using ConsoleApp1.Observador.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Revista
{
    public class Editora : ISujeito
    {
        private List<IObservador> observadores = new List<IObservador>();
        private bool novaEdicao = false;

        public void NotificarObservadores()
        {
            foreach(IObservador observador in observadores)
            {
                observador.Atualizar(this);
            }
        }

        public void RegistrarObservador(IObservador o)
        {
            observadores.Add(o);
        }

        public void RemoverObservador(IObservador o)
        {
            observadores.Remove(o);
        }

        public void AlterarEdicao()
        {
            this.novaEdicao = !novaEdicao;

            NotificarObservadores();
        }

        public Boolean GetEdicao()
        {
            return novaEdicao;
        }
    }
}
