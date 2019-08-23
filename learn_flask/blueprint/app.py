from tree_mold import tree_mold
from another import another
from flask import Flask

app = Flask(__name__)

app.register_blueprint(tree_mold,url_prefix='/oak')
app.register_blueprint(another,url_prefix='/fir')
app.register_blueprint(tree_mold,url_prefix='/ash')

if __name__ == '__main__':
	app.run()