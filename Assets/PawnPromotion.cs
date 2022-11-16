using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PawnPromotion : MonoBehaviour
{
    public GameObject PromotionMenu;
    GameObject PromotedPiece;

    // Start is called before the first frame update
    void Start()
    {
        PromotionMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnTriggerEnter(Collider other)
    //{
    //    if (other.name.Contains("Pawn"))
    //    {
    //        PromotedPiece = other.transform.gameObject;
    //        PromotionMenu.SetActive(true);
    //    }
    //}

    public void spawnPiece(Mesh Piece) 
    {
        PromotedPiece.GetComponent<MeshFilter>().mesh = Piece;
        PromotionMenu.SetActive(false);
    }

    public void ActivateMenu(GameObject Piece)
    {
        PromotionMenu.SetActive(true);
        PromotedPiece = Piece;
    }
}
