using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EJ2
{

    class Cliente
    {
	//Declaro atributos propios de la clase cliente y ademas variables de clase
        TipoDocumento iTipoDocumento;
        string iNroDocumetno;
        string iNombre;
	//Declaro constructores
        public Cliente() : this(0, "", "") { }

        public Cliente(TipoDocumento pTipoDocumetno, string pNroDocumento, string pNombre)
        {
            iTipoDocumento = pTipoDocumetno;
            iNroDocumetno = pNroDocumento;
            iNombre = pNombre;
        }
	//Declaro propiedades que retornar los valores de los atributos de clase
        public TipoDocumento TipoDocumento
        {
            get { return this.iTipoDocumento; }
        }

        public string NroDocumento
        {
            get { return this.iNroDocumetno; }
        }

        public string Nombre
        {
            get { return this.iNombre; }
        }

    }
}
