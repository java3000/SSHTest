namespace SSHTest.Object
{
    /// <summary>
    /// there is no analogue in CIM
    /// </summary>
    internal enum InterfaceType : byte
    {
        Unknown = 1,
        SCSI = 2,
        HDC = 3,
        IDE = 4,
        USB = 5,
        _1394 = 6
    }

    internal static class InterfaceTypeConverter
    {
        private static readonly string[] __names;



        static InterfaceTypeConverter()
        {
            __names = new string[] { 
                "Unknown", "SCSI", "HDC", "IDE", 
                "USB", "1394"
            };
        }



        public static string GetName(InterfaceType interfaceType)
        {
            return __names[(byte)interfaceType - 1];
        }

        public static InterfaceType GetInterfaceType(string interfaceType)
        {
            for (int i = 0; i < __names.Length; i++)
            {
                if (string.Compare(__names[i], interfaceType, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return (InterfaceType)(i + 1);
                }
            }
            //
            return InterfaceType.Unknown;
        }
    }
}
