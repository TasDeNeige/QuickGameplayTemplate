using UnityEngine;
using UnityEngine.InputSystem;

public class TestScript : MonoBehaviour
{
    [Header("Settings")]
    [SerializeField] float jumpHeight = 300.0f;
    
    // Components
    Rigidbody rb;

    private void Awake()
    {
        // Get Rigidbody
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        // Simple jump on Space press
        if (Keyboard.current[Key.Space].wasPressedThisFrame)
        {
            rb.AddForce(Vector3.up * jumpHeight);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        // Update score
        GameManager.instance.CurrentScore++;
        UIUtils.instance.UpdateScore(GameManager.instance.CurrentScore);

        // Victory condition
        if (GameManager.instance.CurrentScore == 5)
        {
            UIUtils.instance.ToggleVictoryScreen(true);
        }
    }
}
