using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Player : MonoBehaviour
{
    public Text itemText;
    private int totalHeart = 0;
    private int totalKey = 0;
    private int totalStar = 0;



    void Start()
    {
        UpdateItemText();
    }
    void OnTriggerEnter2D(Collider2D hit)
    {
        if (hit.CompareTag("Heart"))
        {
            totalHeart++;
            UpdateItemText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Bintang"))
        {
            totalStar++;
            UpdateItemText();
            Destroy(hit.gameObject);
        }
        if (hit.CompareTag("Key"))
        {
            totalKey++;
            UpdateItemText();
            Destroy(hit.gameObject);
        }
    }
    private void UpdateItemText()
    {
        string Pesan = " Star " + totalStar + " Heart " + totalHeart + " Key " + totalKey;
        itemText.text = Pesan;

    }


}