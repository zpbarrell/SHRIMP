using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Shrimp.Data.Enums
{
    public enum DistrictName 
    { 
        Skynet, UmbrellaCorp, BlackMesa, TheInstitute
        // POSSIBLE OPTIONS FOR CASTING
        // [Display(Name = "Sky net")] Skynet,
        // [Display(Name = "Umbrella Corp")] UmbrellaCorp,
        // [Display(Name = "Black Mesa")] BlackMesa,
        // [Display(Name = "The Institute")] TheInstitute,
        // [Description("Skynet")]
        // Skynet,
        // [Description("Umbrella Corp")]
        // UmbrellaCorp,
        // [Description("Black Mesa")]
        // Black,
        // [Description("The Institute")]
        // TheInstitute
        // Skynet = 0,
        // UmbrellaCorp = 1,
        // BlackMesa = 2,
        // TheInstitute = 3
    }
    public enum DressCode { Strict, Moderate, Comfortable }
    public enum Resources { Water, Agriculture, Lumber, Machinery }
    public enum Permits { Weapons, Hunting, Communications, Labor }
}