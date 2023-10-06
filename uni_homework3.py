# r = 13.7
# fi = int(input())
# print(fi * r**2 / 2)
# Number 26


# x = int(input())
# print(1 + x * (- 2 + 3 * x - 4 * x * x))
# print(1 + x * (2 + 3 * x + 4 * x * x))
# Number 30


# start_x, start_y = int(input()), int(input())
# test_x, test_y = int(input()), int(input())
# if (abs(start_y - test_y) % 2 == 0 and abs(start_x - test_x) % 2 == 0) or \
#         (abs(start_y - test_y) % 2 != 0 and abs(start_x - test_x) % 2 != 0):
#     print('YES')
# else:
#     print('NO')
# Number 9


# a, b, c = ((int(input()) for _ in range(3)))
# amount = a + b + c
# a = max(a, b, c)
# c = min(a, b, c)
# b = amount - a - c
# if a ** 2 == b ** 2 + c ** 2:
#     print('pryamougolny')
# elif a > b + c:
#     print('does not exist')
# elif a ** 2 > b ** 2 + c ** 2:
#     print('tupougolny')
# else:
#     print('ostrougolny')
# Number 10


# a, b, c = ((int(input()) for _ in range(3)))
# if a == b == c:
#     print(3)
# if a == b or a == c or b == c:
#     print(2)
# else:
#     print(0)
# Number 11


# a, b, c, d, e = ((int(input()) for _ in range(5)))
# amount = a + b + c
# a = max(a, b, c)
# c = min(a, b, c)
# b = amount - a - c
# amount = d + e
# d = max(d, e)
# e = amount - d
# if b < e:
#     print('YES')
# else:
#     print('NO')
# Number 12


# a, b, c, d, e, f = ((int(input()) for _ in range(6)))
# amount = a + b + c
# a = max(a, b, c)
# c = min(a, b, c)
# b = amount - a - c
# amount = d + e + f
# d = max(d, e, f)
# f = min(d, e, f)
# e = amount - d - f
# if (a > d and b > f and c > e) or (d > a and f > b and e > c):
#     print('YES')
# else:
#     print('NO')


