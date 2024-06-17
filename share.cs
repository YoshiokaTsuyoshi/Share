using System.Collections.Generic;
using System.Linq;
using System;

class hoge
{
    public static void Main(string[] args)
    {
        
    }
}

var temp1 = new List<string>();
var temp2 = new List<List<DateTime>>();
var temp3 = new List<List<List<TimeSpan>>>();
var temp4 = new List<SlectItem>();
var temp5 = new List<List<SlectItem>>();
var temp6 = new List<List<List<SlectItem>>>();
var temp7 = new List<string>();

for(int i = 0; i < temp1.Count; i++)
{
    temp4[i].text = temp1[i];
    temp4[i].value = temp1[i];
    for(int j = 0; j < temp2.Count; j++)
    {
        temp5[i][j].text = temp2[i][j];
        temp5[i][j].value = temp2[i][j];
        for(int k = 0; k < temp3.Count; k++)
        {
            temp6[i][j][k].text = temp3[i][j][k];
            temp6[i][j][k].value = temp3[i][j][k];
        }
    }
}

Session["temp1"] = new List<string>();
Session["temp2"] = new List<List<DateTime>>();
Session["temp3"] = new List<List<List<TimeSpan>>>();