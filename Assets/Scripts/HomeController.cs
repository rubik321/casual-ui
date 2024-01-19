
using UnityEngine;
public class HomeController : MonoBehaviour
{

    public GameObject InfoCharactor;

    public MenuButton ButtonShop;
    public MenuButton ButtonBook;
    public MenuButton ButtonBattle;
    public MenuButton ButtonBag;
    public MenuButton ButtonMap;

    public MenuButton[] listMenuButtons;

    public SettingButton ButtonSettings;
    public SettingButton ButtonAchivement;
    public SettingButton ButtonDailyGift;
    public SettingButton ButtonInbox;



    public SettingButton[] listSettingsButtons;

    public GameObject LevelPanel;
    
    // Start is called before the first frame update
    void Start()
    {
        btnMenuCLick(2);
        
    }



    public void PanelInfoSetting()
    {
        
        InfoCharactor.SetActive(!InfoCharactor.activeSelf);
    }


    public void btnMenuCLick(int index)
    {
        for(int i= 0; i < listMenuButtons.Length; i++)
        {
            listMenuButtons[i].SetFocus(false);
        }
        listMenuButtons[index].SetFocus(true);
    }

    public void btnSettingCLick(int index)
    {
        for(int i= 0; i < listSettingsButtons.Length; i++)
        {
            listSettingsButtons[i].SetFocus(false);
        }
        listSettingsButtons[index].SetFocus(true);
    }

    




    public void btnShopCLick()
    {
        ButtonShop.SetFocus(true);
        ButtonBook.SetFocus(false);
        ButtonBattle.SetFocus(false);
        ButtonBag.SetFocus(false);
        ButtonMap.SetFocus(false);
    }
    public void btnBookCLick()
    {
        ButtonShop.SetFocus(false);
        ButtonBook.SetFocus(true);
        ButtonBattle.SetFocus(false);
        ButtonBag.SetFocus(false);
        ButtonMap.SetFocus(false);
    }
    public void btnBattleCLick()
    {
        ButtonShop.SetFocus(false);
        ButtonBook.SetFocus(false);
        ButtonBattle.SetFocus(true);
        ButtonBag.SetFocus(false);
        ButtonMap.SetFocus(false);
    }
    public void btnBagCLick()
    {
        ButtonShop.SetFocus(false);
        ButtonBook.SetFocus(false);
        ButtonBattle.SetFocus(false);
        ButtonBag.SetFocus(true);
        ButtonMap.SetFocus(false);
    }
    public void btnMapCLick()
    {
        ButtonShop.SetFocus(false);
        ButtonBook.SetFocus(false);
        ButtonBattle.SetFocus(false);
        ButtonBag.SetFocus(false);
        ButtonMap.SetFocus(true);
    }
    public void btnStart(bool isStart)
    {
        LevelPanel.SetActive(isStart);
    }
}


