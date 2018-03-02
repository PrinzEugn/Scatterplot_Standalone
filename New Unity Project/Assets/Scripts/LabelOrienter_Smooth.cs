using UnityEngine;
using System.Collections;

public class LabelOrienter_Smooth : MonoBehaviour {

    /*
     * This script finds objects with an appropriate tag, and makes them rotate according to the camera
     * 1. This script does no have to be placed on a particular object (finds them using tags)
     * 2. The tags must be added to the desired game objects in the Editor
     * 3. The tag must be defined in the inspector of this script
     * 4. Remember to have an active camera!       
     */

    public bool faceCamera = true;
    
	private GameObject[] labels;  // Array, stores all GameObjects that should be kept aligned with camera

    // The tag of the target object, the ones that will track the camera
    public string targetTag; // 

	// Use this for initialization
	void Start ()
    {
        //populates the array "labels" with gameobjects that have the correct tag, defined in inspector
        labels = GameObject.FindGameObjectsWithTag(targetTag);                 

    }
	
	// Update is called once per frame
	void Update () {

      	orientLables ();  // remove if instead you are calling orientLables directly, whenever the camera has moved to make save processing time
	}

        // Method definition
	public void orientLables()
    {

		// go through "labels" array and aligns each object to the Camera.main (built-in) position and orientation
		foreach (GameObject go in labels) {

            // create new position Vector 3 so that object does not rotate around y axis
            Vector3 targetPosition = new Vector3(Camera.main.transform.position.x,
                                                 go.transform.position.y,
                                                 Camera.main.transform.position.z);
            

            // Reverse transform or not
            if (faceCamera == true)           
            {
                // Here the internal math reverses the direction so 3D text faces the correct way
                go.transform.LookAt(2 * go.transform.position - targetPosition);
            }
            else
            {
                //LookAt makes the object face the camera
                go.transform.LookAt(targetPosition);
            }
            

        }
    }
}
