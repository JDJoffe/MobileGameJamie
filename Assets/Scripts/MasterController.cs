using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
public class MasterController : Joystick
{

    [SerializeField] private float moveThreshold = 1;
    [SerializeField] private JoystickType joystickType = JoystickType.Fixed;
    private Vector2 fixedPosition = Vector2.zero;
    public float MoveThreshold
    {
        get { return moveThreshold; }
        set
        {
            MoveThreshold = Mathf.Abs(value);
        }
    }
    public void SetMode(JoystickType joystickType)
    {
        this.joystickType = joystickType;
        if (joystickType == JoystickType.Fixed)
        {
            background.anchoredPosition = fixedPosition;
            background.gameObject.SetActive(true);
        }
        else
        {
            background.gameObject.SetActive(false);
        }
    }

    protected override void Start()
    {
        base.Start();
        fixedPosition = background.anchoredPosition;
        SetMode(joystickType);
    }

    public override void OnPointerDown(PointerEventData eventData)
    {
        if (joystickType != JoystickType.Fixed)
        {
            background.anchoredPosition = ScreenPointToAnchoredPosition(eventData.position);
            background.gameObject.SetActive(true);
        }
        base.OnPointerDown(eventData);
    }

    public override void OnPointerUp(PointerEventData eventData)
    {
        if (joystickType != JoystickType.Fixed)
        {
            background.gameObject.SetActive(false);
        }
        base.OnPointerUp(eventData);
    }

    protected override void HandleInput(float magnitude, Vector2 normalised, Vector2 radius, Camera cam)
    {
        if (joystickType == JoystickType.Dynamic && magnitude > moveThreshold)
        {
            Vector2 difference = normalised * (magnitude - moveThreshold) * radius;
            background.anchoredPosition += difference;
        }
        base.HandleInput(magnitude, normalised, radius, cam);
    }
}
//joystick type
public enum JoystickType
{
    Fixed,
    Floating,
    Dynamic
}

//                                            .,codddddddo:'.                                         
//                                        .';codxxkkkkkkkkkxl;.                                       
//                                     .':odxxkkOOO000000000Okxl,.                                    
//                                    .:odxxkkO000KKKKKKKKKKK00kxo;.                                  
//                                   .codxkkO000KKKKKKKXXXKKKK00Okxl'                                 
//                                  .;ldxkkOO00KKKKKKKXXXXXXXKKK0OOxo,                                
//                                 ,cdxkkOO000KKKXXXXXXXXXXXXXKK00Oxl'                               
//                                 .:dxkkOOOO00KKKXXXXXNNXXXXXXKKK0Okdc.
//                                 .lxxkkkkOO00KKKKXXXXXXXXXXXKK000Okxd:.                             
//                                 .lxxkkkkO000KKKKKXXXXXXXKKKK0000OOkxl'                             
//                                  ;ddxkOOOO0000KKKKXXXXXXK00000000Okxl'                             
//                                .'cdddxkOkkkdoodxO00KKXXK00000000OOxl;.                             
//                               .cdodxddkOOko:ccc::::coxOOkkkkkxdolc;...                             
//                               .okdoodxxO0Oxxxdol:,,;;:loxOOko:,..''',.                             
//                               .lkkdodxxkO00OkxxxdodkkkOO0KKOddxololcl;.                            
//                                'xOkdxxdxO000000KKKKKKKKK00KOxk000Okxo:.                            
//                                .lkxxkkddkOOOO0KKKKKKKKK000K0kxkOOOkxl;.                            
//                                 ;xxxkkxxkOOOO0KKKKK0OkOOO0K0OdoxOOOxl;.                            
//                                 ,dxxkOkkkkkOO00OkxkkkkOOk0KKOxoxkkkko:'                            
//                             .''..;oxkOOkkkkkOkxkkOO00xddoxOOxl:oxxddc,.                            
//                            .;:::;:odkOOkkkkkkxxdxxkOOOkxoc:;;;codddoc;.                            
//                           .::ccc:coxxkOkOOkkkkxollccodxkOkxol:::cxkdl:.                            
//                        ..';:::cc::oxkkkOOOOOkkkkkkxodddddool:;:cdkxdl'                             
//                    ..';cllc::::cc:lxkkkkOOOOOOkkkkxddxkkxdddlccodxdl,                              
//                ..';:clllllc::::ccc:okkOOOOOOO0OOkkkxddxxddolc:lxxl:'                               
//            ..';:::::clllcc::cc:cclccoxkOOOOOOOOOOOkxdddoollccoxxl'                                 
//        ...,;::::::cccccccc:;::::ccccloxkkO00OOkkOOOOkkkxxddodxo;.                                  
//    ..',,;;;;;;::::::ccc::;;,'......':looxkkOOOkxkkkkkkxxxxxddc'  ....''..                          
//  ..',,,,,,;;;;;::;::::::;'.....'',,'':cloodxxkkxxddddoodoolc,.  .',,,,,,,.                         
//..'''',,',,,;:;;;;;;;::;,..';:ccccc::,..,:lllllodollc::;;,'..  .''',,,''','.                        
//....'',''',,,;;;;;;;;;:,',::::::::::::;'.,clcc::::::;;;,'..  ..,,,,,''...'''..                      
//.....'''''',,,,;;,,,,;;;;;;;::;::::::;::;'',;:ccc::;,'....',;c:;,,,,.. .''''''.                     
//.......''.''''',,,,,,,,,,,,,;;;;;;;;;;;;;,''...';cclc::;:loool:;,,,'...'''''''..                    
//............'''',',,,,,,,,,,,,,,,,,,,,,,;;,,,''...';::ccloooolc;,,,'.''''''......    



