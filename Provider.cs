using System.Collections.Immutable;
using System.Diagnostics;
using Renci.SshNet;
using System.Text.RegularExpressions;
using Renci.SshNet.Common;
using SSHTest.Object;

//https://white55.ru/hardware.html
//https://losst.ru/fajlovaya-sistema-proc-v-linux
//https://linux.die.net/man/5/proc

namespace SSHTest
{
    public class Provider
    {
        public ConnectionInfo ConnectionInfo { get; set; }
        public Device currentDevice { get; set; }

        internal List<Subdevice> InquireAuidioCard(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireCDDVDDrive(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireController(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal Device InquireDevice(CacheContainer processCache)
        {
            var result = new Device("this", DateTime.Now, new ProviderType(), "this", new CacheContainer());

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd"; //uname -a
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireDiskDrive(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd"; //sudo fdisk -l
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireDisketteDrive(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireKeyboard(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<LogicalDrive> InquireLogicalDrive(Device device)
        {
            var result = new List<LogicalDrive>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string
                        comm = "pwd"; //lsblk    //lshw -C disk   //hdparm -i /dev/sda    //fdisk -l  //blkid     //df -m
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Memory> InquireMemory(Device device)
        {
            var result = new List<Memory>();
            Motherboard? motherboard = null; //(Motherboard)device.SubdeviceList.Find(x => x is Motherboard);
            string serialNumber = null;
            SubdeviceModel model;
            bool @new;

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    var finalList = RunSudoDmiCommand(client, DmiType.MemoryDevice, "P@ssw0rd");

                    finalList.RemoveAll(x => x["Size"].Equals("No Module Installed"));
                    //
                    //
                    foreach (var obj in finalList)
                    {
                        string manufacturerName = Convert.ToString(obj["Manufacturer"]).Trim();
                        Manufacturer manufacturer = Manufacturer.Get(manufacturerName, device.ProcessCache);

                        //TODO get the model name somethere
                        string modelName = Convert.ToString(obj["Model"]).Trim();
                        model = SubdeviceModel.Get(InquiryObjectType.Memory, modelName, manufacturer,
                            device.ProcessCache,
                            out @new);

                        if (model != null)
                        {
                            if (@new)
                            {
                                ((ByteParameter)model.ParameterList[Parameter.MEMORY_FORMFACTOR]).Value =
                                    Convert.ToByte(MemoryFormFactorConverter.GetMemoryFormFactor(obj["Form Factor"]));
                                ((ByteParameter)model.ParameterList[Parameter.MEMORY_MEMORYTYPE]).Value =
                                    Convert.ToByte(MemoryTypeConverter.GetInterfaceType(obj["Type"]));
                            }

                            Memory memory = new Memory(model, device);
                            memory.SerialNumber = Convert.ToString(obj["Serial Number"]).Trim();
                            memory.Speed = Convert.ToInt32((obj["Speed"].Equals("Unknown")) ? 0 : obj["Speed"]);
                            //
                            long capacity;
                            if (long.TryParse(Convert.ToString(obj["Size"]), out capacity))
                                memory.Capacity = (int)(capacity / (1024 * 1024)); //в Мб
                            //
                            if (motherboard != null)
                            {
                                string deviceLocator = (obj["Bank Locator"].Equals(String.Empty))
                                    ? obj["Locator"]
                                    : obj["Bank Locator"]; //BANK 0 BANK 1,...                    
                                int number;
                                bool memoryInserted = false;
                                //
                                int firstDigitNumber = deviceLocator.IndexOfAny(
                                    new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' });
                                if (firstDigitNumber != -1)
                                {
                                    deviceLocator = deviceLocator.Substring(firstDigitNumber); //число
                                    if (int.TryParse(deviceLocator, out number))
                                    {
                                        if (motherboard.SlotList.Count > number) //есть в матери такой слот
                                        {
                                            if (motherboard.SlotList[number].Plugin == null) //еще не вставляли
                                            {
                                                motherboard.SlotList[number].Plugin = memory;
                                                memoryInserted = true;
                                            }
                                        }
                                    }
                                }

                                //
                                if (!memoryInserted)
                                    for (int i = 0; i < motherboard.SlotList.Count; i++)
                                        if (motherboard.SlotList[i].Plugin == null)
                                        {
                                            motherboard.SlotList[i].Plugin = memory;
                                            break;
                                        }
                            }

                            result.Add(memory);
                            currentDevice.SubdeviceList.Add(memory);
                        }
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        private static List<ImmutableDictionary<string, string>> RunSudoDmiCommand(SshClient client, DmiType type,
            string password)
        {
            IDictionary<TerminalModes, uint> termkvp = new Dictionary<TerminalModes, uint>();
            termkvp.Add(TerminalModes.ECHO, 53);

            ShellStream shellStream = client.CreateShellStream("xterm", 80, 40, 80, 40, 1024 /*, termkvp*/);

            string rep = shellStream.Expect(new Regex(@"[$>]"));

            shellStream.WriteLine("sudo dmidecode -t " + (int)type);
            rep = shellStream.Expect(new Regex(@"([$#>:])"));

            if (rep.Contains(":"))
            {
                shellStream.WriteLine(password);
                rep = shellStream.Expect(new Regex(@"[~$]", RegexOptions.Multiline));
            }

            string[] splitted = rep.Split(new[] { Environment.NewLine }, StringSplitOptions.None);
            var list = new List<string>(splitted);
            var start = list.IndexOf(DmiConverter.GetName(type)) + 1;
            var end = (list.Count - 2) - start;
            var cleanedList = list.GetRange(start, end);

            cleanedList.RemoveAll(x => x == DmiConverter.GetName(type));
            cleanedList.RemoveAll(x => new Regex(@"(.+DMI.+)").IsMatch(x));

            List<ImmutableDictionary<string, string>> finalList = new List<ImmutableDictionary<string, string>>();
            Dictionary<string, string> pairs = new Dictionary<string, string>();

            foreach (var item in cleanedList)
            {
                if (!item.Equals(string.Empty))
                {
                    string[] pair = item.Split(':');
                    pairs.Add(pair[0].Trim('\t', ' '), pair[1].Trim('\t', ' '));
                }
                else
                {
                    finalList.Add(pairs.ToImmutableDictionary());
                    pairs.Clear();
                }
            }

            if (finalList.Count <= 0)
            {
                finalList.Add(pairs.ToImmutableDictionary());
                pairs.Clear();
            }

            return finalList;
        }

        internal List<Subdevice> InquireModem(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireMonitor(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireMotherboard(Device device)
        {
            var result = new List<Subdevice>();
            Motherboard motherboard = null;
            string serialNumber = null;
            SubdeviceModel model;
            bool @new;

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    var motherboardList = RunSudoDmiCommand(client, DmiType.Motherboard, "P@ssw0rd");

                    var board = motherboardList[0];
                    Manufacturer manufacturer = Manufacturer.Get(board["Manufacturer"], device.ProcessCache);
                    model = SubdeviceModel.Get(InquiryObjectType.Motherboard, board["Product Name"], manufacturer,
                        device.ProcessCache, out @new);

                    /*if (@new)
                    {
                        //TODO need to find this params somewhere

                        ((StringParameter)model.ParameterList[Parameter.MOTHERBOARD_PRIMARYBUSTYPE]).Value = "";
                        ((StringParameter)model.ParameterList[Parameter.MOTHERBOARD_SECONDARYBUSTYPE]).Value = "";
                        ((StringParameter)model.ParameterList[Parameter.MOTHERBOARD_CHIPSET]).Value = "";
                        ((StringParameter)model.ParameterList[Parameter.MOTHERBOARD_SOCKETTYPE]).Value = "";
                        ((StringParameter)model.ParameterList[Parameter.MOTHERBOARD_SOCKETTYPENAME]).Value = "";
                    }*/
                    
                    motherboard = new Motherboard(model, device);

                    motherboard.Description = board["Asset Tag"];
                    motherboard.Name = board["Product Name"];
                    motherboard.Status = (@new) ? StatusType.Created : StatusType.Updated;
                    motherboard.ManufacturerName = board["Manufacturer"];
                    motherboard.ModelName = board["Product Name"];
                    motherboard.SerialNumber = board[" Serial Number"];

                    var biosList = RunSudoDmiCommand(client, DmiType.Bios, "P@ssw0rd");
                    var bios = biosList[0];

                    motherboard.BIOSDate = DateTime.Parse(bios["Release Date"]);
                    motherboard.BIOSString = bios["Vendor"];
                    motherboard.BIOSVersion = bios["Version"];

                    //PART3 - MEMORY SLOTS
                }

                client.Disconnect();
            }

            device.SubdeviceList.Add(motherboard);
            result.Add(motherboard);

            return result;
        }

        internal List<NetworkAdapter> InquireNetworkAdapter(Device device)
        {
            var result = new List<NetworkAdapter>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquirePointingDevice(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquirePrinter(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireProcessor(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "cat /proc/cpuinfo"; //lshw -C cpu  //lscpu //sudo dmidecode -t 4
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;

                        if (err.Equals("") && stat == 0)
                        {
                            var processors = ParseCpuinfo(output, "processors");

                            foreach (var processor in processors)
                            {
                                bool @new;
                                Manufacturer manufacturer =
                                    Manufacturer.Get(processor["vendor_id"], device.ProcessCache);
                                SubdeviceModel model = SubdeviceModel.Get(InquiryObjectType.Processor,
                                    processor["model name"], manufacturer, device.ProcessCache, out @new);

                                if (model != null)
                                {
                                    if (@new)
                                    {
                                        int family;
                                        if (!Int32.TryParse(processor["cpu family"], out family))
                                            family = 0;
                                        if (family == 0)
                                        {
                                            ((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_FAMILY]).Value =
                                                (int)ProcessorFamily.Unknown;
                                        }
                                        else
                                        {
                                            ((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_FAMILY]).Value =
                                                family;
                                        }
                                        //((StringParameter)model.ParameterList[Parameter.PROCESSOR_SOCKETTYPENAME]).Value = Convert.ToString(obj["SocketDesignation"]).Trim();
                                        //((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_L1CACHESIZE]).Value = l1CacheSize;

                                        int addressWidth;
                                        string size = processor["address sizes"];
                                        size = size.Substring(size.LastIndexOf("bits", StringComparison.Ordinal) - 3, 2)
                                            .Trim();
                                        if (Int32.TryParse(Convert.ToString(size), out addressWidth))
                                            ((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_ADDRESSWIDTH])
                                                .Value = (addressWidth >= 48) ? 64 : 32;

                                        int l2CacheSize;
                                        if (Int32.TryParse(Convert.ToString(processor["cache size"]), out l2CacheSize))
                                            ((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_L2CACHESIZE])
                                                .Value = l2CacheSize;
                                    }
                                }

                                Subdevice proc = new Subdevice(model, currentDevice);
                                proc.Name = processor["processor"];
                                proc.ManufacturerName = processor["vendor_id"];
                                proc.ModelName = processor["model name"];
                                proc.Status = StatusType.Created;

                                result.Add(proc);
                            }
                        }
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        private static List<Dictionary<string, string>> ParseCpuinfo(string output, string type)
        {
            string categorySeparator = type switch
            {
                "processors" => "processor",
                _ => ""
            };

            var result = new List<Dictionary<string, string>>();
            var rawTextOutput = new List<string>();
            rawTextOutput.AddRange(output.Split("\n"));
            var count = rawTextOutput.Count(s => s.StartsWith(categorySeparator));
            var index = 0;

            for (int i = 0; i < count; i++)
            {
                var itemParams = new Dictionary<string, string>();

                for (int j = index; j < rawTextOutput.Count; j++)
                {
                    ++index;
                    if (rawTextOutput[j].Equals(""))
                    {
                        result.Add(itemParams);
                        break;
                    }

                    itemParams.Add(rawTextOutput[j].Split(':')[0].Trim('\t', ' '),
                        rawTextOutput[j].Split(':')[1].Trim('\t', ' '));
                }
            }

            return result;
        }

        internal List<Installation> InquireSoftware()
        {
            var result = new List<Installation>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireUnclassifiedSubdevice(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireVideoAdapter(Device device)
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "pwd";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;
                    }
                }
            }

            return null;
        }
    }
}