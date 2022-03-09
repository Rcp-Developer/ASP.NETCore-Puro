using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace meu_aula1
{
    public class Configuracao : IConfiguracao
    {
        public string StrCon { get; set; }

        public Configuracao(){}
    }

    public interface IConfiguracao
    {
        public string StrCon { get; set; }
    }
}
