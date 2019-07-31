import os
import sys
path=os.path.dirname(__file__)+'\\class_one'
sys.path.append(path)
from class_one import add
print(add.add(5,7))