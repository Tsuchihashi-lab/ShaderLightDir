using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDirContr : MonoBehaviour
{
    //[SerializeField]
    //private Vector3 rot = new Vector3(50f, 0f ,0f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("w"))
        {
            Debug.Log("w");
            //rot = new Vector3(90f, 0f, 0f);
            transform.rotation = Quaternion.Euler(90f, 0f, 0f);
        }
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("a");
            transform.rotation = Quaternion.Euler(0f, 0f, 0f);
        }
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("s");
            transform.rotation = Quaternion.Euler(0f, 180f, 0f);
        }
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("d");
            transform.rotation = Quaternion.Euler(-90f, 0f, 0f);
        }
        if (Input.GetKeyDown("q"))
        {
            Debug.Log("q");
            transform.rotation = Quaternion.Euler(0f, 90f, 0f);
        }
        if (Input.GetKeyDown("e"))
        {
            Debug.Log("e");
            transform.rotation = Quaternion.Euler(0f, -90f, 0f);
        }
    }
}
