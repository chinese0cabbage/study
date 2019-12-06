#1、定义训练数据：输入张量和目标张量
#2、定义层组成的网络（或模型），将输入映射到目标
#3、配置学习过程：选择损失函数、优化器和需要监控的指标
#4、调用模型的fit方法在训练数据上进行迭代


from keras import  models
from keras import  layers
from keras import optimizers


model=models.Sequential()#初始化Sequential模型

'''堆叠模型'''
model.add(layers.Dense(32,activation='relu',input_shape=(784,)))
model.add((layers.Dense(10,activation='softmax')))


'''上述初始化方法等同于下面'''
input_tensor=layers.Input(shape=(784,))
x=layers.Dense(32,activation='relu')(input_tensor)
output_tensor=layers.Dense(10,activation='softmax')(x)
model=models.Model(input_tensor,output_tensor)
print(input_tensor.shape)


'''配置学习过程，指定优化器'''
model.compile(optimizer=optimizers.rmsprop(lr=0.001),loss='mse',metrics=['accuracy'])#???参数意义


'''通过fit()方法将输入数据的numpy数组和对应的目标数据传入模型(批量迭代)'''
model.fit(input_tensor,target_tensor,batch_size=128,epochs=10)

'''手动分批次将数据传给模型'''
model.train_on_batch(x_batch,y_batch)

'''评估模型性能'''
loss_and_metrics=model.predict((x_test,batch_size=128))