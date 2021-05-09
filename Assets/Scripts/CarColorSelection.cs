using UnityEngine;
using UnityEngine.UI;

public class CarColorSelection : MonoBehaviour
{
    public GameObject[] cars;
    public Button[] carsColorsButtons;
    private int currentCarColor = 0;

    public void ChangeCarColor(int _number)
    {
        //Debug.Log("Number: " + _number);

        for (int i = 0; i < carsColorsButtons.Length; i++)
        {
            //Debug.Log("CarColor " + i + ": " + carsColorsButtons[i]);
        }

        if (_number % 2 == 0)
        {
            carsColorsButtons[_number].interactable = false;
            cars[currentCarColor].SetActive(false);
            currentCarColor = _number;
            //Debug.Log("currentCarColor: " + carsColors[_number]);
            carsColorsButtons[_number+1].interactable = true;
            cars[currentCarColor].SetActive(true);
        }

        if (_number % 2 == 1)
        {
            carsColorsButtons[_number].interactable = false;
            cars[currentCarColor].SetActive(false);
            currentCarColor = _number;
            //Debug.Log("currentCarColor: " + carsColors[_number]);
            carsColorsButtons[_number-1].interactable = true;
            cars[currentCarColor].SetActive(true);
        }
    }

    public void NotActiveCar(int _number)
    {
        cars[_number].SetActive(false);
    }
}
