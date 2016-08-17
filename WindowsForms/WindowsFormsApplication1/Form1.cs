using System;
using System.Numerics;
using System.Globalization;
using System.Net;
using System.Text.RegularExpressions;
using System.Windows.Forms;
namespace WindowsFormsApplication1
{
public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        IPv4CidrMaskBitsCombo.SelectedIndex = 8;
        IPv6CalcCombo.SelectedIndex = 64;
        IPv4VLSMCombo.SelectedIndex = 8;
        IPv6VLSMCombo.SelectedIndex = 64;
    }
    private void Exit3(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void Exit7(object sender, EventArgs e)
    {
        Application.Exit();

    }
    private void Exit2(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void Exit5(object sender, EventArgs e)
    {
        Application.Exit();
    }
    private void Exit4(object sender, EventArgs e)
        {
            Application.Exit();

        }
    private void IPv4ClassCalcButton_Click(object sender, EventArgs e)
    {
        string IpText = IPv4ClassTextBox.Text.Trim();
        Regex IPv4Reg = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg0000______ = new Regex(@"^(0\.)((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){2})([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg10000_____ = new Regex(@"^(10\.)((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){2})([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg10064_____ = new Regex(@"^((100)\.)((6[4-9]|[7-9][0-9]|1[0-1][0-9]|12[0-7])\.)(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg127000____ = new Regex(@"^(127\.)((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){2})([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg16925400__ = new Regex(@"^((169)\.)((254)\.)(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg1721600___ = new Regex(@"^((172)\.)((16|1[7-9]|2[0-9]|3[0-1])\.)(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg192000____ = new Regex(@"^((192)\.)((0)\.)((0)\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg192020____ = new Regex(@"^((192)\.)((0)\.)((2)\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg19288990__ = new Regex(@"^((192)\.)((88)\.)((99)\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg19216800__ = new Regex(@"^((192)\.)((168)\.)(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg19871800__ = new Regex(@"^((198)\.)((18|19)\.)(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg19851100__ = new Regex(@"^((198)\.)((51)\.)((100)\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg20301130__ = new Regex(@"^((203)\.)((0)\.)((113)\.)([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        //Regex IPv4Reg255255255_ = new Regex(@"^((255)\.){3}(255)");
        Regex IPv4RegMC = new Regex(@"^((22[4-9]|23[0-9])\.)((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){2})([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        Regex IPv4RegReserved = new Regex(@"^((24[0-9]|25[0-5])\.)((([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){2})([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        if (!IPv4Reg.IsMatch(IpText))
        {
            MessageBox.Show("No such IPv4.");
            return;
        }

        //{
        //    if (IPv4Reg0000______.IsMatch(IpText))
        //    {

        //    }
        //    else if (IPv4Reg0000______.IsMatch(IpText)){MessageBox.Show(IpText + "Belongs to 0.0.0.0 – 0.255.255.255, which is Used for broadcast messages to the current (this) network as specified by RFC 1700, page 4.");}
        //    else if (IPv4Reg10000_____.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to 10.0.0.0 – 10.255.255.255, which is Private network	Used for local communications within a private network as specified by RFC 1918."); }
        //    else if (IPv4Reg10064_____.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to 100.64.0.0 – 100.127.255.255, which is Private network	Used for communications between a service provider and its subscribers when using a Carrier-grade NAT, as specified by RFC 6598."); }
        //    else if (IPv4Reg127000____.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to 127.0.0.0 – 127.255.255.255, which is Used for loopback addresses to the local host, as specified by RFC 990."); }
        //    else if (IPv4Reg16925400__.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg1721600___.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg192000____.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg192020____.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg19288990__.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg19216800__.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg19871800__.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg19851100__.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg20301130__.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4Reg255255255_.IsMatch(IpText)) { MessageBox.Show(IpText + "Belongs to     , which is        "); }
        //    else if (IPv4RegMC.IsMatch(IpText))
        else if (IPv4RegMC.IsMatch(IpText))
        {
            MessageBox.Show(IpText + " Belongs to 224.0.0.0 - 239.255.255.255 range," +
                "\n" + "which is the Multicast range of IPv4." +
                "\n" + "Subnet Mask is not defined for this range.");
                return;
        }
        else if (IPv4RegReserved.IsMatch(IpText))
        {
            MessageBox.Show(IpText + " Belongs to 240.0.0.0 - 255.255.255.255 range," +
                "\n" + "which is Reserved for future use, as specified by RFC 6890." +
                "\n" + "Subnet Mask is not defined for this range.");
                return;
        }
        else
        {
            IPNetwork ipnetwork = IPNetwork.Parse(IpText);
            string ipNetwork = ipnetwork.Network.ToString();
            string ipNetmask = ipnetwork.Netmask.ToString();
            string ipBroadcast = ipnetwork.Broadcast.ToString();
            string ipFirstUsable = ipnetwork.FirstUsable.ToString();
            string ipLastUsable = ipnetwork.LastUsable.ToString();
            string ipUsable = ipnetwork.Usable.ToString();
            string ipCidr = ipnetwork.Cidr.ToString();
            string NetClass = null;
            if (ipnetwork.Cidr == 8)
            {
                NetClass = "Class: A  --- /8";
            }
            else if (ipnetwork.Cidr == 16)
            {
                NetClass = "Class: B --- /16";
            }
            else if (ipnetwork.Cidr == 24)
            {
                NetClass = "Class: C --- /24";
            }
            MessageBox.Show("Network:  " + ipNetwork + "\n" +
                "Netmask:  " + ipNetmask + "\n" +
                "FirstUsable:  " + ipFirstUsable + "\n" +
                "LastUsable:  " + ipLastUsable + "\n" +
                "Broadcast:  " + ipBroadcast + "\n" +
                "Usable:  " + ipUsable + "\n" + NetClass);
            return;
        }
    }
    private void IPv4CidrComboRelation(object sender, EventArgs e)
    {
        IPv4CidrComboBoxMask.SelectedIndex =
        IPv4CidrComboBoxMaxAddr.SelectedIndex =
        IPv4CidrComboBoxMaxNets.SelectedIndex = IPv4CidrMaskBitsCombo.Items.IndexOf(IPv4CidrMaskBitsCombo.SelectedItem.ToString());
    }
    private void IPv4CidrComboRelation2(object sender, EventArgs e)
    {
        IPv4CidrMaskBitsCombo.SelectedIndex =
        IPv4CidrComboBoxMaxNets.SelectedIndex =
        IPv4CidrComboBoxMaxAddr.SelectedIndex = IPv4CidrComboBoxMask.Items.IndexOf(IPv4CidrComboBoxMask.SelectedItem.ToString());
    }
    private void IPv4CidrComboRelation3(object sender, EventArgs e)
    {
        IPv4CidrMaskBitsCombo.SelectedIndex =
        IPv4CidrComboBoxMaxAddr.SelectedIndex =
        IPv4CidrComboBoxMask.SelectedIndex = IPv4CidrComboBoxMaxNets.Items.IndexOf(IPv4CidrComboBoxMaxNets.SelectedItem.ToString());
    }
    private void IPv4CidrComboRelation4(object sender, EventArgs e)
    {
        IPv4CidrMaskBitsCombo.SelectedIndex =
        IPv4CidrComboBoxMaxNets.SelectedIndex =
        IPv4CidrComboBoxMask.SelectedIndex = IPv4CidrComboBoxMaxAddr.Items.IndexOf(IPv4CidrComboBoxMaxAddr.SelectedItem.ToString());
    }
    private void IPv4CidrCalcButton(object sender, EventArgs e)
    {
        string IpText = IPv4CidrIPv4TextBox.Text.Trim();
        Regex IPv4Reg = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        if (!IPv4Reg.IsMatch(IpText))
        {
            MessageBox.Show("No such IPv4.");
            return;
        }
        else
        {
            string Mask = IPv4CidrMaskBitsCombo.SelectedItem.ToString();
            string IpAndMask = IpText + "/" + Mask;
            //////
            IPNetwork ipnetwork = IPNetwork.Parse(IpAndMask);
            string ipNetwork = ipnetwork.Network.ToString();
            string ipNetmask = ipnetwork.Netmask.ToString();
            string ipBroadcast = ipnetwork.Broadcast.ToString();
            string ipFirstUsable = ipnetwork.FirstUsable.ToString();
            string ipLastUsable = ipnetwork.LastUsable.ToString();
            string ipUsable = ipnetwork.Usable.ToString();
            string ipCidr = ipnetwork.Cidr.ToString();
            MessageBox.Show("Network:  " + ipNetwork + "\n" +
                "Netmask:  " + ipNetmask + "\n" +
                "FirstUsable:  " + ipFirstUsable + "\n" +
                "LastUsable:  " + ipLastUsable + "\n" +
                "Broadcast:  " + ipBroadcast + "\n" +
                "Usable:  " + ipUsable + "\n" +
                "CIDR:  " + ipCidr);
            return;
        }
    }
    private void IPv6Calc(object sender, EventArgs e)
    {
            #region variables
            string IPv6Init = IPv6CalcTextBox.Text.Trim();
            int Prefix = int.Parse(IPv6CalcCombo.SelectedItem.ToString());
            string[] IPv6InitToArr = null;
            string DoubleDotReplace = null;
            string IPv6Final = null;
            string IPv6ToPrint = null;
            string[] IPv6ReplacedToArr;
            int IndexOfDoubleDot = 0;
            BigInteger[] IPv6HextetsToInteger = new BigInteger[8];
            BigInteger IPv6Integer = 0;
            Regex IPv6Reg = new Regex(@"^(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$");
            if (IPv6Reg.IsMatch(IPv6Init))
            {
                IPNetwork IPv6NetworkInitial = IPNetwork.Parse(IPv6Init + "/" + Prefix);
                IPv6Init = IPv6NetworkInitial.Network.ToString();
                IndexOfDoubleDot = IPv6Init.IndexOf("::");
                IPv6InitToArr = IPv6Init.Split(':');
                if (Prefix == 128)
                {
                    MessageBox.Show("It's just the IPv6 address \"" + IPv6Init + "\"");
                    return;
                }
                else if (Prefix == 127)
                {
                    MessageBox.Show("It's just the IPv6 address \"" + IPv6Init + "\" and the address next to it.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("No such IPv6.");
                return;
            }
            #endregion
            #region //Makes 0000::f to 0000:0000:0000:0000:0000:0000:0000:f
            if (IndexOfDoubleDot != (-1))
            {
                for (int i = 0; i < ((8 - IPv6InitToArr.Length) + 1); i++)
                {
                    DoubleDotReplace += ":0000";
                    if (i == (((8 - IPv6InitToArr.Length)))) { DoubleDotReplace += ":"; }
                }
                IPv6Init = IPv6Init.Replace("::", DoubleDotReplace);
            }
            #endregion
            IPv6ReplacedToArr = IPv6Init.Split(':');
            #region Makes 0000:0000:0000:0000:0000:0000:0000:f to 0000:0000:0000:0000:0000:0000:0000:000f
            for (int i = 0; i < IPv6ReplacedToArr.Length; i++)
            {
                if (IPv6ReplacedToArr[i].Length > 4)
                {
                    MessageBox.Show("No Such IPv6");
                    return;
                }
                else if (IPv6ReplacedToArr[i].Length < 4)
                {
                    IPv6ReplacedToArr[i] = (new String('0', (4 - IPv6ReplacedToArr[i].Length)) + IPv6ReplacedToArr[i]).ToString();
                }
            }
            for (int i = 0; i < IPv6ReplacedToArr.Length; i++)
            {
                IPv6Final += IPv6ReplacedToArr[i];
                if (i < IPv6ReplacedToArr.Length - 1) { IPv6Final += ":"; }
            }
            #endregion
            #region Finalize
            if (!IPv6Reg.IsMatch(IPv6Final))//IPv6 Does not match
            {
                MessageBox.Show("No such IPv6.");
                return;
            }
            else//IPv6 Matches
            {
                //Hextets to Integer
                for (int i = 0; i < IPv6HextetsToInteger.Length; i++)
                {
                    IPv6HextetsToInteger[i] = int.Parse(IPv6ReplacedToArr[i], NumberStyles.HexNumber);
                }
                     IPv6Integer = (IPv6HextetsToInteger[0] << 112
                                   | IPv6HextetsToInteger[1] << 96
                                   | IPv6HextetsToInteger[2] << 80
                                   | IPv6HextetsToInteger[3] << 64
                                   | IPv6HextetsToInteger[4] << 48
                                   | IPv6HextetsToInteger[5] << 32
                                   | IPv6HextetsToInteger[6] << 16
                                   | IPv6HextetsToInteger[7]);
                string NetPrint = NumberToIpv6(IPv6Integer);
                string FUPrint = NumberToIpv6(IPv6Integer - 1 + 2);
                string LUPrint = NumberToIpv6(IPv6Integer + (BigInteger.Pow(2, 128 - Prefix) )-2);
                string BCPrint = NumberToIpv6(IPv6Integer + (BigInteger.Pow(2, 128 - Prefix) - 1));
                IPv6ToPrint = "Network Address: " + NetPrint + "\n" +
                            "First Usable Address: " + FUPrint + "\n" +
                            "Last Usable Address: " + LUPrint + "\n" +
                            "Broadcast Address: " + BCPrint + "\n" +
                            "Usable Addresses: " + (BigInteger.Pow(2, 128-Prefix) - 2) + "\n" +
                            "Prefix:" + (Prefix.ToString());
                MessageBox.Show(IPv6ToPrint);
                return;
            }
            #endregion
    }
    private void IPv4VLSMCalcButton_Click(object sender, EventArgs e)
    {
        string IPv4Networks = IPv4VLSMRichTextbox.Text.Trim();
        string IPv4 = IPv4VLSMTextbox.Text.Trim();
        string Mask = IPv4VLSMCombo.SelectedItem.ToString();
        Regex IPv4Reg = new Regex(@"^(([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\.){3}([0-9]|[1-9][0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])$");
        if (!IPv4Reg.IsMatch(IPv4))
        {
            MessageBox.Show("No such IPv4.");
            return;
        }
        else
        {
            IPNetwork IPv4NetworksNET = IPNetwork.Parse((IPv4 + "/" + Mask).ToString());
            IPv4 = IPv4NetworksNET.Network.ToString();
            IPAddress IPv4Addr = IPAddress.Parse(IPv4);
            string IPv4STR = IPv4Addr.ToString();
            string IpAndMask = IPv4Networks + "/" + Mask;
            var Networks = IPv4Networks.Split('\n');
            bool ValidNetworks = true;
            long[] NetworksIntInitial = new long[Networks.Length];
            long TotalAddresses = 0;
            foreach (string element in Networks)
            {
                Regex NetworksValidate = new Regex(@"^\d+$");
                if(!NetworksValidate.IsMatch(element))
                {
                    MessageBox.Show( "\"" + element + "\"" + " is not a valid network.");
                        return;                }
            }
                if (ValidNetworks)
                {
                    for (int i = 0; i < Networks.Length; i++)
                    {
                        NetworksIntInitial[i] = long.Parse(Networks[i]);
                    }
                    Array.Sort(NetworksIntInitial);
                    Array.Reverse(NetworksIntInitial);
                    long[] NetworksIntNearPowerOf2 =  new long[NetworksIntInitial.Length];
                    #region Network size to power of 2
                    for (int i = 0; i < NetworksIntInitial.Length; i++)
                    {
                        if (NetworksIntInitial[i]==0) { MessageBox.Show("Network size of ZERO is not acceptable"); return; }
                        else if (NetworksIntInitial[i] > 0 && NetworksIntInitial[i] <= 2) { NetworksIntNearPowerOf2[i] = 4; }
                        else if (NetworksIntInitial[i] > 2 && NetworksIntInitial[i] <= 6) { NetworksIntNearPowerOf2[i] = 8; }
                        else if (NetworksIntInitial[i] > 6 && NetworksIntInitial[i] <= 14) { NetworksIntNearPowerOf2[i] = 16; }
                        else if (NetworksIntInitial[i] > 14 && NetworksIntInitial[i] <= 30) { NetworksIntNearPowerOf2[i] = 32; }
                        else if (NetworksIntInitial[i] > 30 && NetworksIntInitial[i] <= 62) { NetworksIntNearPowerOf2[i] = 64; }
                        else if (NetworksIntInitial[i] > 62 && NetworksIntInitial[i] <= 126) { NetworksIntNearPowerOf2[i] = 128; }
                        else if (NetworksIntInitial[i] > 126 && NetworksIntInitial[i] <= 254) { NetworksIntNearPowerOf2[i] = 256; }
                        else if (NetworksIntInitial[i] > 254 && NetworksIntInitial[i] <= 510) { NetworksIntNearPowerOf2[i] = 512; }
                        else if (NetworksIntInitial[i] > 510 && NetworksIntInitial[i] <= 1022) { NetworksIntNearPowerOf2[i] = 1024; }
                        else if (NetworksIntInitial[i] > 1022 && NetworksIntInitial[i] <= 2046) { NetworksIntNearPowerOf2[i] = 2048; }
                        else if (NetworksIntInitial[i] > 2046 && NetworksIntInitial[i] <= 4094) { NetworksIntNearPowerOf2[i] = 4096; }
                        else if (NetworksIntInitial[i] > 4094 && NetworksIntInitial[i] <= 8190) { NetworksIntNearPowerOf2[i] = 8192; }
                        else if (NetworksIntInitial[i] > 8190 && NetworksIntInitial[i] <= 16382) { NetworksIntNearPowerOf2[i] = 16384; }
                        else if (NetworksIntInitial[i] > 16382 && NetworksIntInitial[i] <= 32766) { NetworksIntNearPowerOf2[i] = 32768; }
                        else if (NetworksIntInitial[i] > 32766 && NetworksIntInitial[i] <= 65534) { NetworksIntNearPowerOf2[i] = 65536; }
                        else if (NetworksIntInitial[i] > 65534 && NetworksIntInitial[i] <= 131070) { NetworksIntNearPowerOf2[i] = 131072; }
                        else if (NetworksIntInitial[i] > 131070 && NetworksIntInitial[i] <= 262142) { NetworksIntNearPowerOf2[i] = 262144; }
                        else if (NetworksIntInitial[i] > 262142 && NetworksIntInitial[i] <= 524286) { NetworksIntNearPowerOf2[i] = 524288; }
                        else if (NetworksIntInitial[i] > 524286 && NetworksIntInitial[i] <= 1048574) { NetworksIntNearPowerOf2[i] = 1048576; }
                        else if (NetworksIntInitial[i] > 1048574 && NetworksIntInitial[i] <= 2097150) { NetworksIntNearPowerOf2[i] = 2097152; }
                        else if (NetworksIntInitial[i] > 2097150 && NetworksIntInitial[i] <= 4194302) { NetworksIntNearPowerOf2[i] = 4194304; }
                        else if (NetworksIntInitial[i] > 4194302 && NetworksIntInitial[i] <= 8388606) { NetworksIntNearPowerOf2[i] = 8388608; }
                        else if (NetworksIntInitial[i] > 8388606 && NetworksIntInitial[i] <= 16777214) { NetworksIntNearPowerOf2[i] = 16777216; }
                        else if (NetworksIntInitial[i] > 16777214 && NetworksIntInitial[i] <= 33554430) { NetworksIntNearPowerOf2[i] = 33554432; }
                        else if (NetworksIntInitial[i] > 33554430 && NetworksIntInitial[i] <= 67108862) { NetworksIntNearPowerOf2[i] = 67108864; }
                        else if (NetworksIntInitial[i] > 67108862 && NetworksIntInitial[i] <= 134217726) { NetworksIntNearPowerOf2[i] = 134217728; }
                        else if (NetworksIntInitial[i] > 134217726 && NetworksIntInitial[i] <= 268435454) { NetworksIntNearPowerOf2[i] = 268435456; }
                        else if (NetworksIntInitial[i] > 268435454 && NetworksIntInitial[i] <= 536870910) { NetworksIntNearPowerOf2[i] = 536870912; }
                        else if (NetworksIntInitial[i] > 536870910 && NetworksIntInitial[i] <= 1073741822) { NetworksIntNearPowerOf2[i] = 1073741824; }
                        else if (NetworksIntInitial[i] > 1073741822 && NetworksIntInitial[i] <= 2147483646) { NetworksIntNearPowerOf2[i] = 2147483648; }
                        else if (NetworksIntInitial[i] > 2147483646 && NetworksIntInitial[i] <= 4294967294) { NetworksIntNearPowerOf2[i] = 4294967296; }
                        else { MessageBox.Show("Out of range network size"); }
                    }
                    #endregion
                    foreach(long element in NetworksIntNearPowerOf2)
                    {
                        TotalAddresses += element;
                    }
                    long ToatalAddressesByMask = (long)Math.Pow(2,(IPv4VLSMCombo.SelectedIndex));
                    if ( TotalAddresses > ToatalAddressesByMask )
                    {
                        MessageBox.Show("Your networks does not fit in /" + (32-IPv4VLSMCombo.SelectedIndex).ToString() + " network");
                        return;
                    }                  
                    var IPv4SplitedInOctets = IPv4STR.Split(new char[] { '.' });
                    char[] IPv4SplitedInOctetsCharArr= new char[4];
                    for (int i = 0; i < 4; i++)
                    {
                        IPv4SplitedInOctetsCharArr[i] = (char)int.Parse(IPv4SplitedInOctets[i]);
                    }
                    long RestoreIPv4Network = IPv4SplitedInOctetsCharArr[0] << 24 |
                        IPv4SplitedInOctetsCharArr[1] << 16 |
                        IPv4SplitedInOctetsCharArr[2] << 8 |
                        IPv4SplitedInOctetsCharArr[3];
                    long RestoreIPv4FirstUsable = RestoreIPv4Network + 1;
                    long RestoreIPv4LastUsable = RestoreIPv4Network + NetworksIntNearPowerOf2[0] - 2;
                    long RestoreIPv4Broadcast = RestoreIPv4Network + NetworksIntNearPowerOf2[0] - 1;
                    string[] FinalIPv4NetworkStr = new string[NetworksIntNearPowerOf2.Length];
                    long[] NetworkDigits = new long[4];
                    long[] FirstUsable = new long[4];
                    long[] LastUsable = new long[4];
                    long[] Broadcast = new long[4];
                    long[] NetworksIntNearPowerOf2ToPower = new long[NetworksIntNearPowerOf2.Length];
                    for (int i = 0; i < NetworksIntNearPowerOf2.Length; i++)
                    {
                        NetworksIntNearPowerOf2ToPower[i] = (long)Math.Log(NetworksIntNearPowerOf2[i], 2);
                    }
                    IPNetwork UsableAddresses;// = IPNetwork.Parse();
                    string ipUsable;// = UsableAddresses.Usable.ToString();
                    for (int i = 0; i < NetworksIntNearPowerOf2.Length; i++)
                    {
                        //
                        #region NetworkDigits
                        NetworkDigits[0] = ((RestoreIPv4Network >> 24) & 0xFF);
                        NetworkDigits[1] = ((RestoreIPv4Network >> 16) & 0xFF);
                        NetworkDigits[2] = ((RestoreIPv4Network >> 8) & 0xFF);
                        NetworkDigits[3] = ((RestoreIPv4Network) & 0xFF);
                        #endregion
                        #region FirstUsable
                        FirstUsable[0] = ((RestoreIPv4FirstUsable >> 24) & 0xFF);
                        FirstUsable[1] = ((RestoreIPv4FirstUsable >> 16) & 0xFF);
                        FirstUsable[2] = ((RestoreIPv4FirstUsable >> 8) & 0xFF);
                        FirstUsable[3] = ((RestoreIPv4FirstUsable) & 0xFF);
                        #endregion  
                        #region LastUsable
                        LastUsable[0] = ((RestoreIPv4LastUsable >> 24) & 0xFF);
                        LastUsable[1] = ((RestoreIPv4LastUsable >> 16) & 0xFF);
                        LastUsable[2] = ((RestoreIPv4LastUsable >> 8) & 0xFF);
                        LastUsable[3] = ((RestoreIPv4LastUsable) & 0xFF);
                        #endregion   
                        #region Broadcast
                        Broadcast[0] = ((RestoreIPv4Broadcast >> 24) & 0xFF);
                        Broadcast[1] = ((RestoreIPv4Broadcast >> 16) & 0xFF);
                        Broadcast[2] = ((RestoreIPv4Broadcast >> 8) & 0xFF);
                        Broadcast[3] = ((RestoreIPv4Broadcast) & 0xFF);
                        #endregion
                        #region UsableAddresses
                        UsableAddresses = IPNetwork.Parse(FirstUsable[0].ToString() +
                        '.' + FirstUsable[1].ToString() +
                            '.' + FirstUsable[2].ToString() +
                            '.' + FirstUsable[3].ToString() + "/"+
                            (32 - NetworksIntNearPowerOf2ToPower[i]));
                        ipUsable = UsableAddresses.Usable.ToString();
                    #endregion
                        #region Networks Printing
                        FinalIPv4NetworkStr[i] = "Network: " + NetworksIntInitial[i] + "\nNetwork address:" +
                            NetworkDigits[0].ToString() +
                            '.' + NetworkDigits[1].ToString() +
                            '.' + NetworkDigits[2].ToString() +
                            '.' + NetworkDigits[3].ToString() +
                            "\nFirst Usable address:" +
                            FirstUsable[0].ToString() +
                            '.' + FirstUsable[1].ToString() +
                            '.' + FirstUsable[2].ToString() +
                            '.' + FirstUsable[3].ToString() +
                            "\nLast Usable address:" +
                            LastUsable[0].ToString() +
                            '.' + LastUsable[1].ToString() +
                            '.' + LastUsable[2].ToString() +
                            '.' + LastUsable[3].ToString() +
                            "\nBroadcast address:" +
                            Broadcast[0].ToString() +
                            '.' + Broadcast[1].ToString() +
                            '.' + Broadcast[2].ToString() +
                            '.' + Broadcast[3].ToString() +
                            "\nUsable:" + ipUsable +                          
                            "\nNew Mask Bits: /" + (32-NetworksIntNearPowerOf2ToPower[i])
                            + "\n#########################\n";
                    if (i < NetworksIntNearPowerOf2.Length - 1)
                    {
                        RestoreIPv4LastUsable = RestoreIPv4Network + NetworksIntNearPowerOf2[i] + NetworksIntNearPowerOf2[i + 1] - 2;
                        RestoreIPv4Broadcast = RestoreIPv4Network + NetworksIntNearPowerOf2[i] + NetworksIntNearPowerOf2[i + 1] - 1;
                    }
                    RestoreIPv4Network += NetworksIntNearPowerOf2[i];
                    RestoreIPv4FirstUsable = RestoreIPv4Network + 1;
                }
                foreach (var str in FinalIPv4NetworkStr)
                {
                    IPv4VLSMRichTextboxOutput.AppendText(str);
                }
                return;
                #endregion

            }
        }
    }
    private void IPv4VLSMClearButton_Click(object sender, EventArgs e)
    {
        IPv4VLSMRichTextboxOutput.Clear();
    }
    private void IPv6VLSMClearOutputButton_Click(object sender, EventArgs e)
    {
        IPv6VLSMRichTextBoxOutput.Clear();

    }
    private void IPv6VLSMCalcButton_Click(object sender, EventArgs e)
    {
        #region variables
        string IPv6Init = IPv6VLSMTextBox.Text.Trim();
        string IPv6Networks = IPv6VLSMRichTextBox.Text.Trim();
        string Prefix = IPv6VLSMCombo.SelectedItem.ToString();
        string[] IPv6InitToArr = null;
        string DoubleDotReplace = null;
        string IPv6Final = null;
        string[] IPv6ReplacedToArr;
        string[] IPv6NetworksStringArray = IPv6Networks.Split('\n');
        int IndexOfDoubleDot = 0;
        int[] NewPrefixes = new int[IPv6NetworksStringArray.Length];
        BigInteger[] IPv6HextetsToInteger = new BigInteger[8];
        BigInteger[] IPv6NetworksToPrintInteger = new BigInteger[IPv6NetworksStringArray.Length];
        BigInteger[] IPv6FirstUsablesToPrintInteger = new BigInteger[IPv6NetworksStringArray.Length];
        BigInteger[] IPv6LastUsablesToPrintInteger = new BigInteger[IPv6NetworksStringArray.Length];
        BigInteger[] IPv6BroadcastsToPrintInteger = new BigInteger[IPv6NetworksStringArray.Length];
        BigInteger[] IPv6UsableToPrintInteger = new BigInteger[IPv6NetworksStringArray.Length];
        BigInteger IPv6Integer = 0;
        BigInteger[] IPv6NetworksIntInitial = new BigInteger[IPv6NetworksStringArray.Length];
        BigInteger[] NetworksIntNearPowerOf2 = new BigInteger[IPv6NetworksStringArray.Length];
        BigInteger TotalAddresses=0;
        BigInteger ToatalAddressesByMask = BigInteger.Pow(2, 128-int.Parse(Prefix));
        Regex IPv6Reg = new Regex(@"^(([0-9a-fA-F]{1,4}:){7,7}[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,7}:|([0-9a-fA-F]{1,4}:){1,6}:[0-9a-fA-F]{1,4}|([0-9a-fA-F]{1,4}:){1,5}(:[0-9a-fA-F]{1,4}){1,2}|([0-9a-fA-F]{1,4}:){1,4}(:[0-9a-fA-F]{1,4}){1,3}|([0-9a-fA-F]{1,4}:){1,3}(:[0-9a-fA-F]{1,4}){1,4}|([0-9a-fA-F]{1,4}:){1,2}(:[0-9a-fA-F]{1,4}){1,5}|[0-9a-fA-F]{1,4}:((:[0-9a-fA-F]{1,4}){1,6})|:((:[0-9a-fA-F]{1,4}){1,7}|:)|fe80:(:[0-9a-fA-F]{0,4}){0,4}%[0-9a-zA-Z]{1,}|::(ffff(:0{1,4}){0,1}:){0,1}((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])|([0-9a-fA-F]{1,4}:){1,4}:((25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9])\.){3,3}(25[0-5]|(2[0-4]|1{0,1}[0-9]){0,1}[0-9]))$");
        Regex NetworksValidate = new Regex(@"^\d+$");
        if (IPv6Reg.IsMatch(IPv6Init))
        {
            IPNetwork IPv6NetworkInitial = IPNetwork.Parse(IPv6Init + "/" + IPv6VLSMCombo.SelectedItem.ToString());
            IPv6Init = IPv6NetworkInitial.Network.ToString();
            IndexOfDoubleDot = IPv6Init.IndexOf("::");
            IPv6InitToArr = IPv6Init.Split(':');
            }
        else
        {
            MessageBox.Show("No such IPv6.");
            return;
        }
            #endregion
        #region //Makes 0000::f to 0000:0000:0000:0000:0000:0000:0000:f
        if (IndexOfDoubleDot != (-1))
        {
            for (int i = 0; i < ((8 - IPv6InitToArr.Length) + 1); i++)
            {
                DoubleDotReplace += ":0000";
                if (i == (((8 - IPv6InitToArr.Length)))) { DoubleDotReplace += ":"; }
            }
            IPv6Init = IPv6Init.Replace("::", DoubleDotReplace);
        }
        #endregion
        IPv6ReplacedToArr = IPv6Init.Split(':');
        #region Makes 0000:0000:0000:0000:0000:0000:0000:f to 0000:0000:0000:0000:0000:0000:0000:000f
            for (int i = 0; i < IPv6ReplacedToArr.Length; i++)
            {
                if (IPv6ReplacedToArr[i].Length > 4)
                {
                    MessageBox.Show("No Such IPv6");
                    return;
                }
                else if (IPv6ReplacedToArr[i].Length < 4)
                {
                    IPv6ReplacedToArr[i] = (new String('0', (4 - IPv6ReplacedToArr[i].Length)) + IPv6ReplacedToArr[i]).ToString();
                }
            }
            for (int i = 0; i < IPv6ReplacedToArr.Length; i++)
            {
                IPv6Final += IPv6ReplacedToArr[i];
                if (i < IPv6ReplacedToArr.Length - 1) { IPv6Final += ":"; }
            }
            #endregion
        #region Finalize
            if (!IPv6Reg.IsMatch(IPv6Final))//IPv6 Does not match
            {
                MessageBox.Show("No such IPv6.");
                return;
            }
            else//IPv6 Matches
            {
                //Hextets to Integer
                for (int i = 0; i < IPv6HextetsToInteger.Length; i++)
                {
                    IPv6HextetsToInteger[i] = int.Parse(IPv6ReplacedToArr[i], NumberStyles.HexNumber);
                }
                foreach (string element in IPv6NetworksStringArray)
                {
                    if (!NetworksValidate.IsMatch(element))
                    {
                        MessageBox.Show("\"" + element + "\"" + " is not a valid network.");
                        return;
                    }
                }
                //IPv6NetworksIntInitial/NetworksIntNearPowerOf2
                for (int i = 0; i < IPv6NetworksIntInitial.Length; i++)
                {
                    IPv6NetworksIntInitial[i] = BigInteger.Parse(IPv6NetworksStringArray[i]);
                }
                Array.Sort(IPv6NetworksIntInitial);
                Array.Reverse(IPv6NetworksIntInitial);
                #region Network size to power of 2
                for (int i = 0; i < IPv6NetworksStringArray.Length; i++)
                {
                    if (IPv6NetworksIntInitial[i] == 0) { MessageBox.Show("Network size of ZERO is not acceptable"); return; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("0") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4"); NewPrefixes[i] = 2; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("6")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("8"); NewPrefixes[i] = 3; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("6") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("14")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("16"); NewPrefixes[i] = 4; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("14") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("30")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("32"); NewPrefixes[i] = 5; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("30") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("62")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("64"); NewPrefixes[i] = 6; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("62") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("126")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("128"); NewPrefixes[i] = 7; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("126") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("254")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("256"); NewPrefixes[i] = 8; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("254") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("510")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("512"); NewPrefixes[i] = 9; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("510") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1022")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1024"); NewPrefixes[i] = 10; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1022") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2046")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2048"); NewPrefixes[i] = 11; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2046") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4094")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4096"); NewPrefixes[i] = 12; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4094") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("8190")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("8192"); NewPrefixes[i] = 13; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("8190") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("16382")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("16384"); NewPrefixes[i] = 14; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("16382") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("32766")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("32768"); NewPrefixes[i] = 15; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("32766") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("65534")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("65536"); NewPrefixes[i] = 16; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("65534") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("131070")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("131072"); NewPrefixes[i] = 17; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("131070") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("262142")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("262144"); NewPrefixes[i] = 18; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("262142") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("524286")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("524288"); NewPrefixes[i] = 19; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("524286") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1048574")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1048576"); NewPrefixes[i] = 20; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1048574") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2097150")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2097152"); NewPrefixes[i] = 21; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2097150") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4194302")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4194304"); NewPrefixes[i] = 22; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4194302") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("8388606")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("8388608"); NewPrefixes[i] = 23; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("8388606") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("16777214")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("16777216"); NewPrefixes[i] = 24; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("16777214") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("33554430")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("33554432"); NewPrefixes[i] = 25; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("33554430") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("67108862")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("67108864"); NewPrefixes[i] = 26; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("67108862") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("134217726")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("134217728"); NewPrefixes[i] = 27; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("134217726") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("268435454")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("268435456"); NewPrefixes[i] = 28; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("268435454") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("536870910")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("536870912"); NewPrefixes[i] = 29; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("536870910") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1073741822")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1073741824"); NewPrefixes[i] = 30; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1073741822") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2147483646")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2147483648"); NewPrefixes[i] = 31; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2147483646") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4294967294")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4294967296"); NewPrefixes[i] = 32; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4294967294") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("8589934590")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("8589934592"); NewPrefixes[i] = 33; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("8589934590") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("17179869182")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("17179869184"); NewPrefixes[i] = 34; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("17179869182") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("34359738366")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("34359738368"); NewPrefixes[i] = 35; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("34359738366") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("68719476734")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("68719476736"); NewPrefixes[i] = 36; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("68719476734") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("137438953470")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("137438953472"); NewPrefixes[i] = 37; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("137438953470") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("274877906942")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("274877906944"); NewPrefixes[i] = 38; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("274877906942") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("549755813886")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("549755813888"); NewPrefixes[i] = 39; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("549755813886") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1099511627774")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1099511627776"); NewPrefixes[i] = 40; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1099511627774") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2199023255550")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2199023255552"); NewPrefixes[i] = 41; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2199023255550") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4398046511102")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4398046511104"); NewPrefixes[i] = 42; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4398046511102") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("8796093022206")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("8796093022208"); NewPrefixes[i] = 43; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("8796093022206") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("17592186044414")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("17592186044416"); NewPrefixes[i] = 44; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("17592186044414") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("35184372088830")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("35184372088832"); NewPrefixes[i] = 45; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("35184372088830") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("70368744177662")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("70368744177664"); NewPrefixes[i] = 46; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("70368744177662") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("140737488355326")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("140737488355328"); NewPrefixes[i] = 47; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("140737488355326") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("281474976710654")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("281474976710656"); NewPrefixes[i] = 48; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("281474976710654") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("562949953421310")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("562949953421312"); NewPrefixes[i] = 49; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("562949953421310") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1125899906842620")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1125899906842620"); NewPrefixes[i] = 50; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1125899906842620") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2251799813685250")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2251799813685250"); NewPrefixes[i] = 51; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2251799813685250") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4503599627370490")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4503599627370500"); NewPrefixes[i] = 52; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4503599627370490") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("9007199254740990")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("9007199254740990"); NewPrefixes[i] = 53; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("9007199254740990") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("18014398509482000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("18014398509482000"); NewPrefixes[i] = 54; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("18014398509482000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("36028797018964000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("36028797018964000"); NewPrefixes[i] = 55; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("36028797018964000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("72057594037927900")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("72057594037927900"); NewPrefixes[i] = 56; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("72057594037927900") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("144115188075856000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("144115188075856000"); NewPrefixes[i] = 57; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("144115188075856000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("288230376151712000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("288230376151712000"); NewPrefixes[i] = 58; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("288230376151712000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("576460752303424000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("576460752303424000"); NewPrefixes[i] = 59; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("576460752303424000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1152921504606850000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1152921504606850000"); NewPrefixes[i] = 60; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1152921504606850000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2305843009213690000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2305843009213690000"); NewPrefixes[i] = 61; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2305843009213690000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4611686018427390000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4611686018427390000"); NewPrefixes[i] = 62; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4611686018427390000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("9223372036854780000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("9223372036854780000"); NewPrefixes[i] = 63; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("9223372036854780000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("18446744073709600000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("18446744073709600000"); NewPrefixes[i] = 64; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("18446744073709600000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("36893488147419100000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("36893488147419100000"); NewPrefixes[i] = 65; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("36893488147419100000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("73786976294838200000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("73786976294838200000"); NewPrefixes[i] = 66; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("73786976294838200000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("147573952589676000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("147573952589676000000"); NewPrefixes[i] = 67; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("147573952589676000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("295147905179353000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("295147905179353000000"); NewPrefixes[i] = 68; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("295147905179353000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("590295810358706000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("590295810358706000000"); NewPrefixes[i] = 69; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("590295810358706000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1180591620717410000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1180591620717410000000"); NewPrefixes[i] = 70; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1180591620717410000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2361183241434820000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2361183241434820000000"); NewPrefixes[i] = 71; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2361183241434820000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4722366482869650000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4722366482869650000000"); NewPrefixes[i] = 72; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4722366482869650000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("9444732965739290000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("9444732965739290000000"); NewPrefixes[i] = 73; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("9444732965739290000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("18889465931478600000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("18889465931478600000000"); NewPrefixes[i] = 74; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("18889465931478600000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("37778931862957200000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("37778931862957200000000"); NewPrefixes[i] = 75; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("37778931862957200000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("75557863725914300000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("75557863725914300000000"); NewPrefixes[i] = 76; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("75557863725914300000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("151115727451829000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("151115727451829000000000"); NewPrefixes[i] = 77; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("151115727451829000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("302231454903657000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("302231454903657000000000"); NewPrefixes[i] = 78; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("302231454903657000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("604462909807315000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("604462909807315000000000"); NewPrefixes[i] = 79; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("604462909807315000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1208925819614630000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1208925819614630000000000"); NewPrefixes[i] = 80; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1208925819614630000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2417851639229260000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2417851639229260000000000"); NewPrefixes[i] = 81; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2417851639229260000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4835703278458520000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4835703278458520000000000"); NewPrefixes[i] = 82; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4835703278458520000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("9671406556917030000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("9671406556917030000000000"); NewPrefixes[i] = 83; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("9671406556917030000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("19342813113834100000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("19342813113834100000000000"); NewPrefixes[i] = 84; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("19342813113834100000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("38685626227668100000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("38685626227668100000000000"); NewPrefixes[i] = 85; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("38685626227668100000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("77371252455336300000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("77371252455336300000000000"); NewPrefixes[i] = 86; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("77371252455336300000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("154742504910673000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("154742504910673000000000000"); NewPrefixes[i] = 87; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("154742504910673000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("309485009821345000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("309485009821345000000000000"); NewPrefixes[i] = 88; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("309485009821345000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("618970019642690000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("618970019642690000000000000"); NewPrefixes[i] = 89; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("618970019642690000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1237940039285380000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1237940039285380000000000000"); NewPrefixes[i] = 90; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1237940039285380000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2475880078570760000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2475880078570760000000000000"); NewPrefixes[i] = 91; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2475880078570760000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("4951760157141520000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("4951760157141520000000000000"); NewPrefixes[i] = 92; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("4951760157141520000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("9903520314283040000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("9903520314283040000000000000"); NewPrefixes[i] = 93; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("9903520314283040000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("19807040628566100000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("19807040628566100000000000000"); NewPrefixes[i] = 94; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("19807040628566100000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("39614081257132200000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("39614081257132200000000000000"); NewPrefixes[i] = 95; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("39614081257132200000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("79228162514264300000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("79228162514264300000000000000"); NewPrefixes[i] = 96; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("79228162514264300000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("158456325028529000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("158456325028529000000000000000"); NewPrefixes[i] = 97; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("158456325028529000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("316912650057057000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("316912650057057000000000000000"); NewPrefixes[i] = 98; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("316912650057057000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("633825300114115000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("633825300114115000000000000000"); NewPrefixes[i] = 99; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("633825300114115000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1267650600228230000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1267650600228230000000000000000"); NewPrefixes[i] = 100; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1267650600228230000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2535301200456460000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2535301200456460000000000000000"); NewPrefixes[i] = 101; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2535301200456460000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("5070602400912920000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("5070602400912920000000000000000"); NewPrefixes[i] = 102; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("5070602400912920000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("10141204801825800000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("10141204801825800000000000000000"); NewPrefixes[i] = 103; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("10141204801825800000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("20282409603651700000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("20282409603651700000000000000000"); NewPrefixes[i] = 104; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("20282409603651700000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("40564819207303300000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("40564819207303300000000000000000"); NewPrefixes[i] = 105; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("40564819207303300000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("81129638414606700000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("81129638414606700000000000000000"); NewPrefixes[i] = 106; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("81129638414606700000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("162259276829213000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("162259276829213000000000000000000"); NewPrefixes[i] = 107; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("162259276829213000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("324518553658427000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("324518553658427000000000000000000"); NewPrefixes[i] = 108; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("324518553658427000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("649037107316853000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("649037107316853000000000000000000"); NewPrefixes[i] = 109; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("649037107316853000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1298074214633710000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1298074214633710000000000000000000"); NewPrefixes[i] = 110; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1298074214633710000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2596148429267410000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2596148429267410000000000000000000"); NewPrefixes[i] = 111; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2596148429267410000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("5192296858534830000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("5192296858534830000000000000000000"); NewPrefixes[i] = 112; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("5192296858534830000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("10384593717069700000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("10384593717069700000000000000000000"); NewPrefixes[i] = 113; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("10384593717069700000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("20769187434139300000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("20769187434139300000000000000000000"); NewPrefixes[i] = 114; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("20769187434139300000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("41538374868278600000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("41538374868278600000000000000000000"); NewPrefixes[i] = 115; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("41538374868278600000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("83076749736557300000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("83076749736557300000000000000000000"); NewPrefixes[i] = 116; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("83076749736557300000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("166153499473114000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("166153499473114000000000000000000000"); NewPrefixes[i] = 117; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("166153499473114000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("332306998946229000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("332306998946229000000000000000000000"); NewPrefixes[i] = 118; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("332306998946229000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("664613997892458000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("664613997892458000000000000000000000"); NewPrefixes[i] = 119; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("664613997892458000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("1329227995784920000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("1329227995784920000000000000000000000"); NewPrefixes[i] = 120; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("1329227995784920000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("2658455991569830000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("2658455991569830000000000000000000000"); NewPrefixes[i] = 121; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("2658455991569830000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("5316911983139660000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("5316911983139660000000000000000000000"); NewPrefixes[i] = 122; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("5316911983139660000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("10633823966279300000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("10633823966279300000000000000000000000"); NewPrefixes[i] = 123; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("10633823966279300000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("21267647932558700000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("21267647932558700000000000000000000000"); NewPrefixes[i] = 124; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("21267647932558700000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("42535295865117300000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("42535295865117300000000000000000000000"); NewPrefixes[i] = 125; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("42535295865117300000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("85070591730234600000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("85070591730234600000000000000000000000"); NewPrefixes[i] = 126; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("85070591730234600000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("170141183460469000000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("170141183460469000000000000000000000000"); NewPrefixes[i] = 127; }
                    else if (IPv6NetworksIntInitial[i] > BigInteger.Parse("170141183460469000000000000000000000000") && IPv6NetworksIntInitial[i] <= BigInteger.Parse("340282366920938000000000000000000000000")) { NetworksIntNearPowerOf2[i] = BigInteger.Parse("340282366920938000000000000000000000000"); NewPrefixes[i] = 128; }
                    else { MessageBox.Show("Out of range network size"); }
                }
                #endregion
                foreach (BigInteger bigint in NetworksIntNearPowerOf2)
                {
                    TotalAddresses += bigint;
                }
                if (TotalAddresses > ToatalAddressesByMask)//if networks fit in initial network
                {
                    MessageBox.Show("Your networks does not fit in /" + (128 - IPv6VLSMCombo.SelectedIndex).ToString() + " network");
                    return;
                }
                else
                {
                    IPv6Integer = (IPv6HextetsToInteger[0] << 112
                                    |IPv6HextetsToInteger[1] << 96
                                    |IPv6HextetsToInteger[2] << 80
                                    |IPv6HextetsToInteger[3] << 64
                                    |IPv6HextetsToInteger[4] << 48
                                    |IPv6HextetsToInteger[5] << 32
                                    |IPv6HextetsToInteger[6] << 16
                                    |IPv6HextetsToInteger[7]);
                    for (int i = 0; i < NetworksIntNearPowerOf2.Length; i++)
                    {
                        if (i==0)
                        {
                            IPv6NetworksToPrintInteger[i] = IPv6Integer;
                            IPv6FirstUsablesToPrintInteger[i] = IPv6Integer+1;
                            IPv6LastUsablesToPrintInteger[i] = IPv6Integer + NetworksIntNearPowerOf2[i]-2;
                            IPv6BroadcastsToPrintInteger[i] = IPv6Integer + NetworksIntNearPowerOf2[i] - 1;
                            IPv6UsableToPrintInteger[i] = BigInteger.Pow(2,NewPrefixes[i])-2;
                        }
                        else if(i!=0)
                        {
                            IPv6NetworksToPrintInteger[i] = IPv6Integer + NetworksIntNearPowerOf2[i-1];
                            IPv6FirstUsablesToPrintInteger[i] = IPv6NetworksToPrintInteger[i]+1;
                            IPv6LastUsablesToPrintInteger[i] = IPv6NetworksToPrintInteger[i] + NetworksIntNearPowerOf2[i] - 2;
                            IPv6BroadcastsToPrintInteger[i] = IPv6NetworksToPrintInteger[i] + NetworksIntNearPowerOf2[i] - 1;
                            IPv6UsableToPrintInteger[i] = BigInteger.Pow(2, NewPrefixes[i]) - 2;
                            IPv6Integer += NetworksIntNearPowerOf2[i - 1];
                        }
                        IPv6VLSMRichTextBoxOutput.SelectedText +=
                            "Network"+i +"\n"+
                            "Network Address:" + NumberToIpv6(IPv6NetworksToPrintInteger[i]) + "\n"+
                            "First Usable Address:" + NumberToIpv6(IPv6FirstUsablesToPrintInteger[i]) + "\n" +
                            "Last Usable Address:" + NumberToIpv6(IPv6LastUsablesToPrintInteger[i]) + "\n" +
                            "Broadcast Address:" + NumberToIpv6(IPv6BroadcastsToPrintInteger[i]) + "\n" +
                            "Usable Addresses" + IPv6UsableToPrintInteger[i] + "\n" +
                            "New Prefix:" + (128-NewPrefixes[i])+
                            "\n###########################\n";

                    }
                }
            }
            #endregion
            return;
        }
    static string NumberToIpv6(BigInteger input)
        {
            string str = input.ToString("X");
            if (str.Length <= 32)
            {
                str = (new String('0', (32 - str.Length)) + str);
                str = (
                    str[0].ToString() + str[1].ToString() + str[2].ToString() + str[3].ToString() + ':' +
                    str[4].ToString() + str[5].ToString() + str[6].ToString() + str[7].ToString() + ':' +
                    str[8].ToString() + str[9].ToString() + str[10].ToString() + str[11].ToString() + ':' +
                    str[12].ToString() + str[13].ToString() + str[14].ToString() + str[15].ToString() + ':' +
                    str[16].ToString() + str[17].ToString() + str[18].ToString() + str[19].ToString() + ':' +
                    str[20].ToString() + str[21].ToString() + str[22].ToString() + str[23].ToString() + ':' +
                    str[24].ToString() + str[25].ToString() + str[26].ToString() + str[27].ToString() + ':' +
                    str[28].ToString() + str[29].ToString() + str[30].ToString() + str[31].ToString());
            }
            else
            {
                str = (
                    str[1].ToString() + str[2].ToString() + str[3].ToString() + str[4].ToString() + ':' +
                    str[5].ToString() + str[6].ToString() + str[7].ToString() + str[8].ToString() + ':' +
                    str[9].ToString() + str[10].ToString() + str[11].ToString() + str[12].ToString() + ':' +
                    str[13].ToString() + str[14].ToString() + str[15].ToString() + str[16].ToString() + ':' +
                    str[17].ToString() + str[18].ToString() + str[19].ToString() + str[20].ToString() + ':' +
                    str[21].ToString() + str[22].ToString() + str[23].ToString() + str[24].ToString() + ':' +
                    str[25].ToString() + str[26].ToString() + str[27].ToString() + str[28].ToString() + ':' +
                    str[29].ToString() + str[30].ToString() + str[31].ToString() + str[32].ToString());
            }
            return str;
        }
    private void pictureBox1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Insert IPv4 address and click Calc to get its network address, netmask, usable addresses and class.");
        return;
    }
    private void pictureBox2_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Insert IPv4 address and Network mask/Network bits / Max hosts/ Max networks then click Calc to get its parameters.");
        return;
    }
    private void pictureBox3_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Insert IPv6 address and Network prefix then click Calc to get its parameters.");
        return;
    }
    private void pictureBox4_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Insert main IPv4 network and Network mask. Then insert networks in the \"Networks\" text box (Each on a new line). Click Calc and you get the new IPv4 subnets and their parameters.");
        return;
    }
    private void pictureBox5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Insert main IPv6 network and Network prefix. Then insert networks in the \"Networks\" text box (Each on a new line). Click Calc and you get the new IPv6 subnets and their parameters.");
            return;
        }

    }
}