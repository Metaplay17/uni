from math import log10

# NUMBER 1
# n = int(input())
# mx = -10**10
# while n != 0:
#     mx = max(n, mx)
#     n = int(input())
# print(mx)


# NUMBER 2
# n = int(input())
# ans = 0
# while n != 0:
#     if n % 2 == 0:
#         ans += 1
#     n = int(input())
# print(ans)


# NUMBER 3
# n = int(input())
# ans = 0
# last = n
# while n != 0:
#     if n > last:
#         ans += 1
#     last = n
#     n = int(input())
# print(ans)


# NUMBER 4
# n = int(input())
# mx, pred_mx = float("-inf"), float("-inf")
# while n != 0:
#     if n > mx:
#         pred_mx = mx
#         mx = n
#     elif n > pred_mx:
#         pred_mx = n
#     n = int(input())
# print(pred_mx)


# NUMBER 5
# n = int(input())
# mx = float("-inf")
# count = 0
# while n != 0:
#     if n > mx:
#         mx = n
#         count = 1
#     elif n == mx:
#         count += 1
#     n = int(input())
# print(count)


# NUMBER 6
# a, b = int(input()), int(input())
# while a > b:
#     if a % 2 == 0 and a // 2 >= b:
#         print("//2")
#         a //= 2
#     else:
#         print("-1")
#         a -= 1


# NUMBER 7
# n = int(input())
# count_tens = int(log10(n))
# ans = 0
# while n > 10:
#     ans += ((n % 10) * 10**count_tens)
#     count_tens -= 1
#     n //= 10
# ans += n % 10
# print(ans)


# NUMBER 8
# k = int(input())
# ans = 0
# while k > 10:
#     clone = k
#     count_nums = (int(log10(clone)) + 1) // 2
#     ten_degree = 1
#     while count_nums > 0:
#         if not clone % (10**ten_degree) == clone // (10**count_nums):
#             break
#         count_nums -= 1
#     else:
#         ans += 1
#     k -= 1
#
# print(ans + 9)


# NUMBER 9
# n = int(input())
# k = 1
# ans = 0
# while n != 0:
#     last = n
#     n = int(input())
#     if last == n:
#         k += 1
#         ans = max(ans, k)
#     else:
#         k = 1
# print(ans)


# NUMBER 10
# n = int(input())
# k_up, k_down = 1, 1
# ans = 0
# while n != 0:
#     last = n
#     n = int(input())
#     if last == n:
#         k_up, k_down = 1, 1
#     elif last > n:
#         k_up += 1
#         k_down = 1
#         ans = max(ans, k_up)
#     else:
#         k_down += 1
#         k_up = 0
#         ans = max(ans, k_down)
# print(ans)

# NUMBER 11
# n = int(input())
# ans = float("inf")
# pred_mx, pot_mx, post_mx = float("inf"), float("inf"), float("inf")
# last_mx = 0
# count_max = 0
# while n != 0:
#     pred_mx = pot_mx
#     pot_mx = post_mx
#     post_mx = n
#     if pred_mx < pot_mx and pot_mx > post_mx:
#         ans = min(ans, last_mx)
#         last_mx = 0
#         count_max += 1
#     last_mx += 1
#     n = int(input())
# if count_max < 2:
#     print(0)
# else:
#     print(ans)


# NUMBER 12
a, b, c, d = (int(input()) for _ in range(4))
safe_b, safe_d = b, d
nok = 1
div = 2
while div <= max(b, d):
    while b % div == 0 or d % div == 0:
        if b % div == 0 and d % div == 0:
            b, d = b // div, d // div
            nok *= div
        elif b % div == 0:
            nok *= div
            b //= div
        else:
            nok *= div
            d //= div
    div += 1
print(f"{a * (nok // safe_b)}/{nok} {c * (nok // safe_d)}/{nok}")



