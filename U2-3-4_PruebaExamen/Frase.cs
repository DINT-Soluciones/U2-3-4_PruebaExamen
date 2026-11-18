using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace U2_3_4_PruebaExamen
{
    public partial class Frase:ObservableObject
    {
        [ObservableProperty]
        private string? _textoAlmacenado;
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
