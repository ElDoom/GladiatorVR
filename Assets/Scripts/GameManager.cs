using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public bool swordGrabbed = false;
    public bool dragonAlive = true;
    public int dragonHP = 10;
    public int gladiatorHP = 100;

    // Start is called before the first frame update
    public int getDragonHP() { return dragonHP; }

    public void updateDragonHP(int val) 
    {
        dragonHP -= val;
        evaluateGameOver();
    }

    public void evaluateGameOver()
    { 
    if(dragonHP<=0 || gladiatorHP <0)
        {
            if (Time.timeScale == 1)
            {    //si la velocidad es 1
                Time.timeScale = 0;     //que la velocidad del juego sea 0
            }
            else if (Time.timeScale == 0)
            {   // si la velocidad es 0
                Time.timeScale = 1;     // que la velocidad del juego regrese a 1
            }
        }
    }
}
