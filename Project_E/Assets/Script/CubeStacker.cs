using UnityEngine;
using UnityEngine.UIElements;

public class CubeStacker : MonoBehaviour
{
    public int cubeCount = 120;

    [Header("시작 값")]
    public Vector3 startScale = new Vector3(1.1f, 0.1f, 1.1f);
    public float startPosY = 0.55f;
    public Vector3 startRotation = Vector3.zero; // 시작 회전값

    [Header("증가 값 (규칙)")]
    public Vector3 scaleStep = new Vector3(0.1f, 0f, 0.1f); // 크기 증가량
    public float posStepY = 0.1f; // 높이 증가량
    public Vector3 rotStep = new Vector3(0f, 3f, 0f); // 회전 증가량 (Y축으로 1도씩)

    [ContextMenu("큐브 쌓기 실행")]
    void GenerateCubes()
    {
        for (int i = 0; i < cubeCount; i++)
        {
            // 1. 큐브 생성
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.name = $"Cube_{i + 1}";
            cube.transform.parent = this.transform;

            // 2. 크기(Scale) 설정
            cube.transform.localScale = startScale + (scaleStep * i);

            // 3. 위치(Position) 설정
            float newY = startPosY + (posStepY * i);
            cube.transform.localPosition = new Vector3(0, newY, 0);

            // 4. 회전(Rotation) 설정 [추가된 부분!]
            // 시작 회전값 + (증가 회전값 * 순서)
            Vector3 currentRot = startRotation + (rotStep * i);
            cube.transform.localRotation = Quaternion.Euler(currentRot);
        }
        Debug.Log("생성 완료!");
    }

    [ContextMenu("생성된 큐브 지우기")]
    void ClearCubes()
    {
        // 거꾸로 지워야 깔끔하게 지워집니다.
        for (int i = transform.childCount - 1; i >= 0; i--)
        {
            DestroyImmediate(transform.GetChild(i).gameObject);
        }
    }
}