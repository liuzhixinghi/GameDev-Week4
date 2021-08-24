using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int ranNum;


    // Start is called before the first frame update
    void Start()
    {
        ranNum = Random.Range(200,251);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Red"&&i==100)
        {
            gameObject.SetActive(false);
        }
        if (gameObject.tag == "Blue" && i == ranNum)
        {
            gameObject.GetComponent<Renderer>().enabled = false;
        }


        i++;
        Debug.Log(gameObject.name + ":" + i);

    }
}
