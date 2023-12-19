using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cart : MonoBehaviour
{   
    public float total = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter (Collider product) {
        if (product.gameObject.tag == "Product") {
            Debug.Log("Product on cart");
            total += product.gameObject.GetComponent<Product>().preco;
        }
    }

    void OnTriggerExit (Collider product) {
        if (product.gameObject.tag == "Product") {
            Debug.Log("Product out of cart");
            total -= product.gameObject.GetComponent<Product>().preco;
        }
    }
}
