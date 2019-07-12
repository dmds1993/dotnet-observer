using ConsoleApp1.Observador.Interface;
using ConsoleApp1.Revista;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class AssinanteConcreto : IObservador
    {
        private Editora objetoObservado;

        public AssinanteConcreto(Editora editora)
        {
            objetoObservado = editora;
            editora.RegistrarObservador(this);   
        }

        public void Atualizar(ISujeito sujeito)
        {
            if(sujeito == objetoObservado)
            {
                Console.WriteLine("[Aviso] - A editora alterou o seu estado para : " + objetoObservado.GetEdicao());
            }
        }
    }
}
