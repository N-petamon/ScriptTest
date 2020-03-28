using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    void Start () { 
    
        {
            int[] array = new int[5];

            array[0] = 28;
            array[1] = 56;
            array[2] = 14;
            array[3] = 7;
            array[4] = 35;

            for (int i = 0; i < 5; i++)
            {
                Debug.Log(array[i]);
            }
             for (int i = array.Length -1; i >= 0; i--)
            {
                Debug.Log(array[i]);
            }
        }
        
    }
}
	