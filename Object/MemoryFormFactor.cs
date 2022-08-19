namespace SSHTest.Object
{
    /// <summary>
    /// should be updated from CIM.Physical.CIM_Chip.FormFactor
    /// </summary>
    internal enum MemoryFormFactor : byte
    {
        Unknown = 0,
        Other = 1,
        SIP = 2,
        DIP = 3,
        ZIP = 4,
        SOJ = 5,
        Proprietary = 6,
        SIMM = 7,
        DIMM = 8,
        TSOP = 9,
        PGA = 10,
        RIMM = 11,
        SODIMM = 12,
        SRIMM = 13,
        SMD = 14,
        SSMP = 15,
        QFP = 16,
        TQFP = 17,
        SOIC = 18,
        LCC = 19,
        // 20               
        PLCC = 20,
        BGA = 21,
        FPBGA = 22,
        LGA = 23
    }

    internal static class MemoryFormFactorConverter
    {
        private static readonly string[] __names;



        static MemoryFormFactorConverter()
        {
            __names = new string[] { 
                "Unknown", "Other", "SIP", "DIP", "ZIP", "SOJ", "Proprietary",
                "SIMM", "DIMM", "TSOP", "PGA", "RIMM", "SODIMM",
                "SRIMM", "SMD", "SSMP", "QFP", "TQFP", "SOIC", "LCC", 
                // 20               
                "PLCC", "BGA", "FPBGA", 
                "LGA"
            };
        }



        public static string GetName(MemoryFormFactor memoryFormFactor)
        {
            return __names[(byte)memoryFormFactor];
        }

        public static MemoryFormFactor GetMemoryFormFactor(string memoryFormFactor)
        {
            for (int i = 0; i < __names.Length; i++)
            {
                if (string.Compare(__names[i], memoryFormFactor, StringComparison.OrdinalIgnoreCase) == 0)
                {
                    return (MemoryFormFactor)i;
                }
            }
            //
            return MemoryFormFactor.Unknown;
        }
    }
}
