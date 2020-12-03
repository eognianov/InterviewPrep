if __name__ == '__main__':
    N = int(input())
    L = []
    for _ in range(N):
        command_args = input().split()
        command = command_args[0]
        if len(command_args) > 1:
            e = int(command_args[1])
        if command == "insert":
            i = int(command_args[2])
            L.insert(e, i)
        elif command == "remove":
            L.remove(e)
        elif command == "append":
            L.append(e)
        elif command == "sort":
            L.sort()
        elif command == "pop":
            L.pop()
        elif command == "reverse":
            L.reverse()
        elif command == "print":
            print(L)
