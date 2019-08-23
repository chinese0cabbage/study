from flask import Blueprint

tree_mold = Blueprint("mold",__name__)

@tree_mold.route("/leaves")
def leaves():
	return "This tree has leaves"
	pass
@tree_mold.route("/rings")
@tree_mold.route("/rings/<int:year>")
def rings(year=None):
	return "Looking at the rings for {year}".format(year=year)
	pass