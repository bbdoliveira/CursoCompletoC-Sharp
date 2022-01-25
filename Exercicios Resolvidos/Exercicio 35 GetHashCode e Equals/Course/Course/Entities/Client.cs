using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Entities
{
    internal class Client
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public override bool Equals(object? obj)
        {
            if (!(obj is Client)) //Verifica se o objeto é do tipo da classe Client.
            {
                return false;
            }
            Client other = obj as Client; //Seta o objeto como cliente.
            return Email.Equals(other.Email);
        }

        public override int GetHashCode() 
        {
            return Email.GetHashCode(); //Qual objeto que eu vou comparar para saber se são iguais.
        }
    }
}
