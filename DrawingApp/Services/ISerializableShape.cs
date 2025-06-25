using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawingApp.Services
{
    public interface ISerializableShape
    {
        //Bir şeklin özelliklerini metin haline çevirmek için kullandım.
        string Serialize();                
    }
}
