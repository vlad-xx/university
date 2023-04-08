def getLen(func):
    def _wrapper(*args, **kwargs):
        result = func(*args, **kwargs)
        print(len(result))
    return _wrapper

@getLen
def loop():
    l = [i for i in range(10000)]
    return l


loop()

