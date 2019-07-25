import time
def deco(func):
    start_time=time.time()
    f()
    end_time=time.time()
    excution_time=(end_time-start_time)*1000
    print("time is {} ms".format(excution_time))
def f():
    print("hello")
    time.sleep(1)
    print("word")
if __name__='__main__':
    deco(f)
    print("f.__name__ is{}".format(f.__name__))
    print()
