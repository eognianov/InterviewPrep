students = []

for _ in range(int(input())):
    name = input()
    score = float(input())
    students.append([name, score])

second_highest = sorted(set([marks for name, marks in students]))[1]

print('\n'.join([a for a, b in sorted(students) if b == second_highest]))
