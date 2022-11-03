using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.ARFoundation;

public class W05_ImageTracking : MonoBehaviour
{
    ARTrackedImageManager arTrackedImageManager;

    // Start is called before the first frame update
    void Awake()
    {
        arTrackedImageManager = FindObjectOfType<ARTrackedImageManager>(); 
    }

    public void OnEnable()
    {
        arTrackedImageManager.trackedImagesChanged += OnImageChanged;
    }

    public void OnDisable()
    {
        arTrackedImageManager.trackedImagesChanged -= OnImageChanged;
    }

    public void OnImageChanged(ARTrackedImagesChangedEventArgs args)
    {
        foreach(var trackedImage in args.added)
        {
            Debug.Log(trackedImage.name);

            if (trackedImage.name == "Logo_NHL")
            {
                GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
                cube.transform.position = trackedImage.transform.position;
            }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
