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
        unknown_resource=0,
        empty11_resource = 0x01,
        empty12_resource = 0x02,
        empty13_resource = 0x04,
        empty21_resource = 0x08,
        empty22_resource = 0x10,
        empty23_resource = 0x20,
        space_resource = 0x40,
        time_resource = 0x80,
        message_resource = 0x100,
        energe_resource = 0x200,
        attention_resource = 0x400,
        force_resource = 0x800, // признак
        equipment_resource = 0x1000,
        cause_resource = 0x2000, // мотивация
        personal_resource = 0x4000,
        method_resource = 0x8000,
        motivation_resource = 0x10000,
        economical_resource = 0x20000,
        proposal_resource = 0x40000, // предложение
        demand_resource = 0x80000,  // спрос
        market_resource = 0x100000, // рыночное
        technology_resource = 0x200000 // технологическое
    }
}
