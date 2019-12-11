from keras.datasets import imdb
from keras import models
from keras import layers
from keras import optimizers
import numpy as np

(train_data, train_labels), (test_data, test_labels) = imdb.load_data(num_words=10000)


# print(train_data.shape)


# 输入向量的张量化
def vectorize_sequences(sequences, dimension=10000):
    results = np.zeros((len(sequences), dimension))
    for i, sequence in enumerate(sequences):
        results[i, sequence] = 1.
        return results


# 将输入向量和输出向量转化为标准格式
x_train = vectorize_sequences(train_data)
x_test = vectorize_sequences(test_data)
y_train = np.asarray(train_labels).astype('float32')
t_test = np.asarray(test_labels).astype(('float32'))

# print(train_data)
# print(x_train)


# 设计神经网络的每一层，输入层，隐含层，输出层一共三层
model = models.Sequential()
model.add(layers.Dense(16, activation='relu', input_shape=(10000,)))  # 激活函数为relu,神经元数为16
model.add(layers.Dense(16, activation='relu'))
model.add(layers.Dense(1, activation='sigmoid'))

# 编译模型
model.compile(optimizer='rmsprop', loss='binary_crossentropy', metrics=['accuracy'])

# 配置优化器
model.compile(optimizer=optimizers.RMSprop(lr=0.001), loss='binary_crossentropy', metrics=['accuracy'])
