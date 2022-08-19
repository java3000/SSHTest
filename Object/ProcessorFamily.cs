namespace SSHTest.Object
{
    /// <summary>
    /// should be updated from CIM.Device.CIM_Processor.Family
    /// </summary>
    internal enum ProcessorFamily : int
    {
        [FriendlyName("Other")]
        Other = 1,

        [FriendlyName("Unknown")]
        Unknown = 2,

        [FriendlyName("8086")]
        _8086 = 3,

        [FriendlyName("80286")]
        _80286 = 4,

        [FriendlyName("80386")]
        _80386 = 5,

        [FriendlyName("80486")]
        _80486 = 6,

        [FriendlyName("8087")]
        _8087 = 7,

        [FriendlyName("80287")]
        _80287 = 8,

        [FriendlyName("80387")]
        _80387 = 9,

        [FriendlyName("80487")]
        _80487 = 10,

        [FriendlyName("Pentium(R) brand")]
        Pentium_R_brand = 11,

        [FriendlyName("Pentium(R) Pro")]
        Pentium_R_Pro = 12,

        [FriendlyName("Pentium(R) II")]
        Pentium_R_II = 13,

        [FriendlyName("Pentium(R) processor with MMX(TM) technology")]
        Pentium_R_processor_with_MMX_TM_technology = 14,

        [FriendlyName("Celeron(TM)")]
        Celeron_TM_ = 15,

        [FriendlyName("Pentium(R) II Xeon(TM)")]
        Pentium_R_II_Xeon_TM_ = 16,

        [FriendlyName("Pentium(R) III")]
        Pentium_R_III = 17,

        [FriendlyName("M1 Family")]
        M1_Family = 18,

        [FriendlyName("M2 Family")]
        M2_Family = 19,

        [FriendlyName("Intel(R) Celeron(R) M processor")]
        Intel_R_Celeron_R_M_processor = 20,

        [FriendlyName("Intel(R) Pentium(R) 4 HT processor")]
        Intel_R_Pentium_R_4_HT_processor = 21,

        [FriendlyName("K5 Family")]
        K5_Family = 24,

        [FriendlyName("K6 Family")]
        K6_Family = 25,

        [FriendlyName("K6-2")]
        K6_2 = 26,

        [FriendlyName("K6-3")]
        K6_3 = 27,

        [FriendlyName("AMD Athlon(TM) Processor Family")]
        AMD_Athlon_TM_Processor_Family = 28,

        [FriendlyName("AMD(R) Duron(TM) Processor")]
        AMD_R_Duron_TM_Processor = 29,

        [FriendlyName("AMD29000 Family")]
        AMD29000_Family = 30,

        [FriendlyName("K6-2+")]
        K6_2_ = 31,

        [FriendlyName("Power PC Family")]
        Power_PC_Family = 32,

        [FriendlyName("Power PC 601")]
        Power_PC_601 = 33,

        [FriendlyName("Power PC 603")]
        Power_PC_603 = 34,

        [FriendlyName("Power PC 603+")]
        Power_PC_603_ = 35,

        [FriendlyName("Power PC 604")]
        Power_PC_604 = 36,

        [FriendlyName("Power PC 620")]
        Power_PC_620 = 37,

        [FriendlyName("Power PC X704")]
        Power_PC_X704 = 38,

        [FriendlyName("Power PC 750")]
        Power_PC_750 = 39,

        [FriendlyName("Intel(R) Core(TM) Duo processor")]
        Intel_R_Core_TM_Duo_processor = 40,

        [FriendlyName("Intel(R) Core(TM) Duo mobile processor")]
        Intel_R_Core_TM_Duo_mobile_processor = 41,

        [FriendlyName("Intel(R) Core(TM) Solo mobile processor")]
        Intel_R_Core_TM_Solo_mobile_processor = 42,

        [FriendlyName("Intel(R) Atom(TM) processor")]
        Intel_R_Atom_TM_processor = 43,

        [FriendlyName("Alpha Family")]
        Alpha_Family = 48,

        [FriendlyName("Alpha 21064")]
        Alpha_21064 = 49,

        [FriendlyName("Alpha 21066")]
        Alpha_21066 = 50,

        [FriendlyName("Alpha 21164")]
        Alpha_21164 = 51,

        [FriendlyName("Alpha 21164PC")]
        Alpha_21164PC = 52,

        [FriendlyName("Alpha 21164a")]
        Alpha_21164a = 53,

        [FriendlyName("Alpha 21264")]
        Alpha_21264 = 54,

        [FriendlyName("Alpha 21364")]
        Alpha_21364 = 55,

        [FriendlyName("AMD Turion(TM) II Ultra Dual-Core Mobile M Processor Family")]
        AMD_Turion_TM_II_Ultra_Dual_Core_Mobile_M_Processor_Family = 56,

        [FriendlyName("AMD Turion(TM) II Dual-Core Mobile M Processor Family")]
        AMD_Turion_TM_II_Dual_Core_Mobile_M_Processor_Family = 57,

        [FriendlyName("AMD Athlon(TM) II Dual-Core Mobile M Processor Family")]
        AMD_Athlon_TM_II_Dual_Core_Mobile_M_Processor_Family = 58,

        [FriendlyName("AMD Opteron(TM) 6100 Series Processor")]
        AMD_Opteron_TM_6100_Series_Processor = 59,

        [FriendlyName("AMD Opteron(TM) 4100 Series Processor")]
        AMD_Opteron_TM_4100_Series_Processor = 60,

        [FriendlyName("MIPS Family")]
        MIPS_Family = 64,

        [FriendlyName("MIPS R400")]
        MIPS_R4000 = 65,

        [FriendlyName("MIPS R4200")]
        MIPS_R4200 = 66,

        [FriendlyName("MIPS R4400")]
        MIPS_R4400 = 67,

        [FriendlyName("MIPS R4600")]
        MIPS_R4600 = 68,

        [FriendlyName("MIPS R10000")]
        MIPS_R10000 = 69,

        [FriendlyName("SPARC Family")]
        SPARC_Family = 80,

        [FriendlyName("SuperSPARC")]
        SuperSPARC = 81,

        [FriendlyName("microSPARC II")]
        microSPARC_II = 82,

        [FriendlyName("microSPARC IIep")]
        microSPARC_IIep = 83,

        [FriendlyName("UltraSPARC")]
        UltraSPARC = 84,

        [FriendlyName("UltraSPARC II")]
        UltraSPARC_II = 85,

        [FriendlyName("UltraSPARC IIi")]
        UltraSPARC_IIi = 86,

        [FriendlyName("UltraSPARC III")]
        UltraSPARC_III = 87,

        [FriendlyName("UltraSPARC IIIi")]
        UltraSPARC_IIIi = 88,

        [FriendlyName("68040")]
        _68040 = 96,

        [FriendlyName("68xxx Family")]
        _68xxx_Family = 97,

        [FriendlyName("68000")]
        _68000 = 98,

        [FriendlyName("68010")]
        _68010 = 99,

        [FriendlyName("68020")]
        _68020 = 100,

        [FriendlyName("68030")]
        _68030 = 101,

        [FriendlyName("Hobbit Family")]
        Hobbit_Family = 112,

        [FriendlyName("Crusoe(TM) TM5000 Family")]
        Crusoe_TM_TM5000_Family = 120,

        [FriendlyName("Crusoe(TM) TM3000 Family")]
        Crusoe_TM_TM3000_Family = 121,

        [FriendlyName("Efficeon(TM) TM8000 Family")]
        Efficeon_TM_TM8000_Family = 122,

        [FriendlyName("Weitek")]
        Weitek = 128,

        [FriendlyName("Itanium(TM) Processor")]
        Itanium_TM_Processor = 130,

        [FriendlyName("AMD Athlon(TM) 64 Processor Family")]
        AMD_Athlon_TM_64_Processor_Family = 131,

        [FriendlyName("AMD Opteron(TM) Processor Family")]
        AMD_Opteron_TM_Processor_Family = 132,

        [FriendlyName("AMD Sempron(TM) Processor Family")]
        AMD_Sempron_TM_Processor_Family = 133,

        [FriendlyName("AMD Turion(TM) 64 Mobile Technology")]
        AMD_Turion_TM_64_Mobile_Technology = 134,

        [FriendlyName("Dual-Core AMD Opteron(TM) Processor Family")]
        Dual_Core_AMD_Opteron_TM_Processor_Family = 135,

        [FriendlyName("AMD Athlon(TM) 64 X2 Dual-Core Processor Family")]
        AMD_Athlon_TM_64_X2_Dual_Core_Processor_Family = 136,

        [FriendlyName("AMD Turion(TM) 64 X2 Mobile Technology")]
        AMD_Turion_TM_64_X2_Mobile_Technology = 137,

        [FriendlyName("Quad-Core AMD Opteron(TM) Processor Family")]
        Quad_Core_AMD_Opteron_TM_Processor_Family = 138,

        [FriendlyName("Third-Generation AMD Opteron(TM) Processor Family")]
        Third_Generation_AMD_Opteron_TM_Processor_Family = 139,

        [FriendlyName("AMD Phenom(TM) FX Quad-Core Processor Family")]
        AMD_Phenom_TM_FX_Quad_Core_Processor_Family = 140,

        [FriendlyName("AMD Phenom(TM) X4 Quad-Core Processor Family")]
        AMD_Phenom_TM_X4_Quad_Core_Processor_Family = 141,

        [FriendlyName("AMD Phenom(TM) X2 Dual-Core Processor Family")]
        AMD_Phenom_TM_X2_Dual_Core_Processor_Family = 142,

        [FriendlyName("AMD Athlon(TM) X2 Dual-Core Processor Family")]
        AMD_Athlon_TM_X2_Dual_Core_Processor_Family = 143,

        [FriendlyName("PA-RISC Family")]
        PA_RISC_Family = 144,

        [FriendlyName("PA-RISC 8500")]
        PA_RISC_8500 = 145,

        [FriendlyName("PA-RISC 8000")]
        PA_RISC_8000 = 146,

        [FriendlyName("PA-RISC 7300LC")]
        PA_RISC_7300LC = 147,

        [FriendlyName("PA-RISC 7200")]
        PA_RISC_7200 = 148,

        [FriendlyName("PA-RISC 7100LC")]
        PA_RISC_7100LC = 149,

        [FriendlyName("PA-RISC 7100")]
        PA_RISC_7100 = 150,

        [FriendlyName("V30 Family")]
        V30_Family = 160,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 3200 Series")]
        Quad_Core_Intel_R_Xeon_R_processor_3200_Series = 161,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 3000 Series")]
        Dual_Core_Intel_R_Xeon_R_processor_3000_Series = 162,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 5300 Series")]
        Quad_Core_Intel_R_Xeon_R_processor_5300_Series = 163,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 5100 Series")]
        Dual_Core_Intel_R_Xeon_R_processor_5100_Series = 164,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 5000 Series")]
        Dual_Core_Intel_R_Xeon_R_processor_5000_Series = 165,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor LV")]
        Dual_Core_Intel_R_Xeon_R_processor_LV = 166,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor ULV")]
        Dual_Core_Intel_R_Xeon_R_processor_ULV = 167,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 7100 Series")]
        Dual_Core_Intel_R_Xeon_R_processor_7100_Series = 168,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 5400 Series")]
        Quad_Core_Intel_R_Xeon_R_processor_5400_Series = 169,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor")]
        Quad_Core_Intel_R_Xeon_R_processor = 170,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 5200 Series")]
        Dual_Core_Intel_R_Xeon_R_processor_5200_Series = 171,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 7200 Series")]
        Dual_Core_Intel_R_Xeon_R_processor_7200_Series = 172,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 7300 Series")]
        Quad_Core_Intel_R_Xeon_R_processor_7300_Series = 173,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 7400 Series")]
        Quad_Core_Intel_R_Xeon_R_processor_7400_Series = 174,

        [FriendlyName("Multi-Core Intel(R) Xeon(R) processor 7400 Series")]
        Multi_Core_Intel_R_Xeon_R_processor_7400_Series = 175,

        [FriendlyName("Pentium(R) III Xeon(TM)")]
        Pentium_R_III_Xeon_TM_ = 176,

        [FriendlyName("Pentium(R) III Processor with Intel(R) SpeedStep(TM) Technology")]
        Pentium_R_III_Processor_with_Intel_R_SpeedStep_TM_Technology = 177,

        [FriendlyName("Pentium(R)")]
        Pentium_R_4 = 178,

        [FriendlyName("Intel(R) Xeon(TM)")]
        Intel_R_Xeon_TM_ = 179,

        [FriendlyName("AS400 Family")]
        AS400_Family = 180,

        [FriendlyName("Intel(R) Xeon(TM) processor MP")]
        Intel_R_Xeon_TM_processor_MP = 181,

        [FriendlyName("AMD Athlon(TM) XP Family")]
        AMD_Athlon_TM_XP_Family = 182,

        [FriendlyName("AMD Athlon(TM) MP Family")]
        AMD_Athlon_TM_MP_Family = 183,

        [FriendlyName("Intel(R) Itanium(R) 2")]
        Intel_R_Itanium_R_2 = 184,

        [FriendlyName("Intel(R) Pentium(R) M processor")]
        Intel_R_Pentium_R_M_processor = 185,

        [FriendlyName("Intel(R) Celeron(R) D processor")]
        Intel_R_Celeron_R_D_processor = 186,

        [FriendlyName("Intel(R) Pentium(R) D processor")]
        Intel_R_Pentium_R_D_processor = 187,

        [FriendlyName("Intel(R) Pentium(R) Processor Extreme Edition")]
        Intel_R_Pentium_R_Processor_Extreme_Edition = 188,

        [FriendlyName("Intel(R) Core(TM) Solo Processor")]
        Intel_R_Core_TM_Solo_Processor = 189,

        [FriendlyName("K7")]
        K7 = 190,

        [FriendlyName("Intel(R) Core(TM)2 Duo Processor")]
        Intel_R_Core_TM_2_Duo_Processor = 191,

        [FriendlyName("Intel(R) Core(TM)2 Solo processor")]
        Intel_R_Core_TM_2_Solo_processor = 192,

        [FriendlyName("Intel(R) Core(TM)2 Extreme processor")]
        Intel_R_Core_TM_2_Extreme_processor = 193,

        [FriendlyName("Intel(R) Core(TM)2 Quad processor")]
        Intel_R_Core_TM_2_Quad_processor = 194,

        [FriendlyName("Intel(R) Core(TM)2 Extreme mobile processor")]
        Intel_R_Core_TM_2_Extreme_mobile_processor = 195,

        [FriendlyName("Intel(R) Core(TM)2 Duo mobile processor")]
        Intel_R_Core_TM_2_Duo_mobile_processor = 196,

        [FriendlyName("Intel(R) Core(TM)2 Solo mobile processor")]
        Intel_R_Core_TM_2_Solo_mobile_processor = 197,

        [FriendlyName("Intel(R) Core(TM) i7 processor")]
        Intel_R_Core_TM_i7_processor = 198,

        [FriendlyName("Dual-Core Intel(R) Celeron(R) Processor")]
        Dual_Core_Intel_R_Celeron_R_Processor = 199,

        [FriendlyName("S/390 and zSeries Family")]
        S_390_and_zSeries_Family = 200,

        [FriendlyName("ESA/390 G4")]
        ESA_390_G4 = 201,

        [FriendlyName("ESA/390 G5")]
        ESA_390_G5 = 202,

        [FriendlyName("ESA/390 G6")]
        ESA_390_G6 = 203,

        [FriendlyName("z/Architectur base")]
        z_Architectur_base = 204,

        [FriendlyName("Intel(R) Core(TM) i5 processor")]
        Intel_R_Core_TM_i5_processor = 205,

        [FriendlyName("Intel(R) Core(TM) i3 processor")]
        Intel_R_Core_TM_i3_processor = 206,

        [FriendlyName("VIA C7(TM)-M Processor Family")]
        VIA_C7_TM_M_Processor_Family = 210,

        [FriendlyName("VIA C7(TM)-D Processor Family")]
        VIA_C7_TM_D_Processor_Family = 211,

        [FriendlyName("VIA C7(TM) Processor Family")]
        VIA_C7_TM_Processor_Family = 212,

        [FriendlyName("VIA Eden(TM) Processor Family")]
        VIA_Eden_TM_Processor_Family = 213,

        [FriendlyName("Multi-Core Intel(R) Xeon(R) processor")]
        Multi_Core_Intel_R_Xeon_R_processor = 214,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 3xxx Series")]
        Dual_Core_Intel_R_Xeon_R_processor_3xxx_Series = 215,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 3xxx Series")]
        Quad_Core_Intel_R_Xeon_R_processor_3xxx_Series = 216,

        [FriendlyName("VIA Nano(TM) Processor Family")]
        VIA_Nano_TM_Processor_Family = 217,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 5xxx Series")]
        Dual_Core_Intel_R_Xeon_R_processor_5xxx_Series = 218,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 5xxx Series")]
        Quad_Core_Intel_R_Xeon_R_processor_5xxx_Series = 219,

        [FriendlyName("Dual-Core Intel(R) Xeon(R) processor 7xxx Series")]
        Dual_Core_Intel_R_Xeon_R_processor_7xxx_Series = 220,

        [FriendlyName("Quad-Core Intel(R) Xeon(R) processor 7xxx Series")]
        Quad_Core_Intel_R_Xeon_R_processor_7xxx_Series = 221,

        [FriendlyName("Multi-Core Intel(R) Xeon(R) processor 7xxx Series")]
        Multi_Core_Intel_R_Xeon_R_processor_7xxx_Series = 222,

        [FriendlyName("Multi-Core Intel(R) Xeon(R) processor 3400 Series")]
        Multi_Core_Intel_R_Xeon_R_processor_3400_Series = 223,

        [FriendlyName("AMD Opteron(TM) 3000 Series Processor")] 
        AMD_Opteron_TM_3000_Series_Processor = 228,
        
        [FriendlyName("AMD Sempron(TM) II Processor Family")]
        AMD_Sempron_TM_II_Processor_Family = 229,

        [FriendlyName("Embedded AMD Opteron(TM) Quad-Core Processor Family")]
        Embedded_AMD_Opteron_TM_Quad_Core_Processor_Family = 230,

        [FriendlyName("AMD Phenom(TM) Triple-Core Processor Family")]
        AMD_Phenom_TM_Triple_Core_Processor_Family = 231,

        [FriendlyName("AMD Turion(TM) Ultra Dual-Core Mobile Processor Family")]
        AMD_Turion_TM_Ultra_Dual_Core_Mobile_Processor_Family = 232,

        [FriendlyName("AMD Turion(TM) Dual-Core Mobile Processor Family")]
        AMD_Turion_TM_Dual_Core_Mobile_Processor_Family = 233,

        [FriendlyName("AMD Athlon(TM) Dual-Core Processor Family")]
        AMD_Athlon_TM_Dual_Core_Processor_Family = 234,

        [FriendlyName("AMD Sempron(TM) SI Processor Family")]
        AMD_Sempron_TM_SI_Processor_Family = 235,

        [FriendlyName("AMD Phenom(TM) II Processor Family")]
        AMD_Phenom_TM_II_Processor_Family = 236,

        [FriendlyName("AMD Athlon(TM) II Processor Family")]
        AMD_Athlon_TM_II_Processor_Family = 237,

        [FriendlyName("Six-Core AMD Opteron(TM) Processor Family")]
        Six_Core_AMD_Opteron_TM_Processor_Family = 238,

        [FriendlyName("AMD Sempron(TM) M Processor Family")]
        AMD_Sempron_TM_M_Processor_Family = 239,

        [FriendlyName("i860")]
        i860 = 250,

        [FriendlyName("i960")]
        i960 = 251,

        [FriendlyName("SMBIOS Extension")]
        SMBIOS_Extension = 254,

        [FriendlyName("Un-initialized Flash Content - Lo")]
        Un_initialized_Flash_Content_Lo = 255,

        [FriendlyName("SH-3")]
        SH_3 = 260,

        [FriendlyName("SH-4")]
        SH_4 = 261,

        [FriendlyName("ARM")]
        ARM = 280,

        [FriendlyName("StrongARM")]
        StrongARM = 281,

        [FriendlyName("6x86")]
        _6x86 = 300,

        [FriendlyName("MediaGX")]
        MediaGX = 301,

        [FriendlyName("MII")]
        MII = 302,

        [FriendlyName("WinChip")]
        WinChip = 320,

        [FriendlyName("DSP")]
        DSP = 350,

        [FriendlyName("Video Processor")]
        Video_Processor = 500,
        
        [FriendlyName("For Future Special Purpose Assignment")]
        For_Future_Special_Purpose_Assignment = 65534,

        [FriendlyName("Un-initialized Flash Content - Hi")]
        Un_initialized_Flash_Content_Hi = 65535
    }

    internal class FriendlyNameAttribute : Attribute
    {
        public FriendlyNameAttribute(string other)
        {
            throw new NotImplementedException();
        }
    }
}
