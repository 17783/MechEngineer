using fastJSON;

namespace MechEngineer.Features.MechLabSlots
{
    internal class MechLabSlotsSettings : ISettings
    {
        public bool Enabled { get; set; } = true;
        public string EnabledDescription => "Makes the mech lab adhere to any custom mech slot counts.";

        [JsonIgnore]
        public bool MechLabGeneralWidgetEnabled => MechLabGeneralSlots > 0;
        public int MechLabArmTopPadding = 120;
        public int MechLabGeneralSlots = 3;
    }
}