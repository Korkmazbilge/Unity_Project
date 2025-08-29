using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class konteynerveri : MonoBehaviour
{
    public string konteynerAd;
    public string konteynerId;
    public string konteynerDurumu;

    public TextMeshProUGUI adText;    // ← EKLE (Inspector’dan Paneldeki Text’e bağla)
    public TextMeshProUGUI idText;    // ← EKLE
    public TextMeshProUGUI durumText; // ← EKLE

    void OnMouseDown()
    {
        // Console (eskin kalsın)
        Debug.Log("Konteyner Adı: " + konteynerAd + " | ID: " + konteynerId + " | Durum: " + konteynerDurumu);

        // ← YENİ: UI’yi güncelle
        adText.text = "Konteyner Adı: " + konteynerAd;
        idText.text = "Konteyner Id: " + konteynerId;
        durumText.text = "Konteyner Durumu: " + konteynerDurumu;
    }
}




