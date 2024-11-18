using System.Collections;
using System.Collections.Generic;
using System.Threading;
using Unity.VisualScripting;
using UnityEngine;

public class BallScript : MonoBehaviour
{
    [SerializeField] List<Material> materials;
    [SerializeField] MeshRenderer meshRenderer;
    [SerializeField] int speedCheck;
    private Rigidbody rb;
    public float jumpForce = 5.0f;
    public float timer = 0;
    bool canChangeMaterial;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    private void Jump()
    {
        rb.AddForce(transform.up * jumpForce, ForceMode.Impulse);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Ground"))
        {
            Jump();
        }

    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (Mathf.Abs(rb.velocity.magnitude) < speedCheck && canChangeMaterial == true)
        {
            timer = 0;
            meshRenderer.material = materials[0];
            canChangeMaterial = false;
        }
        if (canChangeMaterial == false)
        {
            Debug.Log(timer);
        }
        if (Mathf.Abs(rb.velocity.magnitude) > speedCheck)
        {
            canChangeMaterial = true;
            meshRenderer.material = materials[1];
        }
    }
}

//—оздать в сцене бесконечно прыгающий на одном месте (на плейне) м€ч 
//    (через физику, скорость должна мен€тьс€ реалистично, как если чеканить
//    на ракетке теннисный м€ч). –еализовать изменение цвета м€ча каждый раз,
//    когда модуль скорости становитс€ меньше определенного порога (порог вводитс€ в инспекторе).
//     огда м€ч снова набирает скорость и пересекает порог, цвет становитс€ прежним, а в консоли выводитс€ врем€,
//    в течение которого скорость м€ча была ниже этого порога (используйте цикл с постусловием).