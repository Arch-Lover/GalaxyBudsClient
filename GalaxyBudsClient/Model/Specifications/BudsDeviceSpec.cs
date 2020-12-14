using System;
using System.Collections.Generic;
using GalaxyBudsClient.Model.Constants;
using GalaxyBudsClient.Model.Touchpad;

namespace GalaxyBudsClient.Model.Specifications
{
    public class BudsDeviceSpec : IDeviceSpec
    {
        public Dictionary<IDeviceSpec.Feature, FeatureRule?> Rules =>
            new Dictionary<IDeviceSpec.Feature, FeatureRule?>()
            {
                { IDeviceSpec.Feature.SeamlessConnection, new FeatureRule(3, "R170XXU0ATF2") },
                { IDeviceSpec.Feature.AmbientVoiceFocus, null },
                { IDeviceSpec.Feature.AmbientSound, null },
            };

        public Models Device => Models.Buds;
        public string DeviceBaseName => "Galaxy Buds (";
        public ITouchOption TouchMap => new BudsTouchOption();
        public Guid ServiceUuid => Uuids.Buds;
    }
}