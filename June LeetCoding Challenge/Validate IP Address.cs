using System.Text.RegularExpressions;
public class Solution {
    public string ValidIPAddress(string IP) {
        string chunkIPv4 = "([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])";
        string chunkIPv6 = "([0-9a-fA-F]{1,4})";
        Match match4 = Regex.Match(IP, "^(" + chunkIPv4 + "\\.){3}" + chunkIPv4 + "$");
        if(match4.Success)return "IPv4";
        Match match6 = Regex.Match(IP, "^(" + chunkIPv6 + "\\:){7}" + chunkIPv6 + "$");
        if(match6.Success)return "IPv6";
        return "Neither"; 
    }
}
