from pandas import read_csv as read
from sklearn.model_selection import train_test_split
import numpy
import tensorflow

a = tensorflow.multiply


def loadfile(filename):
    dataset = read(filename)
    x = dataset[['150', '4', 'setosa', 'versicolor']]
    y = dataset[['virginica']]
    x_train, x_test, y_train, y_test = train_test_split(x, y, random_state=1)
    return x_train, x_test, y_train, y_test


if __name__ == '__main__':
    a, b, c, d = loadfile('iris.csv')
    print(len(a))
