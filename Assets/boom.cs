using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    public Rigidbody[] Cube;
    public float Impulse;
    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision myCollision)
    {
        var center = transform.position;
        if (myCollision.gameObject.CompareTag("Square"))
        foreach (var cube in Cube)
        {
            var smash = cube.position - center;
            var stand = smash.normalized;
            cube.AddForce(stand * Impulse, ForceMode.Impulse);
        }

    }
    // Update is called once per frame
    void FixUpdate()
    {
        
    }

   
}
