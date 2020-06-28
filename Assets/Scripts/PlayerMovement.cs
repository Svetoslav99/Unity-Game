using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    // this is a reference to the Rigidbody component called "rb"
    public Rigidbody rb;
    //add a forward force + add it in unity to change it easly
    public float forwardForce = 1000f; // f is to help unity understand that this is a floating point. Most of the time it will not cry if it`s missing, but just in case!
    public float sidewaysForce = 2f;

    public static float acc = 0f; // accelerate forwardForce
    // Update is called once per frame.// Fixedupdate is better than just Update!!!
    void Update()
    {
        acc += 0.025f;
        // x,y,z * Time.deltaTime, за да нямаме разлики между бавен комп и бърз комп при обработването на фреймове в секунда и от там разлика в addForce.
        rb.AddForce(0, 0, forwardForce * Time.deltaTime + acc); 

        if(Input.GetKey("d")) // if the user presses d 
        {
            rb.AddForce(sidewaysForce, 0, 0,ForceMode.VelocityChange);
        }
        else if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce, 0, 0, ForceMode.VelocityChange);
        }

        if(rb.position.y <-1f)
        {
            FindObjectOfType<GameManagerScript>().EndGame();
        }
    }
}
