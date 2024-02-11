using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Movement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector2.up * Time.deltaTime);
            Thread.Sleep(1000);
            transform.Translate(Vector2.down * Time.deltaTime);
        }
        
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }
    }
}
