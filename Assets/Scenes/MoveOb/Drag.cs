using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drag : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject GoalGameObject;
    public GameObject Goal1GameObject;
    private void OnMouseDrag()
    {
        Vector3 mousePosWorld = Input.mousePosition;
        mousePosWorld.z = transform.position.z - Camera.main.transform.position.z;        
        mousePosWorld = Camera.main.ScreenToWorldPoint(mousePosWorld);
        transform.position = new Vector3(mousePosWorld.x,
                                            mousePosWorld.y,
                                            transform.position.z);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.Equals(GoalGameObject))
        {
            Debug.Log("NEXT STAGE -->");
        }
        if (other.gameObject.tag =="Goal")
        {
            Destroy(GoalGameObject);
        }
        if (other.gameObject.Equals(Goal1GameObject))
        {
            Debug.Log("You Win");
        }
    }
}
