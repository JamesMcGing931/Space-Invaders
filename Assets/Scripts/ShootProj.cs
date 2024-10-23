using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootProj : MonoBehaviour
{

    public GameObject projectilePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Instantiate = Spawn -> Instantiate(GameObject, Location, Rotation)
    // Quaternion = Coordinates, telling how to rotate
    //Quaternion.identity Basically means no rotation
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        }
    }
}
