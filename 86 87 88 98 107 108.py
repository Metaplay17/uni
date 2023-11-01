# NUMBER 86
# n = int(input())
# n_safe = n
# count, amount, num_sum, ten_degree = (0 for _ in range(4))
# flag = True
# while n > 0:
#     ten_degree += 1
#     count += 1
#     amount += n % 10
#     n //= 10
# first_num = n_safe // 10**(ten_degree - 1)
# ten_degree -= 1
# while ten_degree >= 0:
#     num_sum = num_sum + ((n_safe // 10**ten_degree) % 10) if flag else num_sum - ((n_safe // 10**ten_degree) % 10)
#     flag = not flag
#     ten_degree -= 1
# print(count, amount, num_sum, first_num)


# NUMBER 87
# n, m = int(input()), int(input())
# amount = 0
# while n > 0 and m > 0:
#     amount += n % 10
#     m -= 1
#     n //= 10
# print(amount)


# NUMBER 88
# n = int(input())
# n_safe1, n_safe2 = n, n
# is_three = False
# n_reverse, ten_degree = 0, 0
# n_square = n * n
# while n_square > 0:
#     if n_square % 10 == 3:
#         is_three = True
#         break
#     n_square //= 10
# while n > 0:
#     ten_degree += 1
#     n //= 10
# # ten_degree -= 1
# safe_ten_degree = ten_degree
# first_num, last_num = ((n_safe1 // 10**ten_degree) % 10), n_safe1 % 10
# n_switch_first_last = last_num * 10**safe_ten_degree
# n_added_ones = (10**(ten_degree + 2) + n_safe1 * 10) + 1
# while ten_degree >= 0:
#     n_reverse += (n_safe1 % 10) * 10**ten_degree
#     ten_degree -= 1
#     n_safe1 //= 10
# while safe_ten_degree > 1:
#     n_switch_first_last += ((n_safe2 // 10**safe_ten_degree) % 10) * 10**safe_ten_degree
#     safe_ten_degree -= 1
# print(n_switch_first_last)
# n_switch_first_last *= 10
# n_switch_first_last += first_num
# print(n_reverse, n_switch_first_last, n_added_ones, is_three)


# NUMBER 98
# n = int(input())
# a_pred, b_pred, k_fact = 1, 1, 1
# ans = 0
# for k in range(2, n + 1):
#     k_fact *= k
#     a = 3 * b_pred + 2 * a_pred
#     b = 2 * a_pred + b_pred
#     a_pred, b_pred = a, b
#     ans += 2**k / ((1 + a**2 + b**2) * k_fact)
# print(ans)


# NUMBER 107
# m = int(input())
# k = 1
# while m => 4**k:
#     k += 1
# print(k)


# NUMBER 108
n = int(input())
r = 1
while 2**r <= n:
    r += 1
print(2**r)





