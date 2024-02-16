# NUMBER 93
# q, r, b, c, d = (int(input()) for _ in range(5))
# n = int(input())
# pred_x, pred_pred_x = d, c
# x = pred_x
# for _ in range(n - 2):
#     x = q * pred_x + r * pred_pred_x + b
#     pred_pred_x = pred_x
#     pred_x = x
# print(x)


# NUMBER 95
# pred_a, pred_pred_a = 1, 1
# for i in range(2, 15):
#     a = pred_pred_a + (pred_a/2**(i - 1))
#     pred_pred_a = pred_a
#     pred_a = a
# print(a)


# NUMBER 99
# ans = 0
# u, v, n = int(input()), int(input()), int(input())
# k = 1
# curr_k_fact = 1
# a_pred, b_pred = u, v
# for i in range(2, n + 1):
#     curr_k_fact *= i
#     a = 2 * b_pred + a_pred
#     b = 2 * a_pred**2 + b_pred
#     a_pred, b_pred = a, b
#     ans += ((a * b)/curr_k_fact)
# print(ans)


# NUMBER 100
# ans = 0
# x1, x2, x3 = 1, 1, 1
# for i in range(4, 101):
#     x = x3 + x1
#     ans += x / 2**i
#     x1, x2, x3 = x2, x3, x
# print(ans)


# NUMBER 101
# a, x, eps = (float(input()) for _ in range(3))
# y_pred = a
# y = 0.5 * (y_pred + (x / y_pred))
# while abs(y**2 - y_pred**2) > eps:
#     y_pred = y
#     y = 0.5 * (y_pred + (x / y_pred))
# print(y)


# NUMBER 103
# eps = float(input())
# y_pred = 1
# y = (y_pred + 1) / (y_pred + 2)
# while abs(y - y_pred) > eps:
#     y_pred = y
#     y = (y_pred + 1) / (y_pred + 2)
# print(y)


# NUMBER 110
ans = 103
next_ans = 101
for _ in range(51):
    ans = next_ans + (1 / ans)
    next_ans -= 1
print(1 / ans)


