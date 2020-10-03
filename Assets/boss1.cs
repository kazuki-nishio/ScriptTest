using System.Collections;
using System.Collections.Generic;

using System.Runtime.InteropServices;
using UnityEngine;

public class boss1 : MonoBehaviour
{
    public class Boss
    {
        private int mp = 53;

        public void Magic(int decmp)
        {
            this.mp -= decmp;

            if (this.mp >= 0)
            {
                Debug.Log("魔法攻撃をした。残りMPは" + this.mp);
            }

            else {
                Debug.Log("MPが足りないため、魔法が使えない");
            }
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        Boss lastboss = new Boss();
        for(int i=1;i<12;i++)
        { 
            lastboss.Magic(5); 
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
