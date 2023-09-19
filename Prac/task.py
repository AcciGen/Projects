# l, r, w, s = map(float, input().split())
# res = round(l + r + w + s) / 4
# int_res = res - int(res)
# print(int(res) if int_res == 0 else res)


# n = int(input())
# lst = list(map(int, input().split()))[:n]
# x = 0
# y = 0
# for i in range(n):
#     if i % 4 == 0:
#         y += lst[i]
#     elif i % 4 == 1:
#         x += lst[i]
#     elif i % 4 == 2:
#         y -= lst[i]
#     else:
#         x -= lst[i]

# print(x, y)


lst = list(map(str, input().split()))
new = []
for i in sorted(lst): new.append(int(i) if i.isdigit() else i)
print(new)