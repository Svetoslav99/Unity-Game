using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    //A refference to our PlayerMovement script
    public PlayerMovement Movement;
    

    //This function runs when we hit another object/
    //We get information about the collision adn call it collisionInfo
    void OnCollisionEnter(Collision collisionInfo)
    {
        //We check if the object we collided with has a tag called "Obstacle"
        if (collisionInfo.collider.tag == "Obstacle")
        {
            Movement.enabled = false; // Disable the players movement
            FindObjectOfType<GameManagerScript>().EndGame();
        }

    }
}
