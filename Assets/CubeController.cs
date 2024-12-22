using UnityEngine;
using DG.Tweening;

public class CubeController : MonoBehaviour
{
    [SerializeField] private float rotationDuration = 2f;
    [SerializeField] private Vector3 rotationAxis = new Vector3(0, 360, 0);
    [SerializeField] private Ease rotationEase = Ease.InOutSine; 

    [SerializeField] private float punchScaleDuration = 1f;
    [SerializeField] private Vector3 punchScaleAmount = new Vector3(1.5f, 1.5f, 1.5f);
    [SerializeField] private Ease punchEase = Ease.OutBounce; 

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            RotateCube();
        }

        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            PunchScaleCube();
        }
    }

    private void RotateCube()
    {
        transform.DORotate(rotationAxis, rotationDuration, RotateMode.FastBeyond360)
            .SetEase(rotationEase);

        Debug.Log("<color=green>Клавіша 1</color> - <color=yellow>обертання куба на 360 градусів</color>");
    }

    private void PunchScaleCube()
    {
        transform.DOPunchScale(punchScaleAmount, punchScaleDuration)
            .SetEase(punchEase);

        Debug.Log("<color=green>Клавіша 2</color> - <color=yellow>анімування зміни масштабу</color>");
    }
}
