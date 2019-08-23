import tensorflow as tf
import numpy as np

sess = tf.Session()
x_vals = np.array([1., 3., 5., 7., 9.])
# print(type(x_vals[1]))
x_data = tf.placeholder(tf.float32)
# print(sess.run(x_data))
m_const = tf.constant(3.)
my_product = tf.multiply(x_data, m_const)
for x_val in x_vals:
    print(sess.run(my_product, feed_dict={x_data: x_val}))
