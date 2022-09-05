using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class story : MonoBehaviour
{
    string heroName = "dazai";
    float heroHeight = 181.1f;
    int heroAge = 22;
    string heroSuperPower = "body transformation";
    string villainName = "chuuya";
    float villainHeight = 163.6f;
    int villainAge = 21;
    string villainSuperPower = "gravity manipulation";
    // Start is called before the first frame update
    void Start()
    {
        int ageDifference = heroAge - villainAge;
        print("my name is " + heroName + " i am " + heroAge + " i am " + heroHeight + " tall and my superpower is " + heroSuperPower);
        print("my name is " + villainName + " i am " + villainAge + " i am " + villainHeight + " tall and my superpower is " + villainSuperPower);
        heroHeight = heroHeight + 5;
        villainSuperPower = "None";
        print("my name is " + heroName + " i am " + heroAge + " i am " + heroHeight + " tall and my superpower is " + heroSuperPower);
        print("my name is " + villainName + " i am " + villainAge + " i am " + villainHeight + " tall and my superpower is " + villainSuperPower);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
