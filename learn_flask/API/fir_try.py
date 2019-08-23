from flask import Flask,request
import json




app = Flask(__name__)

@app.route("/test_1.0",methods=["GET"])
def check():
	return_dict = {'return_code':'200','return_info':'处理成功','result':False}
	if request.args is None:
		return_cict['return_code'] = '5004'
		return_cict['return_info'] = '请求参数为空'
		return json.dumps(return_dict,ensure_ascii=False)
	get_data = request.args.to_dict()
	name = get_data.get('name')
	age = get_data.get('age')
	return_dict['result'] = tt(name,age)

	return json.dumps(return_dict,ensure_ascii = False)
	pass
def tt(name,age):
	result_str = "%s今年%s岁" %(name,age)
	return result_str
	pass
if __name__ == '__main__':
	app.run(debug=True)