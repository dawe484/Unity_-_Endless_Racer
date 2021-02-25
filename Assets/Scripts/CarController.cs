using UnityEngine;

public class CarController : MonoBehaviour
{
    public float carSpeed;
    private const float maxPos = 1.5f;

    //Vector3 position;
    private Vector3 targetPos;

    private int desiredLane = 1; //0 - left; 1 - middle; 2 - right

    // Start is called before the first frame update
    void Start()
    {
        //position = transform.position;
        targetPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //position.x += Input.GetAxis("Horizontal") * carSpeed * Time.deltaTime;
        //position.x = Mathf.Clamp(position.x, -maxPos, maxPos);
        //transform.position = position;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            desiredLane++;
            if (desiredLane == 3) desiredLane = 2;
        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            desiredLane--;
            if (desiredLane == -1) desiredLane = 0;
        }

        targetPos.x = 0;

        if (desiredLane == 0)
        {
            targetPos += Vector3.left * maxPos;
        } else if (desiredLane == 2)
        {
            targetPos += Vector3.right * maxPos;
        }

        transform.position = targetPos;
    }

    // Car collision
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy Car"))
        {
            Destroy(gameObject);
        }
    }
}
