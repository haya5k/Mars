using UnityEngine;
using System.Collections;

public class CameraMoveFPS : MonoBehaviour
{
    Rigidbody m_Rigidbody;

    void Start()
    {
        // 自分のRigidbodyを取ってくる
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // 十字キーで首を左右に回す
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(new Vector3(0.0f, 1.0f, 0.0f));
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(new Vector3(0.0f, -1.0f, 0.0f));
        }

        // WASDで移動する
        float x = 0.0f;
        float z = 0.0f;

        if (Input.GetKey(KeyCode.D))
        {
            x += 20.0f;
        }
        if (Input.GetKey(KeyCode.A))
        {
            x -= 20.0f;
        }
        if (Input.GetKey(KeyCode.W))
        {
            z += 20.0f;
        }
        if (Input.GetKey(KeyCode.S))
        {
            z -= 20.0f;
        }

        m_Rigidbody.velocity = z * transform.forward + x * transform.right;
    }
}