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

//������� � ����� ���������� ��������� �� ����� ����� (�� ������) ��� 
//    (����� ������, �������� ������ �������� �����������, ��� ���� ��������
//    �� ������� ��������� ���). ����������� ��������� ����� ���� ������ ���,
//    ����� ������ �������� ���������� ������ ������������� ������ (����� �������� � ����������).
//    ����� ��� ����� �������� �������� � ���������� �����, ���� ���������� �������, � � ������� ��������� �����,
//    � ������� �������� �������� ���� ���� ���� ����� ������ (����������� ���� � ������������).