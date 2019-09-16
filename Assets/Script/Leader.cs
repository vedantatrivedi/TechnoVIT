using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Leader : MonoBehaviour
{   public Text[] highScores;
    int[] highScoreValues;
    string[] highScoreNames;

    // Start is called before the first frame update
    void Start()
    {
        highScoreValues= new int[highScores.Length];
        highScoreNames= new string[highScores.Length];

        for(int x=0;x<highScores.Length; x++){
highScoreValues[x]= PlayerPrefs.GetInt("highScoreValues"+x);
highScoreNames[x]= PlayerPrefs.GetString("highScoreValues"+x);
}
DrawScores();
    }
void SaveScores(){
for(int x=0;x<highScores.Length;x++){
PlayerPrefs.SetInt("highScoreValues"+x,highScoreValues[x]);
PlayerPrefs.SetString("highScoreValues"+x,highScoreNames[x]);
}
}

public void CheckforHighScore(int _value,string _userName){
for(int x=0;x<highScores.Length;x++){
if(_value>highScoreValues[x]){
for(int y=highScores.Length-1;y>x;y--){
highScoreValues[y]=highScoreValues[y-1];
highScoreNames[y]=highScoreNames[y-1];
}
highScoreValues[x]= _value;
highScoreNames[x]= _userName;

DrawScores();
SaveScores();
break;
}
}
}

void DrawScores(){
for(int x=0;x<highScores.Length;x++){
highScores[x].text=highScoreNames[x]+"1"+ highScoreValues[x].ToString();
}
}


    // Update is called once per frame
    void Update()
    {
        
    }
}

