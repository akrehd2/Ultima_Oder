using UnityEngine;

public class CubeMovement : MonoBehaviour
{
    public float moveSpeed = 5f;

    void Update()
    {
        // 사용자의 입력을 받아 이동 방향을 계산
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput);

        // 이동 방향에 따라 큐브를 움직임
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }
}
