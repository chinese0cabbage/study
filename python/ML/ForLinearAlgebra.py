import numpy as np

original_matrix = np.matrix([[2, 5], [1, 3]])

inverse_matrix = np.linalg.inv(original_matrix)

feature_value, feature_vector = np.linalg.eig(original_matrix)

print("逆矩阵为")
print(inverse_matrix)

print("特征值为：", feature_value)
print(("特征向量为", feature_vector))
