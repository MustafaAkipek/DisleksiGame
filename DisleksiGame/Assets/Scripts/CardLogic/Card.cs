using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    // Özellikleri tanýmlýyoruz
    public Sprite Icon; // 2D grafik kullandýðýmýz için sprite sýnýfýný çaðýrmamýz lazým
    private bool isOpen; // Kart açýk mý? (bu durumu ancak kartýn kendisi deðiþtirebilmeli, dýþarýdan deðiþtirilmemeli o yüzden private)

    public GameObject CardBack;
    public GameObject CardFront;

    //ama dýþarýdaki nesneler tarafýndan açýk olup olmadýðýnýn anlaþýlmasý lazým bu yüzden public bir property tanýmlanmalý
    public bool IsOpen
    {
        get { return isOpen; } // isOpen ne ise onu dondürecek
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        OpenCard();
    }

    public void OpenCard() // cardback' i gizleyip, cardfront' u göstermemiz lazým
    {
        isOpen = true; // kartýn açýk olduðu artýk bilinsin
        CardBack.SetActive(false); // sahnedeki gameobject' i aktif ve inaktif yapmamýzý saðlýyor
        CardFront.SetActive(true);
    }

}
