n = int(input())
arr = map(int, input().split())

z = max(lis)
while max(lis) == z:
    lis.remove(max(lis))

print max(lis)
