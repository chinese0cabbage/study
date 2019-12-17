import numpy as np


def Sigmoid(x):
    return 1.0 / (1 + np.exp(-x))
