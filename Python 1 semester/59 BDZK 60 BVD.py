from math import sqrt

# NUMBER 59
x, y = float(input()), float(input())
# B
if 0.25 <= x ** 2 + y ** 2 <= 1:
    print('YES')
else:
    print('NO')
# D
if abs(2 * x) + abs(y) <= 1:
    print('YES')
else:
    print('NO')
# Z
if -1 <= x <= 1:
    print(-2 <= y <= abs(x))
else:
    print('NO')
# K
if -1 <= x <= 1:
    print(y >= abs(x))
else:
    print(y >= 1)

# NUMBER 60
# B
if 0.25 <= x ** 2 + y ** 2 <= 1:
    print(-3)
else:
    print(y * y)
# V
if abs(y) <= 1 and abs(x) <= 1:
    print(x - y)
else:
    print(x * y + 7)
# D
if abs(2 * x) + abs(y) <= 1:
    print(sqrt(abs(x**2 - 1)))
else:
    print(x - y)












