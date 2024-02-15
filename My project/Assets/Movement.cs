using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 jumpHeight;
    private bool isCoolDown = false;
    private float coolDown = 1f;

    void Start()
    {

    }


    void Update()
    {

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector2.left * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector2.right * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (isCoolDown == false)
            {
                GetComponent<Rigidbody2D>().AddForce(jumpHeight, ForceMode2D.Impulse);
                StartCoroutine(CoolDown());
            }
        }
    }
    IEnumerator CoolDown()
    {
        isCoolDown = true;
        yield return new WaitForSeconds(coolDown);
        isCoolDown = false;
    }      
}