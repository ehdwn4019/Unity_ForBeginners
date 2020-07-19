using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FunctionTest3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int score1, score2, score3;

        score1 = SumScore(10, 20);
        score2 = SumScore(5, 7);
        score3 = SumScore(12, 13);

        print("score1 = " + score1);
        print("score2 = " + score2);
        print("score3 = " + score3);

        

        


    }

    int SumScore(int s1,int s2)
    {
        int score;
        score = s1 + s2;
        return score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
