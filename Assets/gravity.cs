using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{

    private Vector3 acceleration;
    private Vector3 gravity_v;
    private Vector3 velocity;
    private float mass = 55.0f;


    // Start is called before the first frame update
    void Start()
    {
        gravity_v = new Vector3(0, -1, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void applyForce(Vector3 force)
    {
        Vector3 a = force / mass; //F=ma to calculate acceleration
        acceleration += a;
    }

    private void updatePos()
    {
        velocity =  acceleration;
        transform.position += velocity * Time.deltaTime;
        acceleration = new Vector3(0.0f, -8f); //made the velocity constant 
        transform.rotation = Quaternion.Euler(transform.rotation.x, transform.rotation.y, 90f);
    }

    // Update is called once per frame
    void LateUpdate()
    {
        applyForce(gravity_v);
        updatePos();
    }

}
