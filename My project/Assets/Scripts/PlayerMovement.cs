using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public Rigidbody2D RB;
    public GameObject GameManager;
    public AudioSource AS;
    public AudioClip PickupSFX;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
      float angle = Mathf.Atan2(mouse.y - transform.position.y, mouse.x - transform.position.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0, 0, angle);

        if (Input.GetKey(KeyCode.Space))
        {
            RB.AddForce(transform.right);
           
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Sample")
        {
            GameManager.GetComponent<GameManagerScript>().Score += 1;
            AS.PlayOneShot(PickupSFX);
            Destroy(other.gameObject);
        }

    }
}
