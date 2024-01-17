using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace Rubik.Guanyu
{
    public enum ChoseType
    {
        SwapButton = 0,
        Another = 1
    }
    public class ButtonController : MonoBehaviour
    {
        public List<GameObject> lsTabFocus = new List<GameObject>(), lsTabInfoGear = new List<GameObject>(), lsBtn = new List<GameObject>();
        public List<TextMeshProUGUI> lsTxtTab = new List<TextMeshProUGUI>();
        public ChoseType choseTypes;
        public Color colorTxtFocus, colorTxtNormal;
        public bool isHaveTxtFocus, isHaveInfoGear;
        void Awake()
        {
            ResultChose(choseTypes);

        }
        void ResultChose(ChoseType choseType)
        {
            switch (choseType)
            {
                case ChoseType.SwapButton:
                    AddListenerBtn();
                    break;
                case ChoseType.Another:
                    UnityEngine.Debug.Log("Thoát");
                    break;
                default:
                    UnityEngine.Debug.Log("default");
                    break;
            }
        }
        void AddListenerBtn()
        {
            for (int i = 0; i < lsBtn.Count; i++)
            {
                int index = i;
                if (lsBtn[index].GetComponent<Button>() != null)
                {
                    lsBtn[index].GetComponent<Button>().onClick.AddListener(() =>
                    {

                        SwapBtn(index);
                    });
                }
                else
                {
                    lsBtn[index].AddComponent<Button>().onClick.AddListener(() =>
                    {

                        SwapBtn(index);
                    });
                }

            }
        }
        public void SwapBtn(int slot)
        {

            for (int i = 0; i < lsTabFocus.Count; i++)
            {
                if (i == slot)
                {
                    lsTabFocus[slot].SetActive(true);
                    if (isHaveInfoGear)
                    {
                        lsTabInfoGear[slot].SetActive(true);
                    }

                    if (isHaveTxtFocus)
                    {
                        lsTxtTab[slot].color = colorTxtFocus;
                    }


                }
                else
                {
                    lsTabFocus[i].SetActive(false);

                    if (isHaveInfoGear)
                    {
                        lsTabInfoGear[i].SetActive(false);
                    }
                    if (isHaveTxtFocus)
                    {
                        lsTxtTab[i].color = colorTxtNormal;
                    }
                }
            }
        }
    }

}