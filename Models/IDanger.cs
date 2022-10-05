using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheZoo.Models
{
    public interface IDanger
    {
        Dictionary<string, int> DangerType();
    }
}
