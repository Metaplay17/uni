# Number 1
def str_replace(str0, old, new, pos, cnt=0):
	left, right = str0[:pos], str0[pos:]
	if cnt == 0:
		right = right.replace(old, new)
	else:
		right = right.replace(old, new, cnt)
	return left + right

# Number 2
s = "12345qwer12345ty12345"
ans = ""
for i in s:
	if not i.isdigit():
		ans += i
print(ans)

# Number 3
s = "Kirol aaa Kirol aaaaaa Kirol aaaaa"
ans = []
s = s.split()
for i in s:
	if len(i) != 5:
		ans.append(i)
print(" ".join(ans))

# Number 4
s = "aa aaaa aaaaaaa aa aaaa"
print(s.replace(sorted(s.split(), key=len, reverse=True)[0], "<<There was the longest word of the string>>"))

# Number 5
def deencrypt(s, n):
		ans = ""
			
		for i in s:
			if i != " " and ord(i.upper()) - n < 65:
				if i.upper() == i:
					ans += chr(90 - ord(i.upper()) - n)
				else:
					ans += chr(90 - ord(i.upper()) - n).lower()
			else: 
				if i.upper() == i:
					ans += chr(ord(i.upper()) - n)
				else:
					ans += chr(ord(i.upper()) - n).lower()
		return ans
		
print(deencrypt("Nluro", 3))

# Number 6
def del_spaces(s):
	while "  " in s:
		s = s.replace("  ", " ")
	return s.strip()
print(del_spaces("    Kirol Kirol  Kirol     Kirol   K"))

# Number 7
s = "ff tkrjenfn ff gkfjfnf"
if s.index("f") == s.rindex("f"):
	print(s.index("f"))
else:
	print(s.index("f"), s.rindex("f"))
	
# Number 8
s = "In the hole in the ground there lived a hobbit"
print(s[:s.index("h")] + s[s.rindex("h") + 1:])
	