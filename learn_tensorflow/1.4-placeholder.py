import tensorflow as tf

sess = tf.Session()
x = tf.placeholder("float")
y = 2 * x
data = tf.random_uniform([4, 5], 9, 10)
x_data = sess.run(data)
print(type(x_data))
print(x_data)
print('jump')
print(sess.run(y, feed_dict={x: x_data}))
