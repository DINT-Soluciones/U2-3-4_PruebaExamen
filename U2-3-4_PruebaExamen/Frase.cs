using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_3_4_PruebaExamen
{
    public class Frase:ObservableRecipient
    {
        private string? _textoAlmacenado;
        public string? TextoAlmacenado
        {
            get => _textoAlmacenado;
            set => SetProperty(ref _textoAlmacenado, value);
        }

        public Frase()
        {
            TextoAlmacenado = null;
        }
        public Frase(string? textoAlmacenado)
        {
            TextoAlmacenado = textoAlmacenado;
        }
    }
}
