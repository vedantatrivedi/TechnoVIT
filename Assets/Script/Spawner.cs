using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Spawner : MonoBehaviour
{
    public GameObject ob1;
    public GameObject ob2;
    public float spawngap = 5;
    public float x = 7;
    float nxtst;
    public int count;
    public Text scoreText;
    
    // Start is called before the first frame update
    void Start()
    {
        scoreText=GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > nxtst)
        {
            int no;     
            no = Random.Range(1,100);
            nxtst = Time.time + spawngap;
            Vector3 spawnpos = new Vector3(Random.Range(-x, x), 10, 0);
            if (no%2==0)
            {
                Instantiate(ob1, spawnpos, Quaternion.identity);
            }
            else
            {
                Instantiate(ob2, spawnpos, Quaternion.Euler(0, 0, 90));
            }
            count++;
            print("count=" +count);
            DisplayScore();
        }
    }
    void DisplayScore()
    {
        
        scoreText.text="Score: " + count.ToString();
    }
}

