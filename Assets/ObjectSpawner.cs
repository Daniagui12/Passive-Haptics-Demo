using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Microsoft.MixedReality.Toolkit.UI;
using Microsoft.MixedReality.Toolkit.Input;

public class ObjectSpawner : MonoBehaviour
{
    public Interactable bt1;
    public Interactable bt2;
    public Interactable bt3;
    public Material objectMaterialMetal;
    public Texture objectTextureMetal;
    public Material objectMaterialWood;
    public Texture objectTextureWood;
    public Material objectMaterialRock;
    public Texture objectTextureRock;

    public void spawnCube()
    {
        if (bt1.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = vectorPosition;
            cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            cube.AddComponent<Rigidbody>();
            cube.GetComponent<Rigidbody>().useGravity = true;
            cube.AddComponent<Drag>();
            cube.GetComponent<Drag>().obj = cube;
            cube.GetComponent<Drag>().slowDownFactor = 0.1f;
            cube.AddComponent<NearInteractionGrabbable>();
            cube.AddComponent<BoxCollider>();
            cube.AddComponent<ObjectManipulator>();
            cube.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;

            Renderer renderer = cube.GetComponent<Renderer>();
            renderer.material = objectMaterialMetal;
            renderer.material.mainTexture = objectTextureMetal;
        }
        
        else if (bt2.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = vectorPosition;
            cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            cube.AddComponent<NearInteractionGrabbable>();
            cube.AddComponent<BoxCollider>();
            cube.AddComponent<Rigidbody>();
            cube.GetComponent<Rigidbody>().useGravity = true;
            cube.AddComponent<ObjectManipulator>();
            cube.AddComponent<Drag>();
            cube.GetComponent<Drag>().obj = cube;
            cube.GetComponent<Drag>().slowDownFactor = 0.4f;
            cube.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = cube.GetComponent<Renderer>();
            renderer.material = objectMaterialRock;
            renderer.material.mainTexture = objectTextureRock;
        }
        else if (bt3.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.position = vectorPosition;
            cube.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            cube.AddComponent<NearInteractionGrabbable>();
            cube.AddComponent<BoxCollider>();
            cube.AddComponent<Rigidbody>();
            cube.GetComponent<Rigidbody>().useGravity = true;
            cube.AddComponent<ObjectManipulator>();
            cube.AddComponent<Drag>();
            cube.GetComponent<Drag>().obj = cube;
            cube.GetComponent<Drag>().slowDownFactor = 0.6f;
            cube.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = cube.GetComponent<Renderer>();
            renderer.material = objectMaterialWood;
            renderer.material.mainTexture = objectTextureWood;
        }
    }

    public void spawnSphere()
    {
        if (bt1.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = vectorPosition;
            sphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            sphere.AddComponent<NearInteractionGrabbable>();
            sphere.AddComponent<SphereCollider>();
            sphere.AddComponent<Rigidbody>();
            sphere.GetComponent<Rigidbody>().useGravity = true;
            sphere.AddComponent<ObjectManipulator>();
            sphere.AddComponent<Drag>();
            sphere.GetComponent<Drag>().obj = sphere;
            sphere.GetComponent<Drag>().slowDownFactor = 0.1f;
            sphere.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = sphere.GetComponent<Renderer>();
            renderer.material = objectMaterialMetal;
            renderer.material.mainTexture = objectTextureMetal;
        }

        if (bt2.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = vectorPosition;
            sphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            sphere.AddComponent<NearInteractionGrabbable>();
            sphere.AddComponent<SphereCollider>();
            sphere.AddComponent<Rigidbody>();
            sphere.GetComponent<Rigidbody>().useGravity = true;
            sphere.AddComponent<ObjectManipulator>();
            sphere.AddComponent<Drag>();
            sphere.GetComponent<Drag>();
            sphere.GetComponent<Drag>().obj = sphere;
            sphere.GetComponent<Drag>().slowDownFactor = 0.4f;
            sphere.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = sphere.GetComponent<Renderer>();
            renderer.material = objectMaterialRock;
            renderer.material.mainTexture = objectTextureRock;
        }

        if (bt3.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = vectorPosition;
            sphere.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            sphere.AddComponent<NearInteractionGrabbable>();
            sphere.AddComponent<SphereCollider>();
            sphere.AddComponent<Rigidbody>();
            sphere.GetComponent<Rigidbody>().useGravity = true;
            sphere.AddComponent<ObjectManipulator>();
            sphere.AddComponent<Drag>();
            sphere.GetComponent<Drag>().obj = sphere;
            sphere.GetComponent<Drag>().slowDownFactor = 0.6f;
            sphere.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = sphere.GetComponent<Renderer>();
            renderer.material = objectMaterialWood;
            renderer.material.mainTexture = objectTextureWood;
        }

    }

    public void spawnCylinder()
    {
        if (bt1.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.position = vectorPosition;
            cylinder.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            cylinder.AddComponent<NearInteractionGrabbable>();
            cylinder.AddComponent<CapsuleCollider>();
            cylinder.AddComponent<Rigidbody>();
            cylinder.GetComponent<Rigidbody>().useGravity = true;
            cylinder.AddComponent<ObjectManipulator>();
            cylinder.AddComponent<Drag>();
            cylinder.GetComponent<Drag>().obj = cylinder;
            cylinder.GetComponent<Drag>().slowDownFactor = 0.1f;
            cylinder.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = cylinder.GetComponent<Renderer>();
            renderer.material = objectMaterialMetal;
            renderer.material.mainTexture = objectTextureMetal;
        }

        else if (bt2.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.position = vectorPosition;
            cylinder.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            cylinder.AddComponent<NearInteractionGrabbable>();
            cylinder.AddComponent<CapsuleCollider>();
            cylinder.AddComponent<Rigidbody>();
            cylinder.GetComponent<Rigidbody>().useGravity = true;
            cylinder.AddComponent<ObjectManipulator>();
            cylinder.AddComponent<Drag>();
            cylinder.GetComponent<Drag>().obj = cylinder;
            cylinder.GetComponent<Drag>().slowDownFactor = 0.4f;
            cylinder.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = cylinder.GetComponent<Renderer>();
            renderer.material = objectMaterialRock;
            renderer.material.mainTexture = objectTextureRock;
        }

        else if (bt3.IsToggled)
        {
            Vector3 vectorPosition = GameObject.Find("floor").transform.position;
            vectorPosition = new Vector3(vectorPosition.x, vectorPosition.y+0.1f, vectorPosition.z);
            GameObject cylinder = GameObject.CreatePrimitive(PrimitiveType.Cylinder);
            cylinder.transform.position = vectorPosition;
            cylinder.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            cylinder.AddComponent<Rigidbody>();
            cylinder.GetComponent<Rigidbody>().useGravity = true;
            cylinder.AddComponent<Drag>();
            cylinder.GetComponent<Drag>().obj = cylinder;
            cylinder.GetComponent<Drag>().slowDownFactor = 0.6f;
            cylinder.AddComponent<ObjectManipulator>();
            cylinder.AddComponent<NearInteractionGrabbable>();
            cylinder.AddComponent<CapsuleCollider>();
            cylinder.GetComponent<ObjectManipulator>().UseForcesForNearManipulation = true;
            
            Renderer renderer = cylinder.GetComponent<Renderer>();
            renderer.material = objectMaterialWood;
            renderer.material.mainTexture = objectTextureWood;
        }

    }

    public void spawnCapsule()
    {
        Vector3 vectorPosition = GameObject.Find("floor").transform.position;
        GameObject capsule = GameObject.CreatePrimitive(PrimitiveType.Capsule);
        capsule.transform.position = vectorPosition;
        capsule.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
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
        plane.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
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
        quad.transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
        quad.AddComponent<NearInteractionGrabbable>();
        quad.AddComponent<BoxCollider>();
        quad.AddComponent<Rigidbody>();
        quad.GetComponent<Rigidbody>().useGravity = true;
        quad.AddComponent<ObjectManipulator>();
    }

}

