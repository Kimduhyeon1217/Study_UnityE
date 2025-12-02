using UnityEngine;

public class UIManager : MonoBehaviour
{
    public GameObject popupPrefab;
    public Transform canvasTransform;
    public string TitleText;
    public string ContentText;

    public void OpenNoticePopup()
    {
        GameObject newPopup = Instantiate(popupPrefab, canvasTransform);
        Popup popupScript = newPopup.GetComponent<Popup>();

        popupScript.SetContent(this.TitleText, this.ContentText);
    }
}
