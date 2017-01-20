using UnityEngine;
using System.Collections;

public class Bullets : MonoBehaviour {

    // Use this for initialization
    void Start()
    {
        
    }
    public Rigidbody2D bullet;
    public Transform Muzzle;
	
	// Update is called once per frame
	void Update ()
    {
         
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D Shot = Instantiate(bullet, Muzzle.position, transform.rotation) as Rigidbody2D;
            if (GetComponent<PlayerController>().direction == 5)
            {
                Shot.AddForce(Vector3.up * 500);
            }
            if (GetComponent<PlayerController>().direction == 10)
            {
                Shot.AddForce(Vector3.right * 500);
            }
            if (GetComponent<PlayerController>().direction == 15)
            {
                Shot.AddForce(Vector3.left * 500);
            }
            if (GetComponent<PlayerController>().direction == 20)
            {
                Shot.AddForce(Vector3.down * 500);
            }
        }
    }
}
