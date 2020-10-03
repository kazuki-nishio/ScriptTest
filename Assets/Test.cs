using System.Collections;
using System.Collections.Generic;

using UnityEngine;
public class Boss
{
    private int hp = 100;
    private int power = 25;

    public void Atacck()
    {
        Debug.Log(this.power + "のダメージを与えた");
    }

    public void Defence(int damage)
    {
        Debug.Log(damage + "のダメージを受けた");
       

        this.hp -= damage;
        Debug.Log(this.hp);
    }
}

public class Test : MonoBehaviour
{
   

    // Start is called before the first frame update
    void Start()
    {
        Boss midboss = new Boss();

        midboss.Atacck();

        midboss.Defence(6);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
