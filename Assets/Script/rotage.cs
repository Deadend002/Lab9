using UnityEngine;

public class rotage : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] Vector3 angularV,torque;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            rb.angularVelocity = angularV;
        }
        else if (Input.GetKeyDown(KeyCode.T))
        {
            rb.AddTorque(torque);
        }
        else if (Input.GetKeyDown(KeyCode.G))
        {
            rb.angularVelocity = Vector3.zero;       
        }
    }
}
