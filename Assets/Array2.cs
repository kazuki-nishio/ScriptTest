using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Array2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] array = { 6, 3, 9, 5, 8 };

        for(int i=array.Length-1;i>=0;i--)
        {
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
