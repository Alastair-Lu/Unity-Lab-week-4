using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    public int i;
    public GameObject objName;
    public Renderer rend;
    public int x;
    // Start is called before the first frame update
    void Start()
    {
        i = 3;
        x = Random.Range(200, 251);
    }

    // Update is called once per frame
    void Update()
    {
       
            Debug.Log(objName.name + ":" + (++i));
        
        if (i == 100 && objName.tag=="Red")
        {
            objName.SetActive(false);
        }
        if (i == x && objName.tag == "Blue" )
        {
            rend.enabled = false;
            
        }
    }
        
    }
