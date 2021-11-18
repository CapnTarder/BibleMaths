using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEncounter : MonoBehaviour
{
    int number;
    int number1;
    int number2;
    int number3;
    int number4;
    int number5;
    int number6;

    gameobject a;
    gameobject b;
    gameobject c;
    gameobject d;



    // Start is called before the first frame update
    void Start()
    {
        a = GameObject.Find("a");
        b = GameObject.Find("b");
        c = GameObject.Find("c");
        d = GameObject.Find("d");



    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Rnd()
    {
         number = Random.Range(0, 4);
        number1 = Random.Range(5, 10);
        number2 = Random.Range(0, 5);
        number3 = number1 + number2;
        number4 = number1 - number2;
        number5 = number1 * number2;
        number6 = number1 / number2;

    }
    public dab()
    {
       switch (number)
        {
            case 1;
                a.SetActive(true);
                if(inputfield.text == number3)
                {

                }
                break;
            case 2;
                b.SetActive(true);
                if (inputfield.text == number4)
                {

                }
                    break;
            case 3;
                c.SetActive(true);
                if (inputfield.text == number5)
                {

                }
                    break;
            case 4;
                d.SetActive(true);
                if (inputfield.text == number6)
                {

                }
                    break;
        }
    }
}
