using UnityEngine;

public class asteroid : MonoBehaviour
{
    public static System.Action<asteroid> asteroiddestroy = null;
    public Rigidbody2D myRigidbody;
    public asteroid mini;
    public float maximumSpeed = 1.0f;
    public int theAmount = 3;
    
    void Start()
    {
        Vector2 direction = Random.insideUnitCircle;
        direction *= maximumSpeed;
        myRigidbody.velocity = direction;
    }
    void OnTriggerEnter2D (Collider2D outro)
    {
        Destroy(gameObject);
        Destroy(outro.gameObject);

        for(int i = 0; i < theAmount; i++)
        {
            Instantiate(
                mini, 
                myRigidbody.position, 
                Quaternion.identity
            );
        }
        if (asteroiddestroy != null)
        {
            asteroiddestroy();
        }
    }
}
