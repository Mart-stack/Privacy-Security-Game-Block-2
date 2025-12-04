using UnityEngine;
using TMPro;

public class Game : MonoBehaviour
{
    public static Game Instance { get; private set; }
    
    public int privacyPoints;
    public int securityPoints;

    [SerializeField] private TextMeshProUGUI privacyText;
    [SerializeField] private TextMeshProUGUI securityText;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }

    public void UpdatePoints()
    {
        privacyText.text = $"Privacy: {privacyPoints}";
        securityText.text = $"Security: {securityPoints}";
    }
}