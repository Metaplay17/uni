from math import cos, sin, sqrt

# NUMBER 77
n = 4
# G
ans = 0
for i in range(1, n + 1):
    curr_add = 0
    for j in range(1, i + 1):
        curr_add += sin(j)
    curr_add = 1 / curr_add
    ans += curr_add
print(ans)


# D
ans = sqrt(2)
for _ in range(2, n + 1):
    ans = sqrt(2 + ans)
print(ans)

# E
ans = 0
for i in range(1, n + 1):
    curr_add_low = 0
    curr_add_high = 0
    for j in range(1, i + 1):
        curr_add_high += cos(j)
        curr_add_low += sin(j)
        ans += curr_add_high / curr_add_low
print(ans)

# G
ans = sqrt(3 * n)
for i in range(n - 1, 0, -1):
    ans = sqrt(ans + 3 * i)
print(ans)


# NUMBER 78
# B
ans = 1
a = 2
for i in range(n):
    ans *= (a + i)
print(ans)

# V
a = 2
ans = 1 / a
div = a
for i in range(1, n + 1):
    div *= (a + i)
    ans += 1 / div
print(ans)

# NUMBER 81
x, a, n = 0, 2, 4
ans = (x + a)**2
for _ in range(n):
    ans = (ans + a)**2
print(ans, ((((4 + 2)**2 + 2)**2 + 2)**2 + 2)**2)


# NUMBER 82
high, low = 1, 1
x = 0
if not 0 < x < 64 or x % 2 == 0:
    for i in range(1, 64, 2):
        high *= (x - (i + 1))
        low *= (x - i)
print(high / low)

# NUMBER 83
k = 1
i = 1
while k <= a:
    i += 1
    k += 1 / i
print(k, i)








