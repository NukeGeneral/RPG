using UnityEngine;
using System.Collections;

public class ClickToMove : MonoBehaviour {

    private Vector3 playerDestination;
    private float playerDistanceToDestination;
    private Transform playerTransform;
    private float speed = 1f;
    private Vector3 offset;
    private Animation moveAnim;

	// Use this for initialization
	void Start () {
        playerTransform = this.transform;
        moveAnim = GetComponent<Animation>();
        offset = Camera.main.transform.position - playerTransform.position;
        playerDestination = playerTransform.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        Vector3 camDestination = playerTransform.position + offset;
        Camera.main.transform.position = Vector3.Lerp(Camera.main.transform.position, camDestination, 3f * Time.deltaTime);
        playerDistanceToDestination = Vector3.Distance(playerDestination, playerTransform.position);

        if(playerDistanceToDestination < .1f)
        {
            speed = 0f;
        }

        else if(playerDistanceToDestination > .1f)
        {
            speed = 1f;
        }

        if (Input.GetMouseButton(0))
        {
            Plane playerHitBoxPlane = new Plane(Vector3.up, playerTransform.position);
            Ray hitRay = Camera.main.ScreenPointToRay(Input.mousePosition);
            float hitDistance = 0f;

            if(playerHitBoxPlane.Raycast(hitRay,out hitDistance))
            {
                Vector3 targetClick = hitRay.GetPoint(hitDistance);
                playerDestination = hitRay.GetPoint(hitDistance);
                Quaternion targetRot = Quaternion.LookRotation(targetClick - transform.position);
                playerTransform.rotation = targetRot;
                
            }
        }
        
        if(playerDistanceToDestination > .1f)
        {
            playerTransform.position = Vector3.MoveTowards(playerTransform.position, playerDestination, speed * Time.deltaTime);
            moveAnim.Play();
        }
	}

}
