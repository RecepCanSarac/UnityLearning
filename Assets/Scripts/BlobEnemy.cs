using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobEnemy : MonoBehaviour
{
    public float amplitude = 1f;         // Sine dalga genli�i
    public float frequency = 1f;         // Sine dalga frekans�

    private Vector3 initialPosition;     // Nesnenin ba�lang�� pozisyonu

    private void Start()
    {
        initialPosition = transform.position;  // Ba�lang�� pozisyonunu kaydet
    }

    private void Update()
    {
        // Sine hareketini hesapla
        float x = transform.position.x;
        float y = initialPosition.x + amplitude * Mathf.Sin(frequency * Time.time);  // Y ekseni de�i�mesin diye mevcut y de�erini kullan

        transform.position = new Vector3(x, y,transform.position.z);  // Yeni pozisyonu g�ncelle
        transform.Translate(0.01f,0,0);
    }
}
