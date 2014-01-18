using UnityEngine;
using System.Collections;

public class Controller : MonoBehaviour {

    public GameObject playerObject;
    public const float MAX_VELOCITY_X = 4f;
    public const float ACCELERATION_X = 0.2f;
    public const float DECELERATION_X = 0.7f;

    private Vector2 playerVelocity;
    private bool onGround = true;


	// Use this for initialization
	void Start () {
        playerVelocity = playerObject.rigidbody2D.velocity;
	}
	
	// Update is called once per frame
	void Update () {
	    if (Input.GetKey(KeyCode.W))
        {
            if (playerVelocity.x < MAX_VELOCITY_X)
            {
                playerVelocity = new Vector2(playerVelocity.x + ACCELERATION_X, playerVelocity.y);
            }
        }
        if (Input.GetKey(KeyCode.A))
        {
            if (playerVelocity.x > -MAX_VELOCITY_X)
            {
                playerVelocity = new Vector2(playerVelocity.x - ACCELERATION_X, playerVelocity.y);
            }
        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D) && onGround)
        {
            if ((int)playerVelocity.x > 0)
            {
                playerVelocity = new Vector2(playerVelocity.x - DECELERATION_X, playerVelocity.y);
            }
            else if ((int)playerVelocity.x < 0)
            {
                playerVelocity = new Vector2(playerVelocity.x + DECELERATION_X, playerVelocity.y);
            }
        }

	}
}
