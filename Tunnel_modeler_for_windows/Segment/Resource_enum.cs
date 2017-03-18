using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modeler.Tunnel.Windows.Segment
{
    [FlagsAttribute]
    public enum Resource_enum
    {
        fractal_resource = 0x04,
        attention_resource = 0x08,
        energe_resource = 0x10,
        force_resource = 0x20,
        space_resource = 0x40,
        time_resource = 0x80,
        message_resource = 0x100,
        equipment_resource = 0x200,
        cause_resource = 0x400,
        size_resource = 0x800,
        method_resource = 0x1000,
        motivation_resource = 0x2000,



    }
}
