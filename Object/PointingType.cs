namespace SSHTest.Object
{
    /// <summary>
    /// should be updated from CIM.Device.CIM_PointingDevice.PointingType
    /// </summary>
    internal enum PointingType : byte
    {
        Other = 1,
        Unknown = 2,
        Mouse = 3,
        Track_Ball = 4,
        Track_Point = 5,
        Glide_Point = 6,
        Touch_Pad = 7,
        Touch_Screen = 8,
        Mouse_Optical_Sensor = 9
    }

    internal static class PointingTypeConverter
    {
        private static readonly string[] __names;

        static PointingTypeConverter()
        {
            __names = new string[] { 
                "Other", "Unknown", "Mouse", "Track_Ball","Track_Point",
                "Glide_Point", "Touch_Pad", "Touch_Screen", "Mouse_Optical_Sensor"
            };
        }



        public static string GetName(PointingType type)
        {
            return __names[(byte)type - 1];
        }

        public static PointingType GetPointingType(string pointingType)
        {
            for (int i = 0; i < __names.Length; i++)
            {
                if (string.Compare(__names[i], pointingType, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return (PointingType)(i + 1);
                }
            }
            //
            return PointingType.Unknown;
        }
    }
}
