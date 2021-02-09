using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightDirControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        if (Input.GetKey("w") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(0f, 1f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("q") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(-1f, 1f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("e") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(1f, 1f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("s") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(0f, 0f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("a") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(-1f, 0f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("d") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(1f, 0f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("x") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(0f, -1f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("z") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(-1f, -1f, -1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("c") && Input.GetKey(KeyCode.Keypad0))
        {
            myTransform.position = new Vector3(1f, -1f, -1f);
            myTransform.LookAt(Vector3.zero);
        }

        if (Input.GetKey("w") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(0f, 1f, 0f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("q") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(-1f, 1f, 0f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("e") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(1f, 1f, 0f);
            myTransform.LookAt(Vector3.zero);
        }
        //if (Input.GetKey("s") && Input.GetKey(KeyCode.Keypad1))
        //{
        //    myTransform.position = new Vector3(0f, 0f, 0f);
        //    myTransform.LookAt(Vector3.zero);
        //}
        if (Input.GetKey("a") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(-1f, 0f, 0f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("d") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(1f, 0f, 0f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("x") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(0f, -1f, 0f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("z") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(-1f, -1f, 0f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("c") && Input.GetKey(KeyCode.Keypad1))
        {
            myTransform.position = new Vector3(1f, -1f, 0f);
            myTransform.LookAt(Vector3.zero);
        }

        if (Input.GetKey("w") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(0f, 1f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("q") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(-1f, 1f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("e") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(1f, 1f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("s") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(0f, 0f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("a") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(-1f, 0f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("d") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(1f, 0f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("x") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(0f, -1f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("z") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(-1f, -1f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
        if (Input.GetKey("c") && Input.GetKey(KeyCode.Keypad2))
        {
            myTransform.position = new Vector3(1f, -1f, 1f);
            myTransform.LookAt(Vector3.zero);
        }
    }
}
