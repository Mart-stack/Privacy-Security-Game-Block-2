using TMPro;
using UnityEngine;

public class ResourceScript : MonoBehaviour
{
    [SerializeField] private int increasePoints = 1;
    [SerializeField] private bool privacy;
    [SerializeField] private TextMeshProUGUI currentPointsText;
    private int currentPoints;
    
    float timePassed = 0f;
    
    void Update()
    {
        timePassed += Time.deltaTime;
        
        if(timePassed > 1f)
        {
            currentPoints += increasePoints;
            currentPointsText.text = currentPoints.ToString();
            timePassed = 0f;
        } 
    }

    public void Collect()
    {
        if (privacy)
        {
            Game.Instance.privacyPoints += currentPoints;
            currentPoints = 0;
        }
        else
        {
            Game.Instance.securityPoints += currentPoints;
            currentPoints = 0;
        }
        currentPointsText.text = currentPoints.ToString();
        Game.Instance.UpdatePoints();
    }
}
