namespace SSHTest.Object
{
    /// <summary>
    /// should be updated from CIM.Physical.CIM_PhysicalMemory.MemoryType
    /// </summary>
    internal enum MemoryType : byte
    {
        Unknown = 0,
        Other = 1,
        DRAM = 2,
        Synchronous_DRAM = 3, //Synchronous DRAM
        Cache_DRAM = 4, //Cache DRAM
        EDO = 5,
        EDRAM = 6,
        VRAM = 7,
        SRAM = 8,
        RAM = 9,
        //10 
        ROM = 10,
        Flash = 11,
        EEPROM = 12,
        FEPROM = 13,
        EPROM = 14,
        CDRAM = 15,
        _3DRAM = 16, //3DRAM
        SDRAM = 17,
        SGRAM = 18,
        RDRAM = 19,
        // 20              
        DDR = 20,
        DDR_2 = 21, //DDR-2 
        BRAM = 22,
        FB_DIMM = 23, //FB-DIMM
        DDR3 = 24,
        FBD2 = 25,
        DMTF_Reserved = 26,
        Vendor_Reserved = 27
    }

    internal static class MemoryTypeConverter
    {
        private static readonly string[] __names;



        static MemoryTypeConverter()
        {
            __names = new string[] { 
                "Unknown", "Other", "DRAM", "Synchronous DRAM", 
                "Cache DRAM", "EDO", "EDRAM", "VRAM", "SRAM", "RAM", 
                "ROM", "Flash", "EEPROM", "FEPROM", 
                "EPROM", "CDRAM", "3DRAM", "SDRAM", "SGRAM", "RDRAM", 
                "DDR", "DDR-2", "BRAM", "FB-DIMM", "DDR3", "FBD2", 
                "DMTF Reserved", "Vendor Reserved"
            };
        }



        public static string GetName(MemoryType interfaceType)
        {
            return __names[(byte)interfaceType];
        }

        public static MemoryType GetInterfaceType(string memoryType)
        {
            for (int i = 0; i < __names.Length; i++)
            {
                if (string.Compare(__names[i], memoryType, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return (MemoryType)i;
                }
            }
            //
            return MemoryType.Unknown;
        }
    }
}
