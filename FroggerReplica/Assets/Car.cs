using UnityEngine;

public class Car : MonoBehaviour {

	public Rigidbody2D rb;

	public float minSpeed = 8f;
	public float maxSpeed = 12f;
    public float DistanceTraveled = 0,
                MaxDistance;
	float speed = 1f;

	void Start ()
	{
		speed = Random.Range(minSpeed, maxSpeed);
        MaxDistance = 20f;
    }

	void FixedUpdate () {
		Vector2 forward = new Vector2(transform.right.x, transform.right.y);
		rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * speed);
        DistanceTraveled += forward.magnitude * Time.fixedDeltaTime * speed;
        checkDistance();
	}
    void checkDistance()
    {
        if (DistanceTraveled >= MaxDistance)
        {
            //Debug.Log(DistanceTraveled);
            Destroy(gameObject);
        }
    }

}
