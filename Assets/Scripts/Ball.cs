using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Ball : MonoBehaviour
{

   

    public Vector3 MousePosition;
    private Rigidbody2D rb;
    private bool ballInPlay = false;
    public int speed;
    public int counter;
    Scene scene;
    void Awake()
    {
        scene = SceneManager.GetActiveScene();
    
        rb = GetComponent<Rigidbody2D>();
       
    counter = 0;

    }
    private void Update()
    {


    }

    void FixedUpdate()
    {
        if (ballInPlay == true)
        {
            counter += 1;
        }
        if (counter == 300)
        {
            SceneManager.LoadScene(scene.name);
        }
        Vector3 mousePosScreen = Input.mousePosition;
        Vector3 mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosScreen);



        if (Input.GetMouseButton(0) && ballInPlay == false)
        {
            ballInPlay = true;

            transform.parent = null;
            ballInPlay = true;
            rb.isKinematic = false;
            Vector2 posB = new Vector2(mousePosWorld.x - transform.position.x, mousePosWorld.y - transform.position.y);

            rb.AddForce(posB.normalized * speed, ForceMode2D.Impulse);

        }
    }
    void OnTriggerEnter2D(Collider2D trigger)
    {
        if(trigger.CompareTag("ultimo"))
        {
            SceneManager.LoadScene(0);
        }
        int numero = scene.buildIndex + 1;
        if (trigger.CompareTag("Muerte"))
            SceneManager.LoadScene(scene.name);
      
      else  if (trigger.CompareTag("Ganar"))
            SceneManager.LoadScene(numero);
           
        
    }
}