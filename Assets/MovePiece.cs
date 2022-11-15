using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;


public class MovePiece : MonoBehaviour
{
    [SerializeField]
    ARRaycastManager raycastManager;
    List<ARRaycastHit> hits = new List<ARRaycastHit>();
    [SerializeField] GameObject spawnablePrefab;

    private Camera arCam;
    private GameObject selectedGameObject;
    private Color prevColor;
    private Renderer currentPieceColor;
    private void Start()
    {
        selectedGameObject = null;
        arCam = GameObject.Find("AR Camera").GetComponent<Camera>();

    }

    private void Update()
    {
        if (Input.touchCount == 0) return;

        RaycastHit hit;
        Ray ray = arCam.ScreenPointToRay(Input.GetTouch(0).position);


        if (Input.GetTouch(0).phase == TouchPhase.Began)
        {
            if (!Physics.Raycast(ray, out hit)) return;
            if (selectedGameObject == null)
            {
                currentPieceColor = hit.collider.gameObject.GetComponent<Renderer>();
                // lines.SetPositions(new Vector3[]{ arCam.ScreenToWorldPoint(Input.GetTouch(0).position), hit.point });

                    prevColor = currentPieceColor.material.color;
                if (hit.collider.gameObject.CompareTag("Movable"))
                {
                    currentPieceColor.material.color = Color.red;
                    selectedGameObject = hit.collider.gameObject;
                }
            }
            else
            {

                currentPieceColor.material.color = prevColor;
                selectedGameObject.transform.position = hit.point;
                selectedGameObject = null;
                currentPieceColor = null;
            }

        }
        //else if (Input.GetTouch(0).phase == TouchPhase.Moved && spawnedObject != null)
        //{
        //    spawnedObject.transform.position = hits[0].pose.position;
        //}

        //if (Input.GetTouch(0).phase == TouchPhase.Ended)
        //{
        //    spawnedObject = null;
        //}

    }


}
