# a, b, c = int(input()), int(input()), int(input())
# if (a > b and a == c) or (a > c and a == b) or (a > b and a > c):
#     print(a)
# elif (b > a and b == c) or (b > c and b == a) or (b > a and b > c):
#     print(b)
# else:
#     print(c)
# NUMBER 1


# a = int(input())
# if (a % 4 == 0 and a % 100 != 0) or (a % 400 == 0):
#     print('YES')
# else:
#     print('NO')
# NUMBER 2


# king_x, king_y = 1, 1
# test_x, test_y = 2, 2
# if abs(king_x - test_x) <= 1 and abs(king_y - test_y) <= 1:
#     print('YES')
# else:
#     print('NO')
# NUMBER 3


# x, y = 2, 4
# count_flats_on_floor = y - x + 1
# if (x - 1) % count_flats_on_floor == 0:
#     print('YES')
# else:
#     print('NO')
# NUMBER 4


# cell_1_x, cell_1_y = 3, 2
# cell_2_x, cell_2_y = 7, 8
# if ((cell_1_x == cell_2_x or abs(cell_2_x - cell_1_x) % 2 != 1) and
#         (abs(cell_2_y - cell_1_y) % 2 != 1 or cell_1_y == cell_2_y)):
#     print('YES')
# else:
#     print('NO')
# NUMBER 5


# n, m, k = 3, 5, 6
#
# if n * m < k:
#     print('NO')
# elif k % n == 0 or k % m == 0:
#     print('YES')
# else:
#     print('NO')
# NUMBER 6

# n = int(input())
# korov = '056789'
# korova = '1'
# korovi = '234'
# if str(n % 10) in korov:
#     print(f'На лугу пасётся {n} коров.')
# if str(n % 10) in korova:
#     print(f'На лугу пасётся {n} корова.')
# if str(n % 10) in korovi:
#     print(f'На лугу пасётся {n} коровы.')
# NUMBER 7


# x1, y1 = 1, -5
# x2, y2 = -6, -8
# if x1 * y1 > 0 and x2 * y2 > 0:
#     if (x1 > 0 and x2 > 0) or (x1 < 0 and x2 < 0):
#         print('YES')
#     else:
#         print('NO')
# elif x1 * y1 < 0 and x2 * y2 < 0:
#     if (x1 > 0 and x2 > 0) or (x1 < 0 and x2 < 0):
#         print('YES')
#     else:
#         print('NO')
# else:
#     print('NO')
# NUMBER 8


