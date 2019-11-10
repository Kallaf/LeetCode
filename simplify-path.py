class Solution:
    def simplifyPath(self, path: str) -> str:
        folders = path.split('/')
        canonical = []
        folders = list(filter(None, folders)) 
        print(folders)
        for folder in folders:
            if folder != "." and folder != "..":
                canonical.append(folder)
            elif folder == ".." and len(canonical):
                canonical.pop()
        ans = ""
        for folder in canonical:
            ans += '/'+folder
        if ans == "":
            return "/"
        return ans
