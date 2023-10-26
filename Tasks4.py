# NUMBER 1
# a, b, c, d = (int(input()) for _ in range(4))
# if a == 0 or b % a != 0:
#     print("NO")
# else:
#     print(-1 * (b // a))


# NUMBER 2
# k, m, n = (int(input()) for _ in range(3))
# if n % k == 0:
#     print((n // k) * 2 * m)
# else:
#     print((n // k + 1) * 2 * m)


# NUMBER 3
# a1, b1, c1, a2, b2, c2, a, b, c = (int(input()) for _ in range(9))
#
# help_sum = a1 + b1 + c1
# a_help = max(a1, b1, c1)
# c_help = min(a1, b1, c1)
# b_help = help_sum - a_help - c_help
# (
#     a1,
#     b1,
#     c1,
# ) = (
#     a_help,
#     b_help,
#     c_help,
# )
#
# help_sum = a2 + b2 + c2
# a_help = max(a2, b2, c2)
# c_help = min(a2, b2, c2)
# b_help = help_sum - a_help - c_help
# (
#     a2,
#     b2,
#     c2,
# ) = (
#     a_help,
#     b_help,
#     c_help,
# )
#
# help_sum = a + b + c
# a_help = max(a, b, c)
# c_help = min(a, b, c)
# b_help = help_sum - a_help - c_help
# (
#     a,
#     b,
#     c,
# ) = (
#     a_help,
#     b_help,
#     c_help,
# )
#
# if (c > (c1 + c2) and b > (b1 + b2) and a > a1 and a > a2) or (
#     c > c1 and c > c2 and b > b1 and b > b2 and a > (a1 + a2)
# ):
#     print("YES")
# else:
#     print("NO")


# NUMBER 4
k = int(input())
if k == 3 or (k >= 5 and k != 7):
    print("YES")
else:
    print("NO")
