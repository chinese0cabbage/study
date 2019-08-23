from flask import Blueprint

another = Blueprint("another",__name__)

@another.route("/root")
def roots():
	return "And root as well"
	pass