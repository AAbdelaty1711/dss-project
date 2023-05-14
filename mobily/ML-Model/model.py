import pandas as pd
from sklearn import linear_model
import pickle

df = pd.read_csv('mobile.csv')

y= df['price']
x=df[['CPU','memory','Battery']]

lm = linear_model.LinearRegression()
lm.fit(x, y) # fitting the model
pickle.dump(lm, open('model.pkl', 'wb'))

print(lm.predict([[3,5]]))