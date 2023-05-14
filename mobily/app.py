from flask import Flask, render_template,request
import pickle

app = Flask(__name__)
model = pickle.load(open('model.pkl','rb'))

@app.route("/")
def hello():
    return render_template('index.html')
@app.route("/predict",methods=['post'])
def predict():
    CPU= float(request.form['CPU'])
    memory = int(request.form['memory'])
    Battery = int(request.form['Battery'])
    prediction = model.predict([[CPU,memory,Battery]])
    output = round(prediction[0],2)
    return render_template('index.html',price=f'EGP{output}k')
if __name__ == "__main__":
    app.run();