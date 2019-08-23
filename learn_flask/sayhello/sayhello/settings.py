import os
from sayhello import app

dev_db = 'sqlite:///' + os.path.join(os.path.dirname(app.root_path), 'data.db')
SECRET_KEY = os.getenv('SECRET_KEY', 'secure string')
SQLALCHEMY_TRACK_MODIFICATIONS = False
SQLCHEMY_DATABASE_URI = os.getenv('DATABASE_URI', dev_db)
