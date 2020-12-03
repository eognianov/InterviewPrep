n = int(input())
student_marks = {}
for _ in range(n):
    line = input().split()
    name, scores = line[0], line[1:]
    scores = map(float, scores)
    student_marks[name] = scores
query_name = input()


query_scores = list(student_marks[query_name])
scores_count = len(query_scores)

total_scores = sum(query_scores)

avg = total_scores/scores_count

print(f'{avg:.2f}')
