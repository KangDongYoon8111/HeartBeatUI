using UnityEngine;
using UnityEngine.UI;

public class ScrollHeath : MonoBehaviour
{
    [Range(0, 100)] public float health;

    Sprite h_Status;
    Image m_Image;
    [SerializeField] float scrollSpeed;
    [SerializeField] Sprite[] healthStatus;
    [SerializeField] GameObject Status;

    Sprite h_rates;
    [SerializeField] Sprite[] rates;
    [SerializeField] GameObject helthRate;

    void Start()
    {
        Status.GetComponent<Image>().sprite = h_Status;
        m_Image = this.GetComponent<Image>();
        m_Image.color = new Color32(0, 255, 0, 255);
        h_Status = healthStatus[0];

        helthRate.GetComponent<Image>().sprite = h_rates;
        h_rates = rates[0];
    }

    // Update is called once per frame
    void Update()
    {
        Status.GetComponent<Image>().sprite = h_Status;
        helthRate.GetComponent<Image>().sprite = h_rates;
        m_Image.material.mainTextureOffset = m_Image.material.mainTextureOffset + new Vector2(Time.deltaTime * (-scrollSpeed / 10), 0f);

        if (health >= 50)
        {
            h_rates = rates[0];

            m_Image.color = new Color32(0, 255, 0, 255);
            h_Status = healthStatus[0];
        }
        else if (health >= 1)
        {
            h_rates = rates[1];

            m_Image.color = new Color32(255, 255, 0, 255);
            h_Status = healthStatus[1];
        }
        else
        {
            h_rates = rates[2];

            m_Image.color = new Color32(255, 0, 0, 255);
            h_Status = healthStatus[2];
        }
    }
}
