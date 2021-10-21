using UnityEngine;
using System.Text;

public class player : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float speed = 1.0f;
    public float speedAngular = 180.0f;
    public float maximumSpeed = 10.0f;

    public Rigidbody2D prefabProjetil;
    public float velocidadeProjetil = 10.0f;

    void Start()
    {
        
    }
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Rigidbody2D projetil = Instantiate(
                prefabProjetil, 
                myRigidbody.position, 
                Quaternion.identity
            );
            projetil.velocity = transform.up * velocidadeProjetil;   
        }
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            Vector3 direction = transform.up * speed;
            myRigidbody.AddForce(direction, ForceMode2D.Force);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            myRigidbody.rotation += speedAngular * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            myRigidbody.rotation -= speedAngular * Time.deltaTime;
        }
        if (myRigidbody.velocity.magnitude > maximumSpeed)
        {
            myRigidbody.velocity = Vector2.ClampMagnitude(myRigidbody.velocity, maximumSpeed);
        }
    }
    void OnTriggerEnter2D(Collider2D outro)
    {
        Destroy(gameObject);
        
    }
}
