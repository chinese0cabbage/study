import mysql.connector
conn=mysql.connector.connect(user='root',password='yy19960510',database='learn')
cur=conn.cursor()     #产生游标
cur.execute('insert into learn (word1,word2) values (234,\'word\')')
cur.execute('insert into learn (word1,word2) values (345,\'word\')')
print(cur.rowcount)  #统计数据库中已有行数
conn.commit()
cur.close()
cur=conn.cursor()
cur.execute('select * from learn where word2=\'word\'')
values=cur.fetchall()     #values是一个元素为元祖的列表，每一个元祖代表一条查询结果
print(values)