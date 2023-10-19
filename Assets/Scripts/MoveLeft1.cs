using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveLeft : MonoBehaviour
{
    private Vector2 StartPosition;
    [SerializeField] private float speed = 1f;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(translation: Vector2.left * speed * Time.deltaTime);
    }
}
