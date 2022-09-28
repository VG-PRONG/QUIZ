using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quiz : MonoBehaviour
{
    

    public GameObject[] Level;
    
    int currentLevel;

    public void correctAnswer()
    {
        Level[currentLevel].SetActive(false);
        
        currentLevel++;
       Level[currentLevel].SetActive(true);
    }
}
