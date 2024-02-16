from random import randint


# NUMBER 1
# n, m = map(int, input().split())
# matrix = [[randint(0, 100) for _ in range(m)] for _ in range(n)]
# print(*matrix, sep="\n")


# NUMBER 2
def sort_matrix(matrix):
    swapped = True
    while swapped:
        swapped = False
        for i in range(len(matrix[0]) - 1):
            if matrix[0][i] > matrix[0][i + 1]:
                for j in range(len(matrix)):
                    matrix[j][i], matrix[j][i + 1] = matrix[j][i + 1], matrix[j][i]
                    swapped = True
    return matrix


# print(*sort_matrix(matrix), sep="\n")


# NUMBER 3
def transpose_matrix(matrix):
    ans = [[] for _ in range(len(matrix))]
    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            ans[i].append(matrix[j][i])
    return ans


# print(*transpose_matrix(matrix), sep="\n")


# NUMBER 4
def rotate_matrix(matrix, angle=90):
    ans = [[] for _ in range(len(matrix))]
    if angle == 180:
        for i in range(len(matrix)):
            ans[i] = matrix[-(i + 1)][::-1]
        return ans

    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            ans[i].insert(0, matrix[j][i])
    return ans


# print(*rotate_matrix(matrix, 180), sep="\n")


# NUMBER 5
def multiply_matrix(matrix, vector):
    ans = [0 for _ in range(len(vector))]
    for i in range(len(matrix)):
        for j in range(len(matrix[0])):
            ans[i] += matrix[i][j] * vector[j]
    return ans


# print(multiply_matrix([[1, 2, 3], [4, 5, 6], [7, 8, 9]], [1, 2, 3]))


# NUMBER 6
def make_spiral_matrix(size=9):
    ans = [[0 for _ in range(size)] for _ in range(size)]
    ratio = 1
    count = 0
    x, y = 0, 0
    action = True
    while action:
        action = False
        while x < size and ans[y][x] == 0:
            action = True
            ans[y][x] += ratio
            x += 1
            ratio += 1
        x -= 1
        y += 1
        while y < size and ans[y][x] == 0:
            action = True
            ans[y][x] += ratio
            y += 1
            ratio += 1
        y -= 1
        x -= 1
        while x >= 0 and ans[y][x] == 0:
            action = True
            ans[y][x] += ratio
            x -= 1
            ratio += 1
        x += 1
        y -= 1
        while ans[y][x] == 0:
            action = True
            ans[y][x] += ratio
            y -= 1
            ratio += 1
        y += 1
        x += 1
    return ans


# print(*make_spiral_matrix(9), sep="\n")


# NUMBER 7
def max_pooling(matrix):
    size = len(matrix) // 2
    ans = [[], []]
    curr_max = matrix[0][0]
    for i in range(size):
        for j in range(size):
            curr_max = max(curr_max, matrix[i][j])
    ans[0].append(curr_max)

    curr_max = matrix[size * 2 - 1][0]
    for i in range(size, size * 2):
        for j in range(size):
            curr_max = max(curr_max, matrix[i][j])
    ans[1].append(curr_max)

    curr_max = matrix[0][size * 2 - 1]
    for i in range(size):
        for j in range(size, size * 2):
            curr_max = max(curr_max, matrix[i][j])
    ans[0].append(curr_max)

    curr_max = matrix[size * 2 - 1][size * 2 - 1]
    for i in range(size, size * 2):
        for j in range(size, size * 2):
            curr_max = max(curr_max, matrix[i][j])
    ans[1].append(curr_max)

    return ans

# print(max_pooling([[1, 1, 2, 4], [5, 6, 7, 8], [3, 2, 1, 0], [1, 2, 3, 4]]))
