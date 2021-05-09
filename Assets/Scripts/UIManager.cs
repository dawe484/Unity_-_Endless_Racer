using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private int currentCar = 0;
    [SerializeField] private Button previousButton;
    [SerializeField] private Button nextButton;

    public CarColorSelection carColorScript;
    
    public void Play()
    {
        SceneManager.LoadScene("Level 1");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("Quit!");
    }

    private void Awake()
    {
        if (previousButton != null)
        {
            SelectCar(0);
        }
    }

    private void SelectCar(int _index)
    {
        //Debug.Log("index = car number " + _index);
        previousButton.interactable = (_index != 0);
        nextButton.interactable = (_index != transform.childCount - 1);

        for (int i = 0; i < transform.childCount; i++)
        {
            transform.GetChild(i).gameObject.SetActive(i == _index);
        }

        switch (_index)
        {
            case 0:
                carColorScript.ChangeCarColor(0);
                carColorScript.NotActiveCar(1);
                break;
            case 1:
                carColorScript.ChangeCarColor(2);
                carColorScript.NotActiveCar(3);
                break;
        }
    }

    public void ChangeCar(int _change)
    {
        //Debug.Log(_change + " " + currentCar);
        currentCar += _change;
        //Debug.Log("Car: " + currentCar);
        SelectCar(currentCar);
    }
}
