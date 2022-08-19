using Renci.SshNet;
using System.Text.RegularExpressions;
using SSHTest.Object;

namespace SSHTest
{
    public class Provider
    {

        public ConnectionInfo ConnectionInfo { get; set; }

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
            var result = new Device();

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
                    string comm = "pwd"; //lsblk    //lshw -C disk   //hdparm -i /dev/sda    //fdisk -l  //blkid     //df -m
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

                IDictionary<Renci.SshNet.Common.TerminalModes, uint> termkvp = new Dictionary<Renci.SshNet.Common.TerminalModes, uint>();
                termkvp.Add(Renci.SshNet.Common.TerminalModes.ECHO, 53);

                ShellStream shellStream = client.CreateShellStream("xterm", 80, 40, 80, 40, 1024/*, termkvp*/);

                //Get logged in
                string rep = shellStream.Expect(new Regex(@"[$>]")); //expect user prompt

                //send command
                shellStream.WriteLine("sudo dmidecode -t 17");
                rep = shellStream.Expect(new Regex(@"([$#>:])")); //expect password or user prompt
                

                //check to send password
                if (rep.Contains(":"))
                {
                    //send password
                    rep = String.Empty;
                    shellStream.WriteLine("P@ssw0rd");
                    /*byte[] buffer = new byte[shellStream.Length];
                    shellStream.Read(buffer, 0, buffer.Length);
                    rep = Encoding.UTF8.GetString(buffer); */
                    rep = shellStream.Expect(new Regex(@"[~$]", RegexOptions.Multiline)); //expect user or root prompt
                }

                //string[] splitted = rep.Split(Environment.NewLine);
                //найти первую строку с ""*******, DMI type 17, **** *****""
                //var list = splitted.ToList();
                //int start = list.IndexOf("Handle");
                //начало = +1 - со следующей строки
                //найти последнюю пустую строку
                //конец = -2 с пред-предпоследней строки

                string[] splitted = rep.Split(new string[] { Environment.NewLine}, StringSplitOptions.None);
                var list = new List<string>(splitted);
                var start = list.IndexOf("Memory Device") + 1;
                var end = (list.Count - 2) - start;
                var cleanedList = list.GetRange(start, end);

                cleanedList.RemoveAll(x => x == "Memory Device");
                cleanedList.RemoveAll(x => new Regex(@"(.+DMI.+)").IsMatch(x));

                List<Dictionary<string, string>> finalList = new List<Dictionary<string, string>>();

                foreach (var item in cleanedList)
                {
                    Dictionary<string, string> pairs = new Dictionary<string, string>();
                    if (!item.Equals(string.Empty))
                    {
                        string[] pair = item.Split(':');
                        pairs.Add(pair[0], pair[1]); 
                    }
                         


                }



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

                        if (err.Equals("") && stat == 0) result.AddRange(output.Split("\n"));
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
                    string comm = "cat /proc/cpuinfo"; //lshw -C cpu  //lscpu
                    using (var cmd = client.CreateCommand(comm))
                    {
                        var returned = cmd.Execute();
                        var output = cmd.Result;
                        var err = cmd.Error;
                        var stat = cmd.ExitStatus;

                        if (err.Equals("") && stat == 0)
                        {
                            List<string> s = new List<string>();
                            s.AddRange(output.Split("\n"));
                            int count = s.Where(s => s.StartsWith("processor")).Count();
                            int index = 0;

                            for (int i = 0; i < count; i++)
                            {
                                List<string> list = new List<string>();

                                for (int j = index; j < s.Count; j++)
                                {
                                    ++index;
                                    if (s[j].Equals("")) { result.Add(list); break; }
                                    list.Add(s[j]);                                 
                                }
                                
                            }
                        }
                    }
                }
                client.Disconnect();
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

}
