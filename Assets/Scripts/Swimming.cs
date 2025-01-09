using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class JetPack : MonoBehaviour
{
    public InputActionReference jetpackAction;

    public float currentThrustPower;
    public float ThrustAcceleration;
    public float maxThrustPower;

    public float gravitySpeed;

    public float currentFallRate;
    public float fallAcceleration;
    public float maxFallRate;

    private Vector3 thrustDirection;
    private Vector3 gravityDirection;

    // Start is called before the first frame update
    void Start()
    {
        thrustDirection = Vector3.up;
        gravityDirection = Vector3.down;
    }

    // Update is called once per frame
    void Update()
    {
        if (jetpackAction.action.IsPressed())
        {

            //transform.position += thrustDirection * currentThrustPower * Time.deltaTime;

            // calculate thrust
            CalculateThrust();
        }
        else
        {
            //transform.position += gravityDirection * currentThrustPower * Time.deltaTime;
            if (transform.position.y > 1)
            {
                //transform.position += gravityDirection * currentFallRate * Time.deltaTime;

                //calculate gravity
                    CalculateGravity(); 
            }
            // apply thrust
            ApplyThrust();

            // apply gravity
            ApplyGravity();

        }


        Debug.DrawRay(transform.position, Vector3.up, Color.green, 10f);
        Debug.DrawRay(transform.position, gravityDirection, Color.red, 10f);

    }
    private void CalculateThrust()
    {
        currentThrustPower = maxThrustPower * Time.deltaTime;

        currentThrustPower += ThrustAcceleration * Time.deltaTime;

    }
    private void CalculateGravity()
    {
        if (currentThrustPower > 0)
        {
            currentThrustPower -= ThrustAcceleration * Time.deltaTime;
        }
        currentFallRate += fallAcceleration * Time.deltaTime;
    }
    private void ApplyThrust()
    {
        if (currentThrustPower > maxThrustPower)
        {
            currentThrustPower = maxThrustPower;

        }
        transform.position += thrustDirection * currentThrustPower * Time.deltaTime;


    }
    private void ApplyGravity()
    {
        if (currentFallRate > maxFallRate)
        {
            currentFallRate = maxFallRate;
        }


        if (transform.position.y > 1)
        {
            transform.position += gravityDirection * currentFallRate * Time.deltaTime;
        }
        else
            currentFallRate = 0;
    }
}