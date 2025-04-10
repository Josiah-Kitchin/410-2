using UnityEngine;

public class QuestPointer : MonoBehaviour
{
    // References to gameobjects
    public GameObject destination;
    public GameObject player;
    public float rotationSpeed = 5f;

    void Update()
    {
        Vector3 directionToDestination = destination.transform.position - player.transform.position;
        float dotProduct = Vector3.Dot(player.transform.forward, directionToDestination);
        Debug.Log(dotProduct);
        if(dotProduct >= 1){
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        else if (dotProduct < 1){
            GetComponent<SpriteRenderer>().color = Color.red;
        }
    }
}
