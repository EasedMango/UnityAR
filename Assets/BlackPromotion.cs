using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPromotion : MonoBehaviour
{
    public GameObject PromotionMenu;
    GameObject PromotedPiece;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.name.Contains("Pawn"))
        {
            PromotionMenu.GetComponent<PawnPromotion>().ActivateMenu(other.transform.gameObject);            
        }
    }    
}
