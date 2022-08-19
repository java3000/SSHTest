using System.Collections.Immutable;
using System.Diagnostics;
using Renci.SshNet;
using System.Text.RegularExpressions;
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

        internal List<Subdevice> InquireAuidioCard()
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

        internal List<Subdevice> InquireCDDVDDrive()
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

        internal List<Subdevice> InquireController()
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

        internal Device InquireDevice()
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

        internal List<Subdevice> InquireDiskDrive()
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

        internal List<Subdevice> InquireDisketteDrive()
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

        internal List<Subdevice> InquireKeyboard()
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

        internal List<LogicalDrive> InquireLogicalDrive()
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

        internal List<Memory> InquireMemory()
        {
            var result = new List<Memory>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                IDictionary<Renci.SshNet.Common.TerminalModes, uint> termkvp =
                    new Dictionary<Renci.SshNet.Common.TerminalModes, uint>();
                termkvp.Add(Renci.SshNet.Common.TerminalModes.ECHO, 53);

                ShellStream shellStream = client.CreateShellStream("xterm", 80, 40, 80, 40, 1024 /*, termkvp*/);

                string rep = shellStream.Expect(new Regex(@"[$>]")); //expect user prompt

                shellStream.WriteLine("sudo dmidecode -t 17");
                rep = shellStream.Expect(new Regex(@"([$#>:])")); //expect password or user prompt

                if (rep.Contains(":"))
                {
                    rep = String.Empty;
                    shellStream.WriteLine("P@ssw0rd");
                    rep = shellStream.Expect(new Regex(@"[~$]", RegexOptions.Multiline));
                }

                string[] splitted = rep.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
                var list = new List<string>(splitted);
                var start = list.IndexOf("Memory Device") + 1;
                var end = (list.Count - 2) - start;
                var cleanedList = list.GetRange(start, end);

                cleanedList.RemoveAll(x => x == "Memory Device");
                cleanedList.RemoveAll(x => new Regex(@"(.+DMI.+)").IsMatch(x));

                List<ImmutableDictionary<string, string>> finalList = new List<ImmutableDictionary<string, string>>();
                Dictionary<string, string> pairs = new Dictionary<string, string>();
                
                foreach (var item in cleanedList)
                {
                    if (!item.Equals(string.Empty))
                    {
                        string[] pair = item.Split(':');
                        pairs.Add(pair[0].Trim(new []{'\t', ' '}), pair[1].Trim(new []{'\t', ' '}));
                    }
                    else  {finalList.Add(pairs.ToImmutableDictionary()); pairs.Clear();}
                }

                finalList.RemoveAll(x => x["Size"].Equals("No Module Installed"));

                //TODO ADD IM MEMORY CODE HERE

                client.Disconnect();
            }

            return result;
        }

        internal List<Subdevice> InquireModem()
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

        internal List<Subdevice> InquireMonitor()
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

        internal List<Subdevice> InquireMotherboard()
        {
            var result = new List<Subdevice>();

            using (var client = new SshClient(ConnectionInfo))
            {
                client.Connect();

                if (client.IsConnected)
                {
                    string comm = "sudo dmidecode -t baseboard";
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;

                        //if (err.Equals("") && stat == 0) result.AddRange(output.Split("\n"));
                    }
                }

                client.Disconnect();
            }

            return result;
        }

        internal List<NetworkAdapter> InquireNetworkAdapter()
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

        internal List<Subdevice> InquirePointingDevice()
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

        internal List<Subdevice> InquirePrinter()
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

        internal List<Subdevice> InquireProcessor()
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
                                Manufacturer manufacturer = Manufacturer.Get(processor["vendor_id"], new ProcessCache());
                                SubdeviceModel model = SubdeviceModel.Get(InquiryObjectType.Processor, processor["model name"], manufacturer, new ProcessCache(), out @new);
                                
                                if (model != null)
                                {
                                    if (@new)
                                    {
                                        int family;
                                        if (!Int32.TryParse(processor["cpu family"], out family))
                                            family = 0;
                                        if (family == 0)
                                        {
                                            ((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_FAMILY]).Value = (int)ProcessorFamily.Unknown;
                                        }
                                        else
                                        {
                                            ((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_FAMILY]).Value = family;
                                        }
                                        //((StringParameter)model.ParameterList[Parameter.PROCESSOR_SOCKETTYPENAME]).Value = Convert.ToString(obj["SocketDesignation"]).Trim();
                                        //((Int32Parameter)model.ParameterList[Parameter.PROCESSOR_L1CACHESIZE]).Value = l1CacheSize;

                                        int addressWidth;
                                        string size = processor["address sizes"];
                                        size = size.Substring(size.LastIndexOf("bits", StringComparison.Ordinal) - 3, 2) .Trim();
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

        internal List<Subdevice> InquireUnclassifiedSubdevice()
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

        internal List<Subdevice> InquireVideoAdapter()
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
    }

    internal class ProcessCache
    {
    }
}