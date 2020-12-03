if __name__ == '__main__':
    s = input()
    result = [False for _ in range(5)]
    for i in s:
        if i.isalnum():
            result[0] = True
            if i.isdigit():
                result[2] = True
                continue
            else:
                result[1] = True
                if i.islower():
                    result[3] = True
                else:
                    result[4] = True
    [print(i) for i in result]
