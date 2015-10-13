﻿using System;
using System.Linq;
using SharpSenses.Util;

namespace SharpSenses.RealSense.Capabilities {
    public enum Capability {
        HandTracking,
        GestureTracking
    }

    public static class CapabilityHelper {
        public static Capability[] All() {
            return EnumUtil.GetValues<Capability>().ToArray();
        }
    }
}