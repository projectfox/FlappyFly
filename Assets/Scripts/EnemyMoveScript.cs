using UnityEngine;

public class EnemyMoveScript : MonoBehaviour {

    public Vector2 speed = new Vector2(10, 10);

    public Vector2 direction = new Vector2(-1, 0);

    private Vector2 movment;
    private Rigidbody2D rigibodyComponent;
    // Update is called once per frame
    void Update()
    {
       
        movment = new Vector2(
            speed.x * direction.x,
            speed.y * direction.y);
    }

    void FixedUpdate()
    {
        if (rigibodyComponent == null) rigibodyComponent =
                GetComponent<Rigidbody2D>();

        rigibodyComponent.velocity = movment;
    }
}