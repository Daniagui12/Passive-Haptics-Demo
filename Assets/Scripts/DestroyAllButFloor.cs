using UnityEngine;
using System.Collections.Generic;

public class DestroyAllButFloor : MonoBehaviour
{
    void destroyAll()
    {
        List<GameObject> objectsToDelete = new List<GameObject>();

        // Find all 3D objects in the scene and add them to the list of objects to delete
        foreach (GameObject obj in FindObjectsOfType<GameObject>())
        {
            if (obj.name != "floor" && obj.GetComponent<MeshRenderer>() != null)
            {
                if (obj.name.Contains("Cube") || obj.name.Contains("Sphere") || obj.name.Contains("Cylinder"))
                {
                    objectsToDelete.Add(obj);
                }
            }
        }

        // Delete all the objects in the list
        foreach (GameObject obj in objectsToDelete)
        {
            Destroy(obj);
        }
    }
}
