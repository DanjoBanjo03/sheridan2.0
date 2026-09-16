using UnityEngine;
using UnityEngine.InputSystem;
using Unity.Cinemachine;

public class CameraController : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCameraBase[] cameras;

    private int currentCamera = 0;

    void Start()
    {
        SwitchCamera(0);
    }

    void Update()
    {
        if (Keyboard.current.cKey.wasPressedThisFrame)
        {
            currentCamera++;

            if (currentCamera >= cameras.Length)
            {
                currentCamera = 0;
            }

            SwitchCamera(currentCamera);
        }
    }

    private void SwitchCamera(int index)
    {
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].Priority.Enabled = true;
            cameras[i].Priority.Value = (i == index) ? 20 : 0;
        }
    }
}