using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Card : MonoBehaviour
{

    // �zellikleri tan�ml�yoruz
    public Sprite Icon; // 2D grafik kulland���m�z i�in sprite s�n�f�n� �a��rmam�z laz�m
    private bool isOpen; // Kart a��k m�? (bu durumu ancak kart�n kendisi de�i�tirebilmeli, d��ar�dan de�i�tirilmemeli o y�zden private)

    //ama d��ar�daki nesneler taraf�ndan a��k olup olmad���n�n anla��lmas� laz�m bu y�zden public bir property tan�mlanmal�
    public bool IsOpen
    {
        get { return isOpen; } // isOpen ne ise onu dond�recek
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
        Debug.Log("mouse down");
    }
}
