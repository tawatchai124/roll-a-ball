using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{

    private Rigidbody rigidbody;
    public float velocity = 1.0f;

    private int count = 0;


    public Text countText;


    /// <summary>
    /// Visibility
    /// Private
    /// Public
    /// Protected
    /// </summary>
    

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody>();

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        //Vector3(horizon, 0f, vertical)

        rigidbody.AddForce(new Vector3(horizontal * velocity, 0f, vertical * velocity));

        //Debug.Log(vertical);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("PickUp"))
        {
            other.gameObject.SetActive(false);
            count++;

            SetCountText();
            
        }
    }

    private void SetCountText()
    {
        countText.text = "Count : " + count.ToString();
    }
}
