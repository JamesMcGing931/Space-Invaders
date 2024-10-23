using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float moveSpeed = 2f;
    public float horInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    //GetAxisRaw turns input into values -> Right = 1, Left = -1 
    // Vector2.right = faster way of writing Vector2(1,0)
    //Translate slides object around
    void Update()
    {
        horInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(Vector2.right * horInput * moveSpeed * Time.deltaTime);
    }
}
