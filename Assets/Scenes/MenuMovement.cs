using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuMovement : MonoBehaviour
{
    public GameObject MenuOrigPos, MenuActvPos, MenuPanel;
    public bool MoveMenu, MovebackMenu;
    public float moveSpeed, tempMenuPos;

    // Start is called before the first frame update
    void Start()
    {
        MenuPanel.transform.position = MenuOrigPos.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(MoveMenu)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuActvPos.transform.position, moveSpeed = Time.deltaTime);

            if (MenuPanel.transform.localPosition.x == tempMenuPos)
            {
                MoveMenu = false;
                MenuPanel.transform.position = MenuActvPos.transform.position;
                tempMenuPos = -99.99f;
            }

            if(MoveMenu)
            {
                tempMenuPos = MenuPanel.transform.position.x;
            }
        }

        if(MovebackMenu)
        {
            MenuPanel.transform.position = Vector3.Lerp(MenuPanel.transform.position, MenuOrigPos.transform.position, moveSpeed = Time.deltaTime);

            if (MenuPanel.transform.localPosition.x == tempMenuPos)
            {
                MovebackMenu = false;
                MenuPanel.transform.position = MenuOrigPos.transform.position;
                tempMenuPos = -99.99f;
            }

            if(MovebackMenu)
            {
                tempMenuPos = MenuPanel.transform.position.x;
            }
        }
    }   
    public void MovePanel()
    {
        MovebackMenu = false;
        MoveMenu = true;
    }
    public void MovePanelBack()
    {
        MovebackMenu = true;
        MoveMenu = false;
    }


}
