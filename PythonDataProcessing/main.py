"""
Reading inputs from a file and outputs corresponding result in a file

Takes in state abbreviation and county name and outputs house fire risk (int)
Based on data from Red Cross Smoke Alarm Map

Author: Haoxuan Chen
Date:  2019/9/22
"""
import pandas as pd

df = pd.read_csv('d.csv')
with open ("input.txt", "r") as myfile:
    i = myfile.readlines()
    s = i[0]
statein = s[:s.index(" ")]
county = s[s.index(" ")+1:].replace(" ","")
try:
    out = open("result.txt", "w")
    out.write(str(int(df.loc[(df['stateAbbrev'] == statein) & (df['county'] == county),'risk'].iloc[0])))
    out.close()
except:
    out = open("result.txt", "w")
    out.write('invalid input')
    out.close()
