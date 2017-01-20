using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

        float Sprint = 5;
        public int direction;
	
	// Update is called once per frame
	void Update ()
    {
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Sprint = 10;
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector2.up * Sprint * Time.deltaTime, relativeTo: Space.World);
            direction = 5;
            if (Input.GetKey(KeyCode.W))
            {
                transform.rotation = Quaternion.AngleAxis(90, Vector3.forward);
            }          
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector2.right * Sprint * Time.deltaTime, relativeTo: Space.World);
            direction = 10;
            if (Input.GetKey(KeyCode.D))
            {
                transform.rotation = Quaternion.AngleAxis(0, Vector3.forward);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector2.left * Sprint * Time.deltaTime, relativeTo: Space.World);
            direction = 15;
            if (Input.GetKey(KeyCode.A))
            {
                transform.rotation = Quaternion.AngleAxis(180, Vector3.forward);
            }
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector2.down * Sprint * Time.deltaTime, relativeTo: Space.World);
            direction = 20;
            if (Input.GetKey(KeyCode.S))
            {
                transform.rotation = Quaternion.AngleAxis(270, Vector3.forward);
            }
        }
    }
}
