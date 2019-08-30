import re
class Solution:
    def isNumber(self, s: str) -> bool:
        naturalNumberPattern = "((\+|\-)?([0-9]+|([0-9]*\.[0-9]+)|([0-9]+\.[0-9]*))){1}"
        Integer = "(\+|\-)?[0-9]+"
        eExperssion = "(e"+Integer+")?"
        decimalNumber = naturalNumberPattern+eExperssion
        finalExperssion = "(\s*"+decimalNumber+"\s*)"
        pattern = re.compile("^"+finalExperssion+"$")
        return pattern.match(s)
