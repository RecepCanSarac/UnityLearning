using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlobEnemy : MonoBehaviour
{
    public float amplitude = 1f;         // Sine dalga genliði
    public float frequency = 1f;         // Sine dalga frekansý

    private Vector3 initialPosition;     // Nesnenin baþlangýç pozisyonu

    private void Start()
    {
        initialPosition = transform.position;  // Baþlangýç pozisyonunu kaydet
    }

    private void Update()
    {
        // Sine hareketini hesapla
        float x = transform.position.x;
        float y = initialPosition.x + amplitude * Mathf.Sin(frequency * Time.time);  // Y ekseni deðiþmesin diye mevcut y deðerini kullan

        transform.position = new Vector3(x, y,transform.position.z);  // Yeni pozisyonu güncelle
        transform.Translate(0.01f,0,0);
    }
}
