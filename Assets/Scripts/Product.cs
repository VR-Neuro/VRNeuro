using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Product : MonoBehaviour
{
    
    [SerializeField]
    public string nome;
    [SerializeField]
    public float preco;
    [SerializeField]
    public int id;

    Vector3 initialPosition;
    Vector3 initialRotation;

    // Start is called before the first frame update
    void Start()
    {
        initialPosition = gameObject.transform.position;
        initialRotation = gameObject.transform.eulerAngles;
    }


    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {   
        Debug.Log("Collision detected with " + collision.gameObject.name);
        // Check if the other collider has a tag of "Floor"
        if (collision.gameObject.CompareTag("Floor"))
        {   
            Debug.Log("Collision detected with floor detected");
            // Move the object to the initial position
            gameObject.transform.position = initialPosition;
            gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
            gameObject.transform.eulerAngles = initialRotation;
        }
    }
}
