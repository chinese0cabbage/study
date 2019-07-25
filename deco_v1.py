import time
def deco(func):
    def wrapper(a,b):
        start_time=time.time()
        func(a,b)
        end_time=time.time()
        msecs=(end_time-start_time)*1000
        print("time is %d ms" %msecs)
    return wrapper


@deco
def func(a,b):
    print("hello,here is a func for add :")
    time.sleep(1)
    print("result is %d" %(a+b))
if __name__=='__main__':
    f=func
    f(3,4)
    #func()
