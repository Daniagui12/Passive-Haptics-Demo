using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.Input;
using Microsoft.MixedReality.Toolkit.UI;

public class ObjectSpawner : MonoBehaviour
{
    public string shape;

    public void spawnCube()
    {
        Vector3 vectorPosition = GameObject.Find("floor").transform.position;
        GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
        cube.transform.position = vectorPosition;
        cube.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        cube.AddComponent<NearInteractionGrabbable>();
        cube.AddComponent<BoxCollider>();
        cube.AddComponent<Rigidbody>();
        cube.GetComponent<Rigidbody>().useGravity = true;
        cube.AddComponent<ObjectManipulator>();
        cube.AddComponent<Drag>();
    }

    public void spawnSphere()
    {
        Vector3 vectorPosition = GameObject.Find("floor").transform.position;
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = vectorPosition;
        sphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        sphere.AddComponent<NearInteractionGrabbable>();
        sphere.AddComponent<SphereCollider>();
        sphere.AddComponent<Rigidbody>();
        sphere.GetComponent<Rigidbody>().useGravity = true;
        sphere.AddComponent<ObjectManipulator>();
        sphere.AddComponent<Drag>();
    }

    public void spawnCylinder()
    {
        Vector3 vectorPosition = GameObject.Find("floor").transform.position;
        GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
        cylinder.transform.position = vectorPosition;
        cylinder.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        cylinder.AddComponent<NearInteractionGrabbable>();
        cylinder.AddComponent<CapsuleCollider>();
        cylinder.AddComponent<Rigidbody>();
        cylinder.GetComponent<Rigidbody>().useGravity = true;
        cylinder.AddComponent<ObjectManipulator>();
        cylinder.AddComponent<Drag>();
    }

    public void spawnCapsule()
    {
        Vector3 vectorPosition = GameObject.Find("floor").transform.position;
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = vectorPosition;
        capsule.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        capsule.AddComponent<NearInteractionGrabbable>();
        capsule.AddComponent<CapsuleCollider>();
        capsule.AddComponent<Rigidbody>();
        capsule.GetComponent<Rigidbody>().useGravity = true;
        capsule.AddComponent<ObjectManipulator>();
        capsule.AddComponent<Drag>();
    }

    public void spawnPlane()
    {
        GameObject plane = GameObject.CreatePrimitive(PrimitiveType.Plane);
        plane.transform.position = new Vector3 (0, 0.23f, 0.95f);
        plane.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        plane.AddComponent<NearInteractionGrabbable>();
        plane.AddComponent<BoxCollider>();
        plane.AddComponent<Rigidbody>();
        plane.GetComponent<Rigidbody>().useGravity = true;
        plane.AddComponent<ObjectManipulator>();
    }

    public void spawnQuad()
    {
        GameObject quad = GameObject.CreatePrimitive(PrimitiveType.Quad);
        quad.transform.position = new Vector3 (0, 0.23f, 0.95f);
        quad.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
        quad.AddComponent<NearInteractionGrabbable>();
        quad.AddComponent<BoxCollider>();
        quad.AddComponent<Rigidbody>();
        quad.GetComponent<Rigidbody>().useGravity = true;
        quad.AddComponent<ObjectManipulator>();
    }


    void OnClick()
    {
        if (shape == "cube")
        {
            spawnCube();
        }
        else if (shape == "sphere")
        {
            spawnSphere();
        }
        else if (shape == "cylinder")
        {
            spawnCylinder();
        }
        else if (shape == "capsule")
        {
            spawnCapsule();
        }
        else if (shape == "plane")
        {
            spawnPlane();
        }
        else if (shape == "quad")
        {
            spawnQuad();
        }
    }

}

