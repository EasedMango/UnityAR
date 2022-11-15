using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;

public class ARCursor : MonoBehaviour
{
    public GameObject cursor;

    public GameObject spawnGameObject;

    public ARRaycastManager rcManager;

    public bool useCursor = true;
    // Start is called before the first frame update
    void Start()
    {
        cursor.SetActive(useCursor);
    }

    // Update is called once per frame
    void Update()
    {
        if (useCursor)
        {

            UpdateCursor();
        }
    }

    void UpdateCursor()
    {
        Vector2 sp = /*Camera.main.ViewportToScreenPoint(*/(Input.touches[0].position);//);
        List<ARRaycastHit> hits = new List<ARRaycastHit>();
        rcManager.Raycast(sp, hits, TrackableType.Planes);

        if (hits.Count > 0)
        {
            transform.position = hits[0].pose.position;
            transform.rotation = hits[0].pose.rotation;
        }
    }
}
